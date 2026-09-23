# EF Expert 02 - Customer Contact Result

Ügyfélkapcsolati keresési listát kell készítened.

Nyisd meg:

```text
Exam/Exam.sln
```

Feladatok:

1. `FindFirstActiveByNameAsync`: keresd meg az első aktív ügyfélkapcsolati bejegyzést név szerinti sorrendben.
2. `FindByCodeAsync`: keresd meg az egyetlen ügyfélkapcsolati bejegyzést pontos ügyfélkód alapján. A kód üzletileg egyedi.
3. `GetActiveListItemsAsync`: készíts `CustomerContactResultDto` listát az aktív ügyfélkapcsolati bejegyzésekből, név szerint rendezve.

Figyelj arra, hogy a lekérdezés EF Core által SQL-re fordítható maradjon, és a materializálás FirstOrDefaultAsync, SingleOrDefaultAsync vagy ToListAsync legyen.
