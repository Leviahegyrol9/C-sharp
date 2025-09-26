using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkezesek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string fileName = "balkezesek.csv";
            List<LeftHand> leftHandeds = GetLeftHandeds(fileName);

            Console.WriteLine($"A forrásban {leftHandeds.Count} db adat található.");

            List<LeftHand> teamYear = leftHandeds.Where(x => x.Last.Year == 1999 && x.Last.Month == 10).ToList();

            foreach (LeftHand lH in teamYear)
            {
                Console.WriteLine($"\t{lH.Name}: {lH.Height * 2.54} cm");
            }

            int year;

            do
            {

            } while (1990 <= year <= 1999);

            Console.ReadKey();
        }

        private static List<LeftHand> GetLeftHandeds(string fileName)
        {
            List<LeftHand> leftHandeds = new List<LeftHand>();
            LeftHand leftHand = null;

            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines.Skip(1))
            {
                string[] datas = line.Split(';');

                leftHand = new LeftHand(datas[0], Convert.ToDateTime(datas[1]), Convert.ToDateTime(datas[2]), int.Parse(datas[3]), int.Parse(datas[4]));

                leftHandeds.Add(leftHand);
            }

            return leftHandeds;
        }
    }
}
