using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Details
{
    public class DetailsMethods
    {
        public static string GetFirstOrLastIp(string ip, char input)
        {
            string firstIp = ip.Substring(0, ip.Length - 1) + input;

            return firstIp;
        }
    }
}
