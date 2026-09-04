# 02-number-code-analysis

## Feladat Célja

A feladat célja számkódok vizsgálata. Ebben a feladatban a számjegyeket már nem `int` számként, hanem `string` formájú kódként kezeljük, mert ipari rendszerekben a vezető nullák is fontosak lehetnek.

A megoldást a `SzamkodVizsgalat` statikus osztály metódusaiba kell írni.

## Megvalósítandó Metódusok

### `CsakSzamjegyekbolAllE(string kod)`

Döntse el, hogy a kód nem üres, és kizárólag számjegyekből áll-e.

### `MegfeleloHosszusaguKodE(string kod, int hossz)`

Döntse el, hogy a kód pontosan a megadott hosszúságú-e.

### `AzonosSzamjegyekbolAllE(string kod)`

Döntse el, hogy a kód legalább két karakter hosszú, és minden számjegye azonos-e.

### `NovekvoSzamkodE(string kod)`

Döntse el, hogy a kód számjegyei balról jobbra szigorúan növekvő sorrendben vannak-e.

### `CsokkenoSzamkodE(string kod)`

Döntse el, hogy a kód számjegyei balról jobbra szigorúan csökkenő sorrendben vannak-e.

### `GyengeSzamkodE(string kod)`

Döntse el, hogy a kód gyengének számít-e. Ebben a feladatban egy kód gyenge, ha csak számjegyekből áll, és legalább az egyik igaz rá:

- minden számjegye azonos
- szigorúan növekvő számsor
- szigorúan csökkenő számsor

## Ipari Kapcsolódás

Számkódokat használhatnak belépési folyamatok, kuponrendszerek, egyszer használatos kódok, rövid ügyfélazonosítók és adminisztrációs felületek. A cél nem biztonsági rendszer építése, hanem annak gyakorlása, hogyan lehet egy szabályrendszert több kisebb, jól elnevezett metódusra bontani.

## Példák

```text
CsakSzamjegyekbolAllE("0123") -> true
MegfeleloHosszusaguKodE("0123", 4) -> true
AzonosSzamjegyekbolAllE("1111") -> true
NovekvoSzamkodE("1234") -> true
CsokkenoSzamkodE("4321") -> true
GyengeSzamkodE("1111") -> true
GyengeSzamkodE("5831") -> false
```

## Elvárások

- A metódusok legyenek `public static` metódusok.
- A `Program.cs` fájlt nem kell módosítani.
- Az üres kód ne számítson érvényes számkódnak.
- A számkódokat kezelje szövegként, hogy a vezető nullák ne vesszenek el.
- Törekedjen arra, hogy a `GyengeSzamkodE` metódus a kisebb metódusokra épüljön.

