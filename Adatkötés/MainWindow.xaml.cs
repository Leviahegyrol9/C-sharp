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

namespace Orai
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string fileName = "student.txt";
        List<Student> students = new List<Student>();
        int index = 0;
        public MainWindow()
        {
            InitializeComponent();

            Student student = null;

            foreach (string line in File.ReadAllLines(fileName))
            {
                string[] datas = line.Split('\t');

                student = new Student
                {
                    FirstName = datas[0],
                    LastName = datas[1],
                    Class = int.Parse(datas[2])
                };

                students.Add(student);
            }

            this.DataContext = students[index];
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            index++;

            if (index == students.Count)
            {
                index = 0;
            }

            this.DataContext = students[index];
        }
    }
}
