using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beolvasas3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string fileName = "autok.csv";

            List<Car> cars = CarIO.ReadCarsFromFile(fileName);

            //1

            Console.WriteLine($"A {fileName} állományban {cars.Count} autó szerepel.\n");

            //2

            Console.WriteLine($"A {fileName} állományban szerepelő autók ösz súlya {cars.Sum(car => car.Weight)}kg.\n");

            //3

            Car HighestNewton = cars.Where(car => car.Newton == cars.Max(max => max.Newton)).Single();

            Console.WriteLine($"A legnagyobb nyomatékkal a {HighestNewton.Name} rendelkezik ({HighestNewton.Newton}Nm).\n");

            //4

            bool AnyCarUnder7s = cars.Any(car => car.Acceleration < 7);

            Console.WriteLine($"{(AnyCarUnder7s ? "Van" : "Nincs")} olyan autó, amely a 7s alatt gyorsul fel 100km/h sebességre.\n");

            //5

            Dictionary<string, int> manufacterAndCount = GetManufacterAndCount(cars);

            PrintManufacterAndCount(manufacterAndCount);

            //6

            const string newFileName = "evek.txt";

            bool success = WriteYearAndNames(cars, newFileName);

            Console.WriteLine($"\nA mentés {(success ? "sikeres volt." : "nem volt sikeres.")}");

            Console.ReadKey();
        }

        private static Dictionary<string, int> GetManufacterAndCount(List<Car> cars)
        {
            Dictionary<string, int> manufacterAndCount = new Dictionary<string, int>();

            HashSet<string> manufacters = GetManufacters(cars);

            foreach (string manufacter in manufacters)
            {
                manufacterAndCount[manufacter] = 0;
            }

            foreach (Car car in cars)
            {
                manufacterAndCount[car.Manufacter]++;
            }

            return manufacterAndCount;
        }

        private static HashSet<string> GetManufacters(List<Car> cars)
        {
            HashSet<string> manufacters = new HashSet<string>();

            foreach (Car car in cars)
            {
                manufacters.Add(car.Manufacter);
            }

            return manufacters;
        }

        private static void PrintManufacterAndCount(Dictionary<string, int> manufacterAndCount)
        {
            foreach (KeyValuePair<string, int> item in manufacterAndCount)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        private static bool WriteYearAndNames(List<Car> cars, string fileName)
        {
            Dictionary<int, List<string>> yearsAndNames = GetYearsAndNames(cars);

            StreamWriter writer = new StreamWriter(fileName);

            try
            {
                foreach (KeyValuePair<int, List<string>> item in yearsAndNames)
                {
                    writer.WriteLine($"{item.Key}:");

                    foreach(string name in item.Value)
                    {
                        writer.WriteLine($"\t- {name}");
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

        private static Dictionary<int, List<string>> GetYearsAndNames(List<Car> cars)
        {
            Dictionary<int, List<string>> yearsAndNames = new Dictionary<int, List<string>>();

            HashSet<int> years = GetYears(cars);

            foreach (int year in years)
            {
                yearsAndNames[year] = new List<string>();
            }

            foreach (Car car in cars)
            {
                yearsAndNames[car.Year].Add(car.Name);
            }

            Dictionary<int, List<string>> sortedYearsAndNames = yearsAndNames.OrderBy(year => year.Key).ToDictionary(year => year.Key, year => year.Value);

            return sortedYearsAndNames;
        }
        private static HashSet<int> GetYears(List<Car> cars)
        {
            HashSet<int> years = new HashSet<int>();

            foreach (Car car in cars)
            {
                years.Add(car.Year);
            }

            return years;
        }
    }
}
