# 02-digit-calculations

## Feladat Célja

A feladat célja számjegyekből számított eredmények előállítása. A hallgató itt már ciklusokat és akkumulátor változókat használ: összeget, szorzatot, darabszámot, minimumot és maximumot számol.

A megoldást a `SzamjegySzamitasok` statikus osztály metódusaiba kell írni.

## Megvalósítandó Metódusok

### `SzamjegyekOsszege(int szam)`

Adja vissza a szám abszolút értékének számjegyösszegét.

### `SzamjegyekSzorzata(int szam)`

Adja vissza a szám abszolút értékének számjegyszorzatát.

### `ForditottSzam(int szam)`

Adja vissza a szám számjegyeinek fordított sorrendjéből képzett számot. Negatív szám esetén az előjelet tartsa meg.

### `LegnagyobbSzamjegy(int szam)`

Adja vissza a szám legnagyobb számjegyét.

### `LegkisebbSzamjegy(int szam)`

Adja vissza a szám legkisebb számjegyét.

### `ParosSzamjegyekSzama(int szam)`

Adja vissza, hány páros számjegy található a számban.

### `ParatlanSzamjegyekSzama(int szam)`

Adja vissza, hány páratlan számjegy található a számban.

## Ipari Kapcsolódás

Ezek a számítások egyszerű adatprofilozási és ellenőrzési feladatok alapjai. Egy rendszer például vizsgálhatja, hogy egy azonosítóban túl sok nulla van-e, milyen számjegyek dominálnak, vagy egy ellenőrző algoritmushoz szüksége lehet a számjegyek összegére.

## Példák

```text
SzamjegyekOsszege(123) -> 6
SzamjegyekSzorzata(234) -> 24
ForditottSzam(-450) -> -54
LegnagyobbSzamjegy(7291) -> 9
LegkisebbSzamjegy(7291) -> 1
ParosSzamjegyekSzama(24681) -> 4
ParatlanSzamjegyekSzama(24681) -> 1
```

## Elvárások

- A metódusok legyenek `public static` metódusok.
- A `Program.cs` fájlt nem kell módosítani.
- Negatív számoknál a számjegyekkel az abszolút értéken dolgozzon, kivéve ahol a feladat külön kéri az előjel megtartását.
- Törekedjen arra, hogy a megoldás lépései olvashatóak legyenek.

