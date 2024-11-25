using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Labdarúgó_statisztikák
{
    internal class Program
    {
        static bool EditPlayer(string fileName , string name, List<string> players)
        {
            bool playerFound = IsPlayerInFile(name, players);
            bool isNumber;
            int goals;
            int games;
            int age;
            string playerName;

            if (!playerFound)
            {
                return false;
            }

            for (int i = 1; i < players.Count(); i++)
            {
                string[] datas = players[i].Split(';');

                if (datas[0].ToLower() == name.ToLower())
                {
                    playerName = datas[0];
                    age = int.Parse(datas[1]);

                    do
                    {
                        Console.Write($"Adja meg {playerName} góljainak számát: ");
                        string input = Console.ReadLine();

                        isNumber = int.TryParse(input, out goals);

                        if (!isNumber)
                        {
                            Console.Write("Nem számot adott meg!");
                            Thread.Sleep(2500);
                            Console.Clear();
                        }

                    } while (!isNumber);

                    do
                    {
                        Console.Write("Kérem a csapatnál játszott mérkőzések számait: ");
                        string input = Console.ReadLine();

                        isNumber = int.TryParse(input, out games);

                        if (!isNumber)
                        {
                            Console.Write("Nem számot adott meg!");
                            Thread.Sleep(2500);
                            Console.Clear();
                        }

                    } while (!isNumber);

                    DeletePlayer(fileName, name, players);

                    return AddPlayer(fileName, playerName, age, goals, games);
                }
            }

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                for (int i = 0; i < players.Count(); i++)
                {
                    if (i == players.Count() - 1)
                    {
                        writer.Write(players[i]);
                    }
                    else
                    {
                        writer.WriteLine(players[i]);
                    }
                }
            }

            return true;
        }
        static bool IsPlayerInFile(string name, List<string> players)
        {
            foreach (string player in players)
            {
                string[] datas = player.Split(';');

                if (datas[0].ToLower() == name.ToLower()) return true;
            }

            return false;
        }
        static bool DeletePlayer(string fileName, string name, List<string> players)
        {          
            bool playerFound = IsPlayerInFile(name, players);

            if (!playerFound)
            {
                return false;
            }

            for (int i = 1; i < players.Count(); i++)
            {
                string[] datas = players[i].Split(';');

                if (datas[0].ToLower() == name.ToLower())
                {
                    players.RemoveAt(i);
                    break;
                }
            }

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                for (int i = 0; i < players.Count(); i++)
                {
                    if (i == players.Count() - 1)
                    {
                        writer.Write(players[i]);
                    }
                    else
                    {
                        writer.WriteLine(players[i]);
                    }
                }
            }

            return true;            
        }

        static string SearchPlayer(string name, List<string> players)
        {
            foreach (string line in players.Skip(1))
            {
                string[] datas = line.Split(';');

                if (datas[0].ToLower().Contains(name.ToLower())) return line;
            }
            return null;
        }
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
        static bool AddPlayer(string fileName,string name, int age, int goals, int games)
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
        static (string, int, int, int) GetPlayerData(List<string> players)
        {
            bool isNumber;
            bool isString;
            bool playerFound;

            string name = string.Empty;
            int goals = 0;
            int age = 0;
            int games = 0;

            do
            {
                Console.Write("Adja meg a játékos nevét: ");
                name = Console.ReadLine().Trim();

                playerFound = IsPlayerInFile(name, players);

                isString = name.Replace(" ", "").All(char.IsLetter);

                if (!isString || (name.Length < 3))
                {
                    Console.Write("Nem nevet adott meg!");
                    Thread.Sleep(2500);
                    Console.Clear();
                }
                else if (playerFound)
                {
                    Console.Write("Ilyen nevű játékos már van!");
                    Thread.Sleep(2500);
                    Console.Clear();
                }
                else
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
                }

            } while (!isString || (name.Length < 3) || playerFound);

            do
            {
                Console.Write($"Adja meg {name} életkorát: ");
                string input = Console.ReadLine();

                isNumber = int.TryParse(input, out age);

                if (!isNumber || (age < 15 || age > 51))
                {
                    Console.Write("Nem megfelelő életkort adott meg!");
                    Thread.Sleep(2500);
                    Console.Clear();
                }

            } while (!isNumber || (age < 15 || age > 51));

            do
            {
                Console.Write($"Adja meg {name} góljainak számát: ");
                string input = Console.ReadLine();

                isNumber = int.TryParse(input, out goals);

                if (!isNumber || goals < 0)
                {
                    Console.Write("Nem számot adott meg!");
                    Thread.Sleep(2500);
                    Console.Clear();
                }

            } while (!isNumber || goals < 0);

            do
            {
                Console.Write("Kérem a csapatnál játszott mérkőzések számait: ");
                string input = Console.ReadLine();

                isNumber = int.TryParse(input, out games);

                if (!isNumber || games < 0)
                {
                    Console.Write("Nem számot adott meg!");
                    Thread.Sleep(2500);
                    Console.Clear();
                }

            } while(!isNumber || games < 0);
                

            return (name, age, goals, games);
        }
        static void Main(string[] args)
        {
            int option;
            string fileName = "jatekosok.csv";

            while (true)
            {
                bool isNumber;
                do
                {
                    Console.Clear();
                    Console.WriteLine("1 - Új játékos hozzáadása\n2 - Játékos listázása\n3 - Játékos keresése\n4 - Játékos törlése\n5 - Játékos adatainak módosítása\n6 - Játékosok rendezése\n7 - Kilépés");
                    Console.Write("Opció: ");
                    string input = Console.ReadLine();

                    isNumber = int.TryParse(input, out option);

                    if (!isNumber)
                    {
                        Console.Write("Nem számot adott meg!");
                        Thread.Sleep(2500);
                    }
                    else if (option < 1 || option > 7)
                    {
                        Console.Write("Nincs ilyen opció!");
                        Thread.Sleep(2500);
                    }

                } while (!isNumber || (option < 1 || option > 7));

                Console.Clear();

                switch (option)
                {
                    case 1:
                        var (name, age, goals, games) = GetPlayerData(ReadFile(fileName));

                        bool success = AddPlayer(fileName, name, age, goals, games);

                        if (success)
                        {
                            Console.WriteLine($"{fileName} állomány sikeresen frissítve!");
                        }
                        else
                        {
                            Console.WriteLine($"{fileName} állományt nem sikerült frissíteni!");
                        }

                        Thread.Sleep(2500);
                        break;

                    case 2:
                        List<string> players = ReadFile(fileName);

                        if (players.Count() == 1)
                        {
                            Console.Write("Egy játékos sincs a rendszerben!");
                            Thread.Sleep(2500);
                        }
                        else
                        {
                            foreach (string lines in players)
                            {
                                Console.WriteLine(lines);
                            }
                            Console.Write("\nNyomjon meg egy gombot a folytatáshoz!");
                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        bool isString;
                        string searchName = string.Empty;
                        do
                        {
                            Console.Write("Adja meg a keresendő játékos nevét: ");
                            searchName = Console.ReadLine().Trim();

                            isString = searchName.Replace(" ", "").All(char.IsLetter);

                            if (!isString || (searchName.Length < 3))
                            {
                                Console.Write("Nem nevet adott meg!");
                                Thread.Sleep(2500);
                                Console.Clear();
                            }

                        } while (!isString || (searchName.Length < 3));

                        string playerName = SearchPlayer(searchName, ReadFile(fileName));
                        
                        if (playerName == null)
                        {
                            Console.Write("Nincs ilyen játékos!");
                            Thread.Sleep(2500);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(playerName);
                            Console.Write("\nNyomjon meg egy gombot a folytatáshoz!");
                            Console.ReadKey();
                        }
                        break;

                    case 4:
                        string delName = string.Empty;
                        do
                        {
                            Console.Write("Adja meg a kitörölni kívánt játékos nevét: ");
                            delName = Console.ReadLine().Trim();

                            isString = delName.Replace(" ", "").All(char.IsLetter);

                            if (!isString || (delName.Length < 3))
                            {
                                Console.Write("Nem nevet adott meg!");
                                Thread.Sleep(2500);
                                Console.Clear();
                            }

                        } while (!isString || (delName.Length < 3));

                        success = DeletePlayer(fileName ,delName, ReadFile(fileName));

                        if (success)
                        {
                            Console.WriteLine("A játékos sikeresen törölve lett.");
                            Thread.Sleep(2500);
                        }
                        else
                        {
                            Console.WriteLine("A játékos nem található.");
                            Thread.Sleep(2500);
                        }

                        break;

                    case 5:
                        string editName = string.Empty;
                        do
                        {
                            Console.Write("Adja meg a módosítani kívánt játékos nevét: ");
                            editName = Console.ReadLine().Trim();

                            isString = editName.Replace(" ", "").All(char.IsLetter);

                            if (!isString || (editName.Length < 3))
                            {
                                Console.Write("Nem nevet adott meg!");
                                Thread.Sleep(2500);
                                Console.Clear();
                            }

                        } while (!isString || (editName.Length < 3));

                        success = EditPlayer(fileName ,editName, ReadFile(fileName));

                        if (success)
                        {
                            Console.WriteLine("A játékos sikeresen frissítve lett.");
                            Thread.Sleep(2500);
                        }
                        else
                        {
                            Console.WriteLine("A játékos nem található.");
                            Thread.Sleep(2500);
                        }

                        break;

                    case 6:
                        int by;

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("1 - Rendezés életkor alapján\n2 - Rendezés gólok alapján");
                            Console.Write("Opció: ");
                            string input = Console.ReadLine();

                            isNumber = int.TryParse(input, out by);

                            if (!isNumber)
                            {
                                Console.Write("Nem számot adott meg!");
                                Thread.Sleep(2500);
                            }
                            else if (by < 1 || by > 2)
                            {
                                Console.Write("Nincs ilyen opció!");
                                Thread.Sleep(2500);
                            }

                        } while (!isNumber || (by < 1 || by > 2));

                        players = ReadFile(fileName);


                        if (players.Count() == 1)
                        {
                            Console.Write("Egy játékos sincs a rendszerben!");
                            Thread.Sleep(2500);
                        }
                        else if (players.Count() == 2)
                        {
                            
                        }
                        else if (players.Count() != 2 && by == 1)
                        {
                            string temp = string.Empty;

                            for (int i = 1; i < players.Count; i++)
                            {
                                for (int j = i + 1; j < players.Count; j++)
                                {
                                    string[] datasI = players[i].Split(';');
                                    string[] datasJ = players[j].Split(';');

                                    if (int.Parse(datasI[1]) > int.Parse(datasJ[1]))
                                    {
                                        temp = players[j];
                                        players[j] = players[i];
                                        players[i] = temp;
                                    }

                                }
                            }
                        }
                        else if (players.Count() != 2 && by == 2)
                        {
                            string temp = string.Empty;

                            for (int i = 1; i < players.Count; i++)
                            {
                                for (int j = i + 1; j < players.Count; j++)
                                {
                                    string[] datasI = players[i].Split(';');
                                    string[] datasJ = players[j].Split(';');

                                    if (int.Parse(datasI[2]) > int.Parse(datasJ[2]))
                                    {
                                        temp = players[j];
                                        players[j] = players[i];
                                        players[i] = temp;
                                    }

                                }
                            }
                        }
                        Console.Clear();

                        foreach (string player in players)
                        {
                            Console.WriteLine(player);
                        }

                        Console.Write("\nNyomjon meg egy gombot a folytatáshoz!");
                        Console.ReadKey();

                        break;

                    case 7:
                        Console.Write("Kilépés...");
                        Thread.Sleep(2500);
                        Environment.Exit(0); 
                        break;
                }           

            }
        }
    }
}