using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaFeltétek
{
    public partial class Form1 : Form
    {
        const string path = "feltetlista.txt";
        RadioButton radioButton = new RadioButton();
        GroupBox groupBox = new GroupBox();
        public Form1()
        {
            InitializeComponent();
        }

        private void toppingsBtn_Click(object sender, EventArgs e)
        {
            List<string> toppings = AppServices.GetToppings(path);

            groupBox = new GroupBox
            {
                Text = "Feltétek",
                Location = new Point(20, 20),
                Size = new Size(250, 30 + toppings.Count * 30)
            };

            this.Controls.Add(groupBox);

            for (int i = 0; i < toppings.Count; i++)
            {
                radioButton = new RadioButton
                {
                    Text = toppings[i],
                    Location = new Point(10, 25 + i * 25),
                    AutoSize = true
                };

                groupBox.Controls.Add(radioButton);
            }        
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string topping = AppServices.GetToppingText(groupBox, result);
            
            result.Text = topping;
               
        }
    }
}
