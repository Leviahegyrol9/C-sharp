using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Számítógépek_kiosztása
{
    public class consoleServices
    {
        public static List<Item> GetItems(int min, string path, HashSet<string> workers)
        {
            List<string> endList = EditFile(File.ReadAllLines(path).ToList(), min, workers);

            List<Item> items = new List<Item>();
            Item item = new Item();

            foreach (string data in endList)
            {
                string[] datas = data.Split(';');

                item = new Item
                {
                    SerialNumber = datas[0],
                    Type = datas[1],
                    Price = int.Parse(datas[2]),
                    Status = datas[3],
                    InvNumber = datas[4]
                };

                items.Add(item);
            }

            return items;
        }

        private static List<string> EditFile(List<string> startList, int min, HashSet<string> workers)
        {
            List<string> endList = new List<string>();

            foreach (string data in startList.Skip(1))
            {
                string[] datas = data.Split(';');
                string status = GetStatus(datas, workers);

                string newData = $"{data};{status};lel{min}";
                min++;

                endList.Add(newData);
            }

            return endList;
        }
        private static string GetStatus(string[] datas, HashSet<string> workers)
        {
            switch (datas[1].ToLower())
            {
                case "laptop":
                    return GetWorker(workers);

                case "pc":
                    return "Terem";

                case "szerver":
                    return "Rendszergazda";

                default:
                    return string.Empty;
            }
        }

        private static string GetWorker(HashSet<string> workers)
        {
            try
            {
                string worker = workers.First();

                workers.Remove(workers.First());

                return worker;
            }
            catch (Exception)
            {
                return "Leltár";
            }
        }

        public static bool WriteFile(List<Item> items, string path)
        {
            try
            {
                StreamWriter writer = new StreamWriter(path);

                foreach (Item item in items)
                {
                    writer.WriteLine(item);
                }

                writer.Close();

            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
