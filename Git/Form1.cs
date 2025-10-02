using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
        List<string> directories = new List<string>
        { 
            @"C:\Saját\Projects\C-sharp",
            @"C:\Saját\Projects\JS",
            @"C:\Saját\Projects\PHP"
        };
        public Form1()
        {
            InitializeComponent();
        }

        private async void PullBtn_Click(object sender, EventArgs e)
        {
            TurnButton(false);
            
            foreach (string directory in directories)
            {
                await RunGitPull(directory);
            }

            TurnButton(true);
        }

        private async void PushBtn_Click(object sender, EventArgs e)
        {
            TurnButton(false);

            DateTime dateTime = DateTime.Now;
            string commitMessage = dateTime.ToString("yyyy.MM.dd - HH:mm");

            foreach (string directory in directories)
            {              
                await RunGitPush($"/c git add * && git commit -m \"{commitMessage}\" && git push", directory);
            }

            TurnButton(true);
        }

        private Task RunGitPush(string arguments, string dir)
        {
            return Task.Run(() =>
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = arguments;
                process.StartInfo.WorkingDirectory = dir;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;

                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                process.WaitForExit();

                if (error != string.Empty)
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
                Process countProcess = new Process();
                countProcess.StartInfo.FileName = "cmd.exe";
                countProcess.StartInfo.Arguments = "/c git rev-list HEAD..origin/main --count";
                countProcess.StartInfo.WorkingDirectory = dir;
                countProcess.StartInfo.UseShellExecute = false;
                countProcess.StartInfo.RedirectStandardOutput = true;
                countProcess.StartInfo.RedirectStandardError = true;
                countProcess.StartInfo.CreateNoWindow = true;

                countProcess.Start();
                int commits = int.Parse(countProcess.StandardOutput.ReadToEnd().Trim());
                string countError = countProcess.StandardError.ReadToEnd();
                countProcess.WaitForExit();

                if (countError != string.Empty)
                {
                    MessageBox.Show(countError, dir, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (commits > 0)
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

                    if (!string.IsNullOrWhiteSpace(pullError))
                    {
                        MessageBox.Show(pullError, dir, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(pullOutput, dir, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show($"Nincs új fájl.", dir, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            });
        }

        private void TurnButton(bool trueOrFalse)
        {
            foreach (Button button in this.Controls.OfType<Button>()) button.Enabled = trueOrFalse;
        }
    }
}
