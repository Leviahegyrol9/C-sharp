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

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void osszeadas_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double osszeg = double.Parse(szam1.Text.Replace('.',',')) + double.Parse(szam2.Text.Replace('.', ','));
                eredmeny.Content = $"Eredmény: {osszeg}";
            }
            catch (Exception ex)
            {
                eredmeny.Content = $"Hiba: {ex.Message}";
            }
            

        }

        private void torles_Click(object sender, RoutedEventArgs e)
        {
            szam1.Text = string.Empty;
            szam2.Text = string.Empty;
            eredmeny.Content = "Eredmény:";
        }

        private void kivonas_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double kulombseg = double.Parse(szam1.Text.Replace('.', ',')) - double.Parse(szam2.Text.Replace('.', ','));
                eredmeny.Content = $"Eredmény: {kulombseg}";
            }
            catch (Exception ex)
            {
                eredmeny.Content = $"Hiba: {ex.Message}";
            }
        }
    }
}
