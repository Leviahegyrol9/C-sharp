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
            public override string ToString()
            {
                return $"{Azonosito}\t{Osztaly}\t{Nev}\t{Pontszam}";
            }
        }
        List<Diakok> lista = new List<Diakok>();

        List<Diakok> a_osztaly = new List<Diakok>();
        List<Diakok> b_osztaly = new List<Diakok>();
        List<Diakok> c_osztaly = new List<Diakok>();
        public MainWindow()
        {
            InitializeComponent();
            foreach (var i in File.ReadAllLines("diakok.txt").Skip(1))
            {
                string[] t = i.Split(';');
                lista.Add(new Diakok(t[0], t[1], t[2], int.Parse(t[3])));
            }

            a_osztaly = lista.Where(x =>x.Osztaly == "a").ToList();
            b_osztaly = lista.Where(x =>x.Osztaly == "b").ToList();
            c_osztaly = lista.Where(x =>x.Osztaly == "c").ToList();
        }

        private void beolvas_Click(object sender, RoutedEventArgs e)
        {
            kilenc_a.Items.Clear();
            kilenc_b.Items.Clear();
            kilenc_c.Items.Clear();

            foreach (Diakok i in a_osztaly)
            {
                kilenc_a.Items.Add(i);
            }

            foreach (Diakok i in b_osztaly)
            {
                kilenc_b.Items.Add(i);
            }

            foreach (Diakok i in c_osztaly)
            {
                kilenc_c.Items.Add(i);
            }
        }

        private void rendez_Click(object sender, RoutedEventArgs e)
        {
            if (nevnovekvo.IsChecked == true)
            {
                kilenc_a.Items.Clear();
                kilenc_b.Items.Clear();
                kilenc_c.Items.Clear();
                List<Diakok> nevszerint_a = a_osztaly.OrderBy(x => x.Nev).ToList();
                List<Diakok> nevszerint_b = b_osztaly.OrderBy(x => x.Nev).ToList();
                List<Diakok> nevszerint_c = c_osztaly.OrderBy(x => x.Nev).ToList();

                foreach (Diakok i in nevszerint_a)
                {
                    kilenc_a.Items.Add(i.Nev);
                }

                foreach (Diakok i in nevszerint_b)
                {
                    kilenc_b.Items.Add(i.Nev);
                }

                foreach (Diakok i in nevszerint_c)
                {
                    kilenc_c.Items.Add(i.Nev);
                }
            }
            else if (pontnovekvo.IsChecked == true)
            {
                kilenc_a.Items.Clear();
                kilenc_b.Items.Clear();
                kilenc_c.Items.Clear();
                List<Diakok> pontszam_a = a_osztaly.OrderBy(x => x.Pontszam).ToList();
                List<Diakok> pontszam_b = b_osztaly.OrderBy(x => x.Pontszam).ToList();
                List<Diakok> pontszam_c = c_osztaly.OrderBy(x => x.Pontszam).ToList();

                foreach (Diakok i in pontszam_a)
                {
                    kilenc_a.Items.Add($"{i.Nev} - {i.Pontszam}");
                }

                foreach (Diakok i in pontszam_b)
                {
                    kilenc_b.Items.Add($"{i.Nev} - {i.Pontszam}");
                }

                foreach (Diakok i in pontszam_c)
                {
                    kilenc_c.Items.Add($"{i.Nev} - {i.Pontszam}");
                }
            }
        }
        private void legjobb_Click(object sender, RoutedEventArgs e)
        {
            legjobbak.Items.Clear();
            List<Diakok> pontszam_a = a_osztaly.OrderBy(x => x.Pontszam).ToList();
            List<Diakok> pontszam_b = b_osztaly.OrderBy(x => x.Pontszam).ToList();
            List<Diakok> pontszam_c = c_osztaly.OrderBy(x => x.Pontszam).ToList();

            legjobbak.Items.Add($"{pontszam_a.Last().Nev} - {pontszam_a.Last().Pontszam} - {pontszam_a.Last().Osztaly}");
            legjobbak.Items.Add($"{pontszam_b.Last().Nev} - {pontszam_b.Last().Pontszam} - {pontszam_b.Last().Osztaly}");
            legjobbak.Items.Add($"{pontszam_c.Last().Nev} - {pontszam_c.Last().Pontszam} - {pontszam_c.Last().Osztaly}");
        }

        private void legrosszabb_Click(object sender, RoutedEventArgs e)
        {
            legrosszabbak.Items.Clear();
            List<Diakok> pontszam_a = a_osztaly.OrderByDescending(x => x.Pontszam).ToList();
            List<Diakok> pontszam_b = b_osztaly.OrderByDescending(x => x.Pontszam).ToList();
            List<Diakok> pontszam_c = c_osztaly.OrderByDescending(x => x.Pontszam).ToList();

            legrosszabbak.Items.Add($"{pontszam_a.Last().Nev} - {pontszam_a.Last().Pontszam} - {pontszam_a.Last().Osztaly}");
            legrosszabbak.Items.Add($"{pontszam_b.Last().Nev} - {pontszam_b.Last().Pontszam} - {pontszam_b.Last().Osztaly}");
            legrosszabbak.Items.Add($"{pontszam_c.Last().Nev} - {pontszam_c.Last().Pontszam} - {pontszam_c.Last().Osztaly}");
        }

        private void kilep_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
