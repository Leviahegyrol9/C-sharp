using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmek
{
    public class FilmIO
    {
        public static List<Film> GetFilmsFromFile(string fileName)
        {
            List<Film> films = new List<Film>();

            Film film = new Film();

            try
            {
                string[] lines = File.ReadAllLines(fileName, Encoding.UTF8);

                foreach (string line in lines)
                {
                    string[] datas = line.Split(',');
                    string tempGenre = string.Empty;

                    switch (datas[1].ToLower())
                    {
                        case "comdy":
                            tempGenre = "comedy";
                            break;

                        case "romence":
                            tempGenre = "romance";
                            break;
                        default:
                            tempGenre = datas[1].ToLower();
                            break;
                    }

                    film = new Film
                    {
                        Title = datas[0],
                        Genre = tempGenre,
                        Distributor = datas[2],
                        Rate = int.Parse(datas[3]),
                        PayOff = double.Parse(datas[4].Replace(".", ",")),
                        RtRating = int.Parse(datas[5]),
                        Income = double.Parse(datas[6].Replace(".", ",").Replace("$", "")),
                        Year = int.Parse(datas[7])
                    };

                    films.Add(film);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Environment.Exit(0);
            }

            return films;
        }
    }
}
