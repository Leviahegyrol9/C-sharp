namespace DigitCalculations.Console;

public static class SzamjegySzamitasok
{
    /// <summary>
    /// Kiszámolja a szám abszolút értékének számjegyösszegét.
    /// </summary>
    /// <param name="szam">A vizsgált egész szám.</param>
    /// <returns>A számjegyek összege.</returns>
    public static int SzamjegyekOsszege(int szam)
    {
        int sum = 0;

        foreach (char c in szam.ToString())
        {
            sum += int.Parse(c.ToString());
        }

        return sum;
    }

    /// <summary>
    /// Kiszámolja a szám abszolút értékének számjegyszorzatát.
    /// </summary>
    /// <param name="szam">A vizsgált egész szám.</param>
    /// <returns>A számjegyek szorzata.</returns>
    public static int SzamjegyekSzorzata(int szam)
    {
        int sum = 1;

        foreach (char c in szam.ToString())
        {
            sum *= int.Parse(c.ToString());
        }

        return sum; ;
    }

    /// <summary>
    /// Megfordítja a szám számjegyeinek sorrendjét.
    /// </summary>
    /// <param name="szam">A vizsgált egész szám.</param>
    /// <returns>A fordított szám. Negatív szám esetén az eredmény is negatív.</returns>
    public static int ForditottSzam(int szam)
    {
        string text = string.Empty;

        List<int> szamok = new List<int>();

        foreach (char c in szam.ToString())
        {
            if (c == '-')
            {
                text = "-";
                continue;
            }
            szamok.Add(int.Parse(c.ToString()));
        }

        szamok.Reverse();

        foreach (int num in szamok)
        {
            text += num.ToString();
        }

        return int.Parse(text);
    }

    /// <summary>
    /// Megkeresi a szám legnagyobb számjegyét.
    /// </summary>
    /// <param name="szam">A vizsgált egész szám.</param>
    /// <returns>A legnagyobb számjegy.</returns>
    public static int LegnagyobbSzamjegy(int szam)
    {
        int max = 0;

        foreach(char c in szam.ToString())
        {
            if (max < int.Parse(c.ToString())) max = int.Parse(c.ToString());
        }

        return max;
    }

    /// <summary>
    /// Megkeresi a szám legkisebb számjegyét.
    /// </summary>
    /// <param name="szam">A vizsgált egész szám.</param>
    /// <returns>A legkisebb számjegy.</returns>
    public static int LegkisebbSzamjegy(int szam)
    {
        int min = int.MaxValue;

        foreach (char c in szam.ToString())
        {
            if (min > int.Parse(c.ToString())) min = int.Parse(c.ToString());
        }

        return min;
    }

    /// <summary>
    /// Megszámolja a páros számjegyeket.
    /// </summary>
    /// <param name="szam">A vizsgált egész szám.</param>
    /// <returns>A páros számjegyek darabszáma.</returns>
    public static int ParosSzamjegyekSzama(int szam)
    {
        int counter = 0;

        foreach (int c in szam.ToString())
        {
            if (int.Parse(c.ToString()) % 2 == 0) counter++;
        }

        return counter;
    }

    /// <summary>
    /// Megszámolja a páratlan számjegyeket.
    /// </summary>
    /// <param name="szam">A vizsgált egész szám.</param>
    /// <returns>A páratlan számjegyek darabszáma.</returns>
    public static int ParatlanSzamjegyekSzama(int szam)
    {
        int counter = 0;

        foreach (int c in szam.ToString())
        {
            if (int.Parse(c.ToString()) % 2 != 0) counter++;
        }

        return counter;
    }
}

