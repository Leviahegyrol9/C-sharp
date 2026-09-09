namespace NumberCodeAnalysis.Console;

public static class SzamkodVizsgalat
{
    /// <summary>
    /// Eldönti, hogy a kód kizárólag számjegyekből áll-e.
    /// </summary>
    /// <param name="kod">A vizsgált számkód.</param>
    /// <returns>Igaz, ha a kód nem üres, és minden karaktere számjegy.</returns>
    public static bool CsakSzamjegyekbolAllE(string kod)
    {
        return kod.All(char.IsDigit);
    }

    /// <summary>
    /// Eldönti, hogy a kód pontosan a megadott hosszúságú-e.
    /// </summary>
    /// <param name="kod">A vizsgált számkód.</param>
    /// <param name="hossz">Az elvárt hossz.</param>
    /// <returns>Igaz, ha a kód hossza pontosan megegyezik az elvárt hosszal.</returns>
    public static bool MegfeleloHosszusaguKodE(string kod, int hossz)
    {
        return kod.Length == hossz;
    }

    /// <summary>
    /// Eldönti, hogy a kód minden számjegye azonos-e.
    /// </summary>
    /// <param name="kod">A vizsgált számkód.</param>
    /// <returns>Igaz, ha a kód legalább két karakter hosszú, csak számjegyekből áll, és minden számjegye ugyanaz.</returns>
    public static bool AzonosSzamjegyekbolAllE(string kod)
    {
        if (kod.Length < 2 || !kod.All(char.IsDigit)) return false;

        char first = kod.First();

        return !kod.Any(x => x != first);
    }

    /// <summary>
    /// Eldönti, hogy a kód számjegyei szigorúan növekvő sorrendben vannak-e.
    /// </summary>
    /// <param name="kod">A vizsgált számkód.</param>
    /// <returns>Igaz, ha a kód csak számjegyekből áll, és minden számjegy nagyobb az előzőnél.</returns>
    public static bool NovekvoSzamkodE(string kod)
    {
        if (!kod.All(char.IsDigit)) return false;

        int temp = 0;

        foreach (char c in kod)
        {
            if (int.Parse(c.ToString()) > temp) temp = int.Parse(c.ToString());
            else return false;
        }

        return true;
    }

    /// <summary>
    /// Eldönti, hogy a kód számjegyei szigorúan csökkenő sorrendben vannak-e.
    /// </summary>
    /// <param name="kod">A vizsgált számkód.</param>
    /// <returns>Igaz, ha a kód csak számjegyekből áll, és minden számjegy kisebb az előzőnél.</returns>
    public static bool CsokkenoSzamkodE(string kod)
    {
        if (!kod.All(char.IsDigit)) return false;

        int temp = int.MaxValue;

        foreach (char c in kod)
        {
            if (int.Parse(c.ToString()) < temp) temp = int.Parse(c.ToString());
            else return false;
        }

        return true;
    }

    /// <summary>
    /// Eldönti, hogy a kód túl egyszerű mintázatú, ezért gyengének számít-e.
    /// </summary>
    /// <param name="kod">A vizsgált számkód.</param>
    /// <returns>Igaz, ha a kód azonos számjegyekből áll, növekvő számsor vagy csökkenő számsor.</returns>
    public static bool GyengeSzamkodE(string kod)
    {
        return CsakSzamjegyekbolAllE(kod);
    }
}

