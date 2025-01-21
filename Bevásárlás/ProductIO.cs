using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bevásárlás
{
    public class ProductIO
    {
        public static List<Product> GetProducts(string fileName)
        {
            List<Product> products = new List<Product>();
            Product product = new Product();

            try
            {
                string[] lines = File.ReadAllLines(fileName);

                foreach (string line in lines.Skip(1))
                {
                    string[] datas = line.Split(';');

                    product = new Product
                    {
                        Date = DateTime.Parse(datas[0]),
                        Name = datas[1],
                        Price = int.Parse(datas[2]),
                        Category = string.Empty
                    };

                    products.Add(product);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Environment.Exit(0);
            }
            
            return products;
        }
    }
}
