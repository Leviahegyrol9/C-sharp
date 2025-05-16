using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

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
            bool isNumber = int.TryParse(ageTb.Text, out int age);
            bool isValidEmail = Regex.IsMatch(email.Text, RegexPattern.emailPattern);

            if (!isString || nameTb.Text.Length < 3)
            {
                MessageBox.Show("Nem nevet adott meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nameTb.Text = string.Empty;
            }
            else if (!isNumber || age > 150 || age < 0)
            {
                MessageBox.Show("Nem életkort adott meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ageTb.Text = string.Empty;
            }
            else if (!isValidEmail) 
            {
                MessageBox.Show("Nem emailt adott meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                email.Text = string.Empty;
            }
            else afterLogin.Visible = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\People\{fileName.Text}.txt";
            if (File.Exists($@"{Directory.GetCurrentDirectory()}\People\{fileName.Text}.txt"))
            {
                MessageBox.Show("Már létezik ilyen nevű file!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!fileName.Text.All(char.IsLetter))
            {
                MessageBox.Show("Csak betűt tartalmazhat a file név!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (fileName.Text.Contains(".txt"))
            {
                MessageBox.Show("A kiterjesztés ne tartalmazza a file nevet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (StreamWriter sW = new StreamWriter($@"{Directory.GetCurrentDirectory()}\People\{fileName.Text}.txt"))
                    {
                        sW.WriteLine("Név;Életkor;Email");
                        sW.Write($"{nameTb.Text};{ageTb.Text};{email.Text}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show($"Kedves {nameTb.Text}!Gratulálunk, sikeresen jelentkeztél az űrutazásra!", "Jelentkezés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                statusBar.Text = "Emberek száma: " + Directory.GetFiles($@"{Directory.GetCurrentDirectory()}\People").Count().ToString();

                foreach (TextBox tB in this.Controls.OfType<TextBox>())
                {
                    tB.Text = string.Empty;
                }

                fileName.Text = string.Empty;
                
            }
        }
    }
}
