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

namespace Menu
{
    public partial class Form1 : Form
    {
        List<string> images = new List<string>();
        public Form1()
        {
            InitializeComponent();

            images = Directory.GetFiles($@"{Directory.GetCurrentDirectory()}\images", "*.png").ToList();
        }
        private void TeamsClick(object sender, EventArgs e)
        {
            ToolStripItem item = sender as ToolStripItem;

            switch (item.Text)
            {
                case "Gavallérok":
                    FillPictureBox("gavaller");
                    break;

                case "Csokornak":
                    FillPictureBox("viragcsokor");
                    break;

                case "Szárítani":
                    FillPictureBox("szaraz virag");
                    break;

                case "Átultetni":
                    FillPictureBox("ultetettvirag");
                    break;

                case "Magyar":          
                    FillPictureBox("magyarfocista");
                    break;

                case "Külföldi":                    
                    FillPictureBox("kulfoldifocista");
                    break;
            }
            
        }

        private void FillPictureBox(string fileName)
        {
            pictureBox.Image = Image.FromFile(images.Where(img => Path.GetFileNameWithoutExtension(img) == fileName).Single());
        }

        private void CreatorClick(object sender, EventArgs e)
        {

        }

        private void ExitClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztosan ki szeretne lépni?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) Application.Exit();
        }
    }
}
