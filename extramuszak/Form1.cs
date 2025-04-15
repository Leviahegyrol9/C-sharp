using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace extramuszak
{
    public partial class Form1 : Form
    {
        List<Shift> shifts = new List<Shift>();
        public Form1()
        {
            InitializeComponent();
        }
        private void openFileMenu(object sender, EventArgs e)
        {
            Shift shift = null;

            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                    openFileDialog.Title = "Válaszd ki a fájlt!";
                    openFileDialog.Filter = "Szövegesdokumentum|*.txt";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        statusLabel.Text = Path.GetFileName(openFileDialog.FileName);

                        using (StreamReader sR = new StreamReader(openFileDialog.FileName))
                        {
                            while (!sR.EndOfStream)
                            {
                                string line = sR.ReadLine();
                                string[] datas = line.Split(';');

                                shift = new Shift
                                {
                                    Name = datas[0],
                                    Day = datas[1],
                                    Path = datas[2]
                                };

                                shifts.Add(shift);
                            }
                        }
                    }

                    FillEveryoneCb();
                    FillDaysCb();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void contactMenu(object sender, EventArgs e)
        {
            MessageBox.Show("Paplukács Levente\n11.B", "Névjegy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FillEveryoneCb()
        {
            if (shifts.Count != 0)
            {
                foreach (Shift shift in shifts)
                {
                    everyoneCb.Items.Add($"{shift.Name}: {shift.Day}");
                }
            }
        }
        private void FillDaysCb()
        {
            HashSet<string> days = shifts.Select(shift => shift.Day).ToHashSet();
            Dictionary<string, int> daysAndCount = new Dictionary<string, int>();

            foreach (string day in days)
            {
                daysAndCount[day] = 0;
            }

            foreach (Shift shift in shifts)
            {
                daysAndCount[shift.Day]++;
            }

            foreach (KeyValuePair<string, int> item in daysAndCount)
            {
                daysCb.Items.Add($"{item.Key}: {item.Value}");
            }
        }
        private void daysCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenCb.Items.Clear();
            string selectedDay = daysCb.SelectedItem.ToString();

            List<Shift> people = shifts.Where(line => selectedDay.Contains(line.Day)).ToList();

            foreach (Shift person in people)
            {
                chosenCb.Items.Add(person.Name);
            }
        }
        private void chosenCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = chosenCb.SelectedItem.ToString();

            string path = shifts.Where(shift => shift.Name == selectedName).Single().Path;

            pictureBox1.Image = Image.FromFile($@"{Directory.GetCurrentDirectory()}\images\{path}");
        }
    }
}
