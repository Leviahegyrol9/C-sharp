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
using Etterem.UserControls;

namespace Etterem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class Vendeg
    {
        public string Nev { get; set; }
        public string Tipus { get; set; }
        public string EtelFajta { get; set; }
        public int Osszeg { get; set; }
        public Vendeg(string nev, string tipus, string etelFajta, int osszeg)
        {
            Nev = nev;
            Tipus = tipus;
            EtelFajta = etelFajta;
            Osszeg = osszeg;
        }
    }
    public partial class MainWindow : Window
    {
        public static List<Vendeg> vendegek = new List<Vendeg>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void kilepes_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ujvendeg_Click(object sender, RoutedEventArgs e)
        {
            tartalom.Content = new ujvendeg();
        }

        private void stat_Click(object sender, RoutedEventArgs e)
        {
            tartalom.Content = new Statisztika();
        }

        private void statbev_Click(object sender, RoutedEventArgs e)
        {
            tartalom.Content = new etel_stisztika();
        }
    }
}