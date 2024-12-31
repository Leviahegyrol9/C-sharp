using System;
using System.Collections.Generic;
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
            Console.WriteLine($"A legnagyobb értékelést a  {highestRate.Name} című film kapta ({highestRate.Rate}%).\n");

            //4
            bool isAnyFilm = films.Any(film => film.RtRating >= 90);
            Console.WriteLine($"{(isAnyFilm ? "Van" : "Nincs")} olyan film, amely a Rotten Tomatoes értékelése alapján legalább 90% értékelést kapott.\n");

            //5
            Dictionary<string, double> genresAndIncomes = GetGenresAndIncomes(films);
            PrintDict(genresAndIncomes);

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

        private static void PrintDict(Dictionary<string, double> dict)
        {
            foreach(KeyValuePair<string, double> item in dict)
            {
                Console.WriteLine($"{item.Key}: ${item.Value:n2}");
            }
        }
    }
}
