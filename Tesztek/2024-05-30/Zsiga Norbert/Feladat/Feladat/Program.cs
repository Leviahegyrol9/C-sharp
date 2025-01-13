List<Champion> champions = new List<Champion>
{
    new Arwen("Arwen"),
    new Galadriel("Galadriel"),
    new Tauriel("Tauriel"),
    new Eowyn("Eowyn"),
    new Lurtz("Lurtz")
};

int randomSzam = 0;
Random rnd = new Random();
for (int i = 0; i < 10; i++)
{
    randomSzam = rnd.Next(0, 4);

    if (champions[randomSzam].Attack(champions[4]))
    {
        Console.WriteLine($"{i}. kör: {champions[randomSzam]} nyert");
    }
    else
    {
        Console.WriteLine($"{i}. kör: {champions[4]} nyert");
    }
}

