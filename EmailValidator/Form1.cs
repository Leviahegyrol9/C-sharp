using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailValidator
{
    public partial class Form1 : Form
    {
        string emailPattern = RegexPattern.emailPattern;
        public Form1()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {     
            if (Regex.IsMatch(email.Text, emailPattern))
            {
                MessageBox.Show("Valid email!", "Email validator", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Unvalid email!", "Email validator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                email.Clear();
            }          
        }
    }
}
