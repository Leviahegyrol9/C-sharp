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

namespace Tesztkészítő
{
    public partial class Form1 : Form
    {
        const string path = "mondatok.txt";
        List<string> sentences = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                sentences = File.ReadAllLines(path).ToList();

                WriteToCb();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void WriteToCb()
        {
            if (sentences.Count != 0)
            {
                foreach (string sentence in sentences)
                {
                    cb.Items.Add(sentence);
                }
            }
        }
    }
}
