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
        public static Dictionary<string, List<string>> CategorizeProducts(List<Product> products)
        {
            Dictionary<string, List<string>> categoriesAndNames = new Dictionary<string, List<string>>
            {
                {"Élelmiszer", new List<string>()},
                {"Vegyiáru", new List<string>()},
                {"Egyéb", new List<string>()}
            };
            HashSet<string> productNames = GetProductNames(products);

            foreach (string productName in productNames)
            {
                int category = Methods.GetNumberWithCondition($"{Methods.CapitalizeFirstLetter(productName)} milyen kategória?\n\n1 - Élelmiszer\n2 - Vegyiáru\n3 - Egyéb\nVálasztás: ", 1, 3);
                string categoryName = GetCategoryName(category);

                categoriesAndNames[categoryName].Add(productName);
            }

            return categoriesAndNames;
        }
        private static HashSet<string> GetProductNames(List<Product> products)
        {
            HashSet<string> productNames = new HashSet<string>();

            foreach (Product product in products)
            {
                productNames.Add(product.Name.ToLower());
            }

            return productNames;
        }

        private static string GetCategoryName(int category)
        {
            switch (category)
            {
                case 1:
                    return "Élelmiszer";

                case 2:
                    return "Vegyiáru";

                default:
                    return "Egyéb";
            }
        }
        public static void AddCategoryName(List<Product> foods, Dictionary<string, List<string>> categoriesAndNames)
        {
            foreach (Product food in foods)
            {
                food.Category = GetCategory(food.Name, categoriesAndNames);
            }

        }

        private static string GetCategory(string foodName, Dictionary<string, List<string>> categoriesAndNames)
        {
            foreach (var item in categoriesAndNames)
            {
                foreach (string name in item.Value)
                {
                    if (name == foodName)
                    {
                        return item.Key;
                    }
                }
            }

            return string.Empty;
        }

        public static bool WriteFile(string path, List<Product> foods)
        {
            StreamWriter writer = new StreamWriter(path);

            try
            {
                foreach (Product food in foods)
                {
                    writer.WriteLine(food);
                }
            }
            catch (Exception)
            {
                writer.Close();
                return false;
            }
            finally
            {
                writer.Close();
            }

            return true;
        }
    }
}
