using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Diakok
        {
            public string Azonosito {  get; set; }
            public string Osztaly { get; set; }
            public string Nev {  get; set; }
            public int Pontszam {  get; set; }

            public Diakok(string azonosito, string osztaly, string nev, int pontszam)
            {
                Azonosito = azonosito;
                Osztaly = osztaly;
                Nev = nev;
                Pontszam = pontszam;
            }
        }
        List<Diakok> lista = new List<Diakok>();
        public MainWindow()
        {
            InitializeComponent();
            foreach (var i in File.ReadAllLines("diakok.txt").Skip(1))
            {
                string[] t = i.Split(';');
                lista.Add(new Diakok(t[0], t[1], t[2], int.Parse(t[3])));
            }
        }

        private void beolvas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void legjobb_Click(object sender, RoutedEventArgs e)
        {

        }

        private void rendez_Click(object sender, RoutedEventArgs e)
        {

        }

        private void legrosszabb_Click(object sender, RoutedEventArgs e)
        {

        }

        private void kilep_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
