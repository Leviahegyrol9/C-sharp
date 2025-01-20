using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bevásárlás
{
    public class FoodIO
    {
        public static List<Food> GetFoods(string fileName)
        {
            List<Food> foods = new List<Food>();
            Food food = new Food();

            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] datas = line.Split(';');

                food = new Food
                {
                    Date = DateTime.Parse(datas[0]),
                    Name = datas[1],
                    Price = int.Parse(datas[2])
                };

                foods.Add(food);
            }

            return foods;
        }
    }
}
