using CSharpGyakorloFeladatsor;

Console.WriteLine("01-02 – C# gyakorló feladatsor\n");

Teszt("1. Páros számjegyek száma", Feladatok.ParosSzamjegyekSzama(583204), 3);
Teszt("2. Karakter előfordulása", Feladatok.KarakterDarab("programozas", 'o'), 2);
Teszt("3. Negatív számok összege", Feladatok.NegativakOsszege([4, -3, 8, -5, -2]), -10);
Teszt("4. Utolsó pozitív szám indexe", Feladatok.UtolsoPozitivIndexe([-2, 5, -1, 8, 0, -3]), 3);
Teszt("5. Felhasználónév ellenőrzése", Feladatok.ErvenyesFelhasznalonev("anna_25"), true);
Teszt("6. Legolcsóbb termék", Feladatok.LegolcsobbTermek(["Eger", "Billentyuzet", "Pendrive"], [6500, 8900, 4200]), "Pendrive");
TesztTomb("7. Pontszámok kategorizálása", Feladatok.PontKategoriak([42, 75, 91, 63, 80, 30]), [2, 1, 1, 2]);
Teszt("8. Második legnagyobb különböző", Feladatok.MasodikLegnagyobbKulonbozo([12, 7, 18, 5, 18, 14]), 14);
Teszt("9. Legnagyobb összegű oszlop", Feladatok.LegnagyobbOsszeguOszlop(new int[,] { { 3, 8, 1 }, { 4, 2, 7 }, { 2, 5, 3 } }), 1);
Teszt("10. Leghosszabb azonos szakasz", Feladatok.LeghosszabbAzonosSzakasz([2, 2, 5, 5, 5, 1, 3, 3]), 3);

static void Teszt<T>(string nev, T kapott, T vart)
{
    bool jo = EqualityComparer<T>.Default.Equals(kapott, vart);
    Console.WriteLine($"{(jo ? "[OK]" : "[HIBA]")} {nev} | kapott: {kapott} | várt: {vart}");
}

static void TesztTomb(string nev, int[] kapott, int[] vart)
{
    bool jo = kapott.SequenceEqual(vart);
    Console.WriteLine($"{(jo ? "[OK]" : "[HIBA]")} {nev} | kapott: [{string.Join(", ", kapott)}] | várt: [{string.Join(", ", vart)}]");
}
