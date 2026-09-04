using CharChecks.Console;

static void Teszt(string leiras, bool eredmeny)
{
    System.Console.WriteLine($"{leiras}: {(eredmeny ? "IGEN" : "NEM")}");
}

System.Console.WriteLine("=== Karaktervizsgálat ===");
System.Console.WriteLine();

Teszt("MaganhangzoE('a')", KarakterVizsgalat.MaganhangzoE('a'));
Teszt("MaganhangzoE('B')", KarakterVizsgalat.MaganhangzoE('B'));
Teszt("MassalhangzoE('b')", KarakterVizsgalat.MassalhangzoE('b'));
Teszt("BetuE('Á')", KarakterVizsgalat.BetuE('Á'));
Teszt("SzamjegyE('7')", KarakterVizsgalat.SzamjegyE('7'));
Teszt("KisbetuE('x')", KarakterVizsgalat.KisbetuE('x'));
Teszt("NagybetuE('X')", KarakterVizsgalat.NagybetuE('X'));
Teszt("SzokozE(' ')", KarakterVizsgalat.SzokozE(' '));
Teszt("IrasjelE('?')", KarakterVizsgalat.IrasjelE('?'));
Teszt("SpecialisKarakterE('@')", KarakterVizsgalat.SpecialisKarakterE('@'));

