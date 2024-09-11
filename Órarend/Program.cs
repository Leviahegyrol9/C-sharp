using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Órarend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int counter = 0;

            string[] days = new string[] { "Hétfő", "Kedd", "Szerda", "Csütörtök", "Péntek" };
            string[] timetable = new string[] { };
            string[] lessons = new string[] { "magyar", "matek", "töri", "biosz", "kémia", "infó" };

            Console.Write("Hány órád legyen egy nap: ");
            int lesson = Convert.ToInt32(Console.ReadLine());

            for (counter = 0;counter<lesson;counter++)
            {
                int index = random.Next(0, 6);
                Console.WriteLine($"{counter+1}.{lessons[index]}");
            }
            Console.ReadKey();
        }
    }
}
