using System;
using System.Collections;
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
using System.Windows.Shapes;

namespace Etterem.UserControls
{
    /// <summary>
    /// Interaction logic for etel_stisztika.xaml
    /// </summary>
    public partial class etel_stisztika : Window
    {
        public etel_stisztika()
        {
            InitializeComponent();
            var stat = MainWindow.vendegek.GroupBy(x => x.EtelFajta).ToDictionary(x => x.Key, y => y.Count());

            foreach (var item in stat) lista2.Items.Add($"{item.Key} - {item.Value}");

            vegosszeg.Text = MainWindow.vendegek.Sum(x => x.Osszeg).ToString();
        }
    }
}
