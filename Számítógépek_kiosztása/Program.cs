using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Function;

namespace Számítógépek_kiosztása
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string inputPath = "input.txt";
            const string workersPath = "workers.txt";

            const string rgPath = "../../files/Rendszergazda.txt";
            const string wPath = "../../files/Dolgozo.txt";
            const string cPath = "../../files/Termek.txt";

            bool success;
            Dictionary<string, int> classAndCapacity = new Dictionary<string, int>
            {
                {"Terem1", 0},
                {"Terem2", 0},
                {"Terem3", 0},
                {"Terem4", 0},
                {"Terem5", 0}
            };

            for (int i = 1; i < 6; i++)
            {
                int capacity = Methods.GetNumberWithCondition($"Kérem adja meg a Terem{i} férőhelyét: ", 0, int.MaxValue);

                classAndCapacity[$"Terem{i}"] = capacity;
            }

            int minInvNum = Methods.GetNumberWithCondition("Kérem adja meg a leltárszám kezdetét: ", 0, int.MaxValue);

            List<Item> items = consoleServices.GetItems(minInvNum, inputPath, File.ReadAllLines(workersPath).ToHashSet(), classAndCapacity);           

            success = consoleServices.WriteFile(items.Where(item => item.Status == "Rendszergazda" | item.Status == "Tartalék").ToList(), rgPath);
            Methods.CheckSuccess(rgPath, success);

            List<Item> classItems = items.Where(item => item.Status.Contains("Terem")).ToList();

            success = consoleServices.WriteFile(classItems, cPath);
            Methods.CheckSuccess(cPath, success);

            success = consoleServices.WriteFile(items.Where(item => item.Status.Contains("Dolgozó")).ToList(), wPath);
            Methods.CheckSuccess(wPath, success);

            Thread.Sleep(2000);
            Console.Clear();

            int exchangeRate = Methods.GetNumberWithCondition("Kérem az árfolyamot: ", 1, int.MaxValue);

            Console.WriteLine($"A termekben összesen {classItems.Count} eszköz található\nHUF: {classItems.Sum(classI => classI.Price):n2}\nEUR: {classItems.Sum(classI => classI.Price) / exchangeRate:n2}");

            Console.Write("Kérem a gyári számot: ");

            string serialNum = Console.ReadLine();

            Item sN = items.Where(item => item.SerialNumber == serialNum).First();

            Console.WriteLine($"Hol: {sN.Type}\nKinél: {sN.Status}");

            Console.ReadKey();

            Console.Write("Kérem a leltári számot: ");

            string invNum = Console.ReadLine();

            Item iN = items.Where(item => item.InvNumber == invNum).First();

            Console.WriteLine($"Hol: {iN.Type}\nKinél: {iN.Status}");

            Console.ReadKey();
        }
    }
}
