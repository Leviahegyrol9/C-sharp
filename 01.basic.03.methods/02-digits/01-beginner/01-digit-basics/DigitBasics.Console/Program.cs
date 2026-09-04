using DigitBasics.Console;

static void TesztBool(string leiras, bool eredmeny)
{
    System.Console.WriteLine($"{leiras}: {(eredmeny ? "IGEN" : "NEM")}");
}

static void TesztInt(string leiras, int eredmeny)
{
    System.Console.WriteLine($"{leiras}: {eredmeny}");
}

System.Console.WriteLine("=== Számjegy alapok ===");
System.Console.WriteLine();

TesztBool("EgyjegyuE(7)", SzamjegyAlapok.EgyjegyuE(7));
TesztBool("EgyjegyuE(-7)", SzamjegyAlapok.EgyjegyuE(-7));
TesztBool("LegalabbKetjegyu(42)", SzamjegyAlapok.LegalabbKetjegyu(42));
TesztBool("PozitivE(10)", SzamjegyAlapok.PozitivE(10));
TesztBool("NegativE(-3)", SzamjegyAlapok.NegativE(-3));
TesztInt("UtolsoSzamjegy(-347)", SzamjegyAlapok.UtolsoSzamjegy(-347));
TesztInt("ElsoSzamjegy(-347)", SzamjegyAlapok.ElsoSzamjegy(-347));
TesztInt("SzamjegyekSzama(1205)", SzamjegyAlapok.SzamjegyekSzama(1205));

