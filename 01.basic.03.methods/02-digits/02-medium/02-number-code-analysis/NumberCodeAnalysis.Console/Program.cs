using NumberCodeAnalysis.Console;

static void Teszt(string leiras, bool eredmeny)
{
    System.Console.WriteLine($"{leiras}: {(eredmeny ? "IGEN" : "NEM")}");
}

System.Console.WriteLine("=== Számkód vizsgálat ===");
System.Console.WriteLine();

Teszt("CsakSzamjegyekbolAllE(\"0123\")", SzamkodVizsgalat.CsakSzamjegyekbolAllE("0123"));
Teszt("MegfeleloHosszusaguKodE(\"0123\", 4)", SzamkodVizsgalat.MegfeleloHosszusaguKodE("0123", 4));
Teszt("AzonosSzamjegyekbolAllE(\"1111\")", SzamkodVizsgalat.AzonosSzamjegyekbolAllE("1111"));
Teszt("NovekvoSzamkodE(\"1234\")", SzamkodVizsgalat.NovekvoSzamkodE("1234"));
Teszt("CsokkenoSzamkodE(\"4321\")", SzamkodVizsgalat.CsokkenoSzamkodE("4321"));
Teszt("GyengeSzamkodE(\"1111\")", SzamkodVizsgalat.GyengeSzamkodE("1111"));
Teszt("GyengeSzamkodE(\"5831\")", SzamkodVizsgalat.GyengeSzamkodE("5831"));

