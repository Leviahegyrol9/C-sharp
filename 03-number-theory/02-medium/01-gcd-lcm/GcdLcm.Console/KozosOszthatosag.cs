namespace GcdLcm.Console;

/// <summary>
/// Közös osztókkal, LNKO-val, LKKT-vel és relatív prímekkel kapcsolatos metódusokat tartalmaz.
/// </summary>
public static class KozosOszthatosag
{
    /// <summary>
    /// Kiszámítja két szám legnagyobb közös osztóját.
    /// </summary>
    /// <param name="a">Az első szám.</param>
    /// <param name="b">A második szám.</param>
    /// <returns>A legnagyobb közös osztó.</returns>
    public static int LegnagyobbKozosOszto(int a, int b) => 0;

    /// <summary>
    /// Kiszámítja két szám legkisebb közös többszörösét.
    /// </summary>
    /// <param name="a">Az első szám.</param>
    /// <param name="b">A második szám.</param>
    /// <returns>A legkisebb közös többszörös.</returns>
    public static int LegkisebbKozosTobbszoros(int a, int b) => 0;

    /// <summary>
    /// Eldönti, hogy két szám relatív prím-e.
    /// </summary>
    /// <param name="a">Az első szám.</param>
    /// <param name="b">A második szám.</param>
    /// <returns>Igaz, ha a két szám LNKO-ja 1.</returns>
    public static bool RelativPrimekE(int a, int b) => false;

    /// <summary>
    /// Visszaadja két szám közös pozitív osztóit.
    /// </summary>
    /// <param name="a">Az első szám.</param>
    /// <param name="b">A második szám.</param>
    /// <returns>A közös osztók listája.</returns>
    public static List<int> GetKozosOsztok(int a, int b) => [];

    /// <summary>
    /// Vesszővel elválasztott szöveggé alakít egy egész számokat tartalmazó listát.
    /// </summary>
    /// <param name="lista">A megjelenítendő lista.</param>
    /// <returns>A lista elemei szövegként.</returns>
    public static string KiLista(List<int> lista) => string.Empty;
}
