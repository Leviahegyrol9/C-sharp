using Önálló.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Önálló
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ownerFileName = "owners.csv";
            const string carFileName = "cars.txt";

            Random rnd = new Random();

            List<Car> cars = CarIO.GetCars(carFileName);
            List<Owner> owners = OwnerIO.GetOwners(ownerFileName);

            Console.WriteLine($"Az összes km az autókban: {cars.Sum(c => c.Mileage):n0} km");

            double average = cars.Average(c => c.Mileage);
            Console.WriteLine($"Az átlag km az autókban: {average:n2} km\n");

            Car maxKm = cars.Single(c => c.Mileage == cars.Max(m => m.Mileage));
            Car minKm = cars.Single(c => c.Mileage == cars.Min(m => m.Mileage));

            Console.WriteLine($"A legtöbb km a(z) {maxKm.Model} típusú autóban van: {maxKm.Mileage:n0} km");
            Console.WriteLine($"A legkevesebb km a(z) {minKm.Model} típusú autóban van: {minKm.Mileage:n0} km\n");

            Console.WriteLine($"Átlag alatti autók száma: {cars.Count(c => c.Mileage < average)}");

            Console.WriteLine($"A {carFileName} állományban {cars.Count}, az {ownerFileName} állományban pedig {owners.Count} adat szerepel\n");

            Dictionary<string, int> residenceAndCount = GetResidenceAndCount(owners);

            Console.WriteLine("Az autótulajdonosok lakhelyeinek eloszlása:\n");

            foreach (KeyValuePair<string, int> item in residenceAndCount)
            {
                Console.WriteLine($"{item.Key}: {item.Value}db");
            }

            int year = 2000;

            bool isAnyWhoBornAfter2000 = owners.Any(o => o.BirthDate.Year > year);

            Console.WriteLine($"\n{(isAnyWhoBornAfter2000 ? "Van" : "Nincs")} olyan ember aki {year} után született");

            Console.WriteLine($"\n{cars.Count(c => c.Mileage > 100000)} db autó van amiben több mint 100 ezer km van\n");

            string name = GetName("Kérem a keresni kívánt ember nevét: ");

            bool person = owners.Any(o => o.OwnerName == name);

            Console.WriteLine($"{name} {(person ? "szerepel" : "nem szerepel")} az állományban\n");

            Car check = cars[rnd.Next(0, cars.Count + 1)];

            check.IsExpired();

            bool success = WriteOwnerAndCar(cars, owners, "ownerAndCar.txt");

            Console.WriteLine($"\n{(success ? "Sikeres": "Sikertelen")} fájlbaírás\n");

            Owner owner = owners[rnd.Next(0, owners.Count + 1)];

            IAge iAge = owner;

            int age = iAge.GetAge();

            Console.WriteLine($"{owner.OwnerName} életkora: {age}");            
        }
        private static bool WriteOwnerAndCar(List<Car> cars, List<Owner> owners, string fileName)
        {
            try
            {
                HashSet<int> ids = cars.Select(c => c.Id).ToHashSet();
                StreamWriter sW = new StreamWriter(fileName);

                foreach (int id in ids)
                {
                    if (id != ids.Last()) sW.WriteLine($"{owners.Single(o => o.Id == id).OwnerName}: {cars.Single(c => c.Id == id).Model}");

                    else sW.Write($"{owners.Single(o => o.Id == id).OwnerName}: {cars.Single(c => c.Id == id).Model}");
                }

                sW.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
        private static Dictionary<string, int> GetResidenceAndCount(List<Owner> owners)
        {
            Dictionary<string, int> residenceAndCount = new Dictionary<string, int>();
            HashSet<string> residences = owners.Select(o => o.Residence).ToHashSet();

            foreach(string residence in residences)
            {
                residenceAndCount[residence] = 0;
            }

            foreach (Owner owner in owners)
            {
                residenceAndCount[owner.Residence]++;
            }

            return residenceAndCount;
        }
        private static string GetName(string prompt)
        {
            bool isString;
            string name;

            do
            {
                Console.Write(prompt);
                name = Console.ReadLine().Trim();

                isString = name.Replace(" ", "").All(char.IsLetter);

                if (!isString || name.Length < 3)
                {
                    Console.WriteLine("Nem nevet adott meg!");
                    Thread.Sleep(2500);
                }

            } while (!isString || name.Length < 3);

            return CapitalizeName(name);
        }
        private static string CapitalizeName(string name)
        {
            string[] names = name.ToLower().Split(' ');

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = char.ToUpper(names[i][0]) + names[i].Substring(1);
            }

            return string.Join(" ", names);
        }
    }
}