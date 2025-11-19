using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model3.Model
{
    public class Soup:Recept
    {
        public int WaterQuantity { get; set; }
        public Soup(string name, int ingredients, int time, int waterQuantity) : base(name, ingredients, time)
        {
            WaterQuantity = waterQuantity;
        }
        public override void AddTime(int minute)
        {
            base.AddTime(minute);
            int minus = (minute / 5) * 10;
            WaterQuantity -= minus;
            if (WaterQuantity < 0) WaterQuantity = 0;
        }
        public void AddWater(int water)
        {
           WaterQuantity += water;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, vízmennyiség: {WaterQuantity}ml";
        }
    }
}