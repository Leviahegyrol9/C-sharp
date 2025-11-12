using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dolgozo> lista = new List<Dolgozo>
            {
                new IrodaiDolgozo("Kis Péter","ID123",450000,"Pénzügy"),
                new IrodaiDolgozo("Nagy Péter","ID234",550000,"Számvitel"),
                new FizikaiDolgozo("Tóth Tamás","ID456",670000,"nappali"),
                new FizikaiDolgozo("Tóth Tibor","ID678",770000,"éjszakai"),
            };
            foreach(var i in lista)
            {
                i.KiirInformacio();
                if(i is IrodaiDolgozo irodai)
                {
                    irodai.Dolgozik();
                }
                if(i is FizikaiDolgozo fizikai)
                {
                    fizikai.Dolgozik();
                }
                Console.WriteLine();
            }
        }
    }
}
