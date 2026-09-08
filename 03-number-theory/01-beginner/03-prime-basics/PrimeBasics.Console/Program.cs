using PrimeBasics.Console;

void Teszt(string cim, object eredmeny, object vartEredmeny)
{
    Console.WriteLine($"{cim}: {eredmeny} (várt: {vartEredmeny})");
}

Teszt("PrimszamE(7)", PrimAlapok.PrimszamE(7), true);
Teszt("PrimszamE(9)", PrimAlapok.PrimszamE(9), false);
Teszt("GetPrimszamokHatarig(10)", PrimAlapok.KiLista(PrimAlapok.GetPrimszamokHatarig(10)), "2, 3, 5, 7");
Teszt("GetElsoNPrim(5)", PrimAlapok.KiLista(PrimAlapok.GetElsoNPrim(5)), "2, 3, 5, 7, 11");
