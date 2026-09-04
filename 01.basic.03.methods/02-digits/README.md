# 02-digits

Számjegyekkel kapcsolatos elemi algoritmusok C# metódusokkal.

Ez a témakör a karakter- és szövegvizsgálat után következik. A hallgató itt azt gyakorolja, hogyan lehet egy egész számot számjegyeire bontani, a számjegyekből számításokat végezni, majd ipari jellegű kódellenőrzési problémákhoz eljutni.

## Tartalomjegyzék

| Szint | Feladat | Rövid leírás | Ipari kapcsolódás |
| --- | --- | --- | --- |
| 01 Beginner | [01-digit-basics](01-beginner/01-digit-basics/README.md) | Egy szám alapvető tulajdonságai és számjegyeinek elérése | Azonosítók, sorszámok és kódok alapellenőrzése |
| 01 Beginner | [02-digit-calculations](01-beginner/02-digit-calculations/README.md) | Számjegyek összege, szorzata, legkisebb és legnagyobb számjegy | Egyszerű ellenőrző logikák, adatprofilozás, statisztikák |
| 02 Medium | [01-number-patterns](02-medium/01-number-patterns/README.md) | Palindrom, növekvő/csökkenő számjegyek, ismétlődő minták | Gyanús vagy túl egyszerű azonosítók felismerése |
| 02 Medium | [02-number-code-analysis](02-medium/02-number-code-analysis/README.md) | Számkódok vizsgálata, gyenge kódok és tiltott minták felismerése | PIN-szerű kódok, belépési kódok, kuponok előszűrése |
| 03 Advanced | [01-checksum-validation](03-advanced/01-checksum-validation/README.md) | Ellenőrző számjegyes validációk | Vonalkódok, bankkártyaszámok, rendelési és ügyfélazonosítók |
| 03 Advanced | [02-code-generation](03-advanced/02-code-generation/README.md) | Egyszerű azonosítók és ellenőrző számjegyek generálása | Rendelésszámok, kuponkódok, belső ügyviteli azonosítók |
| 03 Advanced | [03-numeric-data-cleaning](03-advanced/03-numeric-data-cleaning/README.md) | Számszerű azonosítók tisztítása és maszkolása | Importált adatok tisztítása, telefonszámok, személyes adatok maszkolása |

## Ipari Kontextus

Számjegy-algoritmusok sok hétköznapi üzleti rendszerben előfordulnak. Rendelési számok, ügyfélazonosítók, kuponkódok, bankkártyaszámok, vonalkódok és importált telefonszámok mind igényelhetnek formátumellenőrzést, tisztítást vagy ellenőrző számjegyes validációt.

Ebben a témakörben a hangsúly nem a bonyolult matematikán van, hanem azon, hogy egy nagyobb ellenőrzési szabályt kisebb, jól tesztelhető metódusokra bontsunk.

## Ajánlott Haladási Sorrend

1. `01-beginner/01-digit-basics`: számjegyek elérése és egyszerű döntések
2. `01-beginner/02-digit-calculations`: számjegyekből számított eredmények
3. `02-medium/01-number-patterns`: mintafelismerés számjegysorokban
4. `02-medium/02-number-code-analysis`: kódszerű számok vizsgálata
5. `03-advanced/01-checksum-validation`: ellenőrző számjegyes validáció
6. `03-advanced/02-code-generation`: kódgenerálás
7. `03-advanced/03-numeric-data-cleaning`: tisztítás és maszkolás
