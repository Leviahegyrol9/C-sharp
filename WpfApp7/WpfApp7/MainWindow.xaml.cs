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

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ujnev.KeyDown += Ujnev_Keydown;
           
        }
        private void Ujnev_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                hozzaad_Click(sender, e);
            }
        }
        private void hozzaad_Click(object sender, RoutedEventArgs e)
        {
            if (ujnev.Text.Length == 0)
            {
                MessageBox.Show("nem adott meg nevet!");
            }
            else if (!lista.Items.Contains(ujnev.Text))
            {
                lista.Items.Add(ujnev.Text);
                ujnev.Text=string.Empty;
                elemszam.Text = lista.Items.Count.ToSting();
            }
            else
            {
                MessageBox.Show("A nev mar szerepel!");
                ujnev.Text = string.Empty;
            }
        }
        private void listaurit_Click(object sender, RoutedEventARgs e)
        {
            var valasz = MessageBox.Show("valoban torolni akarja a lista oosszes elemet?", "torles", MessageBoxButton: YesNo, MessageBoxImage.Question);
            if(valasz==MessageBoxResult.Yes)
            {
                lista.Items.Clear();
            }
        }
        private void rendezes_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.SortDescription.Add(new System.ComponentModel.ShortDescription)
        }
    }

}