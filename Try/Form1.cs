using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Try
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            try
            {
                result.Text = $"{(double.Parse(num1.Text) / double.Parse(num2.Text)):n2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Számot adj meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("0-val nem lehet osztani!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
