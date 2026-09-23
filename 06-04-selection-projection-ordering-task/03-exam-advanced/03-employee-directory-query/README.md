# EF Advanced 03 - Employee Directory Query



Nyisd meg:

```text
Exam/Exam.sln
```

Feladatok:

1. `FindFirstActiveByNameAsync`: keresd meg az első aktív munkatársat név szerinti sorrendben.
2. `FindByCodeAsync`: keresd meg az egyetlen munkatársat pontos munkatárskód alapján. A kód üzletileg egyedi.
3. `GetActiveListItemsAsync`: add vissza az aktív munkatársakat `EmployeeListItemDto` listaként, név szerint rendezve.

Figyelj arra, hogy a lekérdezés EF Core által SQL-re fordítható maradjon, és a materializálás FirstOrDefaultAsync, SingleOrDefaultAsync vagy ToListAsync legyen.
