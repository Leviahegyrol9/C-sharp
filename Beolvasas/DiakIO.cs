using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beolvasas
{
    public static class DiakIO
    {
        public static List<Student> ReadFile(string path)
        {
            List<Student> students = new List<Student>();

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] datas = line.Split('\t');

                Student diak = new Student
                {
                    Name = datas[0],
                    Average = double.Parse(datas[1])
                };

                students.Add(diak);
            }

            return students;
        }

    }
}
