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
            const string fileName = "input.txt";
            const string newFileName = "output.txt";

            List<Product> products = ProductIO.GetProducts(fileName);

            int exchangeRate = Methods.GetNumberWithCondition("Kérem az euró/forint árfolyamot: ", 1, int.MaxValue);

            Dictionary<string, List<string>> categoriesAndNames = ConsoleServices.CategorizeProducts(products);

            ConsoleServices.AddCategoryName(products, categoriesAndNames);

            bool success = ConsoleServices.WriteFile(newFileName, products);
            Methods.CheckSuccess(newFileName, success);

            int food = products.Where(f => f.Category == "Élelmiszer").Sum(p => p.Price);
            int chemical = products.Where(f => f.Category == "Vegyiáru").Sum(p => p.Price);
            int other = products.Where(f => f.Category == "Egyéb").Sum(p => p.Price);

            Console.WriteLine($"Élelmiszer:\n\tHUF: {food:n0}\n\tEUR: {food /exchangeRate:n2}\n");
            Console.WriteLine($"Vegyiáru:\n\tHUF: {chemical:n0}\n\tEUR: {chemical /exchangeRate:n2}\n");
            Console.WriteLine($"Egyéb:\n\tHUF: {other:n0}\n\tEUR: {other /exchangeRate:n2}");

            Console.ReadKey();

            string searchItem = Methods.GetString("Kérem a terméket: ");

            List<Product> searchItems = products.Where(product => product.Name == searchItem).ToList();

            Console.WriteLine("Ezeken a napon történt vásárlás:\n");

            foreach (Product product in searchItems)
            {
                Console.WriteLine(product.Date);
            }

            Console.WriteLine($"\nÖsszesen: {searchItems.Sum(p => p.Price)} HUF");

            Console.ReadKey();
        }
    }
}
