namespace CSharpGyakorloFeladatsor;

/// <summary>
/// A gyakorló feladatsor megoldandó metódusai.
/// A metódusok törzse szándékosan nincs elkészítve.
/// A megoldásoknak a példákon túl a szélső esetekre is helyes eredményt kell adniuk.
/// </summary>
public static class Feladatok
{
    // =========================
    // KÖNNYŰ FELADATOK
    // =========================

    /// <summary>
    /// 1. feladat – Nagybetűk száma
    /// Add vissza, hány nagybetű található a megadott szövegben!
    /// Példa: "AlmaFA" -> 3.
    /// Gondolj az üres szövegre és arra az esetre is, amikor nincs nagybetű.
    /// </summary>
    public static int NagybetukSzama(string szoveg) => szoveg.Count(char.IsUpper);

    /// <summary>
    /// 2. feladat – Számjegyek összege
    /// Add vissza egy nemnegatív egész szám számjegyeinek összegét!
    /// Példa: 472 -> 13.
    /// Gondolj a 0-ra, a sokjegyű számokra és a nullát tartalmazó számokra is.
    /// </summary>
    public static int SzamjegyekOsszege(int szam)
    {
        szam = Math.Abs(szam);

        int sum = 0;

        foreach (char c in szam.ToString())
        {
            sum += int.Parse(c.ToString());
        }

        return sum;
    }

    /// <summary>
    /// 3. feladat – Határérték feletti elemek
    /// Add vissza, hány elem nagyobb szigorúan a megadott határértéknél!
    /// Példa: [12, 7, 19, 10], határ = 10 -> 2.
    /// Gondolj az üres tömbre, a határral egyenlő elemekre és arra is, ha nincs találat.
    /// </summary>
    public static int HatarFelettiDarab(int[] szamok, int hatar) => szamok.Count(x => x > hatar);

    /// <summary>
    /// 4. feladat – Első páros szám helye
    /// Add vissza az első páros elem indexét! Ha nincs páros elem, adj vissza -1-et!
    /// Példa: [5, 9, 8, 2] -> 2.
    /// Gondolj az üres tömbre, az első helyen álló páros számra és a páros nélküli tömbre is.
    /// </summary>
    public static int ElsoParosIndexe(int[] szamok)
    {
        foreach (int szam in szamok)
        {
            if (szam % 2 == 0) return szamok.ToList().IndexOf(szam);
        }

        return -1;
    }

    // =========================
    // KÖZEPES FELADATOK
    // =========================

    /// <summary>
    /// 5. feladat – Termékkód ellenőrzése
    /// Egy termékkód akkor érvényes, ha pontosan 7 karakteres,
    /// az első két karakter nagybetű, a harmadik karakter '-',
    /// az utolsó négy karakter pedig számjegy.
    /// Példa: "AB-2048" -> true.
    /// Gondolj a túl rövid, túl hosszú és rossz helyen hibás karaktert tartalmazó kódokra is.
    /// </summary>
    public static bool ErvenyesTermekkod(string kod)
    {
        if (kod.Length == 7 && char.IsUpper(kod[0]) && char.IsUpper(kod[1]) && kod[2] == '-' && char.IsDigit(kod[4]) && char.IsDigit(kod[5]) && char.IsDigit(kod[6]))
        {
            return true;
        }
        return false;
    }

    /// <summary>
    /// 6. feladat – Legjobb eredményt elérő tanuló
    /// A nevek és pontszámok azonos indexen összetartoznak.
    /// Add vissza a legnagyobb pontszámot elérő tanuló nevét!
    /// Pontegyenlőség esetén az első ilyen tanuló nevét add vissza!
    /// Gondolj az egyetlen tanulóra és a legnagyobb pontszámnál előforduló pontegyenlőségre is.
    /// </summary>
    public static string LegjobbTanulo(string[] nevek, int[] pontok) => nevek[Array.FindIndex(pontok, x => x == pontok.Max())];

    /// <summary>
    /// 7. feladat – Jegyhisztogram
    /// A bemeneti tömb 1 és 5 közötti osztályzatokat tartalmaz.
    /// Készíts 5 elemű tömböt, amely megadja az 1-es, 2-es, 3-as, 4-es és 5-ös
    /// jegyek darabszámát ebben a sorrendben!
    /// Példa: [5, 3, 5, 2] -> [0, 1, 1, 0, 2].
    /// Gondolj az üres tömbre, az egyféle jegyből álló tömbre és az összes jegyet tartalmazó tömbre is.
    /// </summary>
    public static int[] JegyHisztogram(int[] jegyek)
    {
        List<int> list = new List<int>();

        for (int i = 1; i < 6; i++)
        {
            list.Add(jegyek.Count(x => x == i));
        }
       
        return list.ToArray();
    }

    // =========================
    // NEHÉZ FELADATOK
    // =========================

    /// <summary>
    /// 8. feladat – Legnagyobb összegű mátrixsor
    /// Add vissza annak a sornak az indexét, amelyben az elemek összege a legnagyobb!
    /// Ha több sor összege azonos és maximális, az első ilyen sor indexét add vissza!
    /// Gondolj a negatív számokra, az egysoros mátrixra és az azonos maximális sorösszegekre is.
    /// </summary>
    public static int LegnagyobbOsszeguSor(int[,] matrix)
    {
        int maxIndex = 0;
        int maxOsszeg = int.MinValue;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int aktualisOsszeg = 0;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                aktualisOsszeg += matrix[i, j];
            }

            if (aktualisOsszeg > maxOsszeg)
            {
                maxOsszeg = aktualisOsszeg;
                maxIndex = i;
            }
        }
        return maxIndex;
    }

    /// <summary>
    /// 9. feladat – Leghosszabb szigorúan növekvő szakasz
    /// Add vissza a tömb leghosszabb olyan egymást követő szakaszának hosszát,
    /// amelyben minden elem szigorúan nagyobb az előtte állónál!
    /// Egy nem üres tömb esetén a minimális eredmény 1.
    /// Példa: [4, 6, 9, 3, 5, 7, 8, 2] -> 4, mert [3, 5, 7, 8].
    /// Gondolj az egy elemű, végig növekvő, végig csökkenő és egyenlő elemeket tartalmazó tömbre is.
    /// </summary>
    public static int LeghosszabbNovekvoSzakasz(int[] szamok)
    {
        int numberTemp = szamok[0];
        int rowtemp = 1;
        int rowpeak = 1;
        foreach (int i in szamok)
        {
            if (numberTemp < i)
            {
                numberTemp = i;
                rowtemp++;
                if (rowtemp > rowpeak)
                {
                    rowpeak = rowtemp;
                }
            }
            else
            {
                numberTemp = i;
                rowtemp = 1;
            }
        }
        return rowpeak;
    }
}
