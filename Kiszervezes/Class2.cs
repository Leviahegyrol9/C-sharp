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
            string firstIp = ip;

            firstIp.Remove(firstIp.Length - 1);

            firstIp += input;

            return firstIp;
        }
    }
}
