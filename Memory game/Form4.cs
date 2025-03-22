using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_game
{
    public partial class Form4: Form
    {
        public Form4()
        {
            InitializeComponent();

            new Form2().Dispose();

            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                PictureBox pb = panel1.Controls[i] as PictureBox;

                if (i >= Form2.images.Count)
                {
                    pb.ImageLocation = Form2.images[i - 4].Path;
                }
                else
                {
                    pb.ImageLocation = Form2.images[i].Path;
                }
            }
        }
        private void mixBtn_Click(object sender, EventArgs e)
        {
            AppServices.MixBtn(panel1, mixBtn);
        }
        private void PictureBoxClick(object sender, EventArgs e)
        {
            AppServices.ClickImage(panel1, mixBtn, sender);
            AppServices.ShowWinLabel(panel1, winLabel);
        }
        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
