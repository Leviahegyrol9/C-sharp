using Git.Service;
using Git.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Git.Windows
{
    public partial class Manage : Window
    {
        List<string> directories = PathService.GetPaths();
        int percent;
        Dictionary<string, bool> commits;

        public Manage()
        {
            InitializeComponent();
        }
        private void Manage_Loaded(object sender, RoutedEventArgs e)
        {
            try {percent = 100 / directories.Count;}
            catch {NewFile(sender, e);}
            Pull(sender, e);
        }
        private async void Push(object sender, RoutedEventArgs e)
        {
            while (!await HasInternet())
            {
                MessageBox.Show("Nincs internet!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            await PushAsync();
        }
        private async Task PushAsync()
        {
            TurnButtons(false);

            await AnimateProgress(0);

            DateTime dateTime = DateTime.Now;
            string commitMessage = dateTime.ToString("yyyy.MM.dd - HH:mm");          

            foreach (string directory in directories)
            {
                await RunGitPush($"git add * && git commit -m \"{commitMessage}\" && git push", directory);
                await AnimateProgress(progressBar.Value + percent);
            }

            await FixProgressBar();
            TurnButtons(true);
        }
        private Task RunGitPush(string arguments, string dir)
        {
            return Task.Run(() =>
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/c " + arguments;
                process.StartInfo.WorkingDirectory = dir;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;

                process.Start();

                string error = process.StandardError.ReadToEnd();

                process.WaitForExit();

                if (process.ExitCode > 1)
                {
                    MessageBox.Show(error, dir, MessageBoxButton.OK, MessageBoxImage.Error);
                }
            });
        }
        private async void Pull(object sender, RoutedEventArgs e)
        {
            while (!await HasInternet())
            {
                MessageBox.Show("Nincs internet!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            TurnButtons(false);
            commits = await GetCommits(directories, sender, e);
            TurnButtons(true);
            await FixProgressBar();

            if (commits.Any(c => c.Value))
            {
                progressBar.Foreground = new BrushConverter().ConvertFrom("#3aafa9") as SolidColorBrush;
                TurnButtons(false);
                await AnimateProgress(0);

                int percent = 100 / commits.Count(c => c.Value);

                foreach (string commit in commits.Where(c => c.Value).Select(c => c.Key))
                {
                    await RunGitPull(commit);
                    await AnimateProgress(progressBar.Value + percent);
                }

                progressBar.Foreground = new BrushConverter().ConvertFrom("#17252a") as SolidColorBrush;
                TurnButtons(true);
                await FixProgressBar();
            }
        }
        private Task RunGitPull(string dir)
        {
            return Task.Run(() =>
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/c git pull";
                process.StartInfo.WorkingDirectory = dir;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;

                process.Start();

                string error = process.StandardError.ReadToEnd();

                process.WaitForExit();

                if (process.ExitCode != 0)
                {
                    MessageBox.Show(error, dir, MessageBoxButton.OK, MessageBoxImage.Error);
                }
            });
        }

        private async Task<Dictionary<string, bool>> GetCommits(List<string> directories, object sender, RoutedEventArgs e)
        {
            await AnimateProgress(0);

            Dictionary<string, bool> result = new Dictionary<string, bool>();

            try
            {
                foreach (string dir in directories)
                {
                    result[dir] = false;

                    Process process = new Process();
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/c git fetch && git rev-list HEAD..origin/main --count";
                    process.StartInfo.WorkingDirectory = dir;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.CreateNoWindow = true;

                    process.Start();

                    string output = await process.StandardOutput.ReadToEndAsync();
                    string error = await process.StandardError.ReadToEndAsync();
                    int commit = int.Parse(output.Trim());

                    process.WaitForExit();

                    await AnimateProgress(progressBar.Value + percent);

                    if (process.ExitCode != 0)
                    {
                        MessageBox.Show(error, dir, MessageBoxButton.OK, MessageBoxImage.Error);
                        Application.Current.Shutdown();
                    }

                    if (commit > 0) result[dir] = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                NewFile(sender, e);
            }

            return result;
        }
        private async Task<bool> HasInternet()
{
    try
    {
        var handler = new HttpClientHandler()
        {
            UseProxy = false
        };

        using (HttpClient client = new HttpClient(handler))
        {
            client.Timeout = TimeSpan.FromSeconds(3);
            await client.GetAsync("https://www.google.com");
            return true;
        }              
    }
    catch
    {
        return false;
    }
}
        private void NewFile(object sender, RoutedEventArgs e)
        {
            File.Delete(PathService.configPath);
            new FileChoose().Show();
            this.Hide();
        }
        private async Task FixProgressBar()
        {
            await AnimateProgress(100);
        }
        private async Task AnimateProgress(double target)
        {
            while (progressBar.Value < target)
            {
                progressBar.Value += 1;

                await Task.Delay(10);
            }

            progressBar.Value = target;
        }
        private void TurnButtons(bool value)
        {
            foreach (Button btn in mainGrid.Children.OfType<Button>()) btn.IsEnabled = value;
            mainGrid.Children.OfType<StackPanel>().First().IsEnabled = value;
        }
        private async void Manage_Closing(object sender, CancelEventArgs e)
        {       
            e.Cancel = true;

            if (!mainGrid.Children.OfType<Button>().Any(btn => !btn.IsEnabled) &&
                mainGrid.Children.OfType<StackPanel>().First().IsEnabled &&
                progressBar.Value == 100)
            {
                await PushAsync();
                Application.Current.Shutdown();
            }        
        }
    }
}
