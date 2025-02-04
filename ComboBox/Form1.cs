using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ComboBoxFeladat
{
    public partial class Form1 : Form
    {
        const string path = "megfigyelt.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            if (input.Text == string.Empty || !input.Text.Replace(" ", "").All(char.IsLetter))
            {
                MessageBox.Show("Írj be valamit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                list.Items.Add(input.Text.Trim());
                input.Text = string.Empty;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void writeBTN_Click(object sender, EventArgs e)
        {
            bool success = WriteFile();

            if (success) MessageBox.Show($"{path} állomány sikeresen létrehozva!", "FileWrite", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show($"{path} állományt nem sikerült létrehozni!", "FileWrite", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool WriteFile()
        {
            StreamWriter writer = new StreamWriter(path);
            try
            {
                foreach (string name in list.Items)
                {
                    writer.WriteLine(name);
                }
            }
            catch (Exception)
            {
                writer.Dispose();
                return false;
            }
            finally
            {
                writer.Dispose();
            }

            return true;
        }

        private void readBTN_Click(object sender, EventArgs e)
        {
            List<string> names = ReadFile();

            if (names.Count != 0)
            {
                for (int i = 0; i < list.Items.Count; i++)
                {
                    list.Items.Remove(list.Items[i]);
                }

                foreach (string name in names)
                {
                    list.Items.Add(name);
                }
            }
        }

        private List<string> ReadFile()
        {
            List<string> lines = new List<string>();
            try
            {
                lines = File.ReadAllLines(path).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FileRead", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lines;
        }

        private void topBirdBtn_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBox1.Controls)
            {
                groupBox1.Controls.Remove(control);
            }

            Dictionary<string, int> birdsAndCounts = GetBirdsAndCounts(list);

            if (birdsAndCounts.Count != 0)
            {
                int counter = 0;

                foreach (var item in birdsAndCounts)
                {
                    System.Windows.Forms.RadioButton radioButton = new System.Windows.Forms.RadioButton
                    {
                        Text = item.Key,
                        Location = new Point(10, 25 + counter * 25),
                        AutoSize = true
                    };

                    groupBox1.Controls.Add(radioButton);

                    counter++;
                }

                var topBird = birdsAndCounts.Where(count => count.Value == birdsAndCounts.Max(m => m.Value)).First();

                output.Text = $"Leggyakoribb madár a(z) {topBird.Key}: {topBird.Value}";
            }

        }
        private Dictionary<string, int> GetBirdsAndCounts(ComboBox cb)
        {
            Dictionary<string, int> birdsAndCounts = new Dictionary<string, int>();
            HashSet<string> birdNames = GetBirdNames(cb);

            foreach (string name in birdNames)
            {
                birdsAndCounts[name] = 0;
            }

            foreach (string name in cb.Items)
            {
                birdsAndCounts[name]++;
            }

            Dictionary<string, int> sortedDict = birdsAndCounts.OrderByDescending(v => v.Value).ToDictionary(k => k.Key, v => v.Value);

            return sortedDict;
        }
        private HashSet<string> GetBirdNames(ComboBox cb)
        {
            HashSet<string> birdNames = new HashSet<string>();

            foreach (string name in cb.Items)
            {
                birdNames.Add(name);
            }

            return birdNames;
        }
    }
}
