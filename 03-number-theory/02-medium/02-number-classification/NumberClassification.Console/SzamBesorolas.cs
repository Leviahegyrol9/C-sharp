namespace NumberClassification.Console;

/// <summary>
/// Számok osztóösszeg alapján történő besorolásához tartozó metódusokat tartalmaz.
/// </summary>
public static class SzamBesorolas
{
    /// <summary>
    /// Visszaadja a szám pozitív osztóinak összegét.
    /// </summary>
    /// <param name="szam">A vizsgált szám.</param>
    /// <returns>Az osztók összege.</returns>
    public static int GetOsztokOsszege(int szam)
    {
        List<int> list = new List<int>();

        for (int i = 1; i <= szam; i++)
        {
            if (szam % i ==0) list.Add(i);
        }

        return list.Sum();
    }

    /// <summary>
    /// Visszaadja a szám saját osztóinak összegét.
    /// </summary>
    /// <param name="szam">A vizsgált szám.</param>
    /// <returns>A saját osztók összege.</returns>
    public static int GetSajatOsztokOsszege(int szam)
    {
        List<int> list = new List<int>();

        for (int i = 1; i < szam; i++)
        {
            if (szam % i == 0) list.Add(i);
        }

        return list.Sum();
    }

    /// <summary>
    /// Eldönti, hogy a szám tökéletes szám-e.
    /// </summary>
    /// <param name="szam">A vizsgált szám.</param>
    /// <returns>Igaz, ha a saját osztók összege megegyezik a számmal.</returns>
    public static bool TokeletesE(int szam) => GetSajatOsztokOsszege(szam) == szam;

    /// <summary>
    /// Eldönti, hogy a szám hiányos szám-e.
    /// </summary>
    /// <param name="szam">A vizsgált szám.</param>
    /// <returns>Igaz, ha a saját osztók összege kisebb a számnál.</returns>
    public static bool HianyosSzamE(int szam) => GetSajatOsztokOsszege(szam) < szam;

    /// <summary>
    /// Eldönti, hogy a szám bőséges szám-e.
    /// </summary>
    /// <param name="szam">A vizsgált szám.</param>
    /// <returns>Igaz, ha a saját osztók összege nagyobb a számnál.</returns>
    public static bool BosegesSzamE(int szam) => GetSajatOsztokOsszege(szam) > szam;

    /// <summary>
    /// Visszaadja a szám típusát osztóösszeg alapján.
    /// </summary>
    /// <param name="szam">A vizsgált szám.</param>
    /// <returns>A szám típusa: hiányos, tökéletes vagy bőséges.</returns>
    public static string SzamTipusa(int szam)
    {
        if (TokeletesE(szam)) return "Tökéletes";
        else if (HianyosSzamE(szam)) return "Hiányos";
        else if (BosegesSzamE(szam)) return "Bőséges";
        else return "Egyik sem";
    }
}
