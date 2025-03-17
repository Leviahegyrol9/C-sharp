using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MemoriaJatek
{
    public partial class Form1 : Form
    {
        private PictureBox[] pictureBoxes;
        private PictureBox elsoSelected = null;
        private PictureBox masodikSelected = null;
        private Image[] kepekTombje;
        private Image hatlap;

        public Form1()
        {
            InitializeComponent();
            hatlap = Image.FromFile("hatlap.jpg"); // Hátlap beállítása

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxes = this.Controls.OfType<PictureBox>().ToArray();
            kepekTombje = new Image[pictureBoxes.Length / 2 * 2]; // Páros számú képtömb
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBoxes == null || pictureBoxes.Length == 0)
                return;

            List<Image> images = new List<Image>();
            foreach (var pb in pictureBoxes.Take(pictureBoxes.Length / 2))
            {
                images.Add(pb.Image);
                images.Add(pb.Image); // Párosítjuk a képeket
            }

            images = images.OrderBy(_ => Guid.NewGuid()).ToList(); // Véletlenszerű keverés

            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                pictureBoxes[i].Image = hatlap;
                kepekTombje[i] = images[i];
                pictureBoxes[i].Tag = i;
                pictureBoxes[i].Click += pictureBox_Click;
            }

            button1.Visible = false; // Kezdés után elrejtjük a gombot
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox kattintottKep = sender as PictureBox;
            if (kattintottKep == null || kattintottKep.Image == null || kattintottKep.Image != hatlap)
                return;

            if (elsoSelected == null)
            {
                elsoSelected = kattintottKep;
                elsoSelected.Image = kepekTombje[(int)elsoSelected.Tag];
                elsoSelected.BorderStyle = BorderStyle.Fixed3D;
            }
            else if (masodikSelected == null && kattintottKep != elsoSelected)
            {
                masodikSelected = kattintottKep;
                masodikSelected.Image = kepekTombje[(int)masodikSelected.Tag];
                masodikSelected.BorderStyle = BorderStyle.Fixed3D;
                Timer timer = new Timer { Interval = 1000 };
                timer.Tick += (s, ev) => { timer.Stop(); EgyezesVizsgalat(); };
                timer.Start();
            }
        }

        private void EgyezesVizsgalat()
        {
            if (KepekEgyeznek(kepekTombje[(int)elsoSelected.Tag], kepekTombje[(int)masodikSelected.Tag]))
            {
                elsoSelected.Enabled = false;
                masodikSelected.Enabled = false;
            }
            else
            {
                elsoSelected.Image = hatlap;
                masodikSelected.Image = hatlap;
            }

            elsoSelected.BorderStyle = BorderStyle.None;
            masodikSelected.BorderStyle = BorderStyle.None;
            elsoSelected = null;
            masodikSelected = null;
        }

        private bool KepekEgyeznek(Image img1, Image img2)
        {
            if (img1 == null || img2 == null) return false;
            if (img1.Size != img2.Size) return false;

            using (var bmp1 = new Bitmap(img1))
            using (var bmp2 = new Bitmap(img2))
            {
                for (int y = 0; y < bmp1.Height; y++)
                {
                    for (int x = 0; x < bmp1.Width; x++)
                    {
                        if (bmp1.GetPixel(x, y) != bmp2.GetPixel(x, y))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
