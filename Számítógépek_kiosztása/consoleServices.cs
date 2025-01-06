using System;
using System.Collections.Generic;
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
    }
}
