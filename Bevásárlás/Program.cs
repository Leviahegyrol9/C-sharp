using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Function;

namespace Bevásárlás
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string fileName = "foods.txt";

            List<Food> foods = FoodIO.GetFoods(fileName);

            int exchangeRate = Methods.GetNumberWithCondition("Kérem az euró/forint árfolyamot: ", 1, int.MaxValue);

            HashSet<string> foodNames = ConsoleServices.GetFoodName(foods);

            Dictionary<string, List<string>> categoriesAndNames = new Dictionary<string, List<string>>
            {
                {"Élelmiszer", new List<string>()},
                {"Vegyiáru", new List<string>()},
                {"Egyéb", new List<string>()}
            };

            ConsoleServices.CategorizeFoods(foodNames, categoriesAndNames);

        }
    }
}
