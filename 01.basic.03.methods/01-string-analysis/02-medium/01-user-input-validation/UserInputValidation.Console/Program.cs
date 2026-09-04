using UserInputValidation.Console;

static void Teszt(string leiras, bool eredmeny)
{
    System.Console.WriteLine($"{leiras}: {(eredmeny ? "IGEN" : "NEM")}");
}

System.Console.WriteLine("=== Input validáció ===");
System.Console.WriteLine();

Teszt("ErvenyesFelhasznalonev(\"anna_01\")", InputValidator.ErvenyesFelhasznalonev("anna_01"));
Teszt("ErvenyesFelhasznalonev(\"1anna\")", InputValidator.ErvenyesFelhasznalonev("1anna"));
Teszt("ErvenyesTermekkod(\"AB123456\")", InputValidator.ErvenyesTermekkod("AB123456"));
Teszt("ErvenyesKuponkod(\"SAVE2026AA\")", InputValidator.ErvenyesKuponkod("SAVE2026AA"));
Teszt("ErvenyesEmailEgyszeruen(\"user@example.com\")", InputValidator.ErvenyesEmailEgyszeruen("user@example.com"));
Teszt("ErvenyesEgyszeruJelszo(\"Almafa12\")", InputValidator.ErvenyesEgyszeruJelszo("Almafa12"));
