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

namespace IKT2
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        public Search()
        {
            InitializeComponent();

            if (Statistic.sorted.Count == 0) Statistic.GetStatistic();
        }

        private void SearchSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                try
                {
                    list.Items.Clear();
                    var mark = Statistic.sorted.Single(s => s.Key == searchSubject.Text.ToLower());

                    list.Items.Add($"{MainWindow.CapitalizeFirstLetter(mark.Key)}: {string.Join(", ", mark.Value)}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }         
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();

            this.Close();
        }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                list.Items.Clear();
                var mark = Statistic.sorted.Single(s => s.Key == searchSubject.Text.ToLower());

                list.Items.Add($"{MainWindow.CapitalizeFirstLetter(mark.Key)}: {string.Join(", ", mark.Value)}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
