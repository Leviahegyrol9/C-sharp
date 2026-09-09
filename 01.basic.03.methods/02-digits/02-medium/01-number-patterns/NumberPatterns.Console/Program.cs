using NumberPatterns.Console;

static void TesztBool(string leiras, bool eredmeny)
{
    System.Console.WriteLine($"{leiras}: {(eredmeny ? "IGEN" : "NEM")}");
}

static void TesztInt(string leiras, int eredmeny)
{
    System.Console.WriteLine($"{leiras}: {eredmeny}");
}

System.Console.WriteLine("=== Számjegyminták ===");
System.Console.WriteLine();

TesztBool("PalindromE(1221)", SzamjegyMintak.PalindromE(1221));
TesztBool("PalindromE(7)", SzamjegyMintak.PalindromE(7));
TesztBool("NovekvoSzamjegyuE(1379)", SzamjegyMintak.NovekvoSzamjegyuE(1379));
TesztBool("NovekvoSzamjegyuE(1969)", SzamjegyMintak.NovekvoSzamjegyuE(1969));
TesztBool("CsokkenoSzamjegyuE(9752)", SzamjegyMintak.CsokkenoSzamjegyuE(9752));
TesztBool("CsokkenoSzamjegyuE(2691)", SzamjegyMintak.CsokkenoSzamjegyuE(2691));
TesztBool("MindenSzamjegyAzonosE(5555)", SzamjegyMintak.MindenSzamjegyAzonosE(5555));
TesztBool("MindenSzamjegyAzonosE(2234)", SzamjegyMintak.MindenSzamjegyAzonosE(2234));
TesztBool("TartalmazSzamjegyet(2468, 6)", SzamjegyMintak.TartalmazSzamjegyet(2468, 6));
TesztInt("DigitalisGyok(987)", SzamjegyMintak.DigitalisGyok(987));

