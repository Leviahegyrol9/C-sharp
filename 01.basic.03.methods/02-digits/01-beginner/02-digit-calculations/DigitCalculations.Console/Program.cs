using DigitCalculations.Console;

static void Teszt(string leiras, int eredmeny)
{
    System.Console.WriteLine($"{leiras}: {eredmeny}");
}

System.Console.WriteLine("=== Számjegy számítások ===");
System.Console.WriteLine();

Teszt("SzamjegyekOsszege(123)", SzamjegySzamitasok.SzamjegyekOsszege(123));
Teszt("SzamjegyekSzorzata(234)", SzamjegySzamitasok.SzamjegyekSzorzata(234));
Teszt("ForditottSzam(-450)", SzamjegySzamitasok.ForditottSzam(-450));
Teszt("LegnagyobbSzamjegy(7291)", SzamjegySzamitasok.LegnagyobbSzamjegy(7291));
Teszt("LegkisebbSzamjegy(7291)", SzamjegySzamitasok.LegkisebbSzamjegy(7291));
Teszt("ParosSzamjegyekSzama(24681)", SzamjegySzamitasok.ParosSzamjegyekSzama(24681));
Teszt("ParatlanSzamjegyekSzama(24681)", SzamjegySzamitasok.ParatlanSzamjegyekSzama(24681));

