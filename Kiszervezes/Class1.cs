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

        public static bool WriteToFile(string fileName, string ipAddress, bool append)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName, append))
                {
                    writer.WriteLine(ipAddress);
                                       
                    writer.Close();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string ModifyList(int prefix, string ipAddresses)
        {
            string temp = string.Empty;

            for (int i = 0; i < 32; i++)
            {
                if (i < prefix)
                {
                    temp += ipAddresses[i];
                }
                else
                {
                    temp += '0';
                }
            }

            return temp;
            
        }
    }
}
