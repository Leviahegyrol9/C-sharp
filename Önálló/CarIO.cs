using Önálló.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Önálló
{
    public class CarIO
    {
        public static List<Car> GetCars(string fileName)
        {
            List<Car> cars = new List<Car>();
            Car car = null;

            try
            {
                string[] lines = File.ReadAllLines(fileName);

                foreach (string line in lines.Skip(1))
                {
                    string[] datas = line.Split(',');

                    car = new Car
                    {
                        Id = int.Parse(datas[0]),
                        Model = datas[1],
                        RegistrationDate = DateTime.Parse(datas[2]),
                        ExpiryDate = DateTime.Parse(datas[3]),
                        Mileage = int.Parse(datas[4])
                    };

                    cars.Add(car);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Environment.Exit(0);
            }

            return cars;
        }
    }
}