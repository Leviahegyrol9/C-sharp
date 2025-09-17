using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Könyvek
{
    public class Book
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Producer { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public string Theme { get; set; }
        public int PageNum { get; set; }
        public int Honorarium { get; set; }

        public Book()
        {
            
        }
        public override string ToString()
        {
            return $"{LastName};{FirstName};{BirthDay};{Title};{ISBN};{Producer};{Year};{Price};{Theme};{PageNum};{Honorarium}";
        }
    }
}
