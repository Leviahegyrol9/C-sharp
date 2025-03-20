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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            foreach (RadioButton rb in optionPanel.Controls)
            {
                if (rb.Checked)
                {
                    this.Hide();

                    if (rb.Tag.ToString() == "0")
                    {
                        new Form2().Show();
                        
                    }
                    else
                    {
                        new Form3().Show();
                    }
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
