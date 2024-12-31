using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Function;

namespace Filmek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string fileName = "filmek.csv";

            List<Film> films = FilmIO.GetFilmsFromFile(fileName);

            //1
            Console.WriteLine($"A {fileName} állományban {films.Count} film szerepel.\n");

            //2
            Console.WriteLine($"A {fileName} állományban szerepelő filmek ösz bevétele ${films.Sum(film => film.Income):n2} millió dollár.\n");

            //3
            Film highestRate = films.Where(film => film.Rate == films.Max(max => max.Rate)).Single();
            Console.WriteLine($"A legnagyobb értékelést a  {highestRate.Title} című film kapta ({highestRate.Rate}%).\n");

            //4
            bool isAnyFilm = films.Any(film => film.RtRating >= 90);
            Console.WriteLine($"{(isAnyFilm ? "Van" : "Nincs")} olyan film, amely a Rotten Tomatoes értékelése alapján legalább 90% értékelést kapott.\n");

            //5
            Dictionary<string, double> genresAndIncomes = GetGenresAndIncomes(films);
            PrintGenresAndIncomes(genresAndIncomes);
            Console.WriteLine();

            //6
            const string newFileName = "evek.txt";
            bool success = WriteToFile(films, newFileName);

            Console.WriteLine($"A mentés {(success ? "sikeres volt" : "nem volt sikeres")}.");

            Console.ReadKey();
        }
        private static HashSet<string> GetGenres(List<Film> films)
        {
            HashSet<string> genres = new HashSet<string>();

            foreach (Film film in films)
            {
                genres.Add(Methods.CapitalizeFirstLetter(film.Genre));
            }

            return genres;
        }

        private static Dictionary<string, double> GetGenresAndIncomes(List<Film> films)
        {
            Dictionary<string, double> genresAndIncomes = new Dictionary<string, double>();
            HashSet<string> genres = GetGenres(films);

            foreach (string genre in genres)
            {
                genresAndIncomes[genre] = 0;
            }

            foreach(Film film in films)
            {
                genresAndIncomes[Methods.CapitalizeFirstLetter(film.Genre)] += film.Income;
            }

            return genresAndIncomes;
        }

        private static void PrintGenresAndIncomes(Dictionary<string, double> dict)
        {
            foreach(KeyValuePair<string, double> item in dict)
            {
                Console.WriteLine($"{item.Key}: ${item.Value:n2}");
            }
        }

        private static HashSet<int> GetYears(List<Film> films)
        {
            HashSet<int> years = new HashSet<int>();

            foreach (Film film in films)
            {
                years.Add(film.Year);
            }

            return years;
        }

        private static Dictionary<int, List<string>> GetYearsAndTitles(List<Film> films)
        {
            HashSet<int> years = GetYears(films);
            Dictionary<int, List<string>> yearsAndTitles = new Dictionary<int, List<string>>();

            foreach (int year in years)
            {
                yearsAndTitles[year] = new List<string>();
            }

            foreach (Film film in films)
            {
                yearsAndTitles[film.Year].Add(film.Title);
            }

            Dictionary<int, List<string>> sortedYearsAndTitles = yearsAndTitles.OrderBy(year => year.Key).ToDictionary(year => year.Key, year => year.Value);

            return sortedYearsAndTitles;
        }

        private static bool WriteToFile(List<Film> films, string fileName)
        {
            Dictionary<int, List<string>> yearsAndTitles = GetYearsAndTitles(films);

            StreamWriter writer = new StreamWriter(fileName);

            try
            {
                foreach (KeyValuePair<int, List<string>> item in yearsAndTitles)
                {
                    writer.WriteLine($"{item.Key}:");
                    
                    foreach (string title in item.Value)
                    {
                        writer.WriteLine($"\t- {title}");
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                writer.Close();
            }

            return true;
        }
    }
}
