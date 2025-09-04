using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New
{
    public partial class Form1 : Form
    {
        const string fileName = "diakadatok.txt";
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();

            students = StudentIO.ReadStudentsFromFile(fileName);
        }

        private void loadDataBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (Student student in students)
            {
                listBox1.Items.Add(student.ToString().Replace(';', ','));
            }
        }

        private void studentsBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<Student> students9a = students.Where(student => student.Class == "9a").ToList();

            foreach (Student student in students9a)
            {
                listBox1.Items.Add(student.Name);
            }
        }

        private void sexRatioBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int man = students.Count(student => student.Sex == "f");
            int woman = students.Count(student => student.Sex == "n");

            listBox1.Items.Add($"Fiúk: {man}");
            listBox1.Items.Add($"Lányok: {woman}");
        }
    }
}
