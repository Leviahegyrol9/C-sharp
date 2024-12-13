using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Beolvasas2
{
    public class KlubIO
    {
        public static List<Klub> ReadFile(string fileName)
        {
            List<Klub> klubs = new List<Klub>();

            Klub klub = new Klub();

            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] datas = line.Split('\t');
                
                if (datas.Length == 9)
                {
                    klub = new Klub
                    {
                        Name = datas[0],
                        Number = int.Parse(datas[1]),
                        FirstName = datas[2],
                        LastName = datas[3],
                        BirthDate = DateTime.Parse(datas[4]),
                        HunNationality = int.Parse(datas[5]) == -1 ? true : false,
                        AbrNationality = int.Parse(datas[6]) == -1 ? true : false,
                        Value = int.Parse(datas[7]),
                        Post = datas[8]
                    };
                }
                else
                {
                    klub = new Klub
                    {
                        Name = datas[0],
                        Number = int.Parse(datas[1]),
                        FirstName = datas[2],
                        BirthDate = DateTime.Parse(datas[3]),
                        HunNationality = int.Parse(datas[4]) == -1 ? true : false,
                        AbrNationality = int.Parse(datas[5]) == -1 ? true : false,
                        Value = int.Parse(datas[6]),
                        Post = datas[7]
                    };
                }
                

                klubs.Add(klub);
            }

            return klubs;
        }        
    }
}
