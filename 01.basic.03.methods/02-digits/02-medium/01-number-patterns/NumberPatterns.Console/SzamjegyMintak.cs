namespace NumberPatterns.Console;

public static class SzamjegyMintak
{
    /// <summary>
    /// Eldönti, hogy a szám palindrom-e.
    /// </summary>
    /// <param name="szam">A vizsgált egész szám.</param>
    /// <returns>Igaz, ha a szám legalább kétjegyű, és balról-jobbról olvasva ugyanaz.</returns>
    public static bool PalindromE(int szam)
    {
        return false;
    }

    /// <summary>
    /// Eldönti, hogy a szám számjegyei szigorúan növekvő sorrendben vannak-e.
    /// </summary>
    /// <param name="szam">A vizsgált egész szám.</param>
    /// <returns>Igaz, ha minden számjegy nagyobb az előtte állónál.</returns>
    public static bool NovekvoSzamjegyuE(int szam)
    {
        return false;
    }

    /// <summary>
    /// Eldönti, hogy a szám számjegyei szigorúan csökkenő sorrendben vannak-e.
    /// </summary>
    /// <param name="szam">A vizsgált egész szám.</param>
    /// <returns>Igaz, ha minden számjegy kisebb az előtte állónál.</returns>
    public static bool CsokkenoSzamjegyuE(int szam)
    {
        return false;
    }

    /// <summary>
    /// Eldönti, hogy a szám minden számjegye azonos-e.
    /// </summary>
    /// <param name="szam">A vizsgált egész szám.</param>
    /// <returns>Igaz, ha a szám legalább kétjegyű, és minden számjegye ugyanaz.</returns>
    public static bool MindenSzamjegyAzonosE(int szam)
    {
        return false;
    }

    /// <summary>
    /// Eldönti, hogy a szám tartalmazza-e a keresett számjegyet.
    /// </summary>
    /// <param name="szam">A vizsgált egész szám.</param>
    /// <param name="szamjegy">A keresett számjegy 0 és 9 között.</param>
    /// <returns>Igaz, ha a szám tartalmazza a megadott számjegyet.</returns>
    public static bool TartalmazSzamjegyet(int szam, int szamjegy)
    {
        return false;
    }

    /// <summary>
    /// Kiszámolja a szám digitális gyökét.
    /// </summary>
    /// <param name="szam">A vizsgált egész szám.</param>
    /// <returns>Az ismételt számjegyösszeg egyjegyű eredménye.</returns>
    public static int DigitalisGyok(int szam)
    {
        return 0;
    }
}

