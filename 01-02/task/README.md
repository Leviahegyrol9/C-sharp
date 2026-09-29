# C# gyakorló feladatsor 01-02 – .NET 8

A projekt **10 fokozatosan nehezedő feladatot** tartalmaz: 4 könnyű, 4 közepes és 2 nehéz feladatot. A feladatok a korábban tanult metódusokra, alapalgoritmusokra, string- és számjegyfeldolgozásra, valamint tömb- és mátrixfeldolgozásra épülnek. A pontozás nem csak a példákra épít: a megoldásoknak a szélső, de a feladat szempontjából értelmes esetekre is helyes eredményt kell adniuk.

## Használat

A megoldandó metódusok a `Feladatok.cs` fájlban találhatók. Minden metódus fölött rövid XML `summary` tartalmazza a feladat lényegét. A metódusok törzse szándékosan nincs elkészítve, csak egy ideiglenes `return` található bennük.

A `Program.cs` egyszerű ellenőrző teszteket tartalmaz. A projekt induló állapotában a tesztek többsége hibát jelez. A cél, hogy a `Feladatok.cs` metódusainak elkészítése után minden teszt `[OK]` eredményt adjon.

```bash
dotnet run
```

> A feladatok megoldásakor a `Feladatok.cs` fájlban dolgozz. A `Program.cs` tesztjeit ne módosítsd.

---

# Könnyű feladatok

## 1. Páros számjegyek száma

**Témakör:** számjegyek feldolgozása, megszámlálás

Készítsd el a `ParosSzamjegyekSzama` metódust! A metódus egy **nemnegatív egész számot** kap, és adja vissza, hogy a számban hány páros számjegy található.

A `0` páros számjegynek számít.

Példa:

- bemenet: `583204`
- páros számjegyek: `8`, `2`, `0`
- eredmény: `3`

További példa: `13579` esetén az eredmény `0`. Gondolj a `0` értékre és a csak páros számjegyekből álló számokra is.

## 2. Adott karakter előfordulása

**Témakör:** stringbejárás, megszámlálás

A `KarakterDarab` metódus egy szöveget és egy karaktert kap. Számold meg, hogy a megadott karakter **pontosan hányszor** fordul elő a szövegben!

Példa:

- szöveg: `"programozas"`
- keresett karakter: `'o'`
- eredmény: `2`

A kis- és nagybetűk különböző karakternek számítanak, tehát például az `'a'` és az `'A'` nem azonos. Gondolj az üres szövegre és arra is, amikor a keresett karakter többször ismétlődik.

## 3. Negatív számok összege

**Témakör:** tömbbejárás, feltételes összegzés

A `NegativakOsszege` metódus egy egész számokat tartalmazó tömböt kap. Add össze **csak a negatív elemeket**, és az összeget add vissza!

Példa:

- bemenet: `[4, -3, 8, -5, -2]`
- számítás: `-3 + (-5) + (-2)`
- eredmény: `-10`

Ha a tömbben nincs negatív szám, az eredmény legyen `0`. Gondolj az üres tömbre és a csak negatív számokat tartalmazó tömbre is.

## 4. Utolsó pozitív szám indexe

**Témakör:** keresés tömbben

Az `UtolsoPozitivIndexe` metódus keresse meg a tömbben az **utolsó pozitív számot**, és adja vissza annak indexét!

Példa:

- tömb: `[-2, 5, -1, 8, 0, -3]`
- az utolsó pozitív szám: `8`
- index: `3`

A `0` nem pozitív szám. Ha a tömbben egyetlen pozitív szám sincs, az eredmény legyen `-1`. Gondolj az üres tömbre és arra is, amikor a pozitív szám a tömb elején vagy végén áll.

---

# Közepes feladatok

## 5. Felhasználónév ellenőrzése

**Témakör:** stringvalidáció

Az `ErvenyesFelhasznalonev` metódus döntse el egy felhasználónévről, hogy megfelel-e az összes alábbi szabálynak:

- legalább 5 és legfeljebb 12 karakter hosszú;
- az első karakter betű;
- minden karakter betű, számjegy vagy `_` karakter.

Példák:

- `anna_25` → `true`
- `Bela7` → `true`
- `25anna` → `false`, mert nem betűvel kezdődik
- `ab#cd` → `false`, mert a `#` nem megengedett karakter
- `abc` → `false`, mert túl rövid

A metódus `true` vagy `false` értékkel térjen vissza. Gondolj a pontosan 5 és 12 karakteres érvényes nevekre, a túl rövid és túl hosszú nevekre, a rossz kezdőkarakterre és a tiltott karakterekre is.

## 6. Legolcsóbb termék neve

**Témakör:** párhuzamos tömbök, minimumkeresés

A `LegolcsobbTermek` két azonos hosszúságú tömböt kap:

- `termekek`: a termékek nevei;
- `arak`: a hozzájuk tartozó árak.

