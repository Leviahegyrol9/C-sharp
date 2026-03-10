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
    /// Interaction logic for Marks.xaml
    /// </summary>
    public partial class Marks : Window
    {
        public static Dictionary<string, List<int>> subjectAndMarks = new Dictionary<string, List<int>>();
        public Marks()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();

            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                List<int> marks = new List<int>();

                if (marksTb.Text.Contains(','))
                {
                    string[] temp = marksTb.Text.Split(',');

                    foreach (string item in temp)
                    {
                        int number = int.Parse(item);

                        if (number > 0 && number < 6) marks.Add(number);
                    }

                    subjectAndMarks[subjectTb.Text] = marks;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
