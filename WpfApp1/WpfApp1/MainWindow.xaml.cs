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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            rbgyarto.Checked += Rb_Checked;
            rbalap.Checked += Rb_Checked;
            rbkereskedlmi.Checked += Rb_Checked;

        }

        private void Rb_Checked(object sender, RoutedEventArgs e)
        {           
            foreach (GroupBox groupB in mains.Children.OfType<GroupBox>())
            {
                groupB.Visibility = Visibility.Collapsed;
            }

            GroupBox gB = sender as GroupBox;

            gB.Visibility = Visibility.Visible;


        }

        private void szamitas_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
