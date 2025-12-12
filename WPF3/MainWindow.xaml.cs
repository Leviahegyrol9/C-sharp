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

namespace WPF3
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

        private void okbutton_Click(object sender, RoutedEventArgs e)
        {
            if (inputbox.Text == string.Empty)
            {
                MessageBox.Show("Nem adtál meg bemeneti adatot!", "Figyelmeztetés", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show($"Adat rögzítve: {inputbox.Text}", "Adat", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
