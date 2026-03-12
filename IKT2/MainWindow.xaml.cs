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

namespace IKT2
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

        private void ShowCreator(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Készítette: Paplukács Levente 12.b", "Készítő", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Quit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void AddMark(object sender, RoutedEventArgs e)
        {
            new Marks().Show();

            this.Close();
        }

        private void ShowStatistic(object sender, RoutedEventArgs e)
        {
            new Statistic().Show();

            this.Close();
        }

        private void SearchSubject(object sender, RoutedEventArgs e)
        {
            new Search().Show();

            this.Close();
        }
        public static string CapitalizeFirstLetter(string text)
        {
            return char.ToUpper(text[0]) + text.Substring(1);
        }
    }
}
