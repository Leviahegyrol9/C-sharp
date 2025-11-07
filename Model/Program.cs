using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Function;
using Model.Model;

namespace Model
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Methods.GetName("Kérem a nevét: ");
            int age = Methods.GetNumber("Kérem az életkorát: ");

            Human human = new Human(name, age);

            Console.WriteLine(human);

            Student student = new Student("Kovács Imre", 18, 4.08, 12);

            Console.WriteLine(student);

            Teacher teacher = new Teacher("Nagy Ilona", 32, 500000, "Matematika");

            Console.WriteLine(teacher);

            Console.WriteLine($"A tanár születési éve: {teacher.Birth()}");
        }
    }
}
