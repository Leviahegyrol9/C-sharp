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

namespace Nobel_díj
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Nobel> nobelek = new List<Nobel>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void statisztika_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<int, int> statisztika = nobelek.GroupBy(x => x.evszam).ToDictionary(x => x.Key, y => y.Count());
            lista.Items.Clear();

            foreach (var item in statisztika)
            {
                lista.Items.Add($"{item.Key} - {item.Value}db");
            }
        }

        private void betoltes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Nobel nobel = null;

                foreach(string line in File.ReadAllLines("nobel.csv").Skip(1))
                {
                    string[] adatok = line.Split(';');

                    if (adatok[3] == string.Empty)
                    {
                        nobel = new Nobel
                        {
                            evszam = int.Parse(adatok[0]),
                            tipus = adatok[1],
                            keresztnev = adatok[2],
                            vezeteknev = string.Empty
                        };
                    }
                    else
                    {
                        nobel = new Nobel
                        {
                            evszam = int.Parse(adatok[0]),
                            tipus = adatok[1],
                            keresztnev = adatok[2],
                            vezeteknev = adatok[3]
                        };
                    }
                   
                    nobelek.Add(nobel);
                }

                foreach (Nobel i in nobelek)
                {
                    lista.Items.Add(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void szervezetek_Click(object sender, RoutedEventArgs e)
        {
            List<string> bekenobel = nobelek.Where(x => x.tipus == "béke" && x.vezeteknev == string.Empty).Select(x => x.keresztnev).ToList();
            lista.Items.Clear();

            foreach (string i in bekenobel)
            {
                lista.Items.Add(i);
            }
        }

        private void statisztika2_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<string, int> statisztika = nobelek.GroupBy(x => x.tipus).ToDictionary(x => x.Key, y => y.Count());
            lista.Items.Clear();

            foreach (var item in statisztika)
            {
                lista.Items.Add($"{item.Key} - {item.Value}db");
            }
        }

        private void orvosi_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (StreamWriter sW = new StreamWriter("orvosi.txt"))
                {
                    foreach (Nobel nobel in nobelek.Where(x => x.tipus == "orvosi"))
                    {
                        sW.WriteLine($"{nobel.evszam}: {nobel.keresztnev} {nobel.vezeteknev}");
                        MessageBox.Show("Sikeres fájlbaírás");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hiba");
            }
            
        }

        private void elsok_Click(object sender, RoutedEventArgs e)
        {
            var statisztika = nobelek.GroupBy(x => x.tipus).ToDictionary(x => x.Key, y => y.Last());
            lista.Items.Clear();

            foreach (var item in statisztika)
            {
                lista.Items.Add($"{item.Value.evszam} - {item.Key} - {item.Value.vezeteknev} - {item.Value.keresztnev}");
            }
        }

        private void kereses_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            if (keres.Text == string.Empty)
            {
                MessageBox.Show("Nem adott meg keresési feltételt!");
            }

            bool letezo = false;
            string[] ker = keres.Text.Split(' ');

            foreach (var i in nobelek)
            {
                if (i.vezeteknev == ker[0] && i.vezeteknev == ker[1])
                {
                    letezo = true;
                    lista.Items.Add($"{i.evszam} - {i.tipus}");
                }
            }

            if (!letezo)
            {
                MessageBox.Show("Nincs ilyen nevű Nobel díj!");
            }
        }
    }
}
