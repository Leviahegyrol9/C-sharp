using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bevásárlás
{
    public class Food
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public Food()
        {
            
        }
        public Food(DateTime date, string name, int price, string category)
        {
            Date = date;
            Name = name;
            Price = price;
            Category = category;
        }
        public override string ToString()
        {
            return $"{Date};{Name};{Price};{Category}";
        }
    }
}
