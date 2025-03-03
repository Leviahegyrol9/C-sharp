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
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton rb in gB.Controls)
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
                    nextBtn.Visible = true;
                    randomizeBtn.Visible = true;
                    carsCb.Visible = true;
                    pB.Visible = true;
                    break;

                case "Pontgyűjtés":
                    string[] images = Directory.GetFiles($@"{Directory.GetCurrentDirectory()}\img");
                    int random = rnd.Next(0, images.Count() - 1);
                    pB.Image = Image.FromFile(images[random]);
                    break;
            }
        }

        private void carsCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentPic = $@"{Directory.GetCurrentDirectory()}\img\{carsCb.SelectedItem.ToString().ToLower()}.png";
            pB.Image = Image.FromFile(currentPic);
        }
    }
}
