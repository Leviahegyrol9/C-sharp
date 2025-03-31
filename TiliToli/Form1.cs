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

namespace TiliToli
{
    public partial class Form1 : Form
    {
        List<Point> originalPositions = new List<Point>();
        public Form1()
        {
            InitializeComponent();

            foreach (PictureBox pb in panel1.Controls)
            {
                originalPositions.Add(pb.Location);
            }

            MixField();
        }
        private void optionClick(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;

            bool isAnyChecked = menuStrip1.Items.OfType<ToolStripMenuItem>().Any(item => item.ForeColor == Color.Red);

            if (isAnyChecked)
            {
                DialogResult result = MessageBox.Show("Biztosan újra szeretnéd indítani a játékot?", "Újraindítás", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    menuStrip1.Items.OfType<ToolStripMenuItem>().Where(item => item.Tag != menu.Tag).Single().ForeColor = Color.Black;
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
        private void MixField()
        {
            Random rnd = new Random();

            List<PictureBox> pictureBoxes = panel1.Controls.OfType<PictureBox>().ToList();
            List<Point> positions = pictureBoxes.Select(pb => pb.Location).ToList();

            for (int i = 0; positions.Count - 1 > i; i++)
            {
                int j = rnd.Next(i, positions.Count);

                Point temp = positions[i];
                positions[i] = positions[j];
                positions[j] = temp;
            }

            foreach (PictureBox pb in pictureBoxes)
            {
                pb.Location = positions[pictureBoxes.IndexOf(pb)];
            }
        }
        private void ClickImg(object sender, EventArgs e)
        {
            PictureBox clickedPic = sender as PictureBox;

            if (clickedPic.Image != null)
            {
                PictureBox emptyPic = panel1.Controls.OfType<PictureBox>().Where(img => img.Image == null).Single();
                Point tempLocation = clickedPic.Location;

                clickedPic.Location = emptyPic.Location;
                emptyPic.Location = tempLocation;

                if (CheckWin()) ShowWinLabel();
                
            }
        }
        private bool CheckWin()
        {
            List<PictureBox> pictureBoxes = panel1.Controls.OfType<PictureBox>().ToList();

            for (int i = 0; pictureBoxes.Count > i; i++)
            {
                if (pictureBoxes[i].Location != originalPositions[i])
                {
                    return false;
                }
            }

            return true;
        }
        private void ShowWinLabel()
        {
            panel1.Visible = false;
            Label winLabel = new Label();
            winLabel.Text = "Gratulálok, nyertél!";
            winLabel.Font = new Font("Arial", 20, FontStyle.Bold);
            winLabel.ForeColor = Color.Green;
            winLabel.AutoSize = true;
            winLabel.Location = new Point(280, 150);
            this.Controls.Add(winLabel);
        }
    }
}
