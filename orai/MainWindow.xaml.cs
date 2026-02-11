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

namespace orai
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Wall> walls = new List<Wall>();
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                foreach (string line in File.ReadAllLines("falak.txt"))
                {
                    string[] datas = line.Split(';');

                    Wall wall = new Wall
                    {
                        Id = datas[0],
                        WallT = int.Parse(datas[1]),
                        BaseT = int.Parse(datas[2]),
                        Color = datas[3],
                        Type = datas[4]
                    };

                    walls.Add(wall);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetData(object sender, RoutedEventArgs e)
        {
            list.Items.Clear();

            foreach (Wall wall in walls)
            {
                list.Items.Add(wall);
            }
        }

        private void Statistic(object sender, RoutedEventArgs e)
        {
            list.Items.Clear();

            Dictionary<string, int> dict = walls;
        }

        private void Colors(object sender, RoutedEventArgs e)
        {

        }

        private void BiggestRoom(object sender, RoutedEventArgs e)
        {

        }

        private void Calculate(object sender, RoutedEventArgs e)
        {

        }

        private void Search(object sender, RoutedEventArgs e)
        {

        }
    }
}
