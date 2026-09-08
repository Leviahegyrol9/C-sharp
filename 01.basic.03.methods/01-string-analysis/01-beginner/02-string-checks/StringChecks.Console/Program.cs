using StringChecks.Console;

static void Teszt(string leiras, bool eredmeny)
{
    System.Console.WriteLine($"{leiras}: {(eredmeny ? "IGEN" : "NEM")}");
}

System.Console.WriteLine("=== Szövegvizsgálat ===");
System.Console.WriteLine();

Teszt("TartalmazMaganhangzot(\"kutya\")", SzovegVizsgalat.TartalmazMaganhangzot("kutya"));
Teszt("CsakBetuketTartalmaz(\"Alma\")", SzovegVizsgalat.CsakBetuketTartalmaz("Alma"));
Teszt("CsakBetuketTartalmaz(\"Alma1\")", SzovegVizsgalat.CsakBetuketTartalmaz("Alma1"));
Teszt("CsakSzamjegyeketTartalmaz(\"12345\")", SzovegVizsgalat.CsakSzamjegyeketTartalmaz("12345"));
Teszt("TartalmazSzamjegyet(\"alma1\")", SzovegVizsgalat.TartalmazSzamjegyet("alma1"));
Teszt("TartalmazNagybetut(\"almaFa\")", SzovegVizsgalat.TartalmazNagybetut("almaFa"));
Teszt("TartalmazSpecialisKaraktert(\"alma@\")", SzovegVizsgalat.TartalmazSpecialisKaraktert("alma@"));
