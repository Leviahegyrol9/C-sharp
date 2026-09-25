# C# gyakorló feladatsor – .NET 8

A projekt 9, fokozatosan nehezedő feladatot tartalmaz. A feladatok a korábban tanult **metódusok és alapalgoritmusok**, valamint **tömbfeldolgozási** témakörökre épülnek, de a konkrét feladatok részben új környezetet és új kombinációkat használnak.

## Használat

A megoldandó metódusok a `Feladatok.cs` fájlban találhatók. Minden metódus fölött rövid XML `summary` írja le a feladatot. A metódusok törzse szándékosan nincs elkészítve: csak egy ideiglenes `return` található bennük.

A `Program.cs` egyszerű automatikus teszteket futtat. A projekt induló állapotában több teszt hibát fog jelezni. A cél, hogy a `Feladatok.cs` metódusainak elkészítése után minden teszt `[OK]` eredményt adjon.

Fontos: a pontozás nem csak a példákra épít. A megoldásoknak a szélsőséges, de a feladat szempontjából értelmes esetekre is helyes eredményt kell adniuk.

Futtatás:

```bash
dotnet run
```

> A feladatok megoldásához ne módosítsd a `Program.cs` tesztjeit. Elsősorban a `Feladatok.cs` fájlban dolgozz.

---

# Könnyű feladatok

## 1. Nagybetűk száma

**Témakör:** stringelemzés, karaktervizsgálat

Készítsd el a `NagybetukSzama` metódust! A metódus kap egy szöveget, és visszaadja, hogy abban hány nagybetű található.

Példa:

- bemenet: `"AlmaFA"`
- eredmény: `3`

A szövegben lévő kisbetűket, számjegyeket, szóközöket és egyéb karaktereket ne számold bele.

Gondolj az üres szövegre és arra az esetre is, amikor nincs nagybetű.

## 2. Számjegyek összege

**Témakör:** számjegyekkel végzett algoritmusok

A `SzamjegyekOsszege` metódus egy nemnegatív egész számot kap. Add össze a szám számjegyeit, és az összeget add vissza!

Példa:

- bemenet: `472`
- számítás: `4 + 7 + 2`
- eredmény: `13`

A `0` szám esetén az eredmény `0`.

Gondolj a `0`-ra, a sokjegyű számokra és a nullát tartalmazó számokra is.

## 3. Határérték feletti elemek

**Témakör:** tömbstatisztika, megszámlálás

A `HatarFelettiDarab` metódus egy egész számokat tartalmazó tömböt és egy határértéket kap. Számold meg, hány tömbelem **szigorúan nagyobb** a határértéknél!

Példa:

- tömb: `[12, 7, 19, 10]`
- határ: `10`
- eredmény: `2`

A határértékkel pontosan megegyező elem nem számít bele.

Gondolj az üres tömbre, a határral egyenlő elemekre és arra is, ha nincs találat.

## 4. Első páros szám helye

**Témakör:** keresés tömbben

Az `ElsoParosIndexe` metódus keresse meg a tömb első páros elemét, és adja vissza annak indexét!

Példa:

- tömb: `[5, 9, 8, 2]`
- az első páros szám: `8`
- index: `2`

Ha a tömbben nincs páros szám, az eredmény legyen `-1`.

Gondolj az üres tömbre, az első helyen álló páros számra és a páros nélküli tömbre is.

---

# Közepes feladatok

## 5. Termékkód ellenőrzése

**Témakör:** stringvalidáció

Az `ErvenyesTermekkod` metódus döntse el egy termékkódról, hogy megfelel-e az alábbi szabályoknak:

- pontosan 7 karakterből áll;
- az első két karakter nagybetű;
- a harmadik karakter `-`;
- az utolsó négy karakter számjegy.

Példák:

- `AB-2048` → érvényes
- `Ab-2048` → érvénytelen
- `AB2048` → érvénytelen
- `AB-20X8` → érvénytelen

A metódus `true` vagy `false` értékkel térjen vissza.

