using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Xml.Linq;

namespace Function
{
    public class Methods
    {
        public static string Capitalize(string name)
        {
            string[] names = name.Split(' ');

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = char.ToUpper(names[i][0]) + names[i].Substring(1);
            }

            return string.Join(" ", names);
        }

        public static bool WriteFile(string fileName, List<string> content, bool append)
        {
            Random rnd = new Random();

            try
            {
                using (StreamWriter writer = new StreamWriter(fileName, append))
                {
                    int randomnum = rnd.Next(1, 3);

                    List<string> datas = new List<string>();

                    foreach (string line in content)
                    {
                        string[] oneLine = line.Split('\t');
                        string name = oneLine[0];
                        string present = oneLine[randomnum];

                        writer.WriteLine($"{name}\t{present}");
                    }                                      
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void IfSuccess(string fileName, bool success)
        {
            if (success)
            {
                Console.Write($"{fileName} állomány sikeresen létrehozva!");
                Thread.Sleep(2500);
                Console.Clear();
            }
            else
            {
                Console.Write($"{fileName} állományt nem sikerült létrehozni!");
                Console.Write("Nyomjon meg egy gombot a kilépéshez...");
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
                Console.WriteLine(prompt);
                string input = Console.ReadLine();

                isNumber = int.TryParse(input, out number);

                if (!isNumber)
                {
                    Console.Write("Nem számot adott meg!");
                    Thread.Sleep(2500);
                }
                else if (number < min || number > max)
                {
                    Console.Write("Nincs ilyen szám a tartományban!");
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
                Console.WriteLine(prompt);
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

            return name;
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