namespace CharChecks.Console;

public static class KarakterVizsgalat
{
    /// <summary>
    /// Eldönti, hogy a karakter magyar vagy angol magánhangzó-e.
    /// </summary>
    /// <param name="c">A vizsgált karakter.</param>
    /// <returns>Igaz, ha a karakter kis- vagy nagybetűs magyar vagy angol magánhangzó.</returns>
    public static bool MaganhangzoE(char c)
    {
        string mgh = "aeuio";
        return mgh.Contains(char.ToLower(c));
    }

    /// <summary>
    /// Eldönti, hogy a karakter mássalhangzó-e.
    /// </summary>
    /// <param name="c">A vizsgált karakter.</param>
    /// <returns>Igaz, ha a karakter betű, de nem magánhangzó.</returns>
    public static bool MassalhangzoE(char c)
    {
        return BetuE(c) && !MaganhangzoE(c);
    }

    /// <summary>
    /// Eldönti, hogy a karakter betű-e.
    /// </summary>
    /// <param name="c">A vizsgált karakter.</param>
    /// <returns>Igaz, ha a karakter betű.</returns>
    public static bool BetuE(char c)
    {
        return char.IsLetter(c);
    }

    /// <summary>
    /// Eldönti, hogy a karakter számjegy-e.
    /// </summary>
    /// <param name="c">A vizsgált karakter.</param>
    /// <returns>Igaz, ha a karakter 0 és 9 közötti számjegy.</returns>
    public static bool SzamjegyE(char c)
    {
        return char.IsDigit(c);
    }

    /// <summary>
    /// Eldönti, hogy a karakter kisbetű-e.
    /// </summary>
    /// <param name="c">A vizsgált karakter.</param>
    /// <returns>Igaz, ha a karakter kisbetű.</returns>
    public static bool KisbetuE(char c)
    {
        return char.IsLower(c);
    }

    /// <summary>
    /// Eldönti, hogy a karakter nagybetű-e.
    /// </summary>
    /// <param name="c">A vizsgált karakter.</param>
    /// <returns>Igaz, ha a karakter nagybetű.</returns>
    public static bool NagybetuE(char c)
    {
        return char.IsUpper(c);
    }

    /// <summary>
    /// Eldönti, hogy a karakter szóköz-e.
    /// </summary>
    /// <param name="c">A vizsgált karakter.</param>
    /// <returns>Igaz, ha a karakter sima szóköz.</returns>
    public static bool SzokozE(char c)
    {
        return char.IsWhiteSpace(c);
    }

    /// <summary>
    /// Eldönti, hogy a karakter gyakori írásjel-e.
    /// </summary>
    /// <param name="c">A vizsgált karakter.</param>
    /// <returns>Igaz, ha a karakter pont, vessző, felkiáltójel, kérdőjel, kettőspont vagy pontosvessző.</returns>
    public static bool IrasjelE(char c)
    {
        return char.IsWhiteSpace(c) && c != ' ';
    }

    /// <summary>
    /// Eldönti, hogy a karakter speciális karakter-e.
    /// </summary>
    /// <param name="c">A vizsgált karakter.</param>
    /// <returns>Igaz, ha a karakter nem betű, nem számjegy, nem szóköz és nem írásjel.</returns>
    public static bool SpecialisKarakterE(char c)
    {
        return char.IsSymbol(c);
    }
}
