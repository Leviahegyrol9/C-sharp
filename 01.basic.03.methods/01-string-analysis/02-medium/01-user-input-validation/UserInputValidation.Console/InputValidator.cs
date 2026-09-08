using System.Text.RegularExpressions;

namespace UserInputValidation.Console;

public static class InputValidator
{
    /// <summary>
    /// Eldönti, hogy a felhasználónév megfelel-e az alap szabályoknak.
    /// </summary>
    /// <param name="nev">A vizsgált felhasználónév.</param>
    /// <returns>Igaz, ha 3-20 karakter hosszú, betűvel kezdődik, és csak betűt, számjegyet vagy aláhúzást tartalmaz.</returns>
    public static bool ErvenyesFelhasznalonev(string nev)
    {
        if (nev.Length >= 3 && nev.Length <= 20 && char.IsLetter(nev[0]) && (!nev.Any(char.IsSymbol) && !nev.Any(char.IsWhiteSpace))) return true;

        return false;
    }

    /// <summary>
    /// Eldönti, hogy a termékkód formátuma megfelelő-e.
    /// </summary>
    /// <param name="kod">A vizsgált termékkód.</param>
    /// <returns>Igaz, ha pontosan 8 karakterből áll: 2 nagybetűből és 6 számjegyből.</returns>
    public static bool ErvenyesTermekkod(string kod)
    {
        if (kod.Length == 8 && kod.Count(char.IsUpper) == 2 && kod.Count(char.IsDigit) == 6) return true;

        return false;
    }

    /// <summary>
    /// Eldönti, hogy a kuponkód megfelel-e az egyszerű kuponszabálynak.
    /// </summary>
    /// <param name="kod">A vizsgált kuponkód.</param>
    /// <returns>Igaz, ha pontosan 10 karakter hosszú, és csak nagybetűt vagy számjegyet tartalmaz.</returns>
    public static bool ErvenyesKuponkod(string kod)
    {
        if (kod.Length == 10 && kod.All(x => char.IsLetter(x) || char.IsDigit(x))) return true;

        return false;
    }

    /// <summary>
    /// Egyszerű, oktatási célú email-formátum ellenőrzést végez.
    /// </summary>
    /// <param name="email">A vizsgált email cím.</param>
    /// <returns>Igaz, ha pontosan egy @ jelet tartalmaz, az @ előtt és után is van szöveg, az @ után van pont, és nincs benne szóköz.</returns>
    public static bool ErvenyesEmailEgyszeruen(string email)
    {
        return Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
    }

    /// <summary>
    /// Eldönti, hogy a jelszó megfelel-e az egyszerű erősségi feltételeknek.
    /// </summary>
    /// <param name="jelszo">A vizsgált jelszó.</param>
    /// <returns>Igaz, ha legalább 8 karakter hosszú, és tartalmaz kisbetűt, nagybetűt és számjegyet.</returns>
    public static bool ErvenyesEgyszeruJelszo(string jelszo)
    {
        if (jelszo.Length == 8 && jelszo.Any(char.IsLower) && jelszo.Any(char.IsUpper) && jelszo.Any(char.IsDigit)) return true;

        return false;
    }
}
