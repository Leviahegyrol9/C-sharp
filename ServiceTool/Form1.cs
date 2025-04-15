using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceTool
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void startGitCMD(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            Process.Start($@"{Directory.GetCurrentDirectory()}\lib\{btn.Name}.bat");
        }

        private void win10ContextMenu_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "reg.exe",
                Arguments = "add \"HKCU\\Software\\Classes\\CLSID\\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\\InprocServer32\" /f /ve",
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            };

            Process.Start(psi);
        }
    }
}
