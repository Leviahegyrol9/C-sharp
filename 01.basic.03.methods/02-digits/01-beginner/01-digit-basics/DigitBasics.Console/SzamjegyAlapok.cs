namespace DigitBasics.Console;

public static class SzamjegyAlapok
{
    /// <summary>
    /// Eldönti, hogy a szám abszolút értékben egyjegyű-e.
    /// </summary>
    /// <param name="szam">A vizsgált egész szám.</param>
    /// <returns>Igaz, ha a szám -9 és 9 közé esik.</returns>
    public static bool EgyjegyuE(int szam)
    {
        return szam.ToString().Length == 1;
    }

    /// <summary>
    /// Eldönti, hogy a szám abszolút értékben legalább kétjegyű-e.
    /// </summary>
    /// <param name="szam">A vizsgált egész szám.</param>
    /// <returns>Igaz, ha a szám abszolút értéke legalább 10.</returns>
    public static bool LegalabbKetjegyu(int szam)
    {
        return szam.ToString().Length >= 2;
    }

    /// <summary>
    /// Eldönti, hogy a szám pozitív-e.
    /// </summary>
    /// <param name="szam">A vizsgált egész szám.</param>
    /// <returns>Igaz, ha a szám nagyobb mint 0.</returns>
    public static bool PozitivE(int szam)
    {
        return szam > 0;
    }

    /// <summary>
    /// Eldönti, hogy a szám negatív-e.
    /// </summary>
    /// <param name="szam">A vizsgált egész szám.</param>
    /// <returns>Igaz, ha a szám kisebb mint 0.</returns>
    public static bool NegativE(int szam)
    {
        return szam < 0;
    }

    /// <summary>
    /// Visszaadja a szám utolsó számjegyét.
    /// </summary>
    /// <param name="szam">A vizsgált egész szám.</param>
    /// <returns>A szám utolsó számjegye pozitív számjegyként.</returns>
    public static int UtolsoSzamjegy(int szam)
    {
        return szam.ToString().Last();
    }

    /// <summary>
    /// Visszaadja a szám első számjegyét.
    /// </summary>
    /// <param name="szam">A vizsgált egész szám.</param>
    /// <returns>A szám első számjegye pozitív számjegyként.</returns>
    public static int ElsoSzamjegy(int szam)
    {
        return szam.ToString().First();
    }

    /// <summary>
    /// Visszaadja, hogy a szám abszolút értéke hány számjegyből áll.
    /// </summary>
    /// <param name="szam">A vizsgált egész szám.</param>
    /// <returns>A számjegyek száma. A 0 egy számjegyű számnak számít.</returns>
    public static int SzamjegyekSzama(int szam)
    {
        return szam.ToString().Length;
    }
}

