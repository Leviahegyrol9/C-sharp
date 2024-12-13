using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beolvasas2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string fileName = "adatok.txt";
            List<Klub> klubs = KlubIO.ReadFile(fileName);

            //A kapusokon kívül mindenkit mezőnyjátékosnak tekintünk. Keresse ki a legidősebb mezőnyjátékos vezeték- és utónevét, valamint születési dátumát! (Feltételezheti, hogy csak egy ilyen játékos van.)

            Klub oldestPlayer = klubs.Single(klub => klub.BirthDate == klubs.Min(min => min.BirthDate));

            Console.WriteLine($"A legidősebb játékos: {oldestPlayer.LastName} {oldestPlayer.FirstName} ({oldestPlayer.BirthDate.ToString("yyyy.MM.dd.")})");

            //Határozza meg hány magyar, külföldi és kettős állampolgárságú játékos van!

            int hunNationality = klubs.Count(klub => klub.HunNationality == true); 
            int abrNationality = klubs.Count(klub => klub.AbrNationality == true);

            Console.WriteLine();

            Console.WriteLine($"Magyar nemzetiségű játékosok száma: {hunNationality}\nKülföldi nemzetiségű játékosok száma: {abrNationality}");

            //Határozza meg játékosok összértékét csapatonként és írja ki a képernyőre! A csapatok neve és a játékosainak összértéke jelenjen meg!

            Dictionary<string, int> teamsAndValues = GetTeamsAndValues(klubs);

            Console.WriteLine();

            foreach (KeyValuePair<string, int> team in teamsAndValues)
            {
                Console.WriteLine($"{team.Key}: {team.Value} EUR");
            }

            Console.WriteLine();

            //Keressük ki azon játékosokat, akiknek az értékük nem haladja meg a játékosok értékének átlag értékét.

            List<Klub> underAveragePlayers = klubs.Where(klub => klub.Value < klubs.Average(avg => avg.Value)).ToList();

            foreach (Klub player in underAveragePlayers)
            {
                Console.WriteLine($"{player.LastName} {player.FirstName} ({player.Value} EUR)");
            }

            Console.WriteLine();

            //Írja ki azon játékosok nevét, születési dátumát és csapataik nevét, akik 18 és 21 év közt vannak és magyar állampolgárok. Ha nincs ilyen, akkor megfelelő üzenettel helyettesítse a kimenetet.

            DateTime today = DateTime.Now;

            List<Klub> betweenPlayers = klubs.Where(klub => klub.HunNationality == true && (klub.BirthDate.Year - today.Year >= 18 && klub.BirthDate.Year - today.Year <= 21)).ToList();

            if (betweenPlayers.Count != 0)
            {
                foreach (Klub player in betweenPlayers)
                {
                    Console.WriteLine($"{player.Name} {player.LastName} {player.FirstName} ({player.BirthDate.ToString("yyyy.MM.dd.")})");
                }
            }
            else
            {
                Console.WriteLine("Nincs ilyen játékos!");
            }

            Console.ReadKey();
        }

        private static Dictionary<string, int> GetTeamsAndValues(List<Klub> klubs)
        {
            Dictionary<string, int> teamsAndValues = new Dictionary<string, int>();

            HashSet<string> teams = GetAllTeams(klubs);

            foreach (string team in teams)
            {
                teamsAndValues[team] = 0;
            }

            foreach (var klub in klubs)
            {
                teamsAndValues[klub.Name] += klub.Value;
            }

            return teamsAndValues;
        }

        private static HashSet<string> GetAllTeams(List<Klub> klubs)
        {
            HashSet<string> teams = new HashSet<string>();

            foreach (Klub klub in klubs)
            {
                teams.Add(klub.Name);
            }

            return teams;
        }
    }
}
