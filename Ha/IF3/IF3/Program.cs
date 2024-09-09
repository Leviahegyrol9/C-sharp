using System;

namespace IF3
{
    class Program
    {
        static void Main(string[] args)
        {
            int szog1;
            int szog2;
            int szog3;
            Console.WriteLine("Kérem az első belső szöget! ");
            szog1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem a második belső szöget! ");
            szog2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem a harmadik belső szöget! ");
            szog3 = Convert.ToInt32(Console.ReadLine());
            if (szog1 + szog2 + szog3 == 180)
            {
                if ((szog1 == 90) || (szog2 == 90) || (szog3 == 90))
                {
                    Console.WriteLine("A háromszög derékszögű");
                }
        }
    }
}
