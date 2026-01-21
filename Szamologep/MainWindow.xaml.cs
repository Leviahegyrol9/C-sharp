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

namespace Szamologep
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            try
            {
                switch (btn.Content.ToString())
                {
                    case "+":
                        result.Text = (double.Parse(first.Text.Replace(".", ",")) + double.Parse(second.Text.Replace(".", ","))).ToString("n2");
                        break;
                    case "-":
                        result.Text = (double.Parse(first.Text.Replace(".", ",")) - double.Parse(second.Text.Replace(".", ","))).ToString("n2");
                        break;
                    case "*":
                        result.Text = (double.Parse(first.Text.Replace(".", ",")) * double.Parse(second.Text.Replace(".", ","))).ToString("n2");
                        break;
                    case "/":
                        result.Text = (double.Parse(first.Text.Replace(".", ",")) / double.Parse(second.Text.Replace(".", ","))).ToString("n2");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
