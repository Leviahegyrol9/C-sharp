using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public class AppServices
    {
        public static List<Vehicle> GetVehicles(string path)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            Vehicle vehicle = new Vehicle();

            try
            {
                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    string[] datas = line.Split(';');

                    vehicle = new Vehicle
                    { 
                        Name = datas[0],
                        Price = int.Parse(datas[1])
                    };

                    vehicles.Add(vehicle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return vehicles;
        }

        public static Dictionary<string, int> GetNamesAndPrice(List<Vehicle> vehicles)
        {
            Dictionary<string, int> namesAndPrice = new Dictionary<string, int>();

            HashSet<string> names = GetNames(vehicles);

            foreach (string name in names)
            {
                namesAndPrice[name] = 0;
            }

            foreach (Vehicle vehicle in vehicles)
            {
                namesAndPrice[vehicle.Name] += vehicle.Price;
            }

            return namesAndPrice;
        }

        private static HashSet<string> GetNames (List<Vehicle> vehicles)
        {
            HashSet<string> names = new HashSet<string>();

            foreach (Vehicle vehicle in vehicles)
            {
                names.Add(vehicle.Name);
            }

            return names;
        }

        public static bool WriteFile(string path, string vehicle, string price)
        {
            StreamWriter writer = new StreamWriter(path, true);

            try
            {
                writer.WriteLine($"{vehicle};{price}");
            }
            catch (Exception)
            {
                writer.Close();
                return false;
            }

            writer.Close();
            return true;
        }
    }
}
