using DivisibilityBasics.Console;

void Teszt(string cim, object eredmeny, object vartEredmeny)
{
    Console.WriteLine($"{cim}: {eredmeny} (várt: {vartEredmeny})");
}

Teszt("OsztoE(3, 12)", OszthatosagiAlapok.OsztoE(3, 12), true);
Teszt("OsztoE(5, 12)", OszthatosagiAlapok.OsztoE(5, 12), false);
Teszt("ParosE(8)", OszthatosagiAlapok.ParosE(8), true);
Teszt("ParatlanE(7)", OszthatosagiAlapok.ParatlanE(7), true);
Teszt("KozosOsztoE(12, 18, 6)", OszthatosagiAlapok.KozosOsztoE(12, 18, 6), true);