Gondolj a túl rövid, túl hosszú és rossz helyen hibás karaktert tartalmazó kódokra is.

## 6. Legjobb eredményt elérő tanuló

**Témakör:** párhuzamos tömbök, maximumkeresés

A `LegjobbTanulo` két azonos hosszúságú tömböt kap:

- `nevek`: a tanulók nevei;
- `pontok`: a tanulók pontszámai.

Az azonos indexen lévő elemek összetartoznak. Keresd meg a legnagyobb pontszámot, és add vissza a hozzá tartozó tanuló nevét!

Példa:

- nevek: `["Anna", "Béla", "Csilla"]`
- pontok: `[72, 91, 85]`
- eredmény: `"Béla"`

Ha többen is ugyanazt a legnagyobb pontszámot érték el, az első ilyen tanuló nevét add vissza.

Gondolj az egyetlen tanulóra és a legnagyobb pontszámnál előforduló pontegyenlőségre is.

## 7. Jegyhisztogram

**Témakör:** gyakoriság, hisztogram

A `JegyHisztogram` metódus 1 és 5 közötti osztályzatokat tartalmazó tömböt kap. Készíts egy új, 5 elemű tömböt, amely megmutatja, hány darab 1-es, 2-es, 3-as, 4-es és 5-ös jegy szerepel!

Példa:

- bemenet: `[5, 3, 5, 2]`
- eredmény: `[0, 1, 1, 0, 2]`

Az eredménytömb indexei tehát:

- `0` → 1-es jegyek száma
- `1` → 2-es jegyek száma
- `2` → 3-as jegyek száma
- `3` → 4-es jegyek száma
- `4` → 5-ös jegyek száma

Gondolj az üres tömbre, az egyféle jegyből álló tömbre és az összes jegyet tartalmazó tömbre is.

---

# Nehéz feladatok

## 8. Legnagyobb összegű mátrixsor

**Témakör:** mátrixfeldolgozás, maximumkeresés

A `LegnagyobbOsszeguSor` metódus egy kétdimenziós egész számtömböt kap. Számítsd ki minden sor elemeinek összegét, majd add vissza annak a sornak az indexét, amelynek az összege a legnagyobb!

Példa:

```text
3  4  1    összeg: 8
8  2  5    összeg: 15
6  6  1    összeg: 13
```

Az eredmény `1`, mert a második, vagyis `1` indexű sor összege a legnagyobb.

Ha több sor összege is azonos és maximális, az első ilyen sor indexét add vissza.

Gondolj a negatív számokra, az egysoros mátrixra és az azonos maximális sorösszegekre is.

## 9. Leghosszabb növekvő szakasz

**Témakör:** algoritmikus sorozatfeldolgozás

A `LeghosszabbNovekvoSzakasz` metódus keresse meg a tömb leghosszabb **egymást követő, szigorúan növekvő** szakaszának hosszát.

Példa:

```text
[4, 6, 9, 3, 5, 7, 8, 2]
```

A növekvő szakaszok között szerepel:

- `[4, 6, 9]` → hossz: 3
- `[3, 5, 7, 8]` → hossz: 4

Ezért az eredmény `4`.

Fontos, hogy a szakasz elemei egymás mellett legyenek a tömbben. Az egyenlő szomszédos értékek nem folytatják a szigorúan növekvő szakaszt.

Gondolj az egy elemű, végig növekvő, végig csökkenő és egyenlő elemeket tartalmazó tömbre is.

---

# Nehézségi felépítés

| Szint | Feladatok | Fő készségek |
|---|---:|---|
| Könnyű | 1–4 | stringbejárás, számjegyek, megszámlálás, keresés |
| Közepes | 5–7 | validáció, párhuzamos tömbök, gyakoriság |
| Nehéz | 8–9 | kétdimenziós tömb, összetett sorozatfeldolgozás |

A feladatok sorrendje szándékosan fokozatos: az egyszerű bejárásoktól és alapalgoritmusoktól halad az összetettebb, több lépésből álló feldolgozások felé.
