using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConvertToBinary
{
    public class Methods
    {
        public static string ConvertToBinaryMethod(int number)
        {
            return Convert.ToString(number, 2);
        }

        public static bool WriteToFile(string fileName, string[] data, bool append)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName, append))
                {
                    writer.WriteLine($"");
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
