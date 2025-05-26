using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Képválasztó
{
    public class ImageClass
    {
        public string Source { get; set; }

        public string Name => Path.GetFileNameWithoutExtension(Source);

        public ImageClass()
        {
            
        }
    }
}
