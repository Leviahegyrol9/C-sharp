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

namespace Memory_game
{
    public partial class Form2 : Form
    {
        public static List<Image> images = new List<Image>();
        public Form2()
        {
            InitializeComponent();

            new Form1().Dispose();

            infoLabel.Text = $"Válaszz ki {(Form1.option == "0" ? "2" : "4")} képet!";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    Image image = null;

                    openFileDialog.InitialDirectory = $@"{Directory.GetCurrentDirectory()}\images";
                    openFileDialog.Title = "Válassz ki egy képet!";
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                    openFileDialog.Multiselect = true;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        foreach (string file in openFileDialog.FileNames)
                        {
                            string fileName = Path.GetFileNameWithoutExtension(file);

                            if (!imagesCb.Items.Contains(fileName))
                            {
                                imagesCb.Items.Add(fileName);

                                image = new Image
                                {
                                    Name = fileName,
                                    Path = file
                                };

                                images.Add(image);

                                SetStartBtn();
                            }
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void imagesCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imagesCb.SelectedItem != null)
            {
                Image currentImg = images.Where(img => img.Name == imagesCb.SelectedItem.ToString()).Single();

                currentPb.ImageLocation = currentImg.Path;
            }
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Image deleteImg = images.Where(img => img.Name == imagesCb.SelectedItem.ToString()).Single();

            imagesCb.Items.Remove(deleteImg.Name);

            images.Remove(deleteImg);

            currentPb.ImageLocation = null;

            SetStartBtn();
        }
        private void SetStartBtn()
        {
            if (Form1.option == "0" && imagesCb.Items.Count == 2)
            {
                startBtn.Enabled = true;
            }
            else if (Form1.option == "1" && imagesCb.Items.Count == 4)
            {
                startBtn.Enabled = true;
            }
            else
            {
                startBtn.Enabled = false;
            }
        }
        private void startBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            switch (Form1.option)
            {
                case "0":
                    new Form3().Show();
                    break;

                case "1":
                    new Form4().Show();
                    break;
            }
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
