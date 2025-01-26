using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private DateTime startTime;
        private DateTime endTime;
        private bool isNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;

            result.Text = string.Empty;
            progressBar.Value = 0;

            isNumber = GetMotorHp();
            
            if (isNumber)
            {
                progressBar.Value += 50;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void end_Click(object sender, EventArgs e)
        {
            endTime = DateTime.Now;

            if (isNumber && motorHP.Text != string.Empty)
            {
                result.Text = $"Állapot: {motorHP.Text}%\nKi: {startTime.ToShortTimeString()}\nBe: {endTime.ToShortTimeString()}";
                Clipboard.SetText(result.Text);
                motorHP.Text = string.Empty;
                progressBar.Value += 50;
            }
        }

        private bool GetMotorHp()
        {
            bool isNumber = int.TryParse(motorHP.Text, out int value);

            if (!isNumber)
            {
                result.Text = "Nem számot adtál meg!";
                return false;
            }
            else if (value < 0 || value > 100)
            {
                result.Text = "0 és 100 között add meg!";
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
