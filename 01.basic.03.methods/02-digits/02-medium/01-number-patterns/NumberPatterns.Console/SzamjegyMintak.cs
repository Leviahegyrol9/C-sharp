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
        string b = szam.ToString();

        if (b.Length < 2) return false;

        string j = string.Empty;

        List<int> szamok = new List<int>();

        foreach (char c in szam.ToString())
        {
            if (c == '-')
            {
                j = "-";
                continue;
            }
            szamok.Add(int.Parse(c.ToString()));
        }

        szamok.Reverse();

        foreach (int num in szamok)
        {
            j += num.ToString();
        }

        return j == b;
    }

    /// <summary>
    /// Eldönti, hogy a szám számjegyei szigorúan növekvő sorrendben vannak-e.
    /// </summary>
    /// <param name="szam">A vizsgált egész szám.</param>
    /// <returns>Igaz, ha minden számjegy nagyobb az előtte állónál.</returns>
    public static bool NovekvoSzamjegyuE(int szam)
    {
        int temp = 0;

        foreach (char c in szam.ToString())
        {
            if (int.Parse(c.ToString()) > temp) temp = int.Parse(c.ToString());
            else return false;
        }

        return true;
    }

    /// <summary>
    /// Eldönti, hogy a szám számjegyei szigorúan csökkenő sorrendben vannak-e.
    /// </summary>
    /// <param name="szam">A vizsgált egész szám.</param>
    /// <returns>Igaz, ha minden számjegy kisebb az előtte állónál.</returns>
    public static bool CsokkenoSzamjegyuE(int szam)
    {
        int temp = int.MaxValue;

        foreach (char c in szam.ToString())
        {
            if (int.Parse(c.ToString()) < temp) temp = int.Parse(c.ToString());
            else return false;
        }

        return true;
    }

    /// <summary>
    /// Eldönti, hogy a szám minden számjegye azonos-e.
    /// </summary>
    /// <param name="szam">A vizsgált egész szám.</param>
    /// <returns>Igaz, ha a szám legalább kétjegyű, és minden számjegye ugyanaz.</returns>
    public static bool MindenSzamjegyAzonosE(int szam)
    {
        if (szam.ToString().Length < 2) return false;

        char first = szam.ToString().First();

        return !szam.ToString().Any(x => x != first);
    }

    /// <summary>
    /// Eldönti, hogy a szám tartalmazza-e a keresett számjegyet.
    /// </summary>
    /// <param name="szam">A vizsgált egész szám.</param>
    /// <param name="szamjegy">A keresett számjegy 0 és 9 között.</param>
    /// <returns>Igaz, ha a szám tartalmazza a megadott számjegyet.</returns>
    public static bool TartalmazSzamjegyet(int szam, int szamjegy)
    {
        return szam.ToString().Contains(szamjegy.ToString());
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

