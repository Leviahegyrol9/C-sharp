using RangeAnalysis.Console;

void Teszt(string cim, object eredmeny, object vartEredmeny)
{
    Console.WriteLine($"{cim}: {eredmeny} (várt: {vartEredmeny})");
}

Teszt("GetPrimszamok(1, 10)", TartomanyElemzes.KiLista(TartomanyElemzes.GetPrimszamok(1, 10)), "2, 3, 5, 7");
Teszt("GetTokeletesek(1, 30)", TartomanyElemzes.KiLista(TartomanyElemzes.GetTokeletesek(1, 30)), "6, 28");
Teszt("GetHianyosSzamok(1, 6)", TartomanyElemzes.KiLista(TartomanyElemzes.GetHianyosSzamok(1, 6)), "1, 2, 3, 4, 5");
Teszt("GetBosegesSzamok(1, 12)", TartomanyElemzes.KiLista(TartomanyElemzes.GetBosegesSzamok(1, 12)), "12");
