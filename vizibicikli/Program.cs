using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizibicikli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<WaterCycle> waterCycles = GetWaterCycle("kolcsonzesek.txt");

            Console.WriteLine($"Kölcsönzések száma: {waterCycles.Count}db");

            Console.WriteLine("Kérem a nevet: ");
            string name = Console.ReadLine();

            List<WaterCycle> nameCount = waterCycles.Where(x => x.Name == name).ToList();

            Console.WriteLine($"{(nameCount.Count != 0 ? $"Van ilyen kölcsönzés\n {nameCount.Count}db" : "Nincs ilyen kölcsönzés!")}");

            Console.WriteLine("Kérem a keresett időpontot: ");
            string[] time = Console.ReadLine().Split(':');

            string hour = time[0];
            string minute = time[1];

            List<WaterCycle> onWater = waterCycles.Where(x => x.VehicleOutH <);
        }

        private static List<WaterCycle> GetWaterCycle(string fileName)
        {
            List<WaterCycle > list = new List<WaterCycle>();

            WaterCycle wC = null;

            foreach (string line in File.ReadLines(fileName).Skip(1))
            {
                string[] datas = line.Split(';');

                wC = new WaterCycle
                {
                    Name = datas[0],
                    Id = datas[1],
                    VehicleOutH = int.Parse(datas[2]),
                    VehicleOutM = int.Parse(datas[3]),
                    VehicleInH = int.Parse(datas[4]),
                    VehicleInM = int.Parse(datas[5]),
                };

                list.Add(wC);
            }

            return list;

        }
    }
}
