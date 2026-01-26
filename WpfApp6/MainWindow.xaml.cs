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
using System.IO;

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///
    public partial class MainWindow : Window
    {
        public class Kirandulas
        {
            public string Hely {  get; set; }
            public int Ar {  get; set; }

            public Kirandulas(string hely, int ar)
            {
                Hely = hely;
                Ar = ar;
            }
        }
        List<Kirandulas> list = new List<Kirandulas>();
        public MainWindow()
        {
            InitializeComponent();

            foreach (var i in File.ReadAllLines("kirandulas.txt").Skip(1))
            {
                string[] t = i.Split(';');
                list.Add(new Kirandulas(t[0], int.Parse(t[1])));
            }

            foreach (var i in list)
            {
                lista1.Items.Add(i.Hely+":" + i.Ar + " Ft");
            }
        }

        private void hozzaad_Click(object sender, RoutedEventArgs e)
        {
            if (lista1.SelectedItem != null)
            {
                lista2.Items.Add(lista1.SelectedItem);
            }
        }

        private void szamol_Click(object sender, RoutedEventArgs e)
        {            
            try
            {
                int letsz = int.Parse(letszam.Text);
                int veg = 0;

                foreach (var i in lista2.Items)
                {
                    string osszeg = i.ToString().Split(':')[1].Replace("Ft", "");
                    veg += int.Parse(osszeg);
                }
                veg *= letsz;

                vegosszeg.Text = veg.ToString("C0");
            }
            catch
            {
                MessageBox.Show("Nem jó a létszam adat!");
            }
        }
    }
}
