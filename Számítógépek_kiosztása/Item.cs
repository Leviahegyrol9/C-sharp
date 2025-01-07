using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Számítógépek_kiosztása
{
    public class Item
    {
        public string SerialNumber { get; set; }
        public string InvNumber { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public string Status { get; set; }

        public Item()
        {
            
        }

        public Item(string serialNumber, string invNumber, string type, int price, string status)
        {
            SerialNumber = serialNumber;
            InvNumber = invNumber;
            Type = type;
            Price = price;
            Status = status;
        }

        public override string ToString()
        {
            return $"{SerialNumber} {InvNumber} {Type} {Status} {Price}";
        }
    }
}
