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
            classAndCapacity.Add(className, capacity);

            return classAndCapacity;

        }

        public static List<Item> GetItems(string path)
        {
            List<string> startList = File.ReadAllLines(path).ToList();

            List<string> endList = EditFile(startList);

            List<Item> items = new List<Item>();
            Item item = new Item();

            foreach (string data in endList)
            {
                string[] datas = data.Split(';');

                item = new Item
                {
                    SerialNumber = datas[0],
                    InvNumber = datas[1],
                    Type = datas[2],
                    Status = datas[3],
                    Price = int.Parse(datas[4])
                };

                items.Add(item);
            }

            return items;
        }

        private static List<string> EditFile(List<string> startList)
        {
            List<string> strings = new List<string>();

            foreach (string data in startList)
            {

            }
        }

        public static bool WriteFile(List<string> list)
        {
            return;
        }
    }
}
