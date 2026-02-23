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
using System.Windows.Shapes;

namespace Etterem.UserControls
{
    /// <summary>
    /// Interaction logic for Statisztika.xaml
    /// </summary>
    public partial class Statisztika : Window
    {
        public Statisztika()
        {
            InitializeComponent();

            Dictionary<string, int> stat = MainWindow.vendegek.GroupBy(x => x.Tipus).ToDictionary(x => x.Key, y => y.Count());

            foreach (var item in stat) lista.Items.Add($"{item.Key} - {item.Value}");
        }
    }
}
