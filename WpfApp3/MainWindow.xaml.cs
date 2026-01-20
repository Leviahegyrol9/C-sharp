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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        HashSet<int> szamok;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void general_Click(object sender, RoutedEventArgs e)
        {
            RadioButton rB = radioButtons.Children.OfType<RadioButton>().Single(rb => rb.IsChecked == true);
            Lottoszamok(int.Parse(rB.Uid));

            foreach (int i in szamok)
            {
                szamoklista.Items.Add(i);
            }
        }
        private void fajbair_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("lotoo.txt"))
                {
                    foreach (int szam in szamok)
                    {
                        sw.WriteLine(szam);

                        if (szam != szamok.Last()){
                            sw.Write(" ");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void fajlbeolvasas_Click(object sender, RoutedEventArgs e)
        {

        }
        private HashSet<int> Lottoszamok(int id)
        {
            HashSet<int> szamok = new HashSet<int>();

            switch (id)
            {
                case 0:
                    for (int i = 0; i < 5; i++)
                    {
                        szamok.Add(random.Next(1,90));
                    }
                    break;
                case 1:
                    for (int i = 0; i < 6; i++)
                    {
                        szamok.Add(random.Next(1, 45));
                    }
                    break;
                case 2:
                    for (int i = 0; i < 7; i++)
                    {
                        szamok.Add(random.Next(1, 35));
                    }
                    break;
                default:
                    return null;
            }

            return szamok;
        }
    }
}