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
        static void print(int[,] table)
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
        static void Main(string[] args)
        {
            int col = 0;
            int row = 0;
            bool isNumber;
            bool win = false;
            int? coin = 1;
            bool repeat = true;

            int[,] table = new int[3, 3];

            while (!win)
            {
                while (coin == 1)
                {
                    isNumber = false;

                    while (repeat)
                    {
                        while (!isNumber || (row > 3 || row < 1))
                        {
                            print(table);
                            Console.WriteLine($"{coin}. játékos\n");
                            Console.Write("Írja be a sort: ");
                            string input = Console.ReadLine();

                            isNumber = int.TryParse(input, out row);

                            if (!isNumber)
                            {
                                Console.Write("Nem számot adott meg!");
                                Thread.Sleep(2500);
                            }
                            else if (isNumber && (row > 3 || row < 1))
                            {
                                Console.Write("Tartományon kívüli érték!");
                                Thread.Sleep(2500);
                                Console.Clear();
                            }
                            Console.Clear();
                        }

                        isNumber = false;

                        while (!isNumber || (col > 3 || col < 1) || (table[row - 1, col - 1] != 0))
                        {
                            print(table);
                            Console.WriteLine($"{coin}. játékos\n");
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
                            else if (isNumber && (col > 3 || col < 1))
                            {
                                Console.Write("Tartományon kívüli érték!");
                                Thread.Sleep(2500);
                                Console.Clear();
                                continue;
                            }
                            if (table[row - 1, col - 1] != 0)
                            {
                                Console.Write("Ez a mező nem üres!");
                                Thread.Sleep(2500);
                                repeat = true;
                                Console.Clear();
                                continue;
                            }
                            else
                            {
                                repeat = false;
                                table[row - 1, col - 1] = 1;
                                coin = 2;
                            }

                            Console.Clear();
                        }
                    }
                }

                repeat = true;
                    

                while (coin == 2)
                {
                    isNumber = false;
                    while (repeat)
                    {
                        while (!isNumber || (row > 3 || row < 1))
                        {
                            print(table);
                            Console.WriteLine($"{coin}. játékos\n");
                            Console.Write("Írja be a sort: ");
                            string input = Console.ReadLine();

                            isNumber = int.TryParse(input, out row);

                            if (!isNumber)
                            {
                                Console.Write("Nem számot adott meg!");
                                Thread.Sleep(2500);
                                Console.Clear();
                            }
                            else if (isNumber && (row > 3 || row < 1))
                            {
                                Console.Write("Tartományon kívüli érték!");
                                Thread.Sleep(2500);
                                Console.Clear();
                            }
                        }

                        isNumber = false;

                        while (!isNumber || (col > 3 || col < 1))
                        {
                            print(table);
                            Console.WriteLine($"{coin}. játékos\n");
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
                            else if (isNumber && (col > 3 || col < 1))
                            {
                                Console.Write("Tartományon kívüli érték!");
                                Thread.Sleep(2500);
                                Console.Clear();
                                continue;
                            }
                            if (table[row - 1, col - 1] != 0)
                            {
                                Console.Write("Ez a mező nem üres!");
                                Thread.Sleep(2500);
                                repeat = true;
                                Console.Clear();
                                continue;
                            }
                            else
                            {
                                repeat = false;
                                table[row - 1, col - 1] = 2;
                                coin = 1;
                            }
                        }   
                    }    
                }    
            }
            Console.ReadKey();
        }
    }
}
