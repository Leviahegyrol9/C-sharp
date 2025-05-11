using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hazi
{
    public partial class Form1 : Form
    {
        int dx = 10, dy = 10;
        int minx = 0, miny = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void IdozitoIndit_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            dx = Convert.ToInt32(speed.Text);
            dy = dx;
            minx = Convert.ToInt32(x.Text);
            miny = Convert.ToInt32(y.Text);
            pictureBox1.Left = minx;
            pictureBox1.Top = miny;

            foreach (Control control in this.Controls.OfType<TextBox>())
            {
                control.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += dx;
            pictureBox1.Top += dy;

            if (pictureBox1.Right >= this.ClientSize.Width || pictureBox1.Left <= 0)
            {
                dx = -dx;
            }

            if (pictureBox1.Bottom >= this.ClientSize.Height || pictureBox1.Top <= 0)
            {
                dy = -dy;
            }
        }
    }
}
