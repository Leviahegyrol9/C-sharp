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

namespace WpfApp2.UserControls
{
    /// <summary>
    /// Interaction logic for Jegyzetiras.xaml
    /// </summary>
    public partial class Jegyzetiras : UserControl
    {
        public static string mentettJegyzet = string.Empty;
        public Jegyzetiras()
        {
            InitializeComponent();
        }

        private void mentes_Click(object sender, RoutedEventArgs e)
        {
            mentettJegyzet = jegyzet.Text;
            File.AppendAllText("jegyzetek.txt", jegyzet.Text + "\n");
            MessageBox.Show("Sikeres mentés!", "Mentés", MessageBoxButton.OK, MessageBoxImage.Information);

        }
    }
}
