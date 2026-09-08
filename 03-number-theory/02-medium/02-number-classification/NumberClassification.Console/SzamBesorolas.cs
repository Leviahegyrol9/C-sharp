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
    public static int GetOsztokOsszege(int szam) => 0;

    /// <summary>
    /// Visszaadja a szám saját osztóinak összegét.
    /// </summary>
    /// <param name="szam">A vizsgált szám.</param>
    /// <returns>A saját osztók összege.</returns>
    public static int GetSajatOsztokOsszege(int szam) => 0;

    /// <summary>
    /// Eldönti, hogy a szám tökéletes szám-e.
    /// </summary>
    /// <param name="szam">A vizsgált szám.</param>
    /// <returns>Igaz, ha a saját osztók összege megegyezik a számmal.</returns>
    public static bool TokeletesE(int szam) => false;

    /// <summary>
    /// Eldönti, hogy a szám hiányos szám-e.
    /// </summary>
    /// <param name="szam">A vizsgált szám.</param>
    /// <returns>Igaz, ha a saját osztók összege kisebb a számnál.</returns>
    public static bool HianyosSzamE(int szam) => false;

    /// <summary>
    /// Eldönti, hogy a szám bőséges szám-e.
    /// </summary>
    /// <param name="szam">A vizsgált szám.</param>
    /// <returns>Igaz, ha a saját osztók összege nagyobb a számnál.</returns>
    public static bool BosegesSzamE(int szam) => false;

    /// <summary>
    /// Visszaadja a szám típusát osztóösszeg alapján.
    /// </summary>
    /// <param name="szam">A vizsgált szám.</param>
    /// <returns>A szám típusa: hiányos, tökéletes vagy bőséges.</returns>
    public static string SzamTipusa(int szam) => string.Empty;
}
