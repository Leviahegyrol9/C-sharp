using System;
using System.Collections;
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
using WpfApp1;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Konyvek> list = new List<Konyvek>();
        public MainWindow()
        {
            InitializeComponent();
            foreach (var i in File.ReadAllLines("konyvek.txt"))
            {
                list.Add(new Konyvek(i));
            }
        }

        private void legdragabb_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            var maxra = list.OrderBy(x => x.ar).Last();
            lista.Items.Add($"{maxra.veznev}\t{maxra.kernev}\t{maxra.konyvcim}");
        }

        private void termtud_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            var teremtud = list.Where(x => x.tema == "természerttudomány");
        }

        private void osszeg_Click(object sender, RoutedEventArgs e)
        {

        }

        private void konyvstat_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            var stat = list.GroupBy(x => x.kiadaseve).ToDictionary(x => x.Key, y => y.Count());
            foreach (var i in stat)
            {
                lista.Items.Add(i.Key + " - " + i.Value);
            }
        }

        private void maxhon_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            var maxh = list.OrderBy(x => x.honorarium).Last();
            lista.Items.Add(maxh.veznev + '\t' + maxh.kernev + '\t' + maxh.konyvcim);
        }

        private void betoltes_Click(object sender, RoutedEventArgs e)
        {
            foreach (var i in list)
            {
                lista.Items.Add(i.veznev + '\t' + i.kernev + '\t' + i.konyvcim);
            }
            lista.Items.Add("Konyvek szama: " + list.Count);
        }
    }
}
