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

namespace Grid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            newNum.KeyDown += NewNum_KeyDown;
        }

        private void NewNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                add_Click(sender, e);
            }
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                numberList.Items.Add(double.Parse(newNum.Text.Replace(".", ",")));
                newNum.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                newNum.Text = string.Empty;
            }
        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            if (numberList.Items.Count != 0)
            {
                double sum = 0;

                foreach (double number in numberList.Items)
                {
                    sum += number;
                }

                average.Text = $"{sum / numberList.Items.Count:n2}";
            }
            else
            {
                MessageBox.Show("Nincs elem a listában!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (numberList.Items.Count != 0)
            {
                if (numberList.SelectedItem != null)
                {                  
                    numberList.Items.Remove(numberList.SelectedItem);
                }
                else
                {
                    numberList.Items.Remove(numberList.Items[0]);
                }
                
            }
            else
            {
                MessageBox.Show("Nincs elem a listában!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
