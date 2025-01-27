using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        DateTime startTime;
        DateTime endTime;
        bool isNumber;
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "FMT", "data.txt");
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;

            result.Text = string.Empty;
            progressBar.Value = 0;

            isNumber = GetMotorHp();
            
            if (isNumber)
            {
                progressBar.Value += 50;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string folderPath = $"{desktopPath}/FMT";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }

        private void end_Click(object sender, EventArgs e)
        {
            endTime = DateTime.Now;

            if (isNumber && motorHP.Text != string.Empty && progressBar.Value < 100)
            {
                Clipboard.SetText($"Állapot: {motorHP.Text}%\nKi: {startTime.ToShortTimeString()}\nBe: {endTime.ToShortTimeString()}");
                motorHP.Text = string.Empty;
                progressBar.Value += 50;
                result.Text = "Vágólapra másolva!";
            }
        }
        private bool GetMotorHp()
        {
            bool isNumber = int.TryParse(motorHP.Text, out int value);

            if (!isNumber)
            {
                result.Text = "Nem számot adtál meg!";
                return false;
            }
            else if (value < 0 || value > 100)
            {
                result.Text = "0 és 100 között add meg!";
                return false;
            }
            else
            {
                return true;
            }

        }

        private void CashClear_Click(object sender, EventArgs e)
        {
            string appDataLocal = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            string fiveMPath = Path.Combine(appDataLocal, "FiveM", "FiveM.app", "data");

            bool success = ClearCache(fiveMPath);

            result.Text = $"A törlés {(success ? "sikerült" : "nem sikerült")}!";

        }

        private static bool ClearCache(string fiveMPath)
        {
            try
            {
                Directory.Delete($"{fiveMPath}/cache", true);
                Directory.Delete($"{fiveMPath}/server-cache", true);
                Directory.Delete($"{fiveMPath}/server-cache-priv", true);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string vehicle = vehicles.SelectedItem.ToString();

            string price = priceBox.Text;

            bool success = AppServices.WriteFile(path, vehicle, price);

            result.Text = $"Elem {(success ? "sikeresen" : "nem lett")} hozzáadva!";
        }

        private void summaryBTN_Click(object sender, EventArgs e)
        {
            List<Vehicle> vehciles = AppServices.GetVehicles(path);
            Dictionary<string, int> namesAndPrice = AppServices.GetNamesAndPrice(vehciles);

            string text = string.Empty;

            foreach (var item in namesAndPrice)
            {
                text += $"{item.Key}: {item.Value}\n";
            }

            Clipboard.SetText(text);
            result.Text = "Vágólapra másolva!";
        }
    }
}
