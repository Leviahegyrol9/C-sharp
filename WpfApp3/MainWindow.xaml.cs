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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class Idojaras
    {
        public string Varos {  get; set; }
        public int Homerseklet {  get; set; }
        public int Paratartalom { get; set; }
    }
    public partial class MainWindow : Window
    {
        Idojaras adat = new Idojaras();
        public MainWindow()
        {
            InitializeComponent();
            adat.Varos = "Szeged";
            adat.Homerseklet = 30;
            adat.Paratartalom = 60;
            this.DataContext = adat;
        }

        private void ertekeles_Click(object sender, RoutedEventArgs e)
        {
            double hoerz = adat.Homerseklet + (adat.Paratartalom / 100.0) * 5;
            hoerzet.Text = hoerz.ToString("f1");

            if (hoerz > 30)
            {
                idojaras.Text = "Időjarás: Forró";
            }
            else if (hoerz >= 20)
            {
                idojaras.Text = "Időjarás: Meleg";
            }
            else
            {
                idojaras.Text = "Időjarás: Hűvös";
            }
        }

        private void noveles_Click(object sender, RoutedEventArgs e)
        {
            adat.Homerseklet += 5;
            this.DataContext = null;
            this.DataContext = adat;
        }
    }
}
