using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beolvasas3
{
    public class CarIO
    {
        public static List<Car> ReadCarsFromFile(string filename)
        {
            Car car = new Car();
            List<Car> cars = new List<Car>();

            try
            {
                string[] lines = File.ReadAllLines(filename, UTF8Encoding.UTF8);

                foreach (string line in lines)
                {
                    string[] datas = line.Split(',');

                    car = new Car
                    {
                        Name = datas[0],
                        MPG = double.Parse(datas[1].Replace(".", ",")),
                        Cylinder = int.Parse(datas[2]),
                        Newton = double.Parse(datas[3].Replace(".", ",")),
                        HorsePower = double.Parse(datas[4].Replace(".", ",")),
                        Weight = int.Parse(datas[5]),
                        Acceleration = double.Parse(datas[6].Replace(".", ",")),
                        Year = int.Parse(datas[7]),
                        Manufacter = datas[8]
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
