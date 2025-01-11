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
            const string outputPath = "output.txt";

            const string rgPath = "Rendszergazda.txt";
            const string wPath = "Dolgozo.txt";
            const string cPath = "Termek.txt";

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

                classAndCapacity = consoleServices.GetClassAndCapacity(classAndCapacity, $"Terem{i}", capacity);
            }

            Console.WriteLine($"Összesen {classAndCapacity.Sum(capacity => capacity.Value)} gépnek van hely a termekben.");

            int minInvNum = Methods.GetNumberWithCondition("Kérem adja meg a leltárszám kezdetét: ", 0, int.MaxValue);

            List<string> startList = File.ReadAllLines(inputPath).ToList();

            List<Item> items = consoleServices.GetItems(startList, minInvNum);

            success = consoleServices.WriteFile(items, outputPath);

            Methods.CheckSuccess(outputPath, success);

            success = consoleServices.WriteFile(items.Where(item => item.Status == "Rendszergazda").ToList(), rgPath);

            Methods.CheckSuccess(rgPath, success);

            success = consoleServices.WriteFile(items.Where(item => item.Status == "Dolgozó").ToList(), wPath);

            Methods.CheckSuccess(wPath, success);

            success = consoleServices.WriteFile(items.Where(item => item.Status == "Terem").ToList(), cPath);

            Methods.CheckSuccess(cPath, success);

            Console.ReadKey();
        }
    }
}
