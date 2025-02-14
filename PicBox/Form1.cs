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

namespace PicBox
{
    public partial class Form1 : Form
    {
        List<string> pictures = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string currentPath = Directory.GetCurrentDirectory();

            pictures = Directory.GetFiles(currentPath,"*.jpg").ToList();

            foreach (string picture in pictures)
            {
                foreach (ComboBox cb in this.Controls.OfType<ComboBox>())
                {
                    cb.Items.Add(Path.GetFileName(picture));
                }            
            }
        }
        private void cB1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cB2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = pictures.Where(p => p.Contains(cB2.SelectedItem.ToString())).Single();

            picBox2.Image = Image.FromFile(path);
        }


        private void cB3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
