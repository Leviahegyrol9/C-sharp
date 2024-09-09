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
            Console.Write("Hány órád van hétfőn: ");
            int het = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hány órád van kedden: ");
            int kedd = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hány órád van szerdán: ");
            int szer = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hány órád van csütörtökön: ");
            int csut = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hány órád van pénteken: ");
            int pen = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int hours = het + kedd + szer + csut + pen;
            Console.Write("A héten ennyi órád van: "+ hours);
            Console.ReadLine();
        }
    }
}
