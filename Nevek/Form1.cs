using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nevek
{
    public partial class Form1 : Form
    {
        const string path = "nevek.txt";
        List<string> allNames = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void readFileBtn_Click(object sender, EventArgs e)
        {
            resultCb.Visible = false;
            result.Text = string.Empty;

            List<string> names = ReadFile(path);

            foreach (string name in names)
            {
                namesCb.Items.Add(name);
            }

        }
        private List<string> ReadFile(string path)
        {
            try
            {
                allNames = File.ReadAllLines(path).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return allNames;
        }

        private void resultBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> namesAndCount = GetNamesAndCount(allNames);

            if (namesAndCount.Count != 0)
            {
                foreach (string name in namesAndCount.Keys)
                {
                    resultCb.Items.Add(name);
                }

                resultCb.Visible = true;

                result.Text = $"Egyedi: {namesAndCount.Count} db.";
            }
        }

        private Dictionary<string, int> GetNamesAndCount(List<string> allNames)
        {
            Dictionary<string, int> namesAndCount = new Dictionary<string, int>();
            HashSet<string> names = GetNames(allNames);

            foreach (string name in names)
            {
                namesAndCount[name] = 0;
            }

            foreach (string name in allNames)
            {
                namesAndCount[name]++;
            }

            Dictionary<string, int> sorted = namesAndCount.OrderBy(name => name.Key).ToDictionary(k => k.Key, v => v.Value);

            return sorted;
        }

        private HashSet<string> GetNames(List<string> allNames)
        {
            HashSet<string> names = new HashSet<string>();

            foreach (string name in allNames)
            {
                names.Add(name);
            }

            return names;
        }
    }
}
