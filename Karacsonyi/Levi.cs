using Function;
using IO;
using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karacsonyi
{
    public class Levente
    {
        public static void Function()
        {
            string baseFileName = "adatok.txt";
            string fileName = "adatok_rnd.txt";

            List<string> datas = File.ReadAllLines(baseFileName).ToList();

            bool success = Methods.WriteFile(fileName, datas, false);

            Methods.IfSuccess(fileName, success);

            List<Person> people = PersonIO.ReadFile(fileName);
        }
    }
}
