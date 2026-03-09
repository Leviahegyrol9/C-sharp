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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            rbFocista.Checked += RbFocista_Checked;
            rbAlap.Checked += RbAlap_Checked;
            rbUszo.Checked += RbUszo_Checked;
        }                                        

        private void RbUszo_Checked(object sender, RoutedEventArgs e)
        {
            gbFocista.Visibility = Visibility.Collapsed;
            gbUszo.Visibility = Visibility.Visible;
        }

        private void RbAlap_Checked(object sender, RoutedEventArgs e)
        {
            gbFocista.Visibility = Visibility.Collapsed;
            gbUszo.Visibility = Visibility.Collapsed;
        }

        private void RbFocista_Checked(object sender, RoutedEventArgs e)
        {
            gbFocista.Visibility = Visibility.Visible;
            gbUszo.Visibility = Visibility.Collapsed;
        }

        private void szamitas_Click(object sender, RoutedEventArgs e)
        {
            string n = tbNev.Text;
            int k = int.Parse(tbKor.Text);
            double edzes = double.Parse(tbEdzes.Text);
            Sportolo sportolo;

            if (rbFocista.IsChecked == true)
            {
                string p = tbPoszt.Text;
                int gol = int.Parse(tbGol.Text);
                sportolo = new Focista(n, k, edzes, p, gol);
            }
        }
    }
}
