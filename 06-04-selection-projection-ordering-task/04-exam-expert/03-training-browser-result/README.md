# EF Expert 03 - Training Browser Result

Képzésböngésző jellegű üzleti lekérdezést kell megírnod.

Nyisd meg:

```text
Exam/Exam.sln
```

Feladatok:

1. `FindFirstActiveByNameAsync`: keresd meg az első aktív képzési programot név szerinti sorrendben.
2. `FindByCodeAsync`: keresd meg az egyetlen képzési programot pontos képzéskód alapján. A kód üzletileg egyedi.
3. `GetActiveListItemsAsync`: készíts `TrainingBrowserResultDto` listát az aktív képzési programokból, név szerint rendezve.

Figyelj arra, hogy a lekérdezés EF Core által SQL-re fordítható maradjon, és a materializálás FirstOrDefaultAsync, SingleOrDefaultAsync vagy ToListAsync legyen.
