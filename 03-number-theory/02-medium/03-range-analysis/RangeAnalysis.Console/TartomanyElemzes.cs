namespace RangeAnalysis.Console;

/// <summary>
/// Számelméleti tulajdonságok tartományon belüli kereséséhez tartozó metódusokat tartalmaz.
/// </summary>
public static class TartomanyElemzes
{
    private static bool PrimszamE(int szam)
    {
        List<int> osztok = new List<int>();

        for (int i = 1; i <= szam; i++)
        {
            if (szam % i == 0) osztok.Add(i);
        }

        return osztok.Count == 2;
    }
    private static int GetSajatOsztokOsszege(int szam)
    {
        List<int> list = new List<int>();

        for (int i = 1; i < szam; i++)
        {
            if (szam % i == 0) list.Add(i);
        }

        return list.Sum();
    }
    private static bool TokeletesE(int szam) => GetSajatOsztokOsszege(szam) == szam;
    private static bool HianyosSzamE(int szam) => GetSajatOsztokOsszege(szam) < szam;
    private static bool BosegesSzamE(int szam) => GetSajatOsztokOsszege(szam) > szam;

    /// <summary>
    /// Visszaadja a megadott tartományban található prímszámokat.
    /// </summary>
    /// <param name="kezdet">A tartomány kezdete.</param>
    /// <param name="veg">A tartomány vége.</param>
    /// <returns>A tartomány prímszámai.</returns>
    public static List<int> GetPrimszamok(int kezdet, int veg)
    {
        List<int> primek = new List<int>();

        for (int i = kezdet; i <= veg; i++)
        {
            if (PrimszamE(i)) primek.Add(i);
        }

        return primek;
    }

    /// <summary>
    /// Visszaadja a megadott tartományban található tökéletes számokat.
    /// </summary>
    /// <param name="kezdet">A tartomány kezdete.</param>
    /// <param name="veg">A tartomány vége.</param>
    /// <returns>A tartomány tökéletes számai.</returns>
    public static List<int> GetTokeletesek(int kezdet, int veg)
    {
        List<int> list = new List<int>();

        for (int i = kezdet; i <= veg; i++)
        {
            if (TokeletesE(i)) list.Add(i);
        }

        return list;
    }

    /// <summary>
    /// Visszaadja a megadott tartományban található hiányos számokat.
    /// </summary>
    /// <param name="kezdet">A tartomány kezdete.</param>
    /// <param name="veg">A tartomány vége.</param>
    /// <returns>A tartomány hiányos számai.</returns>
    public static List<int> GetHianyosSzamok(int kezdet, int veg)
    {
        List<int> list = new List<int>();

        for (int i = kezdet; i <= veg; i++)
        {
            if (HianyosSzamE(i)) list.Add(i);
        }

        return list;
    }

    /// <summary>
    /// Visszaadja a megadott tartományban található bőséges számokat.
    /// </summary>
    /// <param name="kezdet">A tartomány kezdete.</param>
    /// <param name="veg">A tartomány vége.</param>
    /// <returns>A tartomány bőséges számai.</returns>
    public static List<int> GetBosegesSzamok(int kezdet, int veg)
    {
        List<int> list = new List<int>();

        for (int i = kezdet; i <= veg; i++)
        {
            if (BosegesSzamE(i)) list.Add(i);
        }

        return list;
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
