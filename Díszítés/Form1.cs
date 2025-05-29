using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Díszítés
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void madeMenu(object sender, EventArgs e)
        {
            MessageBox.Show("2024-2025", "Készült", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void contactMenu(object sender, EventArgs e)
        {
            MessageBox.Show("Paplukács Levente", "Készítette", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textChanged(object sender, EventArgs e)
        {
            if (isValidDatas() && double.Parse(sofaWidth.Text.Replace(".", ",")) < double.Parse(wallWidth.Text.Replace(".", ",")))
            {
                calculateBtn.Visible = true;
                menuBar.Text = string.Empty;
            }
            else
            {
                menuBar.Text = "Nem adta meg az adatokat vagy hibás adatokat adott meg!";
            }
        }

        private bool isValidDatas()
        {
            foreach (TextBox tB in panel1.Controls.OfType<TextBox>())
            {
                if (tB.Text == string.Empty || !double.TryParse(tB.Text.Replace(".", ","), out _) || double.Parse(tB.Text.Replace(".", ",")) < 1) return false;
            }

            return true;
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            if (isValidDatas() && double.Parse(sofaWidth.Text.Replace(".", ",")) < double.Parse(wallWidth.Text.Replace(".", ",")))
            {
                double pictureWidth = (double.Parse(sofaWidth.Text.Replace(".", ","))) * (2 / 3.0);
                double pictureHeight = (pictureWidth) * (2 / 3.0);

                double leftSpace = double.Parse(wallHeight.Text.Replace(".", ",")) - (double.Parse(sofaHeight.Text.Replace(".", ",")) + pictureHeight + pictureHeight * 0.2);

                if (leftSpace > pictureHeight / 2)
                {
                    menuBar.Text = "Lehetséges a kép felrakása";

                    resultLabel.Text = $"A kép magassága: {pictureHeight:n2}\nA kép szélessége: {pictureWidth:n2}\nA padlótól {double.Parse(sofaHeight.Text.Replace(".", ",")) + leftSpace:n2} magasan felfüggeszthető";
                }
                else menuBar.Text = "Nem ajánlott képet felrakni!";
            }
            else menuBar.Text = "Rossz adat!";
            
        }
    }
}
