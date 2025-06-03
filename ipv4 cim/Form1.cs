using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IPv4Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void checkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                int o1 = CheckOktet(textBox1.Text, "1. oktett");
                int o2 = CheckOktet(textBox2.Text, "2. oktett");
                int o3 = CheckOktet(textBox3.Text, "3. oktett");
                int o4 = CheckOktet(textBox4.Text, "4. oktett");

                int o5 = CheckOktet(textBox5.Text, "5. oktett");
                int o6 = CheckOktet(textBox6.Text, "6. oktett");
                int o7 = CheckOktet(textBox7.Text, "7. oktett");
                int o8 = CheckOktet(textBox8.Text, "8. oktett");

                if (CheckPrefix(panel1.Controls.OfType<TextBox>().ToList()))
                {
                    label1.Text = $"Megadott cím: {o1}.{o2}.{o3}.{o4} /{prefixBox.Text}";
                    label2.Text = $"Megadott cím: {o5}.{o6}.{o7}.{o8} /{prefixBox2.Text}";
                    menuBar.Text = "Sikeres ellenőrzés.";
                }
                else throw new Exception("Prefix csak 1 és 32 közé eshet.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hibás adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                menuBar.Text = "Hiba: " + ex.Message;
            }
        }
        private int CheckOktet(string szoveg, string mezonév)
        {
            if (!int.TryParse(szoveg, out int ertek))
                throw new Exception($"{mezonév} nem szám.");
            if (ertek < 0 || ertek > 255)
                throw new Exception($"{mezonév} csak 0 és 255 közötti szám lehet.");
            return ertek;
        }
        private bool CheckPrefix(List<TextBox> textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                int prefix = int.Parse(textBox.Text);
                if (prefix < 1 || prefix > 32)
                {
                    return false;
                }
            }

            return true;
        }    
        private void contactMenu(object sender, EventArgs e)
        {
            MessageBox.Show("IPv4 Ellenőrző\nKészítette: Paplukács Levente\nTanév: 2024/2025", "Névjegy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
