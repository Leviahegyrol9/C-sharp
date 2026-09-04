using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static void printTable(string[,] table)
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
                //jobbra
                if (table[i, 0] != "-" && table[i, 0] == table[i, 1] && table[i, 1] == table[i, 2]) return true;

                //lefelé
                if (table[0, i] != "-" && table[0, i] == table[1, i] && table[1, i] == table[2, i]) return true;
            }

            //srégen
            if (table[0, 0] != "-" && table[0, 0] == table[1, 1] && table[1, 1] == table[2, 2]) return true;
            if (table[0, 2] != "-" && table[0, 2] == table[1, 1] && table[1, 1] == table[2, 0]) return true;

            return false;
        }

        static bool IsTie(string[,] table)
        {
            /*
            GetLenth parancs olyan mint a sima Lenght viszont
            table.Lenght = 9 mert 3x3 mező van
            table.GetLenght(dimenzio indexe) -> table[dimenzio1, dimenzio2]
            */
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
            bool repeat;
            string player = null;

            int playerType = 0;
            Random random = new Random();
            List<List<int>> availableSlots = new List<List<int>>();

            //Feltöltöm a listát kötőjelekkel
            string[,] table = new string[3, 3];

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = "-";
                }
            }

            //Feltöltöm a listát az elérhető kordináták értékeivel
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                   availableSlots.Add(new List<int>() {i, j});
                }
            }
            //Addig ismétlem a ciklust amíg a felhasználó számot és az adott lehetőséget választja
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

            //Játék
            while (!win)
            {
                repeat = true;

                //Addig ismétlem amíg olyan kordinátát ir be amin üres mező van
                while (repeat)
                {
                    player = "X";

                    isNumber = false;

                    while (!isNumber || (row > 3 || row < 1))
                    {
                        printTable(table);
                        Console.WriteLine($"{player} játékos\n");
                        Console.Write("Írja be a sort: ");
                        string input = Console.ReadLine();

                        //Megnézem hogy int e a szám ha int akkor true lesz az isNumber értéke és a row-t átalakítja int tipusra
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
                        printTable(table);
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
                            //Kitörlöm azt a kordinátát amit felhasználtam
                            availableSlots.RemoveAll(slot => slot[0] == row - 1 && slot[1] == col - 1);
                            win = CheckWin(table);
                            if (win)
                            {
                                //Kilépek az összes ciklusból és az End-hez lépek
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

                //Robot
                if (playerType == 2)
                {
                    player = "O";

                    //Egy random számot generálok 0-tól az elérhető helyekig
                    int counter = random.Next(0, availableSlots.Count());

                    //Lebontom a listát sorra és oszlopra
                    row = availableSlots[counter][0];

                    col = availableSlots[counter][1];
 
                    printTable(table);

                    Console.Write("A robot gondolkodik...");
                    Thread.Sleep(2500);
                    Console.Clear();

                    table[row, col] = player;
                    availableSlots.RemoveAll(slot => slot[0] == row && slot[1] == col);

                    win = CheckWin(table);
                    if (win)
                    {
                        goto EndRobot;
                    }
                    if (IsTie(table))
                    {
                        goto Tie;
                    }
                }

                repeat = true;

                //Ez a ciklus akkor fut le ha játékos az ellenfél
                while (playerType == 1 && repeat)
                {
                    player = "O";
                    isNumber = false;

                    while (!isNumber || (row > 3 || row < 1))
                    {
                        printTable(table);
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
                        printTable(table);
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
                            availableSlots.RemoveAll(slot => slot[0] == row - 1 && slot[1] == col - 1);
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
            printTable(table);
            Console.Write($"\nA(z) {player} játékos nyert!");
            Console.ReadKey();
            return;

        EndRobot:
            Console.Clear();
            printTable(table);
            Console.Write("\nA robot nyert!");
            Console.ReadKey();
            return;

        Tie:
            Console.Clear();
            printTable(table);
            Console.Write("Döntetlen!");
            Console.ReadKey();
            return;
        }
    }
}