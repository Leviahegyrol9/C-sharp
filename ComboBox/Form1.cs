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

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            if (input.Text == string.Empty)
            {
                MessageBox.Show("Írj be valamit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                list.Items.Add(input.Text);
                input.Text = string.Empty;
            }        
        }

        private void removeBTN_Click(object sender, EventArgs e)
        {
            try
            {
                list.Items.Remove(list.SelectedItem);

            }
            catch (Exception)
            {
                MessageBox.Show("Nem sikerült a törlés!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sortBTN_Click(object sender, EventArgs e)
        {
            list.Sorted = true;
            list.Sorted = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void writeBTN_Click(object sender, EventArgs e)
        {
            if (fileName.Text == string.Empty)
            {
                MessageBox.Show("Írj be valamit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool success = WriteFile();

                if (success) MessageBox.Show($"{fileName.Text} állomány sikeresen létrehozva!", "FileWrite", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show($"{fileName.Text} állományt nem sikerült létrehozni!", "FileWrite", MessageBoxButtons.OK, MessageBoxIcon.Error);

                fileName.Text = string.Empty;
            }        
        }

        private bool WriteFile()
        {
            StreamWriter writer = new StreamWriter($"{fileName.Text}.txt");
            try
            {
                foreach (string name in list.Items)
                {
                    writer.WriteLine(name);
                }
            }
            catch (Exception)
            {
                writer.Close();
                return false;
            }
            finally
            {
                writer.Close();              
            }

            return true;
        }

        private void readBTN_Click(object sender, EventArgs e)
        {
            if (fileName2.Text == string.Empty)
            {
                MessageBox.Show("Írj be valamit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<string> names = ReadFile();

                foreach (string name in names)
                {
                    result.Items.Add(name);
                }

                resultText.Text = $"Tanulók száma: {names.Count}";

                result.Visible = true;

                fileName2.Text = string.Empty;
            }
        }

        private List<string> ReadFile()
        {
            List<string> lines = new List<string>();
            try
            {
                lines = File.ReadAllLines($"{fileName2.Text}.txt").ToList();               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FileRead", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lines;
        }
    }
}
