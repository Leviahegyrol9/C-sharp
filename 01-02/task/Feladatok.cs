namespace CSharpGyakorloFeladatsor;

/// <summary>
/// A 01-02 gyakorló feladatsor megoldandó metódusai.
/// A metódusok törzse szándékosan nincs elkészítve.
/// A megoldásoknak a példákon túl a szélső esetekre is helyes eredményt kell adniuk.
/// </summary>
public static class Feladatok
{
    // =========================
    // KÖNNYŰ FELADATOK
    // =========================

    /// <summary>
    /// 1. feladat – Páros számjegyek száma
    /// Add vissza, hány páros számjegy található a megadott nemnegatív egész számban!
    /// A 0 páros számjegynek számít.
    /// Példa: 583204 -> 3, mert a páros számjegyek: 8, 2 és 0.
    /// </summary>
    public static int ParosSzamjegyekSzama(int szam) => szam.ToString().Count(x => int.Parse(x.ToString()) % 2 == 0);

    /// <summary>
    /// 2. feladat – Karakter előfordulása
    /// Add vissza, hányszor fordul elő a megadott karakter a szövegben!
    /// A kis- és nagybetűk különböző karakternek számítanak.
    /// Példa: "programozas", 'o' -> 2.
    /// Gondolj az üres szövegre, a többször ismétlődő karakterre és a kis-/nagybetű különbségre is.
    /// </summary>
    public static int KarakterDarab(string szoveg, char karakter) => szoveg.Count(x => x == karakter);

    /// <summary>
    /// 3. feladat – Negatív számok összege
    /// Add össze a tömbben található negatív számokat, és add vissza az összeget!
    /// Ha nincs negatív szám, az eredmény 0.
    /// Példa: [4, -3, 8, -5, -2] -> -10.
    /// Gondolj az üres tömbre, a negatív szám nélküli és a csak negatív számokat tartalmazó tömbre is.
    /// </summary>
    public static int NegativakOsszege(int[] szamok)
    {
        int sum = 0;

        foreach (int x in szamok)
        {
            if (x < 0) sum += x;
        }

        return sum;
    }

    /// <summary>
    /// 4. feladat – Utolsó pozitív szám indexe
    /// Add vissza a tömb utolsó pozitív elemének indexét!
    /// A 0 nem pozitív. Ha nincs pozitív elem, adj vissza -1-et!
    /// Példa: [-2, 5, -1, 8, 0, -3] -> 3.
    /// Gondolj az üres tömbre, a pozitív szám nélküli és az utolsó helyen álló pozitív számra is.
    /// </summary>
    public static int UtolsoPozitivIndexe(int[] szamok)
    {
        int index = -1;

        for (int i = 0; szamok.Length > i; i++)
        {
            if (szamok[i] > 0) index = i;
        }

        return index;
    }

    // =========================
    // KÖZEPES FELADATOK
    // =========================

    /// <summary>
    /// 5. feladat – Felhasználónév ellenőrzése
    /// Egy felhasználónév akkor érvényes, ha 5–12 karakter hosszú, betűvel kezdődik,
    /// és minden karaktere betű, számjegy vagy '_' karakter.
    /// Példa: "anna_25" -> true, "25anna" -> false.
    /// Gondolj a pontosan 5 és 12 karakteres nevekre, a rossz kezdőkarakterre és a tiltott karakterekre is.
    /// </summary>
    public static bool ErvenyesFelhasznalonev(string nev)
    {
        if (nev.Length < 5 || nev.Length > 12) return false;

        if (!char.IsLetter(nev[0])) return false;

        for (int i = 0; i < nev.Length; i++)
        {
            if (!char.IsLetterOrDigit(nev[i]) && nev[i] != '_') return false;
        }

        return true;
    }


