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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using EmailValidator;
using Function;

namespace Cukraszda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            bool isString = nameTb.Text.Replace(" ", "").All(char.IsLetter);
            bool isNumber = int.TryParse(countTb.Text, out int count);
            bool isValidEmail = Regex.IsMatch(emailTb.Text, RegexPattern.emailPattern);

            if (!isString || nameTb.Text.Length < 3)
            {
                MessageBox.Show("Nem nevet adott meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nameTb.Text = string.Empty;
            }
            else if (!isNumber)
            {
                MessageBox.Show("Nem számot adott meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                countTb.Text = string.Empty;
            }
            else if (!isValidEmail)
            {
                MessageBox.Show("Nem emailt adott meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailTb.Text = string.Empty;
            }
            else
            {
                if (cakeType.SelectedItem != null)
                {
                    MessageBox.Show($"Köszönjük, {Methods.CapitalizeName(nameTb.Text)}! Rendelését ({count} db {cakeType.SelectedItem}) sikeresen rögzítettük.\nHamarosan e-mailben visszaigazoljuk.", "Jelenkezés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    
                else MessageBox.Show("Add meg a sütemény tipusát is!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
