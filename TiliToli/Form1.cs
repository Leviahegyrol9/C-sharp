using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiliToli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MixField(panel1);
        }

        private void optionClick(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;

            bool isAnyChecked = menuStrip1.Items.Cast<ToolStripMenuItem>().Any(item => item.ForeColor == Color.Red);

            if (isAnyChecked)
            {
                DialogResult result = MessageBox.Show("Biztosan újra szeretnéd indítani?", "Újraindítás", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    menuStrip1.Items.Cast<ToolStripMenuItem>().Where(item => item.Tag != menu.Tag).Single().ForeColor = Color.Black;
                    menu.ForeColor = Color.Red;
                    Restart(menu.Tag);
                }
            }
            else menu.ForeColor = Color.Red;
        }

        private void Restart(object tag)
        {
            switch (tag)
            {
                case "0":
                    break;

                case "1":
                    break;
            }
        }
        private void MixField(Panel panel)
        {
            Random rnd = new Random();

            List<PictureBox> pictureBoxes = panel.Controls.OfType<PictureBox>().ToList();
            List<Point> positions = pictureBoxes.Select(pb => pb.Location).ToList();

            for (int i = positions.Count - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                Point temp = positions[i];

                positions[i] = positions[j];
                positions[j] = temp;
            }
        }
        private void ClickImg(object sender, EventArgs e)
        {
            PictureBox clickedPic = sender as PictureBox;

            PictureBox emptyPic = panel1.Controls.OfType<PictureBox>().Where(img => img.Image == null).Single();
            Image tempImg = clickedPic.Image;
            Point tempLocation = clickedPic.Location;

            clickedPic.Image = null;
            clickedPic.Location = emptyPic.Location;
            emptyPic.Image = tempImg;
            emptyPic.Location = tempLocation;
        }
    }
}
