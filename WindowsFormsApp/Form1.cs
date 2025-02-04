using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        DateTime startTime;
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "FMT", "data.txt");
        public Form1()
        {
            InitializeComponent();           
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            string folderPath = $"{desktopPath}/FMT";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (progressBar.Value != 50)
            {
                startTime = DateTime.Now;
                              
                result.Text = string.Empty;
                progressBar.Value = 0;

                bool isNumber = AppServices.GetMotorHp(motorHP, result);

                if (isNumber)
                {
                    progressBar.Value += 50;
                    motorHP.ReadOnly = true;
                }
            }     
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            DateTime endTime = DateTime.Now;

            if (progressBar.Value == 50)
            {
                Clipboard.SetText($"Állapot: {motorHP.Text}%\nKi: {startTime.ToShortTimeString()}\nBe: {endTime.ToShortTimeString()}");
                progressBar.Value += 50;
                result.Text = "Vágólapra másolva!";
                motorHP.Text = string.Empty;
                motorHP.ReadOnly = false;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            DialogResult resultD = MessageBox.Show("Biztosan kitörlöd a temp mappát?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultD == DialogResult.Yes)
            {
                string appDataLocal = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

                string fiveMPath = Path.Combine(appDataLocal, "FiveM", "FiveM.app", "data");

                AppServices.ClearCache(fiveMPath);
            }       
        }  
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (priceBox.Text == string.Empty || vehiclesCb.SelectedItem == null)
            {
                result.Text = "Add meg az adatokat!";
            }
            else if (!int.TryParse(priceBox.Text, out int num))
            {
                result.Text = "Nem számot adott meg!";
                priceBox.Text = string.Empty;
            }
            else
            {
                string vehicle = vehiclesCb.SelectedItem.ToString();

                priceBox.Text = string.Empty;

                bool success = AppServices.WriteFile(path, vehicle, num);

                result.Text = $"Elem {(success ? "sikeresen" : "nem lett")} hozzáadva!";
            }           
        }

        private void summaryBtn_Click(object sender, EventArgs e)
        {
            List<Vehicle> vehicles = AppServices.GetVehicles(path, result);

            if (vehicles.Count != 0)
            {
                Dictionary<string, int> namesAndPrice = AppServices.GetNamesAndPrice(vehicles);

                string text = string.Empty;

                foreach (var item in namesAndPrice)
                {
                    text += $"{item.Key}: {item.Value}$\n";
                }

                text += $"Összesen: {namesAndPrice.Sum(p => p.Value)}$";

                Clipboard.SetText(text);
                result.Text = "Vágólapra másolva!";

                DialogResult resultD = MessageBox.Show("Szeretnéd törölni az adatokat?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultD == DialogResult.Yes) AppServices.RunResult(resultD, path);
            }        
        }
    }
}
