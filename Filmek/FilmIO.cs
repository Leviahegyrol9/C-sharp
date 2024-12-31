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

                    switch (datas[1].ToLower())
                    {
                        case "comdy":
                            film = new Film
                            {
                                Name = datas[0],
                                Genre = "comedy",
                                Distributor = datas[2],
                                Rate = int.Parse(datas[3]),
                                PayOff = double.Parse(datas[4].Replace(".", ",")),
                                RtRating = int.Parse(datas[5]),
                                Income = double.Parse(datas[6].Replace(".", ",").Replace("$", "")),
                                Year = int.Parse(datas[7])
                            };
                            break;

                        case "romence":
                            film = new Film
                            {
                                Name = datas[0],
                                Genre = "romance",
                                Distributor = datas[2],
                                Rate = int.Parse(datas[3]),
                                PayOff = double.Parse(datas[4].Replace(".", ",")),
                                RtRating = int.Parse(datas[5]),
                                Income = double.Parse(datas[6].Replace(".", ",").Replace("$", "")),
                                Year = int.Parse(datas[7])
                            };
                            break;

                        default:
                            film = new Film
                            {
                                Name = datas[0],
                                Genre = datas[1].ToLower(),
                                Distributor = datas[2],
                                Rate = int.Parse(datas[3]),
                                PayOff = double.Parse(datas[4].Replace(".", ",")),
                                RtRating = int.Parse(datas[5]),
                                Income = double.Parse(datas[6].Replace(".", ",").Replace("$", "")),
                                Year = int.Parse(datas[7])
                            };
                            break;
                    }

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
