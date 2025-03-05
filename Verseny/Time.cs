using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verseny
{
    public class Time
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public string FormatedTime => $"{Hour}:{Minute}";

        public Time()
        {
            
        }
        public Time(int hour, int minute)
        {
            Hour = hour;
            Minute = minute;
        }
    }
}
