using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            atvaltas1.SelectedIndex = 0;
            atvaltas2.SelectedIndex = 0;
        }

        private void atvalt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double bemenet = double.Parse(atvaltando.Text.Replace("-","."));
                string mibol = (atvaltas1.SelectedItem as ComboBoxItem).Content.ToString();
                string mibe = (atvaltas2.SelectedItem as ComboBoxItem).Content.ToString();

                double ertek = 0.0;
                switch (mibol)
                {
                    case "cm":
                        ertek = bemenet;
                        break;
                    case "m":
                        ertek = bemenet * 100;
                        break;
                    case "km":
                        ertek = bemenet * 100000;
                        break;
                    case "inch":
                        ertek = bemenet * 2.54;
                        break;
                }

                switch (mibe)
                {
                    case "cm":
                        ertek = bemenet;
                        break;
                    case "m":
                        ertek = ertek / 100;
                        break;
                    case "km":
                        ertek = ertek / 100000;
                        break;
                    case "inch":
                        ertek = ertek / 2.54;
                        break;
                }

                eredmeny.Text = ertek.ToString("n2");
            }
            catch
            {
                MessageBox.Show("Nem jó a bemenet formátuma!");
            }
        }
    }
}
