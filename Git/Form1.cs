using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Git
{
    public partial class Form1 : Form
    {
        List<string> directories = GetDirectory();
        Dictionary<string, bool>.KeyCollection commits;
        public Form1()
        {
            InitializeComponent();
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            TurnButton(false);

            Dictionary<string, bool> directoriesWithCommit = await GetCommits(directories);
            commits = directoriesWithCommit.Where(c => c.Value).ToDictionary(k => k.Key, v => v.Value).Keys;


            if (commits.Count != 0)
            {
                commitLabel.ForeColor = Color.Red;
                commitLabel.Text = "Van új file!";
                PullBtn.Enabled = true;
            }
            else
            {
                commitLabel.ForeColor = Color.Green;
                commitLabel.Text = "Nincs új file.";
                TurnButton(true);
            }
        }

        private async void PullBtn_Click(object sender, EventArgs e)
        {
            TurnButton(false);

            Dictionary<string, bool> directoriesWithCommit = await GetCommits(directories);
            commits = directoriesWithCommit.Where(c => c.Value).ToDictionary(k => k.Key, v => v.Value).Keys;

            foreach (string commit in commits)
            {
                await RunGitPull(commit);
            }

            commitLabel.Text = string.Empty;

            TurnButton(true);
        }

        private async void PushBtn_Click(object sender, EventArgs e)
        {
            TurnButton(false);

            DateTime dateTime = DateTime.Now;
            string commitMessage = dateTime.ToString("yyyy.MM.dd - HH:mm");       

            foreach (string directory in directories)
            {              
                await RunGitPush($"git add * && git commit -m \"{commitMessage}\" && git push", directory);
            }

            TurnButton(true);
        }

        private async Task<Dictionary<string, bool>> GetCommits(List<string> directories)
        {
            Dictionary<string, bool> result = new Dictionary<string, bool>();

            foreach (string dir in directories)
            {
                result[dir] = false;

                Process countProcess = new Process();
                countProcess.StartInfo.FileName = "cmd.exe";
                countProcess.StartInfo.Arguments = "/c git fetch && git rev-list HEAD..origin/main --count";
                countProcess.StartInfo.WorkingDirectory = dir;
                countProcess.StartInfo.UseShellExecute = false;
                countProcess.StartInfo.RedirectStandardOutput = true;
                countProcess.StartInfo.RedirectStandardError = true;
                countProcess.StartInfo.CreateNoWindow = true;

                countProcess.Start();

                string output = await countProcess.StandardOutput.ReadToEndAsync();
                string countError = await countProcess.StandardError.ReadToEndAsync();
                int commit = int.Parse(output.Trim());

                countProcess.WaitForExit();

                if (countProcess.ExitCode != 0)
                {
                    MessageBox.Show(countError, dir, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Enabled = false;
                }

                if (commit > 0) result[dir] = true;
            }

            return result;
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
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;

                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                process.WaitForExit();

                if (process.ExitCode > 1)
                {
                    MessageBox.Show(error, dir, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show(output, dir, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            });
        }
        private Task RunGitPull(string dir)
        {
            return Task.Run(() =>
            {
                Process pullProcess = new Process();
                pullProcess.StartInfo.FileName = "cmd.exe";
                pullProcess.StartInfo.Arguments = "/c git pull";
                pullProcess.StartInfo.WorkingDirectory = dir;
                pullProcess.StartInfo.UseShellExecute = false;
                pullProcess.StartInfo.RedirectStandardOutput = true;
                pullProcess.StartInfo.RedirectStandardError = true;
                pullProcess.StartInfo.CreateNoWindow = true;

                pullProcess.Start();

                string pullOutput = pullProcess.StandardOutput.ReadToEnd();
                string pullError = pullProcess.StandardError.ReadToEnd();

                pullProcess.WaitForExit();

                if (pullProcess.ExitCode != 0)
                {
                    MessageBox.Show(pullError, dir, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(pullOutput, dir, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }               
            });
        }
        private void TurnButton(bool trueOrFalse)
        {
            foreach (Button button in this.Controls.OfType<Button>()) button.Enabled = trueOrFalse;
        }
        private static List<string> GetDirectory()
        {
            List<string> directories = new List<string>
            {
                @"C:\Saját\Projects\C-sharp",
                @"C:\Saját\Projects\JS",
                @"C:\Saját\Projects\PHP"
            };

            List<string> directories2 = new List<string>
            {
                @"J:\C-sharp",
                @"J:\JS",
                @"J:\PHP"
            };

            bool dir1Missing = directories.Any(d => !Directory.Exists(d));
            bool dir2Missing = directories2.Any(d => !Directory.Exists(d));

            return (!dir1Missing) ? directories : directories2;
        }
    }
}
