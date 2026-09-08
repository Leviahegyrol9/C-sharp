using GcdLcm.Console;

void Teszt(string cim, object eredmeny, object vartEredmeny)
{
    Console.WriteLine($"{cim}: {eredmeny} (várt: {vartEredmeny})");
}

Teszt("LegnagyobbKozosOszto(12, 18)", KozosOszthatosag.LegnagyobbKozosOszto(12, 18), 6);
Teszt("LegkisebbKozosTobbszoros(4, 6)", KozosOszthatosag.LegkisebbKozosTobbszoros(4, 6), 12);
Teszt("RelativPrimekE(8, 15)", KozosOszthatosag.RelativPrimekE(8, 15), true);
Teszt("GetKozosOsztok(12, 18)", KozosOszthatosag.KiLista(KozosOszthatosag.GetKozosOsztok(12, 18)), "1, 2, 3, 6");
