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
        static List<string> ReadFile(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);

            List<string> datas = new List<string>();

            foreach (string line in lines)
            {
                datas.Add(line);
            }

            return datas;
        }
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
                names[i] = char.ToUpper(names[i][0]) + names[i].Substring(1);
            }

            return string.Join(" ", names);
        }

        static int GetOption(string prompt)
        {
            bool isNumber;
            int option;
            do
            {
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

                Console.Clear();

            } while (!isNumber || option < 1 || option > 3);

            return option;
        }

        static string GetName(string prompt)
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

            return Capitalize(name);
        }

        static string OptionToText(int choice)
        {
            switch (choice)
            {
                case 1: 
                    return "Kő";

                case 2: 
                    return "Papír";

                case 3: 
                    return "Olló";

                default:
                    return string.Empty;
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

        static void ShowStatistics(string fileName, string name1, string name2)
        {
            List<string> players = ReadFile(fileName);

            if (!File.Exists(fileName) || players.Count == 0)
            {
                Console.WriteLine("Nincs adat a statisztikához.");
            }
            else
            {
                int player1Wins = 0;
                int player2Wins = 0;
                int draws = 0;

                foreach (string player in players)
                {
                    if (player.Contains($"Győztes: {name1}"))
                    {
                        player1Wins++;
                    }
                    else if (player.Contains($"Győztes: {name2}"))
                    {
                        player2Wins++;
                    }
                    else
                    {
                        draws++;
                    }
                }

                Console.WriteLine("Statisztika:\n");
                Console.WriteLine($"{name1} győzelmei: {player1Wins}");
                Console.WriteLine($"{name2}  győzelmei: {player2Wins}");
                Console.WriteLine($"Döntetlenek: {draws}");

                if(player1Wins == player2Wins)
                {
                    Console.WriteLine("\nDöntetlen!");
                }
                else if (player1Wins > player2Wins)
                {
                    Console.WriteLine($"\nGyőztes: {name1}");
                }
                else
                {
                    Console.WriteLine($"\nGyőztes: {name2}");
                }

                Console.WriteLine("\nNyomjon meg egy gombot a folytatáshoz!");
                Console.ReadKey();
                Console.Clear();
            }         
        }

        static void Main(string[] args)
        {
            int round = 0;
            int maxRounds = 10;

            int points1 = 0;
            int points2 = 0;

            string name1 = GetName("Kérem az első játékos nevét: ");
            string name2 = GetName("Kérem a második játékos nevét: ");

            string fileName = "eredmenyek.txt";

            while (round != maxRounds)
            {
                round++;

                int input1 = GetOption($"Forduló: {round}\n{name1} következik:\n1 - Kő\n2 - Papír\n3 - Olló");
                int input2 = GetOption($"Forduló: {round}\n{name2} következik:\n1 - Kő\n2 - Papír\n3 - Olló");

                string choice1 = OptionToText(input1);
                string choice2 = OptionToText(input2);

                string winner = GetTheResult(input1, input2, points1, points2, name1, name2);

                bool success = SaveResult(fileName, round, name1, choice1, name2, choice2, winner);

                if (!success)
                {
                    Console.Write($"{fileName} állományt nem sikerült frissíteni!");
                    Console.WriteLine("\nNyomjon meg egy gombot a kilépéshez!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                Console.Clear();
            }

            ShowStatistics(fileName, name1, name2);
        }
    }
}
