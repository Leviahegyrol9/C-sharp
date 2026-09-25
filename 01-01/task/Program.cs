using CSharpGyakorloFeladatsor;

Console.OutputEncoding = System.Text.Encoding.UTF8;

int sikeres = 0;
int osszes = 0;

void Teszt<T>(string nev, T vart, T kapott)
{
    osszes++;
    bool jo = EqualityComparer<T>.Default.Equals(vart, kapott);
    if (jo) sikeres++;
    Console.WriteLine($"{(jo ? "[OK]" : "[HIBA]")} {nev} | várt: {vart} | kapott: {kapott}");
}

void TombTeszt(string nev, int[] vart, int[] kapott)
{
    osszes++;
    bool jo = vart.SequenceEqual(kapott);
    if (jo) sikeres++;
    Console.WriteLine($"{(jo ? "[OK]" : "[HIBA]")} {nev} | várt: [{string.Join(", ", vart)}] | kapott: [{string.Join(", ", kapott)}]");
}

void Cim(string szoveg)
{
    Console.WriteLine();
    Console.WriteLine(new string('=', 70));
    Console.WriteLine(szoveg);
    Console.WriteLine(new string('=', 70));
}

Cim("KÖNNYŰ FELADATOK");

Teszt("1/A Nagybetűk száma", 3, Feladatok.NagybetukSzama("AlmaFA"));
Teszt("1/B Nagybetűk száma", 0, Feladatok.NagybetukSzama("korte"));
Teszt("1/C Nagybetűk száma", 5, Feladatok.NagybetukSzama("CSharp.NET"));

Teszt("2/A Számjegyek összege", 13, Feladatok.SzamjegyekOsszege(472));
Teszt("2/B Számjegyek összege", 0, Feladatok.SzamjegyekOsszege(0));
Teszt("2/C Számjegyek összege", 25, Feladatok.SzamjegyekOsszege(90709));

Teszt("3/A Határ feletti darab", 2, Feladatok.HatarFelettiDarab([12, 7, 19, 10], 10));
Teszt("3/B Határ feletti darab", 0, Feladatok.HatarFelettiDarab([1, 2, 3], 5));
Teszt("3/C Határ feletti darab", 3, Feladatok.HatarFelettiDarab([-2, 0, 5, 8], -1));

Teszt("4/A Első páros indexe", 2, Feladatok.ElsoParosIndexe([5, 9, 8, 2]));
Teszt("4/B Első páros indexe", 0, Feladatok.ElsoParosIndexe([6, 3, 5]));
Teszt("4/C Első páros indexe", -1, Feladatok.ElsoParosIndexe([1, 3, 5, 7]));

Cim("KÖZEPES FELADATOK");

Teszt("5/A Érvényes termékkód", true, Feladatok.ErvenyesTermekkod("AB-2048"));
Teszt("5/B Érvénytelen: kisbetű", false, Feladatok.ErvenyesTermekkod("Ab-2048"));
Teszt("5/C Érvénytelen: rossz formátum", false, Feladatok.ErvenyesTermekkod("AB2048"));
Teszt("5/D Érvénytelen: nem számjegy", false, Feladatok.ErvenyesTermekkod("AB-20X8"));

Teszt("6/A Legjobb tanuló", "Béla", Feladatok.LegjobbTanulo(["Anna", "Béla", "Csilla"], [72, 91, 85]));
Teszt("6/B Pontegyenlőség esetén első", "Dani", Feladatok.LegjobbTanulo(["Dani", "Erika", "Feri"], [88, 88, 75]));

TombTeszt("7/A Jegyhisztogram", [0, 1, 1, 0, 2], Feladatok.JegyHisztogram([5, 3, 5, 2]));
TombTeszt("7/B Jegyhisztogram", [2, 0, 1, 1, 1], Feladatok.JegyHisztogram([1, 4, 3, 1, 5]));

Cim("NEHÉZ FELADATOK");

int[,] matrix1 =
{
    { 3, 4, 1 },
    { 8, 2, 5 },
    { 6, 6, 1 }
};
Teszt("8/A Legnagyobb összegű sor", 1, Feladatok.LegnagyobbOsszeguSor(matrix1));

int[,] matrix2 =
{
    { 5, 5 },
    { 8, 2 },
    { 1, 1 }
};
Teszt("8/B Azonos maximum esetén első sor", 0, Feladatok.LegnagyobbOsszeguSor(matrix2));

Teszt("9/A Leghosszabb növekvő szakasz", 4, Feladatok.LeghosszabbNovekvoSzakasz([4, 6, 9, 3, 5, 7, 8, 2]));
Teszt("9/B Csökkenő tömb", 1, Feladatok.LeghosszabbNovekvoSzakasz([9, 7, 5, 3]));
Teszt("9/C Teljesen növekvő tömb", 5, Feladatok.LeghosszabbNovekvoSzakasz([1, 2, 4, 8, 16]));

Cim("ÖSSZESÍTÉS");
Console.WriteLine($"Sikeres tesztek: {sikeres}/{osszes}");
Console.WriteLine("A kiinduló projektben a metódusok szándékosan nincsenek megoldva, ezért a hibás tesztek normálisak.");
