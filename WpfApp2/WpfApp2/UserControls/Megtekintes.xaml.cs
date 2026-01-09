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
    /// Interaction logic for Megtekintes.xaml
    /// </summary>
    public partial class Megtekintes : UserControl
    {
        public Megtekintes()
        {
            InitializeComponent();
            //mentettjegyzet.Text = Jegyzetiras.mentettJegyzet;
            if (File.Exists("jegyzetek.txt"))
            {
                mentettjegyzet.Text = File.ReadAllText("jegyzetek.txt");
            }
            else
            {
                mentettjegyzet.Text = "Nincs még mentett jegyzet";
            }
        }
    }
}
