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

            List<Team> teams = GetTeams(fileName);

            Console.WriteLine($"A csapatok száma: {teams.Count}db");

            Dictionary<string, int> teamsAndDraws = GetTeamsAndDraws(teams);

            foreach (KeyValuePair<string, int> item in teamsAndDraws)
            {
                Console.WriteLine($"\t{item.Key}: {item.Value}");
            }

            List<Team> mins = teams.Where(x => x.Points.Count(y => y == 1) == teams.Min(z => z.Points.Count(d => d == 1))).ToList();

            Console.WriteLine($"A legkevesebb 1 pontost mérkőzést játszotta:");

            foreach (Team team in mins)
            {
                Console.WriteLine(team.TeamName);
            }

            Team winner = teams.Single(x => x.Points.Average(y => y) == teams.Max(z => z.Points.Average()));

            Console.WriteLine($"A bajnokság győztese: {winner.TeamName}");

            Console.ReadKey();
        }

        private static Dictionary<string, int> GetTeamsAndDraws(List<Team> teams)
        {
            Dictionary<string, int> teamsAndDraws = new Dictionary<string, int>();
            HashSet<string> teamNames = teams.Select(name => name.TeamName).ToHashSet();

            foreach (string name in teamNames)
            {
                teamsAndDraws[name] = 0;
            }

            foreach (Team team in teams)
            {
                int draws = team.Points.Count(num => num == 2);

                teamsAndDraws[team.TeamName] = draws;
            }

            return teamsAndDraws;

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

                team = new Team(datas[0], points);

                teams.Add(team);
            }

            return teams;
        }

    }
}
