using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New
{
    public class StudentIO
    {
        public static List<Student> ReadStudentsFromFile(string filename)
        {
            Student student = new Student();
            List<Student> students = new List<Student>();

            try
            {
                string[] lines = File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] datas = line.Split(';');

                    student = new Student
                    {
                        Name = datas[0],
                        Sex = datas[1],
                        Class = datas[2]
                    };

                    students.Add(student);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return students;
        }
    }
}