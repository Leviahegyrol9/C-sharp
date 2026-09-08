namespace RangeAnalysis.Console;

/// <summary>
/// Számelméleti tulajdonságok tartományon belüli kereséséhez tartozó metódusokat tartalmaz.
/// </summary>
public static class TartomanyElemzes
{
    /// <summary>
    /// Visszaadja a megadott tartományban található prímszámokat.
    /// </summary>
    /// <param name="kezdet">A tartomány kezdete.</param>
    /// <param name="veg">A tartomány vége.</param>
    /// <returns>A tartomány prímszámai.</returns>
    public static List<int> GetPrimszamok(int kezdet, int veg) => [];

    /// <summary>
    /// Visszaadja a megadott tartományban található tökéletes számokat.
    /// </summary>
    /// <param name="kezdet">A tartomány kezdete.</param>
    /// <param name="veg">A tartomány vége.</param>
    /// <returns>A tartomány tökéletes számai.</returns>
    public static List<int> GetTokeletesek(int kezdet, int veg) => [];

    /// <summary>
    /// Visszaadja a megadott tartományban található hiányos számokat.
    /// </summary>
    /// <param name="kezdet">A tartomány kezdete.</param>
    /// <param name="veg">A tartomány vége.</param>
    /// <returns>A tartomány hiányos számai.</returns>
    public static List<int> GetHianyosSzamok(int kezdet, int veg) => [];

    /// <summary>
    /// Visszaadja a megadott tartományban található bőséges számokat.
    /// </summary>
    /// <param name="kezdet">A tartomány kezdete.</param>
    /// <param name="veg">A tartomány vége.</param>
    /// <returns>A tartomány bőséges számai.</returns>
    public static List<int> GetBosegesSzamok(int kezdet, int veg) => [];

    /// <summary>
    /// Vesszővel elválasztott szöveggé alakít egy egész számokat tartalmazó listát.
    /// </summary>
    /// <param name="lista">A megjelenítendő lista.</param>
    /// <returns>A lista elemei szövegként.</returns>
    public static string KiLista(List<int> lista) => string.Empty;
}
