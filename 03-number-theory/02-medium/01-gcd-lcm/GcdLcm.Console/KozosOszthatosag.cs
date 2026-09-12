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
    public static int LegnagyobbKozosOszto(int a, int b)
    {
        while (b != 0)
        {
            int maradek = a % b;
            a = b;
            b = maradek;
        }

        return a;
    }

    /// <summary>
    /// Kiszámítja két szám legkisebb közös többszörösét.
    /// </summary>
    /// <param name="a">Az első szám.</param>
    /// <param name="b">A második szám.</param>
    /// <returns>A legkisebb közös többszörös.</returns>
    public static int LegkisebbKozosTobbszoros(int a, int b) => a * b / LegnagyobbKozosOszto(a, b);

    /// <summary>
    /// Eldönti, hogy két szám relatív prím-e.
    /// </summary>
    /// <param name="a">Az első szám.</param>
    /// <param name="b">A második szám.</param>
    /// <returns>Igaz, ha a két szám LNKO-ja 1.</returns>
    public static bool RelativPrimekE(int a, int b) => LegnagyobbKozosOszto(a, b) == 1;

    /// <summary>
    /// Visszaadja két szám közös pozitív osztóit.
    /// </summary>
    /// <param name="a">Az első szám.</param>
    /// <param name="b">A második szám.</param>
    /// <returns>A közös osztók listája.</returns>
    public static List<int> GetKozosOsztok(int a, int b)
    {
        List<int> osztok = [];

        for (int i = 1; i <= a; i++)
        {
            if (a % i == 0) osztok.Add(i);
        }

        List<int> kozos = [];

        foreach (int oszto in osztok)
        {
            if (b % oszto == 0) kozos.Add(oszto);
        }

        return kozos;
    }

    /// <summary>
    /// Vesszővel elválasztott szöveggé alakít egy egész számokat tartalmazó listát.
    /// </summary>
    /// <param name="lista">A megjelenítendő lista.</param>
    /// <returns>A lista elemei szövegként.</returns>
    public static string KiLista(List<int> lista)
    {
        string text = string.Empty;

        foreach (int i in lista)
        {
            text += $"{i}, ";
        }

        return text.Substring(0, text.Length - 2);
    }
}
