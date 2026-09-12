namespace DivisorLists.Console;

/// <summary>
/// Osztók és saját osztók listázásához tartozó metódusokat tartalmaz.
/// </summary>
public static class OsztoListak
{
    /// <summary>
    /// Visszaadja a szám pozitív osztóit növekvő sorrendben.
    /// </summary>
    /// <param name="szam">A vizsgált szám.</param>
    /// <returns>A szám pozitív osztóinak listája.</returns>
    public static List<int> GetOsztok(int szam)
    {
        List<int> osztok = [];

        for (int i = 1; i <= szam; i++)
        {
            if (szam % i == 0)
            {
                osztok.Add(i);
            }
        }

        return osztok;
    }

    /// <summary>
    /// Visszaadja a szám saját osztóit, vagyis az osztókat a szám önmaga nélkül.
    /// </summary>
    /// <param name="szam">A vizsgált szám.</param>
    /// <returns>A saját osztók listája.</returns>
    public static List<int> GetSajatOsztok(int szam)
    {
        List<int> osztok = [];

        for (int i = 1; i < szam; i++)
        {
            if (szam % i == 0)
            {
                osztok.Add(i);
            }
        }

        return osztok;
    }

    /// <summary>
    /// Visszaadja a szám pozitív osztóinak darabszámát.
    /// </summary>
    /// <param name="szam">A vizsgált szám.</param>
    /// <returns>Az osztók száma.</returns>
    public static int GetOsztokSzama(int szam) => GetOsztok(szam).Count;

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
            text += $"{i},";
        }

        return text.Substring(0, text.Length - 1);
    }
}
