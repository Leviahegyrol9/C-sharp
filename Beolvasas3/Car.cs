using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beolvasas3
{
    public class Car
    {
        public string Name { get; set; }
        public double MPG { get; set; }
        public int Cylinder { get; set; }
        public double Newton { get; set; }
        public double HorsePower { get; set; }
        public int Weight { get; set; }
        public double Acceleration { get; set; }
        public int Year { get; set; }
        public string Manufacter { get; set; }

        public Car()
        {
            
        }

        public Car(string name, double mPG, int cylinder, double newton, double horsePower, int weight, double acceleration, int year, string source)
        {
            Name = name;
            MPG = mPG;
            Cylinder = cylinder;
            Newton = newton;
            HorsePower = horsePower;
            Weight = weight;
            Acceleration = acceleration;
            Year = year;
            Manufacter = source;
        }

        public override string ToString()
        {
            return $"{Name}, {MPG}, {Cylinder}, {Newton}, {HorsePower}, {Weight}, {Acceleration}, {Year}, {Manufacter}";
        }
    }
}
