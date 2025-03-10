using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxok_megkeverése
{
    public partial class Form1 : Form
    {
        private PictureBox[] pictureBoxes;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(pictureBoxes == null || pictureBoxes.Length == 0)
            {
                return;
            }

            Random rnd = new Random();

            List<Image> images = pictureBoxes.Select(img => img.Image).ToList();
            images = images.OrderBy(_ => rnd.Next()).ToList();

            for(int i = 0; i < pictureBoxes.Length; i++)
            {
                pictureBoxes[i].Image = images[i];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxes = this.Controls.OfType<PictureBox>().ToArray();
        }
    }
}
