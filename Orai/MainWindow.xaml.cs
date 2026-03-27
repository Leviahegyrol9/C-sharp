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

namespace Orai
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Racer
        {
            public int Km { get; set; }
            public int Minute { get; set; }

            public Racer(int km, int minute)
            {
                Km = km;
                Minute = minute;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new Racer(3,30);
        }

        private void kiertekeles_Click(object sender, RoutedEventArgs e)
        {
            double speed = int.Parse(kmTb.Text) / (int.Parse(timeTb.Text) * 60);
            avgSpeed.Content = $"Átlagsebesség: {speed:n1} km/h";

            if (speed > 12) info.Content = $"Teljesítmény: Versenyző szint";
            else if (8 <= speed && speed >= 12) info.Content = $"Teljesítmény: Haladó szint";
            else info.Content = $"Teljesítmény: Kezdő szint";
        }

        private void csokkentes_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(kmTb.Text) - 2 >= 0)
            {
                Racer racer = new Racer(int.Parse(kmTb.Text), int.Parse(timeTb.Text));
                racer.Km -= 2;
                this.DataContext = racer;
            }
        }
    }
}
