using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verseny
{
    public class TimeIO
    {
        public static List<Time> GetTImes(string path)
        {
            List<Time> times = new List<Time>();
            Time time = null;

            try
            {
                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    string[] datas = line.Split(' ');

                    time = new Time
                    {
                        Hour = int.Parse(datas[0]),
                        Minute = int.Parse(datas[1])
                    };

                    times.Add(time);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Environment.Exit(0);
            }

            return times;
        }
    }
}
