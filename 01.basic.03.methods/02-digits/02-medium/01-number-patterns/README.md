# 01-number-patterns

## Feladat Célja

A feladat célja számjegyminták felismerése egész számokban. A hallgató itt már nem csak kiszámol egy értéket, hanem egy szám számjegyeinek egymáshoz való viszonyát vizsgálja.

A megoldást a `SzamjegyMintak` statikus osztály metódusaiba kell írni.

## Megvalósítandó Metódusok

### `PalindromE(int szam)`

Döntse el, hogy a szám palindrom-e, vagyis balról és jobbról olvasva ugyanaz-e. Egyjegyű szám ne számítson palindromnak.

### `NovekvoSzamjegyuE(int szam)`

Döntse el, hogy a szám számjegyei balról jobbra haladva szigorúan növekvő sorrendben vannak-e.

### `CsokkenoSzamjegyuE(int szam)`

Döntse el, hogy a szám számjegyei balról jobbra haladva szigorúan csökkenő sorrendben vannak-e.

### `MindenSzamjegyAzonosE(int szam)`

Döntse el, hogy a szám minden számjegye azonos-e.

### `TartalmazSzamjegyet(int szam, int szamjegy)`

Döntse el, hogy a szám tartalmazza-e a paraméterként kapott számjegyet. A `szamjegy` paraméter csak 0 és 9 között érvényes.

### `DigitalisGyok(int szam)`

Adja vissza a szám digitális gyökét: ismételten adja össze a számjegyeket addig, amíg egyjegyű számot nem kap.

## Ipari Kapcsolódás

Számjegyminták felismerése előfordulhat azonosítók, sorszámok, ügyfélkódok vagy rövid belépési kódok előszűrésénél. Egy rendszer például gyanúsnak tarthatja a túl egyszerű mintákat, mint az `111111`, `123456` vagy `987654`.

## Példák

```text
PalindromE(1221) -> true
PalindromE(7) -> false
NovekvoSzamjegyuE(1379) -> true
CsokkenoSzamjegyuE(9752) -> true
MindenSzamjegyAzonosE(5555) -> true
TartalmazSzamjegyet(2468, 6) -> true
DigitalisGyok(987) -> 6
```

## Elvárások

- A metódusok legyenek `public static` metódusok.
- A `Program.cs` fájlt nem kell módosítani.
- Negatív számoknál a számjegymintákat az abszolút érték alapján vizsgálja.
- Törekedjen arra, hogy a metódusok egymásra épüljenek, ahol ez természetes.

