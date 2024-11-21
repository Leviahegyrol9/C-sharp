using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Labdarúgó_statisztikák
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            bool isNumber;
            bool isString;

            do
            {
                Console.WriteLine("1 - Új játékos hozzáadása\n2 - Játékos listázása\n3 - Játékos keresése\n4 - Játékos törlése\n5 - Játékos adatainak módosítása\n6 - Extra funkciók (opcionális)");
                Console.Write("Opció: ");
                string input = Console.ReadLine();

                isNumber = int.TryParse(input, out option);

                if (!isNumber)
                {
                    Console.Write("Nem számot adott meg!");
                    Thread.Sleep(2500);
                    Console.Clear();
                }
                else if (option < 1 || option > 6)
                {
                    Console.Write("Nincs ilyen opció!");
                    Thread.Sleep(2500);
                    Console.Clear();
                }

            } while (!isNumber || (option < 1 || option > 6));

            if (option == 1)
            {
                do
                {
                    //játékos nevét, életkorát, góljainak számát, összpontszámát
                    Console.Write("Adja meg a játékos nevét: ");
                    string name = Console.ReadLine();

                    isString = name is string && (name.Length < 3);

                    if(!isString)
                    {
                        Console.Write("Nem nevet adott meg!");
                        Thread.Sleep(2500);
                        Console.Clear();
                        continue;
                    }

                    Console.Write($"Adja meg {name} életkorát: ");
                    string input = Console.ReadLine();

                    isNumber = int.TryParse(input, out int age) && (age < 15 || age > 51);

                    if(!isNumber)
                    {
                        Console.Write("Nem megfelelő életkort adott meg!");
                        Thread.Sleep(2500);
                        Console.Clear();
                        continue;
                    }

                    Console.Write($"Adja meg {name} góljainak számát: ");
                    input = Console.ReadLine();



                } while (!isString || !isNumber);

            }

            Console.ReadKey();
        }
    }
}
