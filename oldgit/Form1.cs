using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git
{
    public partial class Form1 : Form
    {
        Dictionary<string, bool>.KeyCollection commits;
        public static string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        public static List<string> directories;
        public Form1()
        {
            InitializeComponent();
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            TurnButtons(false);

            try
            {
                bool fileExist = File.Exists($@"{userProfile}\gitDirsPath.txt");
                bool notEmpty = File.ReadAllLines($@"{userProfile}\gitDirsPath.txt").Length == 1;

                string path = File.ReadAllText($@"{userProfile}\gitDirsPath.txt");

                bool originalFileExist = File.Exists(path);
                bool originalNotEmpty = File.ReadAllLines(path).Length != 0;

                directories = File.ReadAllLines(path).ToList();

                Dictionary<string, bool> directoriesWithCommit = await GetCommits(directories);
                commits = directoriesWithCommit.Where(c => c.Value).ToDictionary(k => k.Key, v => v.Value).Keys;
                FixProgressBar();

                if (commits.Count != 0)
                {
                    infoLabel.ForeColor = Color.Red;
                    infoLabel.Text = "Van új file!";
                    PullBtn.Enabled = true;
                }
                else
                {
                    infoLabel.ForeColor = Color.Green;
                    infoLabel.Text = "Nincs új file.";
                    TurnButtons(true);
                }

            }
            catch (FileNotFoundException)
            {
                this.Hide();

                new Form2().Show();
            }          
        }
        private async void PushBtn_Click(object sender, EventArgs e)
        {
            await PushAsync();
        }
        private async void PullBtn_Click(object sender, EventArgs e)
        {
            TurnButtons(false);

            progressBar.Value = 0;
            infoLabel.Text = string.Empty;

            if (commits.Count == 0)
            {
                Dictionary<string, bool> directoriesWithCommit = await GetCommits(directories);
                commits = directoriesWithCommit.Where(c => c.Value).ToDictionary(k => k.Key, v => v.Value).Keys;
                FixProgressBar();
            }

            if (commits.Count != 0)
            {
                int percent = 100 / commits.Count;

                foreach (string commit in commits)
                {
                    await RunGitPull(commit);
                    progressBar.Value += percent;
                }

                FixProgressBar();
            }
            else
            {
                infoLabel.ForeColor = Color.Green;
                infoLabel.Text = "Nincs új file.";
            }

            TurnButtons(true);
        }
        private async Task PushAsync()
        {
            TurnButtons(false);

            progressBar.Value = 0;
            infoLabel.Text = string.Empty;

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
                    MessageBox.Show(error, dir, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
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
                    MessageBox.Show(error, dir, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show(error, dir, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Dispose();
                    }

                    if (commit > 0) result[dir] = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.Delete($@"{userProfile}\gitDirsPath.txt");
                this.Dispose();
            }

            return result;
        }
        private void TurnButtons(bool trueOrFalse)
        {
            foreach (Button button in this.Controls.OfType<Button>()) button.Enabled = trueOrFalse;
        }

        private void FixProgressBar()
        {
            if (progressBar.Value < 100) progressBar.Value += 100 - progressBar.Value;
        }
        private async void ProgramExit(object sender, FormClosingEventArgs e)
        {
            if (!GetPath.Enabled)
            {
                e.Cancel = true;

                if (!this.Controls.OfType<Button>().Any(b => !b.Enabled))
                {
                    await PushAsync();
                    this.Dispose();
                }
            }            
        }
    }
}