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

namespace WpfApp9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Allatok
        {
            public string Nev {  get; set; }
            public int Eletkor {  get; set; }
            public double Suly {  get; set; }
            public string Fajta {  get; set; }
            public Allatok(string nev, int eletkor, double suly, string fajta)
            {
                Nev = nev;
                Eletkor = eletkor;
                Suly = suly;
                Fajta = fajta;
            }

            public override string ToString()
            {
                return $"{Nev} {Eletkor} éves {Suly} kg {Fajta} fajta";
            }
        }

        List<Allatok> allatok = new List<Allatok>();
        public MainWindow()
        {
            InitializeComponent();

            foreach(string sor in File.ReadAllLines("allatok.txt").Skip(1))
            {
                string[] adatok = sor.Split(';');
                allatok.Add(new Allatok(adatok[0], int.Parse(adatok[1]), double.Parse(adatok[2]), adatok[3]));
            }

            foreach (Allatok allat in allatok)
            {
                lista.Items.Add(allat);
            }
        }

        private void clearClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult valasz = MessageBox.Show("Törölni szeretné?", "Törlés", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (valasz == MessageBoxResult.Yes)
            {
                lista.Items.Clear();
            }
        }

        private void addClick(object sender, RoutedEventArgs e)
        {
            if (tb.Children.OfType<TextBox>().Any(tB => tB.Text != string.Empty))
            {
                try
                {
                    allatok.Add(new Allatok(ujnev.Text, int.Parse(ujev.Text), double.Parse(ujsuly.Text), ujfajta.Text));
                    lista.Items.Add($"{ujnev.Text} {ujev.Text} éves {ujsuly.Text} kb {ujfajta.Text} fajta");
                    foreach (TextBox tB in tb.Children.OfType<TextBox>()) tB.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba");
                    foreach (TextBox tB in tb.Children.OfType<TextBox>()) tB.Clear();
                }          
            }
            else
            {
                MessageBox.Show("Minden mezőt töltsön ki!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void averageClick(object sender, RoutedEventArgs e)
        {
            atlagoskor.Text = allatok.Average(a => a.Eletkor).ToString("n2");
            atlagsuly.Text = allatok.Average(a => a.Suly).ToString("n2");
        }

        private void countClick(object sender, RoutedEventArgs e)
        {
            letszam.Text = allatok.Count().ToString();
        }
    }
}
