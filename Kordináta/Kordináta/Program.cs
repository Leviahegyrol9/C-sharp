using System;

namespace Kordináta
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1;
            double x2;
            double y1;
            double y2;

            Console.WriteLine("Adja meg az x1 értéket!");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Adja meg az x2 értéket!");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Adja meg az y1 értéket!");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Adja meg az y2 értéket!");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A két kordináta közötti távolság: {0}", Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y2 - y1, 2)));
            Console.ReadKey();
        }
    }
}
