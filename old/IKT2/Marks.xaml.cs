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
        public static List<Mark> subjectAndMarks = new List<Mark>();
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
                Mark mark = null;
                List<int> marks = new List<int>();

                if (marksTb.Text.Contains(','))
                {
                    string[] temp = marksTb.Text.Replace(" ", "").Split(',');

                    foreach (string item in temp)
                    {
                        int number = int.Parse(item);

                        if (number > 0 && number < 6) marks.Add(number);
                    }

                    mark = new Mark
                    {
                        Subject = subjectTb.Text.ToLower(),
                        Marks = marks
                    };

                    subjectAndMarks.Add(mark);
                }
                else
                {
                    mark = new Mark
                    {
                        Subject = subjectTb.Text.ToLower(),
                        Marks = new List<int> {int.Parse(marksTb.Text)}
                    };

                    subjectAndMarks.Add(mark);
                }

                subjectTb.Clear();
                marksTb.Clear();

                MessageBox.Show("Jegy(ek) hozzáadva!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
