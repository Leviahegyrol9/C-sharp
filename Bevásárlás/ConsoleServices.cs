using Function;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bevásárlás
{
    public class ConsoleServices
    {
        public static HashSet<string> GetFoodName(List<Food> foods)
        {
            HashSet<string> foodNames = new HashSet<string>();

            foreach (Food food in foods)
            {
                foodNames.Add(food.Name);
            }

            return foodNames;
        }

        public static void CategorizeFoods(HashSet<string> foodNames, Dictionary<string, List<string>> categoriesAndNames)
        {
            foreach (string foodName in foodNames)
            {
                int category = Methods.GetNumberWithCondition($"{Methods.CapitalizeFirstLetter(foodName)} milyen kategória?\n1 - Élelmiszer\n2 - Vegyiáru\n3 - Egyéb\nVálasztás: ", 1, 3);
                string categoryName = GetCategory(category);

                categoriesAndNames[categoryName].Add(foodName);
            }
        }
        private static string GetCategory(int category)
        {
            switch (category)
            {
                case 1:
                    return "Élelmiszer";

                case 2:
                    return "Vegyuiáru";

                default:
                    return "Egyéb";
            }
        }
    }
}
