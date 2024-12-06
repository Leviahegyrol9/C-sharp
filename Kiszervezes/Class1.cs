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
        public static string ConvertToBinaryMethod(int number, int counter)
        {
            string binary = Convert.ToString(number, 2);

            if (counter < 3)
            {
                binary += ".";
            }

            return binary;
        }

        public static bool WriteToFile(string fileName, List<string> ipAddress, bool append)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName, append))
                {
                    foreach (string ip in ipAddress)
                    {
                        writer.WriteLine(ip);

                    }
                    writer.Close();
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
