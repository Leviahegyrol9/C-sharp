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

            AppServices.FillPictureBoxes(panel1);

            pointLabel.Text = AppServices.point.ToString();
        }
        private void mixBtn_Click(object sender, EventArgs e)
        {
            AppServices.MixBtn(panel1, mixBtn);
        }
        private void PictureBoxClick(object sender, EventArgs e)
        {
            AppServices.ClickImage(panel1, mixBtn, pointLabel, sender);
            if (!mixBtn.Visible) AppServices.ShowWinLabel(panel1, winLabel);
        }
        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
