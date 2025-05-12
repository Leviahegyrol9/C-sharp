using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EmailValidator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            bool isString = nameTb.Text.Replace(" ", "").All(char.IsLetter);

            if (!isString || nameTb.Text.Length < 3)
            {
                MessageBox.Show("Nem nevet adott meg!","Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bool isNumber = int.TryParse(ageTb.Text, out int age);

            if (!isNumber || age > 150 || age < 0)
            {
                MessageBox.Show("Nem életkort adott meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bool isValidEmail = Regex.IsMatch(email.Text, RegexPattern.emailPattern);

            if (!isValidEmail) MessageBox.Show("Nem emailt adott meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
