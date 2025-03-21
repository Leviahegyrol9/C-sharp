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
        public List<Image> images = new List<Image>();
        public Form2()
        {
            InitializeComponent();

           new Form1().Dispose();
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
                            comboBox1.Items.Add(Path.GetFileNameWithoutExtension(file));

                            image = new Image
                            {
                                Name = Path.GetFileNameWithoutExtension(file),
                                Path = file
                            };

                            images.Add(image);

                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image currentImg = images.Where(i => i.Name == comboBox1.SelectedItem.ToString()).Single();

            pictureBox1.ImageLocation = currentImg.Path;

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            comboBox1.Items.Remove(comboBox1.SelectedItem);

            pictureBox1.ImageLocation = null;

        }

        private void startBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
