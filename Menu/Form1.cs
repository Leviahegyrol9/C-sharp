using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace Menu
{
    public partial class Form1 : Form
    {
        Point maxPoint = new Point(600, 288);
        public Form1()
        {
            InitializeComponent();
        }

        private void AddImage(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = $@"{Directory.GetCurrentDirectory()}\images";
                    openFileDialog.Title = "Válaszd ki a képet!";
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        pB.Image = Image.FromFile(openFileDialog.FileName);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pB_Click(object sender, EventArgs e)
        {
            if (pB.Image != null)
            {
                if (pB.Location.X >= maxPoint.X)
                {
                    pB.Location = new Point(12, 288);
                }
                else
                {
                    pB.Location = new Point(pB.Location.X + 100, pB.Location.Y);
                }
            }        
        }
    }
}
