# 01-digit-basics

## Feladat Célja

A feladat célja, hogy a hallgató megtanulja egy egész szám egyszerű tulajdonságait metódusokkal vizsgálni, illetve elérni a szám első és utolsó számjegyét.

Ez a feladat még nem bonyolult algoritmusokról szól. A lényeg az, hogy minden részfeladat külön, jól elnevezett metódusba kerüljön.

A megoldást a `SzamjegyAlapok` statikus osztály metódusaiba kell írni.

## Megvalósítandó Metódusok

### `EgyjegyuE(int szam)`

Döntse el, hogy a szám abszolút értékben egyjegyű-e.

### `LegalabbKetjegyu(int szam)`

Döntse el, hogy a szám abszolút értékben legalább kétjegyű-e.

### `PozitivE(int szam)`

Döntse el, hogy a szám pozitív-e. A `0` nem számít pozitívnak.

### `NegativE(int szam)`

Döntse el, hogy a szám negatív-e.

### `UtolsoSzamjegy(int szam)`

Adja vissza a szám utolsó számjegyét. Negatív szám esetén is pozitív számjegyet adjon vissza.

### `ElsoSzamjegy(int szam)`

Adja vissza a szám első számjegyét. Negatív szám esetén is pozitív számjegyet adjon vissza.

### `SzamjegyekSzama(int szam)`

Adja vissza, hogy hány számjegyből áll a szám abszolút értéke.

## Ipari Kapcsolódás

Az ilyen alapműveletek az azonosítók, sorszámok és kódok ellenőrzésének első építőkövei. Egy üzleti rendszerben gyakori kérdés, hogy egy kód megfelelő hosszúságú-e, egy sorszám pozitív-e, vagy egy azonosító utolsó számjegye alapján kell-e további ellenőrzést végezni.

## Példák

```text
EgyjegyuE(7) -> true
EgyjegyuE(-7) -> true
LegalabbKetjegyu(42) -> true
PozitivE(10) -> true
NegativE(-3) -> true
UtolsoSzamjegy(-347) -> 7
ElsoSzamjegy(-347) -> 3
SzamjegyekSzama(1205) -> 4
```

## Elvárások

- A metódusok legyenek `public static` metódusok.
- A `Program.cs` fájlt nem kell módosítani.
- A negatív számokat kezelje tudatosan, ahol a feladat ezt kéri.
- Törekedjen egyszerű, olvasható megoldásra.

