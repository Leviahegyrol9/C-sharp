using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToName
{
    public static class Convert
    {
        public static string Capitalize(string name)
        {
            string[] names = name.Split(' ');

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = char.ToUpper(names[i][0]) + names[i].Substring(1);
            }

            return string.Join(" ", names);
        }
    }
}
