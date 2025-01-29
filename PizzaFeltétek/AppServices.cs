using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaFeltétek
{
    public class AppServices
    {
        public static List<string> GetToppings(string path)
        {
            List<string> toppings = new List<string>();

            try
            {
                toppings = File.ReadAllLines(path).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return toppings;
        }

        public static string GetToppingText(GroupBox groupBox, Label result)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return $"Kiválasztott feltét: {radioButton.Text}";
                }
            }

            return string.Empty;
        }
    }
}
