using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Model;

namespace IO
{
    public static class PersonIO
    {
        public static List<Model.Person> ReadFile(string path)
        {
            List<Model.Person> diakok = new List<Model.Person>();

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] datas = line.Split('\t');

                Model.Person diak = new Model.Person
                {
                    Name = datas[0],
                    Present1 = datas[1],
                    Present2 = datas[2]
                };

                diakok.Add(diak);
            }

            return diakok;
        }

    }
}
