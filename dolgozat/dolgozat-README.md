# LINQ ismétlő dolgozat

**Idő:** 45 perc  
**Összpontszám:** 40 pont

## Általános tudnivalók

A dolgozat 8, fokozatosan nehezedő LINQ feladatot tartalmaz. A feladatok több különböző témakörhöz kapcsolódnak, de minden szükséges adatosztály már elkészült.

A megoldandó metódusokat az `Exam/App/SummaryTasks.cs` fájlban találod. A metódusok nevét, paramétereit és visszatérési típusát ne módosítsd.

A megoldásokhoz LINQ műveleteket használj. A feladatok megoldásához szükséges adatok a paraméterként kapott listákban találhatók, ezért külön adatbekérésre nincs szükség.

---

## A használt domainek és adatok

### Iskola – `Student`

Egy tanulót a neve és a tanulmányi átlaga ír le.

- `Name` – a tanuló neve
- `Average` – a tanuló tanulmányi átlaga

### Termék / webshop – `Product`

Egy termékhez tartozik név, kategória, ár és készleten lévő darabszám.

- `Name` – a termék neve
- `Category` – a termék kategóriája
- `Price` – a termék ára forintban
- `Stock` – a készleten lévő darabszám

### Könyvtár – `Book`

Egy könyvhöz a címét és azt tároljuk, hogy eddig hányszor kölcsönözték ki.

- `Title` – a könyv címe
- `BorrowCount` – a kölcsönzések száma

### Dolgozateredmény – `ExamResult`

Egy dolgozateredmény megadja a tanuló nevét és az elért pontszámát.

- `StudentName` – a tanuló neve
- `Points` – a dolgozaton elért pontszám

### Sport – `Player`

Egy játékosnál nyilvántartjuk a nevét, a lejátszott mérkőzéseinek számát és a szerzett góljait.

- `Name` – a játékos neve
- `Matches` – a lejátszott mérkőzések száma
- `Goals` – a szerzett gólok száma

### Raktár – `WarehouseItem`

Egy raktári tétel megadja a termék nevét, egységárát és a raktáron lévő mennyiséget.

- `Name` – a termék neve
- `UnitPrice` – egy darab ára forintban
- `Quantity` – a raktáron lévő darabszám

Egy raktári tétel **készletértéke**:

`UnitPrice * Quantity`

### Projekt – `ProjectInfo` és `ProjectTask`

Egy projekt több feladatot tartalmaz. A `ProjectInfo.Tasks` ezért egy `ProjectTask` elemekből álló lista.

A projekt adatai:

- `Name` – a projekt neve
- `Tasks` – a projekthez tartozó feladatok listája

Egy projektfeladat adatai:

- `Title` – a feladat neve
- `EstimatedHours` – a feladat becsült munkaideje órában
- `Completed` – `true`, ha a feladat elkészült, egyébként `false`

---

# Feladatok

## 1. Jó tanulók – 3 pont

Készítsd el a `GetGoodStudentNames` metódust!

A metódus egy tanulókat tartalmazó listát kap. Add vissza **azoknak a tanulóknak a nevét**, akiknek a tanulmányi átlaga **legalább 4,0**.

A visszatérési érték egy `List<string>` legyen, amely csak a megfelelő tanulók neveit tartalmazza.

---

## 2. Készleten lévő termékek – 3 pont

Készítsd el a `CountProductsInStock` metódust!

A metódus egy terméklistát kap. Határozd meg, **hány olyan termék van, amelyből legalább 1 darab található készleten**.

A metódus a megfelelő termékek darabszámát adja vissza.

---

## 3. Népszerű könyvek – 4 pont

Készítsd el a `GetPopularBookTitles` metódust!

A metódus egy könyveket tartalmazó listát kap. Egy könyvet tekintsünk népszerűnek, ha azt **legalább 10 alkalommal kölcsönözték ki**.

