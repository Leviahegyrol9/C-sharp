using Önálló.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Önálló
{
    public class OwnerIO
    {
        public static List<Owner> GetOwners(string fileName)
        {
            List<Owner> owners = new List<Owner>();
            Owner owner = null;

            try
            {
                string[] lines = File.ReadAllLines(fileName);

                foreach (string line in lines.Skip(1))
                {
                    string[] datas = line.Split(';');

                    owner = new Owner
                    (
                        int.Parse(datas[0]),
                        datas[1],
                        DateTime.Parse(datas[2]),
                        datas[3],
                        datas[4]
                    );

                    owners.Add(owner);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Environment.Exit(0);
            }

            return owners;
        }
    }
}