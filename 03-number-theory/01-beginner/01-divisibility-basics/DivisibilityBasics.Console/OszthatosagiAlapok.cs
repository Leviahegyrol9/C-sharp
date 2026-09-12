namespace DivisibilityBasics.Console;

/// <summary>
/// Egyszerű oszthatósági vizsgálatokat tartalmazó statikus osztály.
/// </summary>
public static class OszthatosagiAlapok
{
    /// <summary>
    /// Eldönti, hogy az osztó maradék nélkül osztja-e a vizsgált számot.
    /// </summary>
    /// <param name="oszto">A lehetséges osztó.</param>
    /// <param name="szam">A vizsgált szám.</param>
    /// <returns>Igaz, ha az osztás maradéka nulla.</returns>
    public static bool OsztoE(int oszto, int szam) => szam % oszto == 0;

    /// <summary>
    /// Eldönti, hogy a szám páros-e.
    /// </summary>
    /// <param name="szam">A vizsgált szám.</param>
    /// <returns>Igaz, ha a szám 2-vel osztva nulla maradékot ad.</returns>
    public static bool ParosE(int szam) => szam % 2 == 0;

    /// <summary>
    /// Eldönti, hogy a szám páratlan-e.
    /// </summary>
    /// <param name="szam">A vizsgált szám.</param>
    /// <returns>Igaz, ha a szám nem páros.</returns>
    public static bool ParatlanE(int szam) => szam % 2 != 0;

    /// <summary>
    /// Eldönti, hogy az osztó mindkét számnak osztója-e.
    /// </summary>
    /// <param name="a">Az első vizsgált szám.</param>
    /// <param name="b">A második vizsgált szám.</param>
    /// <param name="oszto">A lehetséges közös osztó.</param>
    /// <returns>Igaz, ha az osztó mindkét számot maradék nélkül osztja.</returns>
    public static bool KozosOsztoE(int a, int b, int oszto) => a % oszto == 0 && b % oszto == 0;
}
