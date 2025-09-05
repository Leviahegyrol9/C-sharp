using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanar
{
    public struct Teacher
    {
        public string Name;
        public string Subject;
        public int Age;
        public int Salary;
        public int Experience;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Teacher> teachers = new List<Teacher>();
            Teacher teacher = new Teacher();

            using (StreamReader sR = new StreamReader("tanarok.txt"))
            {
                sR.ReadLine();
                while (!sR.EndOfStream)
                {
                    string line = sR.ReadLine();
                    string[] datas = line.Split(';');

                    teacher.Name = datas[0];
                    teacher.Subject = datas[1];
                    teacher.Age = int.Parse(datas[2]);
                    teacher.Salary = int.Parse(datas[3]);
                    teacher.Experience = int.Parse(datas[4]);

                    teachers.Add(teacher);
                }
            }

            Console.WriteLine($"Tanárok száma: {teachers.Count}");

            Console.WriteLine($"Infó tanárok száma: {teachers.Count(count => count.Subject == "Informatika")}");

            Teacher maxAge = teachers.Single(t => t.Age == teachers.Max(m => m.Age));

            Console.WriteLine($"{maxAge.Name}: {maxAge.Age}");

            double average = teachers.Average(t => t.Salary);

            Console.WriteLine($"Átlag fizetés: {average:n0} Ft");

            int minExp = teachers.Single(t => t.Experience == teachers.Min(m => m.Experience)).Experience;

            Console.WriteLine($"Legevesebb tapasztalat: {minExp}");

        }
    }
}
