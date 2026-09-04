using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Autó_gyakorló
{
    public partial class Form1 : Form
    {
        const string fileName = "cars.txt";
        string option;
        Random rnd = new Random();
        int point = 0;
        public Form1()
        {
            InitializeComponent();
            
            foreach (string car in File.ReadLines(fileName))
            {
                carsCb.Items.Add(car);
            }

            radioButton1.Checked = true;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            try
            {
                carsCb.SelectedIndex++;
            }
            catch (Exception)
            {
                carsCb.SelectedIndex = 0;
            }
        }

        private void randomizeBtn_Click(object sender, EventArgs e)
        {
            carsCb.Items.Clear();

            List<string> shuffled = File.ReadLines(fileName).OrderBy(i => rnd.Next()).ToList();

            foreach (string car in shuffled)
            {
                carsCb.Items.Add(car);
            }

            carsCb.SelectedIndex = 0;
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton rb in panel3.Controls)
            {
                if (rb.Checked)
                {
                    option = rb.Text;
                    break;
                }
            }

            switch (option)
            {
                case "Gyakorlás":

                    carsCb.SelectedItem = null;
                    carsCb.SelectedIndex = 0;

                    foreach (Control ctrl in panel2.Controls)
                    {
                        ctrl.Visible = false;
                    }

                    foreach (Control ctrl in panel1.Controls)
                    {
                        ctrl.Visible = true;
                    }
                    break;

                case "Pontgyűjtés":

                    pB.Image = null;

                    foreach (Control ctrl in panel1.Controls)
                    {
                        ctrl.Visible = false;
                    }

                    foreach (Control ctrl in panel2.Controls)
                    {
                        ctrl.Visible = true;
                    }

                    if (checkBtn.Enabled) GetRandomImg();
                    break;
            }
        }

        private void GetRandomImg()
        {
            List<string> images = Directory.GetFiles($@"{Directory.GetCurrentDirectory()}\img").Where(car => car != $@"{Directory.GetCurrentDirectory()}\img\Thumbs.db").ToList();
            int random = rnd.Next(0, images.Count() - 1);
            pB.ImageLocation = images[random];
        }

        private void carsCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carsCb.SelectedItem != null)
            {
                string currentPic = $@"{Directory.GetCurrentDirectory()}\img\{carsCb.SelectedItem.ToString().ToLower()}.png";
                pB.Image = Image.FromFile(currentPic);
            }
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            foreach (Control control in panel2.Controls)
            {
                if (control is TrackBar tb && Enabled)
                {
                    tb.Enabled = false;
                }
            }

            string car = Path.GetFileNameWithoutExtension(pB.ImageLocation);

            if (guess.Text.ToLower() == car.ToLower())
            {
                point += trackBar1.Value;
                points.ForeColor = Color.Green;
            }
            else
            {
                point -= trackBar2.Value;
                points.ForeColor = Color.Red;
            }

            points.Text = point.ToString();

            if (point >= trackBar3.Value)
            {
                MessageBox.Show("Nyertél!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkBtn.Enabled = false;
            }

            if (checkBtn.Enabled && guess.Text.ToLower() == car) GetRandomImg();

            guess.Text = null;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            plusPoint.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            minusPoint.Text = trackBar2.Value.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            maxPoint.Text = trackBar3.Value.ToString();
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            foreach (Control control in panel2.Controls)
            {
                if (control is TrackBar tb)
                {
                    tb.Enabled = true;

                    if (tb.Name == "trackBar3") tb.Value = 15;
                    else tb.Value = 1;

                }
            }

            trackBar1_Scroll(sender, e);
            trackBar2_Scroll(sender, e);
            trackBar3_Scroll(sender, e);

            point = 0;
            checkBtn.Enabled = true;
            radioButton1.Checked = true;
            points.Text = null;
        }
    }
}