Az azonos indexen lévő adatok összetartoznak. Keresd meg a **legkisebb árat**, majd add vissza a hozzá tartozó termék nevét!

Példa:

- termékek: `["Eger", "Billentyuzet", "Pendrive"]`
- árak: `[6500, 8900, 4200]`
- eredmény: `"Pendrive"`

Ha több termék ára is megegyezik a legkisebb árral, az **első ilyen termék** nevét add vissza. Gondolj az egyetlen termékből álló bemenetre és a döntetlen minimumárra is.

## 7. Pontszámok kategorizálása

**Témakör:** gyakoriság, csoportosítás, hisztogram

A `PontKategoriak` metódus `0` és `100` közötti pontszámokat tartalmazó tömböt kap. Készíts egy **4 elemű új tömböt**, amely megmutatja, hány pontszám tartozik az egyes kategóriákba!

A kategóriák és az eredménytömb indexei:

- `0. index`: `0–49` pont
- `1. index`: `50–64` pont
- `2. index`: `65–79` pont
- `3. index`: `80–100` pont

Példa:

- bemenet: `[42, 75, 91, 63, 80, 30]`
- `0–49`: 2 darab (`42`, `30`)
- `50–64`: 1 darab (`63`)
- `65–79`: 1 darab (`75`)
- `80–100`: 2 darab (`91`, `80`)
- eredmény: `[2, 1, 1, 2]`

Gondolj az üres tömbre és a kategóriahatárokon álló pontszámokra is: `0`, `49`, `50`, `64`, `65`, `79`, `80`, `100`.

## 8. Második legnagyobb különböző érték

**Témakör:** tömbfeldolgozás, maximumkeresés

A `MasodikLegnagyobbKulonbozo` metódus egy egész számokat tartalmazó tömböt kap.

Először határozd meg a tömbben található **legnagyobb értéket**, majd keresd meg azt a **legnagyobb számot, amely ennél kisebb**. Ezt az értéket add vissza.

Ha a legnagyobb szám többször is szerepel, az ismétlődéseket nem kell külön értéknek tekinteni.

Példa:

```text
[12, 7, 18, 5, 18, 14]
```

A legnagyobb érték `18`. Bár a `18` kétszer szerepel, csak egy különböző értéknek számít.

A `18`-nál kisebb értékek:

```text
12, 7, 5, 14
```

Ezek közül a legnagyobb `14`, ezért az eredmény:

```text
14
```

Gondolj az ismétlődő legnagyobb értékre, a két elemű tömbre és a negatív számokat tartalmazó bemenetre is.

---

# Nehéz feladatok

## 9. Legnagyobb összegű mátrixoszlop

**Témakör:** mátrixfeldolgozás, maximumkeresés

A `LegnagyobbOsszeguOszlop` metódus egy kétdimenziós egész számtömböt kap. Számítsd ki minden **oszlop elemeinek összegét**, majd add vissza annak az oszlopnak az indexét, amelynek az összege a legnagyobb!

Példa:

```text
3  8  1
4  2  7
2  5  3
```

Oszlopösszegek:

- 0. oszlop: `3 + 4 + 2 = 9`
- 1. oszlop: `8 + 2 + 5 = 15`
- 2. oszlop: `1 + 7 + 3 = 11`

Az eredmény `1`, mert az `1` indexű oszlop összege a legnagyobb.

Ha több oszlop összege is azonos és maximális, az **első ilyen oszlop indexét** add vissza. Gondolj az egysoros, egyoszlopos, negatív értékeket tartalmazó és döntetlen oszlopösszegű mátrixokra is.

## 10. Leghosszabb azonos elemekből álló szakasz

**Témakör:** algoritmikus sorozatfeldolgozás

A `LeghosszabbAzonosSzakasz` metódus határozza meg, hogy a tömbben maximum hány **egymás mellett álló azonos szám** található!

Példa:

```text
[2, 2, 5, 5, 5, 1, 3, 3]
```

Az azonos elemekből álló szakaszok többek között:

- `[2, 2]` → hossz: 2
- `[5, 5, 5]` → hossz: 3
- `[3, 3]` → hossz: 2

A leghosszabb ilyen szakasz hossza `3`, ezért az eredmény `3`.

Fontos, hogy csak az **egymás mellett lévő** azonos értékek alkotnak egy szakaszt. Gondolj az egy elemű, csupa azonos, csupa különböző és döntetlen hosszúságú szakaszokat tartalmazó tömbre is.

---

# Nehézségi felépítés

| Szint | Feladatok | Fő készségek |
|---|---:|---|
| Könnyű | 1–4 | számjegyek, stringbejárás, összegzés, keresés |
| Közepes | 5–8 | validáció, párhuzamos tömbök, csoportosítás, összetett maximumkeresés |
| Nehéz | 9–10 | kétdimenziós tömb, összetett sorozatfeldolgozás |

A feladatok sorrendje szándékosan fokozatosan nehezedik.

