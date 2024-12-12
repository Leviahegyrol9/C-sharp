using Function;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karacsonyi
{
    public class Csaba
    {
        public static void Function()
        {
            List<string> toDoList = new List<string>(5);
            int counter = 0;
            string item = string.Empty;

            while (counter < 5)
            {
                counter++;
                item = Methods.GetString($"Adja meg a(z) {counter}. feladatot: ");
                toDoList.Add(item);
            }

            foreach (string point in toDoList)
            {
                Console.WriteLine(point);
            }
        }
    }
}
