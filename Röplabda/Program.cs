using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Röplabda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string fileName = "roplabda.txt"; 
        }

        private static List<Team> GetTeams(string fileName)
        {
            List<Team> teams = new List<Team>();
            Team team = null;

            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] datas = line.Split('\t');

                List<int> points = new List<int>();

                foreach (string point in datas[1].Split(','))
                {
                    points.Add(int.Parse(point));
                }

                team = new Team
                {
                    TeamName = datas[0],
                    Points = new List<int>().AddRange(points)
                };
            }
        }

    }
}