Add vissza a népszerű könyvek **címeit** úgy, hogy a legtöbbször kölcsönzött könyv kerüljön előre, vagyis a könyveket a kölcsönzések száma szerint **csökkenő sorrendbe** kell rendezni.

A visszatérési lista csak a könyvek címeit tartalmazza.

---

## 4. Sikeres dolgozatok átlaga – 4 pont

Készítsd el a `GetSuccessfulExamAverage` metódust!

A metódus dolgozateredményeket kap. Egy dolgozatot akkor tekintünk sikeresnek, ha a tanuló **legalább 50 pontot** ért el.

Számítsd ki kizárólag a sikeres dolgozatok **átlagpontszámát**.

Ha a listában **egyetlen sikeres dolgozat sincs**, a metódus `0` értéket adjon vissza.

---

## 5. Megfizethető termékek – 5 pont

Készítsd el a `GetAffordableProductNames` metódust!

A metódus két paramétert kap:

- egy termékeket tartalmazó listát;
- egy `category` szöveget, amely megadja a keresett kategóriát.

Válaszd ki azokat a termékeket, amelyek

- a paraméterként megadott kategóriába tartoznak, **és**
- az áruk **50 000 Ft-nál kevesebb**.

A megfelelő termékeket ár szerint **növekvő sorrendbe** rendezd, majd csak a termékek **nevét** add vissza.

---

## 6. Legjobb góllövő – 6 pont

Készítsd el a `GetBestScorerName` metódust!

A metódus játékosokat tartalmazó listát kap. A vizsgálatban csak azok a játékosok vehetnek részt, akik **legalább 5 mérkőzésen játszottak**.

Közülük keresd meg azt a játékost, aki a **legtöbb gólt szerezte**, és add vissza a nevét.

Ha nincs olyan játékos, aki legalább 5 mérkőzésen játszott, a metódus `null` értéket adjon vissza.

---

## 7. Értékes raktárkészlet – 7 pont

Készítsd el a `GetValuableStockTotal` metódust!

A metódus raktári tételeket tartalmazó listát kap. Csak azokat a tételeket vedd figyelembe,

- amelyekből **legalább 5 darab** van raktáron, **és**
- amelyek egységára **legalább 1000 Ft**.

Egy tétel teljes készletértékét az alábbi módon számoljuk:

`UnitPrice * Quantity`

Számítsd ki a feltételeknek megfelelő **összes raktári tétel készletértékének összegét**, és ezt az értéket add vissza.

---

## 8. Fontos projektek – 8 pont

Készítsd el a `GetImportantProjectNames` metódust!

A metódus projektek listáját kapja. Minden projekt saját feladatlistával (`Tasks`) rendelkezik.

Egy projekt akkor számít **fontos projektnek**, ha egyszerre teljesül rá mindhárom feltétel:

1. legalább **3 feladata** van;
2. van legalább **egy olyan feladata, amely még nincs befejezve** (`Completed == false`);
3. a projekt összes feladatának becsült munkaideje együtt **legalább 20 óra**.

Válaszd ki a feltételeknek megfelelő projekteket, majd rendezd őket az **összes becsült munkaidejük szerint csökkenő sorrendbe**. Tehát az a projekt kerüljön előre, amelynek feladatai összesen több munkaórát igényelnek.

A visszatérési lista csak a projektek **nevét** tartalmazza.

---

## Pontozás összefoglalása

| Feladat                      | Nehézség      | Pont        |
| ---------------------------- | ------------- | -----------:|
| 1. Jó tanulók                | könnyű        | 3           |
| 2. Készleten lévő termékek   | könnyű        | 3           |
| 3. Népszerű könyvek          | közepes       | 4           |
| 4. Sikeres dolgozatok átlaga | közepes       | 4           |
| 5. Megfizethető termékek     | közepes       | 5           |
| 6. Legjobb góllövő           | közepes–nehéz | 6           |
| 7. Értékes raktárkészlet     | közepes–nehéz | 7           |
| 8. Fontos projektek          | nehéz         | 8           |
| **Összesen**                 |               | **40 pont** |
