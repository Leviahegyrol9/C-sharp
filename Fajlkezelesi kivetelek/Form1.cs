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
        private void openBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Filter = "Text files (*.txt)|*.txt";

            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    loadedFilePath = openfiledialog.FileName;
                    string content = File.ReadAllText(loadedFilePath);
                    noteArea.Text = content;
                    MessageBox.Show("Fájl betöltve.");
                    fileName.Text = Path.GetFileName(loadedFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba a fájl betöltésekor:\n" + ex.Message);
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loadedFilePath))
            {
                MessageBox.Show("Nincs fájl megnyitva (En voltam).");
                return;
            }
            try
            {
                File.WriteAllText(loadedFilePath, noteArea.Text);
                MessageBox.Show("Sikeres mentés. (En voltam)");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mentési hiba: \n (Én voltam)" + ex.Message);
            }
        }
    }
}