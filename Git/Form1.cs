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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Git
{
    public partial class Form1 : Form
    {
        List<string> directories;
        Dictionary<string, bool>.KeyCollection commits;
        public Form1()
        {
            InitializeComponent();
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            TurnButtons(false);

            if (File.Exists($@"%userprofile%\gitDirs.txt") && File.ReadAllLines($@"%userprofile%\gitDirs.txt").Length != 0)
            {
                GetPath.Enabled = false;

                directories = File.ReadAllLines($@"%userprofile%\gitDirs.txt").ToList();
            }
            else
            {
                infoLabel.ForeColor = Color.Red;
                infoLabel.Text = "Válasszd ki az elérési útvonalat!";
            }

            if (!GetPath.Enabled)
            {
                Dictionary<string, bool> directoriesWithCommit = await GetCommits(directories);
                commits = directoriesWithCommit.Where(c => c.Value).ToDictionary(k => k.Key, v => v.Value).Keys;

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
        }

        private async void PullBtn_Click(object sender, EventArgs e)
        {
            TurnButtons(false);

            Dictionary<string, bool> directoriesWithCommit = await GetCommits(directories);
            commits = directoriesWithCommit.Where(c => c.Value).ToDictionary(k => k.Key, v => v.Value).Keys;

            foreach (string commit in commits)
            {
                await RunGitPull(commit);
            }

            infoLabel.Text = string.Empty;

            TurnButtons(true);
        }

        private async void PushBtn_Click(object sender, EventArgs e)
        {
            TurnButtons(false);

            DateTime dateTime = DateTime.Now;
            string commitMessage = dateTime.ToString("yyyy.MM.dd - HH:mm");       

            foreach (string directory in directories)
            {              
                await RunGitPush($"git add * && git commit -m \"{commitMessage}\" && git push", directory);
            }

            TurnButtons(true);
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
        private void TurnButtons(bool trueOrFalse)
        {
            foreach (Button button in this.Controls.OfType<Button>()) button.Enabled = trueOrFalse;
        }
        private void GetPath_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Válaszd ki az eléri útvonalakat tartalmazó szöveges file-t!";
                    openFileDialog.Filter = "Text File|*.txt";
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string[] lines = File.ReadAllLines(openFileDialog.FileName);

                        File.WriteAllLines($@"{Directory}\gitDirs.txt",lines);

                        GetPath.Enabled = false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
