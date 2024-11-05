using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TikTakToe
{
    internal class Program
    {
        static void print(string[,] table)
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {table[0, 0]}  |  {table[0, 1]}  |  {table[0, 2]}");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {table[1, 0]}  |  {table[1, 1]}  |  {table[1, 2]}");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {table[2, 0]}  |  {table[2, 1]}  |  {table[2, 2]}");
            Console.WriteLine("     |     |      ");
        }

        static bool CheckWin(string[,] table)
        {
            for (int i = 0; i < 3; i++)
            {
                if (table[i, 0] != "-" && table[i, 0] == table[i, 1] && table[i, 1] == table[i, 2]) return true;

                if (table[0, i] != "-" && table[0, i] == table[1, i] && table[1, i] == table[2, i]) return true;
            }
            if (table[0, 0] != "-" && table[0, 0] == table[1, 1] && table[1, 1] == table[2, 2]) return true;
            if (table[0, 2] != "-" && table[0, 2] == table[1, 1] && table[1, 1] == table[2, 0]) return true;

            return false;
        }

        static bool IsTie(string[,] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (table[i, j] == "-")
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int col = 0;
            int row = 0;
            bool isNumber = false;
            bool win = false;
            string player = null;
            int playerType = 0;
            Random random = new Random();
            bool repeat;

            string[,] table = new string[3, 3];

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = "-";
                }
            }
            while (playerType == 0 || !isNumber || (playerType < 1 || playerType > 2))
            {
                Console.WriteLine("1 - Player\n2 - Robot\n");
                Console.WriteLine("Kivel szeretne játszani?");

                string input = Console.ReadLine();

                isNumber = int.TryParse(input, out playerType);

                if(!isNumber)
                {
                    Console.Write("Nem számot adott meg!");
                    Thread.Sleep(2500);
                }
                else if (playerType < 1 || playerType > 2)
                {
                    Console.Write("Tartományon kívüli érték!!");
                    Thread.Sleep(2500);
                }
                Console.Clear();
            }


            while (!win)
            {
                repeat = true;

                while (repeat)
                {
                    player = "X";

                    isNumber = false;

                    while (!isNumber || (row > 3 || row < 1))
                    {
                        print(table);
                        Console.WriteLine($"{player} játékos\n");
                        Console.Write("Írja be a sort: ");
                        string input = Console.ReadLine();

                        isNumber = int.TryParse(input, out row);

                        if (!isNumber)
                        {
                            Console.Write("Nem számot adott meg!");
                            Thread.Sleep(2500);
                        }
                        else if (row > 3 || row < 1)
                        {
                            Console.Write("Tartományon kívüli érték!");
                            Thread.Sleep(2500);
                        }
                        Console.Clear();
                    }

                    isNumber = false;

                    while (!isNumber || (col > 3 || col < 1))
                    {
                        print(table);
                        Console.WriteLine($"{player} játékos\n");
                        Console.Write("Írja be az oszlopot: ");
                        string input = Console.ReadLine();

                        isNumber = int.TryParse(input, out col);

                        if (!isNumber)
                        {
                            Console.Write("Nem számot adott meg!");
                            Thread.Sleep(2500);
                            Console.Clear();
                            continue;
                        }
                        else if (col > 3 || col < 1)
                        {
                            Console.Write("Tartományon kívüli érték!");
                            Thread.Sleep(2500);
                            Console.Clear();
                            continue;
                        }
                        if (table[row - 1, col - 1] != "-")
                        {
                            Console.Write("Ez a mező nem üres!");
                            Thread.Sleep(2500);
                            repeat = true;
                        }
                        else
                        {
                            repeat = false;
                            table[row - 1, col - 1] = player;
                            win = CheckWin(table);
                            if (win)
                            {
                                goto End;
                            }
                            if (IsTie(table))
                            {
                                goto Tie;
                            }
                        }
                        Console.Clear();
                    }
                }

                if (playerType == 2)
                {
                    Console.Clear();
                    player = "O";

                    row = random.Next(1, 4);
                    col = random.Next(1, 4);

                    print(table);

                    Console.Write("A robot gondolkodik...");
                    Thread.Sleep(2500);
                    Console.Clear();

                    table[row - 1, col - 1] = player;

                    win = CheckWin(table);
                    if (win)
                    {
                        goto End;
                    }
                    if (IsTie(table))
                    {
                        goto Tie;
                    }
                }

                repeat = true;

                while (playerType == 1 && repeat)
                {
                    player = "O";
                    isNumber = false;

                    while (!isNumber || (row > 3 || row < 1))
                    {
                        print(table);
                        Console.WriteLine($"{player} játékos\n");
                        Console.Write("Írja be a sort: ");
                        string input = Console.ReadLine();

                        isNumber = int.TryParse(input, out row);

                        if (!isNumber)
                        {
                            Console.Write("Nem számot adott meg!");
                            Thread.Sleep(2500);
                        }
                        else if (row > 3 || row < 1)
                        {
                            Console.Write("Tartományon kívüli érték!");
                            Thread.Sleep(2500);
                        }
                        Console.Clear();
                    }

                    isNumber = false;

                    while (!isNumber || (col > 3 || col < 1))
                    {
                        print(table);
                        Console.WriteLine($"{player} játékos\n");
                        Console.Write("Írja be az oszlopot: ");
                        string input = Console.ReadLine();

                        isNumber = int.TryParse(input, out col);

                        if (!isNumber)
                        {
                            Console.Write("Nem számot adott meg!");
                            Thread.Sleep(2500);
                            Console.Clear();
                            continue;
                        }
                        else if (col > 3 || col < 1)
                        {
                            Console.Write("Tartományon kívüli érték!");
                            Thread.Sleep(2500);
                            Console.Clear();
                            continue;
                        }
                        if (table[row - 1, col - 1] != "-")
                        {
                            Console.Write("Ez a mező nem üres!");
                            Thread.Sleep(2500);
                            repeat = true;
                        }
                        else
                        {
                            repeat = false;
                            table[row - 1, col - 1] = player;
                            win = CheckWin(table);
                            if (win)
                            {
                                goto End;
                            }
                            if (IsTie(table))
                            {
                                goto Tie;
                            }
                        }
                        Console.Clear();
                    }   
                }       
            }
        End:
            Console.Clear();
            print(table);
            Console.Write($"\nA(z) {player} játékos nyert!");
            Console.ReadKey();

        Tie:
            Console.Clear();
            print(table);
            Console.Write("Döntetlen!");
            Console.ReadKey();
        }
    }
}
