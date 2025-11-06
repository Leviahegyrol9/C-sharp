using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nobel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "nobel.csv";

            List<Nobel> nobels = GetNobels(fileName);

            Nobel arthur = nobels.Single(x => x.LastName == "Arthur B." && x.FirstName == "McDonald");

            Console.WriteLine(arthur.Type);

            Nobel literature = nobels.Single(x => x.Type == "irodalmi" && x.Year == 2017);

            Console.WriteLine($"{literature.LastName} {literature.FirstName}");

            List<Nobel> bekeNobel = nobels.Where(x => x.Type == "béke" && x.FirstName == string.Empty && x.Year > 1990).ToList();

            foreach(Nobel b in bekeNobel)
            {
                Console.WriteLine(b.LastName);
            }

            List<Nobel> curie = nobels.Where(x => x.FirstName.ToLower().Contains("curie")).ToList();

            foreach (Nobel cur in curie)
            {
                Console.WriteLine(cur);
            }

        }
        private static List<Nobel> GetNobels(string fileName)
        {
            List<Nobel> nobels = new List<Nobel>();
            Nobel nobel = null;

            foreach (string line in File.ReadAllLines(fileName).Skip(1))
            {
                string[] datas = line.Split(';');

                nobel = new Nobel
                {
                    Year = int.Parse(datas[0]),
                    Type = datas[1],
                    LastName = datas[2],
                    FirstName = datas[3]
                };

                nobels.Add(nobel);
            }

            return nobels;
        }
    }
}
