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
        public static bool GetMotorHp(TextBox motorHP, Label result)
        {
            bool isNumber = int.TryParse(motorHP.Text, out int value);

            if (!isNumber)
            {
                result.Text = "Nem számot adtál meg!";
                motorHP.Text = string.Empty;
                return false;
            }
            else if (value < 0 || value > 100)
            {
                result.Text = "0 és 100 között add meg!";
                motorHP.Text = string.Empty;
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void ClearCache(string fiveMPath)
        {
            try
            {
                Directory.Delete($"{fiveMPath}/cache", true);
                Directory.Delete($"{fiveMPath}/server-cache", true);
                Directory.Delete($"{fiveMPath}/server-cache-priv", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Sikeres törlés", "Törlés", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static List<Vehicle> GetVehicles(string path, Label result)
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
            catch (FileNotFoundException)
            {
                result.Text = "Először adj hozzá valamit!";
            }
            catch (Exception ex)
            {
                result.Text = ex.Message;
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

        public static bool WriteFile(string path, string vehicle, int price)
        {
            StreamWriter writer = new StreamWriter(path, true);

            try
            {
                writer.WriteLine($"{vehicle};{price}");
            }
            catch (Exception)
            {
                writer.Dispose();
                return false;
            }

            writer.Dispose();
            return true;
        }

        public static void RunResult(DialogResult result, string path)
        {
            try
            {
                if (result == DialogResult.Yes)
                {
                    File.Delete(path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Sikeres törlés", "Törlés", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
