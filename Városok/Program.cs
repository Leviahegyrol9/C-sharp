using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Városok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string fileName = "varosok.txt";

            List<City> cities = GetCityFromFile(fileName);

            Console.WriteLine($"{cities.Count} település található.");

            List<City> cityType = cities.Where(c => c.Type == "város").ToList();

            Console.WriteLine($"{cityType.Count}db város található.");

            City biggestCity = cities.Single(c => c.Place == cities.Max(max => max.Place));

            Console.WriteLine(biggestCity);

            bool cityC2 = cities.Any(c => c.Country2 == "Nagykállói");

            Console.WriteLine($"{(cityC2 ? "Van" : "Nincs")} olyan település, amely a Nagykállói járásban található.");

            List<City> howMany = cities.Where(c => c.Population >= 50000 && c.Population <= 100000).ToList();

            Console.WriteLine($"{howMany.Count}db település van, melynek népessége 50000 és 100000 között van.");

            bool isSuccess = WriteBekesToFile("bekes.txt", cities.Where(c => c.Country == "Békés").ToList());

            Console.ReadLine();
        }
        private static bool WriteBekesToFile(string fileName, List<City> cities)
        {
            try
            {
                using(StreamWriter sW = new StreamWriter(fileName))
                {
                    
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static List<City> GetCityFromFile(string fileName)
        {
            List<City> cities = new List<City>();
            City city = null;

            try
            {
                using (StreamReader sR = new StreamReader(fileName))
                {
                    while (!sR.EndOfStream)
                    {
                        string line = sR.ReadLine();
                        string[] datas = line.Split('\t');

                        city = new City
                        {
                            Name = datas[0],
                            Type = datas[1],
                            Country = datas[2],
                            Country2 = datas[3],
                            Area = datas[4],
                            Population = int.Parse(datas[5]),
                            Place = double.Parse(datas[6])
                        };

                        cities.Add(city);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return cities;
        }
    }
}
