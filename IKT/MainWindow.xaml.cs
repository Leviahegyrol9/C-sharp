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

namespace IKT
{
    public partial class MainWindow : Window
    {
        double VAT = 27.0;
        public MainWindow()
        {
            InitializeComponent();

            name.KeyDown += tb_KeyDown;
            netto.KeyDown += tb_KeyDown;
            quantity.KeyDown += tb_KeyDown;
            brutto.KeyDown += tb_KeyDown;
        }
        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                calculate_Click(sender, e);
                add_Click(sender, e);
            }
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (!MainGrid.Children.OfType<TextBox>().Any(tb => tb.Text == string.Empty))
            {
                try
                {
                    productList.Items.Add($"{name.Text}\t{netto.Text}\t{quantity.Text}\t{brutto.Text}");

                    foreach (TextBox tb in MainGrid.Children.OfType<TextBox>()) tb.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Töltsd ki a mezőket!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (productList.Items.Count != 0)
            {
                if (productList.SelectedItem != null)
                {
                    productList.Items.Remove(productList.SelectedItem);
                }
                else
                {
                    productList.Items.Remove(productList.Items[0]);
                }

            }
            else
            {
                MessageBox.Show("Nincs elem a listában!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double result = ((int.Parse(netto.Text)) * ((VAT / 100) + 1)) * int.Parse(quantity.Text);
                brutto.Text = result.ToString("n2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
