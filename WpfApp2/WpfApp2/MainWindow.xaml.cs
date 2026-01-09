using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp2.UserControls;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tartalom.Content = new Fooldal();
        }

        private void kilepes_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void fooldal_Click(object sender, RoutedEventArgs e)
        {
            tartalom.Content = new Fooldal();
        }

        private void jegyzetiras_Click(object sender, RoutedEventArgs e)
        {
            tartalom.Content = new Jegyzetiras();
        }

        private void megtekintes_Click(object sender, RoutedEventArgs e)
        {
            tartalom.Content = new Megtekintes();
        }

        private void nevjegy_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Készítette: Paplukács Levente","Névjegy", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}