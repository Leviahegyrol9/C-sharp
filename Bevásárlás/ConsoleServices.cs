using Function;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bevásárlás
{
    public class ConsoleServices
    {
        public static HashSet<string> GetFoodNames(List<Food> foods)
        {
            HashSet<string> foodNames = new HashSet<string>();

            foreach (Food food in foods)
            {
                foodNames.Add(food.Name);
            }

            return foodNames;
        }

        public static Dictionary<string, List<string>> CategorizeFoods(HashSet<string> foodNames)
        {
            Dictionary<string, List<string>> categoriesAndNames = new Dictionary<string, List<string>>
            {
                {"Élelmiszer", new List<string>()},
                {"Vegyiáru", new List<string>()},
                {"Egyéb", new List<string>()}
            };

            foreach (string foodName in foodNames)
            {
                int category = Methods.GetNumberWithCondition($"{Methods.CapitalizeFirstLetter(foodName)} milyen kategória?\n1 - Élelmiszer\n2 - Vegyiáru\n3 - Egyéb\nVálasztás: ", 1, 3);
                string categoryName = GetCategoryName(category);

                categoriesAndNames[categoryName].Add(foodName);
            }

            return categoriesAndNames;
        }
        private static string GetCategoryName(int category)
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

        public static List<Food> GetFoodAndCategory(List<Food> foods, HashSet<string> foodNames)
        {
            List<Food> foodWithCategory = new List<Food>();

            foreach (Food food in foods)
            {
                food.Category = GetCategory(food.Name);
            }

            return foodWithCategory;
        }

        private static string GetCategory(string foodName, Dictionary<string, List<string>> categoriesAndNames)
        {
            foreach (var item in categoriesAndNames)
            {

            }
        }

        public static bool WriteFile(string path, List<Food> foods)
        {
            StreamWriter writer = new StreamWriter(path);

            try
            {
                foreach (Food food in foods)
                {

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
