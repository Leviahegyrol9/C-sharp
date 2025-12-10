using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void order_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Content",ListSortDirection.Ascending));
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (newName.Text != string.Empty)
            {
                ListBoxItem item = new ListBoxItem();
                item.Content = newName.Text;
                listBox.Items.Add(item);
                listBox.Items.Refresh();
                newName.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Nincs név megadva!","Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
