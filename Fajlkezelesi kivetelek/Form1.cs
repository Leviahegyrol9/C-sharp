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

namespace Fajlkezelesi_kivetelek
{
    public partial class Form1 : Form
    {
        string loadedFilePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    loadedFilePath = ofd.FileName;
                    string content = File.ReadAllText(loadedFilePath);
                    textBox1.Text = content;
                    MessageBox.Show("Fájl betöltve.");
                    label1.Text = loadedFilePath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba a fájl betöltésekor:\n" + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loadedFilePath))
            {
                MessageBox.Show("Nincs fájl megnyitva (En voltam).");
                return;
            }
            try
            {
                File.WriteAllText(loadedFilePath, textBox1.Text);
                MessageBox.Show("Sikeres mentés. (En voltam)");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mentési hiba: \n (Én voltam)" + ex.Message);
            }


        }
    }
    }
