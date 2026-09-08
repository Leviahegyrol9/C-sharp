namespace StringChecks.Console;

public static class SzovegVizsgalat
{
    /// <summary>
    /// Eldönti, hogy a szöveg tartalmaz-e legalább egy magyar vagy angol magánhangzót.
    /// </summary>
    /// <param name="szoveg">A vizsgált szöveg.</param>
    /// <returns>Igaz, ha van benne legalább egy magánhangzó, különben hamis.</returns>
    public static bool TartalmazMaganhangzot(string szoveg)
    {
        string mgh = "aeioöuüáéíóőúű";

        foreach (char letter in mgh)
        {
            if (szoveg.Contains(char.ToLower(letter))) return true;
        }
        
        return false;
    }

    /// <summary>
    /// Eldönti, hogy a szöveg kizárólag betűkből áll-e.
    /// </summary>
    /// <param name="szoveg">A vizsgált szöveg.</param>
    /// <returns>Igaz, ha a szöveg nem üres és minden karaktere betű.</returns>
    public static bool CsakBetuketTartalmaz(string szoveg)
    {
        return szoveg.All(char.IsLetter);
    }

    /// <summary>
    /// Eldönti, hogy a szöveg kizárólag számjegyekből áll-e.
    /// </summary>
    /// <param name="szoveg">A vizsgált szöveg.</param>
    /// <returns>Igaz, ha a szöveg nem üres és minden karaktere számjegy.</returns>
    public static bool CsakSzamjegyeketTartalmaz(string szoveg)
    {
        return szoveg.All(char.IsDigit);
    }

    /// <summary>
    /// Eldönti, hogy a szöveg tartalmaz-e legalább egy számjegyet.
    /// </summary>
    /// <param name="szoveg">A vizsgált szöveg.</param>
    /// <returns>Igaz, ha van benne legalább egy számjegy.</returns>
    public static bool TartalmazSzamjegyet(string szoveg)
    {
        return szoveg.Any(char.IsDigit);
    }

    /// <summary>
    /// Eldönti, hogy a szöveg tartalmaz-e legalább egy nagybetűt.
    /// </summary>
    /// <param name="szoveg">A vizsgált szöveg.</param>
    /// <returns>Igaz, ha van benne legalább egy nagybetű.</returns>
    public static bool TartalmazNagybetut(string szoveg)
    {
        return szoveg.Any(char.IsUpper);
    }

    /// <summary>
    /// Eldönti, hogy a szöveg tartalmaz-e legalább egy kisbetűt.
    /// </summary>
    /// <param name="szoveg">A vizsgált szöveg.</param>
    /// <returns>Igaz, ha van benne legalább egy kisbetű.</returns>
    public static bool TartalmazKisbetut(string szoveg)
    {
        return szoveg.Any(char.IsLower);
    }

    /// <summary>
    /// Eldönti, hogy a szöveg tartalmaz-e legalább egy szóközt.
    /// </summary>
    /// <param name="szoveg">A vizsgált szöveg.</param>
    /// <returns>Igaz, ha van benne legalább egy szóköz karakter.</returns>
    public static bool TartalmazSzokozt(string szoveg)
    {
        return szoveg.Any(char.IsWhiteSpace);
    }

    /// <summary>
    /// Eldönti, hogy a szöveg tartalmaz-e legalább egy gyakori írásjelet.
    /// </summary>
    /// <param name="szoveg">A vizsgált szöveg.</param>
    /// <returns>Igaz, ha van benne pont, vessző, felkiáltójel, kérdőjel, kettőspont vagy pontosvessző.</returns>
    public static bool TartalmazIrasjelet(string szoveg)
    {
        return szoveg.Any(char.IsPunctuation);
    }

    /// <summary>
    /// Eldönti, hogy a szöveg tartalmaz-e legalább egy speciális karaktert.
    /// </summary>
    /// <param name="szoveg">A vizsgált szöveg.</param>
    /// <returns>Igaz, ha van benne olyan karakter, amely nem betű, nem számjegy, nem szóköz és nem írásjel.</returns>
    public static bool TartalmazSpecialisKaraktert(string szoveg)
    {
        return szoveg.Any(x => char.IsSymbol(x) || x == '@');
    }
}
