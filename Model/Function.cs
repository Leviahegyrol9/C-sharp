using System;
using System.Linq;
using System.Threading;

namespace Function
{
    public class Methods
    {
        public static string CapitalizeName(string name)
        {
            string[] names = name.ToLower().Split(' ');

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = char.ToUpper(names[i][0]) + names[i].Substring(1);
            }

            return string.Join(" ", names);
        }

        public static string CapitalizeFirstLetter(string text)
        {
            return char.ToUpper(text[0]) + text.Substring(1);
        }
        public static void CheckSuccess(string fileName, bool success)
        {
            if (success)
            {
                Console.WriteLine($"{fileName} állomány sikeresen létrehozva!");
                Thread.Sleep(2500);
            }
            else
            {
                Console.WriteLine($"{fileName} állományt nem sikerült létrehozni!");
                Console.ReadKey();
                Environment.Exit(0);

            }
        }

        public static int GetNumberWithCondition(string prompt, int min, int max)
        {
            bool isNumber;
            int number;

            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                isNumber = int.TryParse(input, out number);

                if (!isNumber)
                {
                    Console.Write("Nem számot adott meg!");
                    Thread.Sleep(2500);
                }
                else if (number < min || number > max)
                {
                    Console.Write("Nincs ilyen opció!");
                    Thread.Sleep(2500);
                }

                Console.Clear();

            } while (!isNumber || number < min || number > max);

            return number;
        }

        public static int GetNumber(string prompt)
        {
            bool isNumber;
            int number;

            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                isNumber = int.TryParse(input, out number);

                if (!isNumber)
                {
                    Console.Write("Nem számot adott meg!");
                    Thread.Sleep(2500);
                }

                Console.Clear();

            } while (!isNumber);

            return number;
        }

        public static string GetName(string prompt)
        {
            bool isString;
            string name;

            do
            {
                Console.Write(prompt);
                name = Console.ReadLine().Trim();

                isString = name.Replace(" ", "").All(char.IsLetter);

                if (!isString || name.Length < 3)
                {
                    Console.Write("Nem nevet adott meg!");
                    Thread.Sleep(2500);
                }

                Console.Clear();

            } while (!isString || name.Length < 3);

            return CapitalizeName(name);
        }

        public static string GetString(string prompt)
        {
            bool isString;
            string text;

            do
            {
                Console.Write(prompt);
                text = Console.ReadLine().Trim();

                isString = text.Replace(" ", "").All(char.IsLetter);

                if (!isString)
                {
                    Console.Write("Nem betűt adott meg!");
                    Thread.Sleep(2500);
                }

                Console.Clear();

            } while (!isString);

            return text;
        }
    }
}