    /// <summary>
    /// 6. feladat – Legolcsóbb termék neve
    /// A terméknevek és árak azonos indexen összetartoznak.
    /// Add vissza a legkisebb árhoz tartozó termék nevét!
    /// Ha több termék ára is azonos és minimális, az első ilyen termék nevét add vissza!
    /// Példa: ["Eger", "Billentyuzet", "Pendrive"], [6500, 8900, 4200] -> "Pendrive".
    /// Gondolj az egyetlen termékre és azonos legalacsonyabb ár esetén az első találatra is.
    /// </summary>
    public static string LegolcsobbTermek(string[] termekek, int[] arak) => termekek[Array.FindIndex(arak, a => a == arak.Min())];

    /// <summary>
    /// 7. feladat – Pontszámok kategorizálása
    /// A tömb 0 és 100 közötti pontszámokat tartalmaz.
    /// Készíts 4 elemű gyakorisági tömböt a következő kategóriákhoz:
    /// 0–49, 50–64, 65–79, 80–100.
    /// Példa: [42, 75, 91, 63, 80, 30] -> [2, 1, 1, 2].
    /// Gondolj az üres tömbre és a kategóriahatárokon álló pontszámokra is.
    /// </summary>
    public static int[] PontKategoriak(int[] pontok)
    {
        int first = 0;
        int second = 0;
        int third = 0;
        int fourth = 0;

        List<int> list = new List<int>();

        foreach (int x in pontok)
        {
            if (x >= 0 && x <= 49) first++;
            else if (x >= 50 && x <= 64) second++;
            else if (x >= 65 && x <= 79) third++;
            else fourth++;
        }

        list.Add(first);
        list.Add(second);
        list.Add(third);
        list.Add(fourth);

        return list.ToArray();
    }

    /// <summary>
    /// 8. feladat – Második legnagyobb különböző érték
    /// Határozd meg a tömb legnagyobb értékét, majd add vissza azt a legnagyobb számot,
    /// amely ennél kisebb! A legnagyobb érték többszöri előfordulása nem számít külön értéknek.
    /// Példa: [12, 7, 18, 5, 18, 14] -> 14.
    /// </summary>
    public static int MasodikLegnagyobbKulonbozo(int[] szamok)
    {
        int legnagyobb = int.MinValue;
        int masodik = int.MinValue;

        foreach (int szam in szamok)
        {
            if (szam > legnagyobb)
            {
                masodik = legnagyobb;
                legnagyobb = szam;
            }
            else if (szam > masodik && szam < legnagyobb) masodik = szam;
        }

        return masodik;
    }


    // =========================
    // NEHÉZ FELADATOK
    // =========================

    /// <summary>
    /// 9. feladat – Legnagyobb összegű mátrixoszlop
    /// Add vissza annak az oszlopnak az indexét, amelyben az elemek összege a legnagyobb!
    /// Ha több oszlop összege azonos és maximális, az első ilyen oszlop indexét add vissza!
    /// Gondolj az egysoros, egyoszlopos, negatív értékeket tartalmazó és döntetlen oszlopösszegű mátrixokra is.
    /// </summary>
    public static int LegnagyobbOsszeguOszlop(int[,] matrix)
    {
        int maxOsszeg = int.MinValue;
        int maxOszlop = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int osszeg = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                osszeg += matrix[i, j];
            }

            if (osszeg > maxOsszeg)
            {
                maxOsszeg = osszeg;
                maxOszlop = j;
            }
        }

        return maxOszlop;
    }

    /// <summary>
    /// 10. feladat – Leghosszabb azonos elemekből álló szakasz
    /// Add vissza, maximum hány egymás mellett álló azonos szám található a tömbben!
    /// Példa: [2, 2, 5, 5, 5, 1, 3, 3] -> 3.
    /// </summary>
    public static int LeghosszabbAzonosSzakasz(int[] szamok)
    {
        int aktualis = 1;
        int leghosszabb = 1;

        for (int i = 1; i < szamok.Length; i++)
        {
            if (szamok[i] == szamok[i - 1])
            {
                aktualis++;
            }
            else
            {
                aktualis = 1;
            }

            if (aktualis > leghosszabb)
            {
                leghosszabb = aktualis;
            }
        }

        return leghosszabb;
    }

}


