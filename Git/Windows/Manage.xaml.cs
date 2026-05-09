using Git.Service;
using Git.Windows;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
        List<string> directories = SettingsService.GetPaths();
        Dictionary<string, bool> commits;

        public Manage()
        {
            InitializeComponent();            
        }
        private async void Manage_Loaded(object sender, RoutedEventArgs e)
        {
            TurnButtons(false);
            commits = await GetCommits(directories);
            TurnButtons(true);
            FixProgressBar();
        }
        private async void Push(object sender, RoutedEventArgs e)
        {
            await PushAsync();
        }
        private async Task PushAsync()
        {
            TurnButtons(false);

            progressBar.Value = 0;

            DateTime dateTime = DateTime.Now;
            string commitMessage = dateTime.ToString("yyyy.MM.dd - HH:mm");
            int percent = 100 / directories.Count;

            foreach (string directory in directories)
            {
                await RunGitPush($"git add * && git commit -m \"{commitMessage}\" && git push", directory);
                progressBar.Value += percent;
            }

            FixProgressBar();
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
            TurnButtons(false);

            progressBar.Value = 0;

            if (commits.Any(c => c.Value))
            {
                int percent = 100 / commits.Count(c => c.Value);

                foreach (string commit in commits.Where(c => c.Value).Select(c => c.Key))
                {
                    await RunGitPull(commit);
                    progressBar.Value += percent;
                }

                FixProgressBar();
            }

            TurnButtons(true);
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

        private async Task<Dictionary<string, bool>> GetCommits(List<string> directories)
        {
            int percent = 100 / directories.Count;
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

                    progressBar.Value += percent;

                    if (process.ExitCode != 0)
                    {
                        MessageBox.Show(error, dir, MessageBoxButton.OK, MessageBoxImage.Error);
                        this.Close();
                    }

                    if (commit > 0) result[dir] = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                this.Close();
            }

            return result;
        }

        private void NewFile(object sender, RoutedEventArgs e)
        {
            File.Delete(SettingsService.configPath);
            new FileChoose().Show();
            this.Close();
        }
        private void FixProgressBar()
        {
            if (progressBar.Value < 100) progressBar.Value += 100 - progressBar.Value;
        }
        private void TurnButtons(bool value)
        {
            foreach (Button btn in mainGrid.Children.OfType<Button>()) btn.IsEnabled = value;
            mainGrid.Children.OfType<StackPanel>().First().IsEnabled = value;
        }
    }
}
