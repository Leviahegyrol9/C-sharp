using NumberClassification.Console;

void Teszt(string cim, object eredmeny, object vartEredmeny)
{
    Console.WriteLine($"{cim}: {eredmeny} (várt: {vartEredmeny})");
}

Teszt("GetSajatOsztokOsszege(6)", SzamBesorolas.GetSajatOsztokOsszege(6), 6);
Teszt("TokeletesE(6)", SzamBesorolas.TokeletesE(6), true);
Teszt("HianyosSzamE(10)", SzamBesorolas.HianyosSzamE(10), true);
Teszt("BosegesSzamE(12)", SzamBesorolas.BosegesSzamE(12), true);
Teszt("SzamTipusa(28)", SzamBesorolas.SzamTipusa(28), "tökéletes");
