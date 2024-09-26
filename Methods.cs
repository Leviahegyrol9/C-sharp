using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orarend_keszito
{
    public class Methods
    {
        public string CapitalizeFirstLetter(string text)
        {
            text = char.ToUpper(text[0]) + text.Substring(1);
            return text;
        }
    }
}
