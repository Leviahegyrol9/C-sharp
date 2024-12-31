using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmek
{
    public class Film
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Distributor { get; set; }
        public int Rate { get; set; }
        public double PayOff { get; set; }
        public int RtRating   { get; set; }
        public double Income { get; set; }
        public int Year { get; set; }

        public Film()
        {
            
        }

        public Film(string name, string genre, string distributor, int rate, double payOff, int rtRating, double income, int year)
        {
            Title = name;
            Genre = genre;
            Distributor = distributor;
            Rate = rate;
            PayOff = payOff;
            RtRating = rtRating;
            Income = income;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Title} {Genre} {Distributor} {Rate} {PayOff} {RtRating} ${Income} {Year}";
        }
    }
}
