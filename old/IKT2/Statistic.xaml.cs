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
    /// Interaction logic for Statistic.xaml
    /// </summary>
    public partial class Statistic : Window
    {
        public static Dictionary<string, List<int>> sorted = new Dictionary<string, List<int>>();
        public Statistic()
        {
            InitializeComponent();
            ShowStatistics();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();

            this.Close();
        }
        public static void GetStatistic()
        {
            HashSet<string> subjects = Marks.subjectAndMarks.Select(s => s.Subject).ToHashSet();

            foreach (string subject in subjects)
            {
                sorted[subject] = new List<int>();
            }

            foreach (Mark mark in Marks.subjectAndMarks)
            {
                sorted[mark.Subject].AddRange(mark.Marks);
            }
        }

        private void ShowStatistics()
        {
            GetStatistic();

            foreach (var item in sorted)
            {
                item.Value.Sort();
                list.Items.Add($"{MainWindow.CapitalizeFirstLetter(item.Key)}: {string.Join(", ", item.Value)}\nÁtlag: {item.Value.Average():n2}");
            }
        }
    }
}
