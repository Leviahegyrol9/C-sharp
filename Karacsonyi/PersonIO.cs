using Model;
using System.Collections.Generic;
using System.IO;

namespace IO
{
    public static class PersonIO
    {
        public static List<Person> ReadFile(string path)
        {
            List<Person> diakok = new List<Person>();

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] datas = line.Split('\t');

                Person diak = new Person
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
