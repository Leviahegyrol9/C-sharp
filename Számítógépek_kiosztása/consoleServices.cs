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
        public static Dictionary<string, int> GetClassAndCapacity(Dictionary<string, int> classAndCapacity ,string className, int capacity)
        {
            classAndCapacity[className] = capacity;

            return classAndCapacity;

        }

        public static List<Item> GetItems(List<string> startList, int min)
        {
            List<string> endList = EditFile(startList, min);

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

        private static List<string> EditFile(List<string> startList, int min)
        {
            List<string> strings = new List<string>();

            foreach (string data in startList)
            {
                string[] datas = data.Split(';');
                string status = GetStatus(datas);

                string newData = $"{data};{status};lel{min}";
                min++;

                strings.Add(newData);
            }

            return strings;
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

        private static string GetStatus(string[] datas)
        {
            Random random = new Random();

            switch (random.Next(1, 3))
            {
                case 1:
                    return "Rendszergazda";

                case 2:
                    return "Dolgozó";

                default:
                    return string.Empty;
            }
        }
    }
}
