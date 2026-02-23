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
    /// Interaction logic for ujvendeg.xaml
    /// </summary>
    public partial class ujvendeg : Window
    {
        public ujvendeg()
        {
            InitializeComponent();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            try
            {
                string n = a.Text;
                string t = b.Text;
                string etel = c.Text;
                int ossz = int.Parse(d.Text);
                MainWindow.vendegek.Add(new Vendeg(n, t, etel, ossz));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
