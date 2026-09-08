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
    public static List<int> GetOsztok(int szam) => [];

    /// <summary>
    /// Visszaadja a szám saját osztóit, vagyis az osztókat a szám önmaga nélkül.
    /// </summary>
    /// <param name="szam">A vizsgált szám.</param>
    /// <returns>A saját osztók listája.</returns>
    public static List<int> GetSajatOsztok(int szam) => [];

    /// <summary>
    /// Visszaadja a szám pozitív osztóinak darabszámát.
    /// </summary>
    /// <param name="szam">A vizsgált szám.</param>
    /// <returns>Az osztók száma.</returns>
    public static int GetOsztokSzama(int szam) => 0;

    /// <summary>
    /// Vesszővel elválasztott szöveggé alakít egy egész számokat tartalmazó listát.
    /// </summary>
    /// <param name="lista">A megjelenítendő lista.</param>
    /// <returns>A lista elemei szövegként.</returns>
    public static string KiLista(List<int> lista) => string.Empty;
}
