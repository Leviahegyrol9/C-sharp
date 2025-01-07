using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string time1 = "20:50:00";
            string time2 = "21:30:00";

            // Konvertáljuk az időket DateTime formátumba
            DateTime date1 = DateTime.ParseExact(time1, "HH:mm:ss", null);
            DateTime date2 = DateTime.ParseExact(time2, "HH:mm:ss", null);

            // Időeltérés kiszámítása
            TimeSpan difference = date2 - date1;

            // Az eltelt órák és percek
            Console.WriteLine($"Eltelt idő: {difference.Hours} óra és {difference.Minutes} perc.");
            Console.ReadKey();
        }
    }
}
