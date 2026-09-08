using DivisorLists.Console;

void Teszt(string cim, object eredmeny, object vartEredmeny)
{
    Console.WriteLine($"{cim}: {eredmeny} (várt: {vartEredmeny})");
}

Teszt("GetOsztok(12)", OsztoListak.KiLista(OsztoListak.GetOsztok(12)), "1, 2, 3, 4, 6, 12");
Teszt("GetSajatOsztok(12)", OsztoListak.KiLista(OsztoListak.GetSajatOsztok(12)), "1, 2, 3, 4, 6");
Teszt("GetOsztokSzama(12)", OsztoListak.GetOsztokSzama(12), 6);
