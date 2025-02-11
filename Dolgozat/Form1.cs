using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dolgozat
{
    public partial class Form1 : Form
    {
        const string path = "allatok.txt";
        List<Animal> animals = new List<Animal>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            animals = AnimalIO.GetAnimals(path);

            foreach (Animal animal in animals)
            {
                cb1.Items.Add($"{animal.Name} ({animal.Continent}, {animal.Food})");
            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            string food = GetCheckedName(groupBox1);
            string continent = GetCheckedName(groupBox2);

            List<Animal> animalsWithCondition = animals.Where(a => a.Continent == continent && a.Food == food).ToList();

            foreach (Animal animal in animalsWithCondition)
            {
                cb2.Items.Add($"{animal.Name} ({animal.LatinName})");
            }

        }

        private static string GetCheckedName(GroupBox gb)
        {
            foreach (RadioButton radioButton in gb.Controls)
            {
                if (radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }

            return string.Empty;
        }

        private void resultBtn_Click(object sender, EventArgs e)
        {
            cb3.Items.Add(cb2.SelectedItem.ToString());
        }
    }
}
