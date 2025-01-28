using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            var cntls = GetAll(this, typeof(RadioButton));
            foreach (Control cntrl in cntls)
            {
                RadioButton rb = (RadioButton)cntrl;
                if (rb.Checked)
                {
                    rb.Checked = false;
                }
            }

            result1.Text = string.Empty; 
            result2.Text = string.Empty;
        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            List<Control> controls = control.Controls.Cast<Control>().ToList();
            return controls.SelectMany(ctrls => GetAll(ctrls, type)).Concat(controls).Where(c => c.GetType() == type);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            result1.Text = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            result1.Text = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            result1.Text = radioButton3.Text;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            result2.Text = radioButton4.Text;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            result2.Text = radioButton5.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }
    }
}
