using System;
using System.Collections.Generic;
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
        }
        private static List<Car> GetCars(string path)
        {
            List<Car> cars = new List<Car>();
            Car car = null;
        }
    }
}
