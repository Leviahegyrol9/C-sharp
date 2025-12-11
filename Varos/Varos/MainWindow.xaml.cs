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

namespace Varos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lista.SelectedIndex = 0;
        }

        private void hozzaad_Click(object sender, RoutedEventArgs e)
        {
            if (ujvaros.Text.Length > 0)
            {
                for (int i = 0; i< lista.Items.Count; i++)
                {
                    if (lista.Items.Contains(ujvaros.Text))
                    {
                        MessageBox.Show("Ez a város már létezik!", "Hiba");
                        
                    }
                    else
                    {
                        lista.Items.Add(ujvaros.Text);
                        ujvaros.Text = string.Empty;
                    }
                }               
            }
            else
            {
                MessageBox.Show("Nincs meg adva városnév!", "Hiba");
            }
        }

        private void torles_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.RemoveAt(lista.SelectedIndex);
            lista.SelectedIndex = 0;
        }
    }
}
