# EF Expert 01 - Catalog Search Result

Valósabb katalógus keresési eredményt kell készítened DTO-val és rendezéssel.

Nyisd meg:

```text
Exam/Exam.sln
```

Feladatok:

1. `FindFirstActiveByNameAsync`: keresd meg az első aktív katalóguselemet név szerinti sorrendben.
2. `FindByCodeAsync`: keresd meg az egyetlen katalóguselemet pontos katalóguskód alapján. A kód üzletileg egyedi.
3. `GetActiveListItemsAsync`: készíts keresési eredményhez használható `CatalogSearchResultDto` listát az aktív katalóguselemekből, név szerint rendezve.

Figyelj arra, hogy a lekérdezés EF Core által SQL-re fordítható maradjon, és a materializálás FirstOrDefaultAsync, SingleOrDefaultAsync vagy ToListAsync legyen.
