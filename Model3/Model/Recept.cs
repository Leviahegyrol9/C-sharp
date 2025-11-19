using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model3.Model
{
    public class Recept
    {
        public string Name { get; set; }
        public int Ingredients { get; set; }
        public int Time { get; set; }

        public Recept(string name, int ingredients, int time)
        {
            Name = name;
            Ingredients = ingredients;
            Time = time;
        }

        public virtual void AddIngredient()
        {
            Ingredients++;
        } 
        public virtual void AddTime(int minute)
        {
            Time += minute;
        }

        public override string ToString()
        {
            return $"Recept: {Name}, Hozzávalók: {Ingredients} db, Idő: {Time} perc";
        }
    }
}
