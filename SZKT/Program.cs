using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SZKT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> tram1 = new List<string>();
            int tram1Time = 17;
            List<string> tram2 = new List<string>() { "Vértó", "Bálint Sándor utca", "Rókusi víztorony", "Szatymazu utca", "Vásárhelyi Pál út", "Damjanich utca", "Tavasz utca", "Rókusi templom", "Anna-kút", "Széchenyi tér", "Somogyi utca", "Aradi vértanúk tere", "Bécsi krt.", "Bem utca", "Szeged vá." };
            int tram2Time = 18;
            List<string> tram3 = new List<string>();
            int tram3Time = 17;
            List<string> tram3F = new List<string>();
            int tram3FTime = 17;
            List<string> tram4 = new List<string>() { "Szalámigyár", "Szabadkai út", "Vám tér", "Szivárvány kitérő", "Vitéz utca", "Dugonics tér", "Tisza Lajos krt. (Károlyi u.)", "Anna-kút", "Glattfelder Gyula tér", "Szent György tér", "Brüsszeli krt.", "Kecskeméti utca", "Rózsa utca", "Deák Ferenc Gimnázium", "Budapesti krt.", "Tarján"};
            int tram4Time = 16;

            Console.WriteLine($"A 1-es villamos átlagosan {AverageCalculate(tram1, tram1Time)} perc alatt ér egy megállóhoz.");
            Console.WriteLine($"A 2-es villamos átlagosan {AverageCalculate(tram2, tram2Time)} perc alatt ér egy megállóhoz.");
            Console.WriteLine($"A 3-as villamos átlagosan {AverageCalculate(tram3, tram3Time)} perc alatt ér egy megállóhoz.");
            Console.WriteLine($"A 3F villamos átlagosan {AverageCalculate(tram3F, tram3FTime)} perc alatt ér egy megállóhoz.");
            Console.WriteLine($"A 4-es villamos átlagosan {AverageCalculate(tram4, tram4Time)} perc alatt ér egy megállóhoz.");

            Console.ReadKey();
        }

        static double AverageCalculate(List<string> tram, int time)
        {
            return (double) time / tram.Count();
        }
    }
}
