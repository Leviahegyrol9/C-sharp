using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskola
{
    public class StudentIO
    {
        public static List<Student> ReadStudentsFromFile(string path)
        {
            List<Student> students = new List<Student>();
            Student student = null;

            try
            {
                using (StreamReader sR = new StreamReader(path))
                {
                    while (!sR.EndOfStream)
                    {
                        string line = sR.ReadLine();
                        string[] datas = line.Split(';');

                        student = new Student
                        {
                            Year = int.Parse(datas[0]),
                            Class_ = datas[1],
                            Name = datas[2]
                        };                      

                        students.Add(student);
                    }                   
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return students;
            
        }
    }
}
