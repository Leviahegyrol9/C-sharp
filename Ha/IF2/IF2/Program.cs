using System;

namespace IF2
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam1;
            int szam2;
            Console.WriteLine("Kérem az első számot: ");
            szam1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem a második számot: ");
            szam2 = Convert.ToInt32(Console.ReadLine());
            if(szam2 < szam1)
            {
                Console.WriteLine("A kisebb szám: {0}", szam2);
            }
            else if(szam1<szam2)
            {
                Console.WriteLine("A kisebb szám: {0}", szam1);
            }
            else
            {
                Console.WriteLine("A két szám egyenlő!");
            }
        }
    }
}
