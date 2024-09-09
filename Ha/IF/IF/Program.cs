using System;

namespace IF
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam;
            Console.WriteLine("Kérem a vizsgálandó számot:");
            szam = Convert.ToInt32(Console.ReadLine());
            if (szam > 0)
            {
                Console.WriteLine("A szám pozitív!");
            }
            else
            {
                Console.WriteLine("A szám negatív!");
            }
;        }
    }
}
