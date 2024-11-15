using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "befizetesek.txt";  // A fájl neve

        // A fájl beolvasása
        string[] lines = File.ReadAllLines(filePath);  // Minden sor beolvasása

        // Tömbök a nevekre és a befizetett összegekre
        double[] amounts = new double[lines.Length];  // Befizetett összegek
        string[] names = new string[lines.Length];    // Kirándulók nevei

        double totalAmount = 0;  // Az összes befizetett pénz összege

        // A fájl sorainak feldolgozása
        for (int i = 0; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(';');  // Sor felbontása névre és összegre
            names[i] = parts[0].Trim();            // Kiránduló neve
            amounts[i] = Convert.ToDouble(parts[1].Trim());  // Befizetett összeg
            totalAmount += amounts[i];  // Összesítés
        }

        // Kimenet: A befizetések listája és az összes összeg
        Console.WriteLine("A befizetések listája:");
        for (int i = 0; i < lines.Length; i++)
        {
            Console.WriteLine($"{names[i]}: {amounts[i]:C2}");
        }
        Console.WriteLine($"\nÖsszes befizetés: {totalAmount:C2}");

        // A legnagyobb befizetés meghatározása
        var (maxAmount, maxIndex) = FindMaxAmount(amounts);

        // Kimenet: A legnagyobb befizetés és annak tulajdonosa
        Console.WriteLine($"A legnagyobb befizetés: {names[maxIndex]}: {maxAmount:C2}");

        var (minAmount, minIndex) = FindMinAmount(amounts);
        Console.WriteLine($"A legkisebb befizetés: {names[minIndex]}: {minAmount:C2}");

        Console.ReadKey();
    }

    // A legnagyobb befizetés megtalálása
    static (double, int) FindMaxAmount(double[] amounts)
    {
        double maxAmount = amounts[0];
        int maxIndex = 0;

        for (int i = 1; i < amounts.Length; i++)
        {
            if (amounts[i] > maxAmount)
            {
                maxAmount = amounts[i];
                maxIndex = i;
            }
        }

        return (maxAmount, maxIndex);
    }

    static (double, int) FindMinAmount(double[] amounts)
    {
        double minAmount = amounts[0];
        int minIndex = 0;

        for (int i = 1; i < amounts.Length; i++)
        {
            if (amounts[i] < minAmount)
            {
                minAmount = amounts[i];
                minIndex = i;
            }
        }

        return (minAmount, minIndex);
    }
}