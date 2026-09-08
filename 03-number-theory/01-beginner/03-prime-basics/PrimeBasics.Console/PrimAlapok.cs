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
    public static bool PrimszamE(int szam) => false;

    /// <summary>
    /// Visszaadja az összes prímszámot 1-től a megadott határig.
    /// </summary>
    /// <param name="veg">A felső határ.</param>
    /// <returns>A megtalált prímszámok listája.</returns>
    public static List<int> GetPrimszamokHatarig(int veg) => [];

    /// <summary>
    /// Visszaadja az első megadott darabszámú prímszámot.
    /// </summary>
    /// <param name="darab">A kért prímszámok darabszáma.</param>
    /// <returns>Az első prímszámok listája.</returns>
    public static List<int> GetElsoNPrim(int darab) => [];

    /// <summary>
    /// Vesszővel elválasztott szöveggé alakít egy egész számokat tartalmazó listát.
    /// </summary>
    /// <param name="lista">A megjelenítendő lista.</param>
    /// <returns>A lista elemei szövegként.</returns>
    public static string KiLista(List<int> lista) => string.Empty;
}
