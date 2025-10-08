using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telekocsi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = GetCars("autok.csv");
            List<Demand> demands = GetDemands("igenyek.csv");

            Console.WriteLine($"{cars.Count} autós hirdet fuvart");

            int count = cars.Count(c => c.Start == "Budapest" && c.End == "Miskolc");

            Console.WriteLine($"Összesen {count} férőhelyet hirdettek az autósok Budapestről Miskolcra");

            Car max = cars.Single(x => x.Capacity == cars.Max(c => c.Capacity));

            Console.WriteLine($"A legtöbb férőhelyet ({max.Capacity}-et) a {max.Start}-{max.End} útvonalon\r\najánlották fel a hirdetők");


        }
        private static List<Car> GetCars(string path)
        {
            List<Car> cars = new List<Car>();
            Car car = null;

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines.Skip(1))
            {
                string[] datas = line.Split(';');

                car = new Car
                {
                    Start = datas[0],
                    End = datas[1],
                    Plate = datas[2],
                    PhoneNumber = datas[3],
                    Capacity = int.Parse(datas[4])
                };

                cars.Add(car);
            }

            return cars;
        }

        private static List<Demand> GetDemands(string path)
        {
            List<Demand> demands = new List<Demand>();
            Demand demand = null;

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines.Skip(1))
            {
                string[] datas = line.Split(';');

                demand = new Demand
                {
                    Id = datas[0],
                    Start = datas[1],
                    End = datas[2],
                    People = int.Parse(datas[3])
                };

                demands.Add(demand);
            }

            return demands;
        }
    }
}
