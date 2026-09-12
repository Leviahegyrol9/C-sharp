namespace PrimeBasics.Console;

/// <summary>
/// Prímszámok vizsgálatához és gyűjtéséhez tartozó metódusokat tartalmaz.
/// </summary>
public static class PrimAlapok
{
    /// <summary>
    /// Eldönti, hogy a szám prímszám-e.
    /// </summary>
    /// <param name="szam">A vizsgált szám.</param>
    /// <returns>Igaz, ha a számnak pontosan két pozitív osztója van.</returns>
    public static bool PrimszamE(int szam)
    {
        List<int> osztok = new List<int>();

        for (int i = 1; i <= szam; i++)
        {
            if (szam % i == 0) osztok.Add(i);
        }

        return osztok.Count == 2;
    }


    /// <summary>
    /// Visszaadja az összes prímszámot 1-től a megadott határig.
    /// </summary>
    /// <param name="veg">A felső határ.</param>
    /// <returns>A megtalált prímszámok listája.</returns>
    public static List<int> GetPrimszamokHatarig(int veg)
    {
        List<int> primek = new List<int>();

        for (int i = 1;i <= veg; i++)
        {
            if (PrimszamE(i)) primek.Add(i);
        }

        return primek;
    }

    /// <summary>
    /// Visszaadja az első megadott darabszámú prímszámot.
    /// </summary>
    /// <param name = "darab" > A kért prímszámok darabszáma.</param>
    /// <returns>Az első prímszámok listája.</returns>
    public static List<int> GetElsoNPrim(int darab)
    {
        List<int> primek = new List<int>();

        for (int i = 1; i <= int.MaxValue; i++)
        {
            if (PrimszamE(i)) primek.Add(i);
            if (primek.Count == darab) break;
        }

        return primek;

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
