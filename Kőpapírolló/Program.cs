using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Kőpapírolló
{
    internal class Program
    {
        static bool AddPlayer(string fileName, string name, int age, int goals, int games)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName, true))
                {

                    writer.Write($"\n{name};{age};{goals};{games + goals}");

                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        static string Capitalize(string name)
        {
            string[] names = name.Split(' ');

            if (names.Length == 1)
            {
                names[0] = char.ToUpper(names[0][0]) + names[0].Substring(1);
                name = names[0];
            }
            else if (names.Length == 2)
            {
                names[0] = char.ToUpper(names[0][0]) + names[0].Substring(1);
                names[1] = char.ToUpper(names[1][0]) + names[1].Substring(1);
                name = $"{names[0]} {names[1]}";
            }
            else if (names.Length == 3)
            {
                names[0] = char.ToUpper(names[0][0]) + names[0].Substring(1);
                names[1] = char.ToUpper(names[1][0]) + names[1].Substring(1);
                names[2] = char.ToUpper(names[2][0]) + names[2].Substring(1);
                name = $"{names[0]} {names[1]} {names[2]}";
            }

            return name;
        }
        static int GetOption(string prompt)
        {
            bool isNumber;
            int option;
            do
            {
                Console.Clear();

                Console.WriteLine(prompt);
                Console.Write("\nOpció: ");
                string input = Console.ReadLine();

                isNumber = int.TryParse(input, out option);

                if (!isNumber)
                {
                    Console.Write("Nem számot adott meg!");
                    Thread.Sleep(2500);
                }
                else if (option < 1 || option > 3)
                {
                    Console.Write("Nincs ilyen opció!");
                    Thread.Sleep(2500);
                }

            } while (!isNumber || option < 1 || option > 3);

            return option;
        }
        static string GetName(string prompt)
        {
            bool isString;
            string name;

            do
            {
                Console.Clear();

                Console.Write(prompt);
                name = Console.ReadLine().Trim();

                isString = name.Replace(" ", "").All(char.IsLetter);

                if (!isString || name.Length < 3)
                {
                    Console.Write("Nem nevet adott meg!");
                    Thread.Sleep(2500);
                }

            } while (!isString || name.Length < 3);

            return Capitalize(name);
        }
        static void Main(string[] args)
        {
            int counter = 10;

            List<int> option1 = new List<int>();
            List<int> option2 = new List<int>();

            string name1 = GetName("Kérem az első nevet: ");

            string name2 = GetName("Kérem a második nevet: ");

            while (counter != 0)
            {
                counter--;

                option1.Add(GetOption($"{name1} következik:\n1 - Kő\n2 - Papír\n3 - Olló"));

                option2.Add(GetOption($"{name2} következik:\n1 - Kő\n2 - Papír\n3 - Olló"));

            }

            Console.ReadKey();

        }
    }
}
