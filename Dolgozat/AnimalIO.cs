using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dolgozat
{
    public class AnimalIO
    {
        public static List<Animal> GetAnimals(string path)
        {
            List<Animal> animals = new List<Animal>();
            Animal animal = new Animal();

            try
            {
                string[] lines = File.ReadAllLines(path);

                foreach(string line in lines)
                {
                    string[] datas = line.Split(';');

                    animal = new Animal
                    {
                        Name = datas[0],
                        LatinName = datas[1],
                        Continent = datas[2],
                        Food = datas[3]
                    };

                    animals.Add(animal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return animals;
        }
    }
}
