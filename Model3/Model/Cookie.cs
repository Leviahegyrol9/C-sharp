using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model3.Model
{
    public class Cookie:Recept
    {
        public int SugarQuantity { get; set; }
        public Cookie(string name, int ingredients, int time, int sugarQuantity) : base(name, ingredients, time)
        {
            SugarQuantity = sugarQuantity;
        }
        public override void AddIngredient()
        {
            base.AddIngredient();
            SugarQuantity += 10;
        }
        public void Diabetes()
        {
            SugarQuantity /= 2;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, cukor mennyisége: {SugarQuantity}";
        }
    }
}