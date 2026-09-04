using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKT2
{
    public class Mark
    {
        public string Subject { get; set; }
        public List<int> Marks { get; set; }

        public Mark()
        {
            
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
