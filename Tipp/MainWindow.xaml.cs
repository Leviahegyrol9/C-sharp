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

namespace Tipp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    TextBox tB = new TextBox();
                    tB.Width = 50;
                    tB.Height = 30;
                    tB.Margin = new Thickness(5);
                    Grid.SetRow(tB, row);
                    Grid.SetColumn(tB, col);
                    myGrid.Children.Add(tB);
                }
            }
        }

        private void kereses_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            bool szerepel = false;

            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    int szam = rnd.Next(1, 50);
                    TextBox tB = new TextBox();
                    tB.Width = 50;
                    tB.Height = 30;
                    tB.Margin = new Thickness(5);
                    tB.Text = szam.ToString();
                    HorizontalAlignment = HorizontalAlignment.Center;
                    VerticalAlignment = VerticalAlignment.Center;

                    if (tB.Text == tipp.Text)
                    {
                        tB.Foreground = new SolidColorBrush(Colors.Red);
                        tB.BorderBrush = new SolidColorBrush(Colors.Red);
                        tB.BorderThickness = new Thickness(5);
                        szerepel = true;
                    }

                    Grid.SetRow(tB, row);
                    Grid.SetColumn(tB, col);
                    myGrid.Children.Add(tB);
                }              
            }

            if (!szerepel)
            {
                MessageBox.Show("Nincs találat!");
            }
        }
    }
}
