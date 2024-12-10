using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Diak.IO
{
    public static class DiakIO
    {
        public static List<Model.Diak> ReadFile(string path)
        {
            List<Model.Diak> diakok = new List<Model.Diak>();

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] datas = line.Split('\t');

                Model.Diak diak = new Model.Diak
                {
                    Name = datas[0],
                    Average = double.Parse(datas[1])
                };

                diakok.Add(diak);
            }

            return diakok;
        }

    }
}
