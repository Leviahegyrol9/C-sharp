using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kőpapírolló
{
    internal class Program
    {
        static bool SaveResult(string fileName, int round, string name1, string choice1, string name2, string choice2, string winner)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName, true))
                {
                    writer.WriteLine($"Forduló: {round}, {name1} választása: {choice1}, {name2} választása: {choice2}, Győztes: {winner}");
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

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = char.ToUpper(names[i][0]) + names[i].Substring(1).ToLower();
            }

            return string.Join(" ", names);
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

        // A választásokat lefordítja szövegre
        static string GetChoice(int choice)
        {
            switch (choice)
            {
                case 1: 
                    return "kő";

                case 2: 
                    return "papír";

                case 3: 
                    return "olló";

                default:
                    return "";
            }
        }

        static string GetTheResult(int choice1, int choice2, int points1, int points2, string name1, string name2)
        {
            if (choice1 == choice2)
            {
                return "Döntetlen";
            }
            else if ((choice1 == 1 && choice2 == 3) || (choice1 == 2 && choice2 == 1) || (choice1 == 3 && choice2 == 2))
            {
                points1++;
                return name1;
            }
            else
            {
                points2++;
                return name2;
            }
        }

        static void ShowStatistics(string fileName)
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine("Még nem készült fájl a statisztikához.");
                return;
            }

            var lines = File.ReadAllLines(fileName);
            int player1Wins = 0, player2Wins = 0, draws = 0;

            foreach (var line in lines)
            {
                if (line.Contains("Győztes: Játékos 1"))
                {
                    player1Wins++;
                }
                else if (line.Contains("Győztes: Játékos 2"))
                {
                    player2Wins++;
                }
                else
                {
                    draws++;
                }
            }

            Console.WriteLine("Statisztika:");
            Console.WriteLine($"Játékos 1 győzelmei: {player1Wins}");
            Console.WriteLine($"Játékos 2 győzelmei: {player2Wins}");
            Console.WriteLine($"Döntetlenek: {draws}");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int rounds = 0;
            int maxRounds = 10;

            int points1 = 0;
            int points2 = 0;

            string name1 = GetName("Kérem az első játékos nevét: ");
            string name2 = GetName("Kérem a második játékos nevét: ");

            string fileName = "eredmenyek.txt";

            while (rounds != maxRounds)
            {
                rounds++;
                Console.Clear();

                int input1 = GetOption($"{name1} következik:\n1 - Kő\n2 - Papír\n3 - Olló");
                int input2 = GetOption($"{name2} következik:\n1 - Kő\n2 - Papír\n3 - Olló");

                string choice1 = GetChoice(input1);
                string choice2 = GetChoice(input2);

                string winner = GetTheResult(input1, input2, points1, points2, name1, name2);

                bool success = SaveResult(fileName, rounds, name1, choice1, name2, choice2, winner);

                if(success )
                {
                    Console.Write($"{fileName} állomány sikeresen frissítve!");
                }
                else
                {
                    Console.Write($"{fileName} állományt nem sikerült frissíteni!");
                }

                Console.Clear();
                Console.WriteLine($"Forduló: {rounds}");
                Console.WriteLine($"{name1} választása: {choice1}, {name2} választása: {choice2}");
                Console.WriteLine($"Győztes: {winner}");
                Console.WriteLine($"Pontok: {name1} {points1} - {name2} {points2}");
                Thread.Sleep(2000);
            }

            Console.Clear();
            Console.WriteLine("Játék vége!");
            if (points1 > points2)
            {
                Console.WriteLine($"{name1} nyert {points1} - {points2}-re.");
            }
            else if (points2 > points1)
            {
                Console.WriteLine($"{name2} nyert {points2} - {points1}-re.");
            }
            else
            {
                Console.WriteLine("Döntetlen!");
            }

            Console.ReadKey();
        }
    }
}
