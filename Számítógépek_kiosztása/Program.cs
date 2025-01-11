using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
            int capacitySum = classAndCapacity.Sum(capacity => capacity.Value);

            Console.WriteLine($"Összesen {capacitySum} gépnek van hely a termekben.");

            int minInvNum = Methods.GetNumberWithCondition("Kérem adja meg a leltárszám kezdetét: ", 0, int.MaxValue);

            List<Item> items = consoleServices.GetItems(minInvNum, inputPath, File.ReadAllLines(workersPath).ToHashSet());           

            success = consoleServices.WriteFile(items.Where(item => item.Status == "Rendszergazda").ToList(), rgPath);
            Methods.CheckSuccess(rgPath, success);

            success = consoleServices.WriteFile(items.Where(item => item.Status == "Terem").ToList(), cPath);
            Methods.CheckSuccess(cPath, success);

            success = consoleServices.WriteFile(items.Where(item => item.Status != "Rendszergazda" & item.Status != "Terem").ToList(), wPath);
            Methods.CheckSuccess(wPath, success);

            Console.ReadKey();
        }
    }
}
