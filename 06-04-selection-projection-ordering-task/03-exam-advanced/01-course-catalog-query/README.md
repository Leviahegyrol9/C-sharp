# EF Advanced 01 - Course Catalog Query

Kurzuslista-szerű üzleti lekérdezéseket kell írnod EF Core-ban.

Nyisd meg:

```text
Exam/Exam.sln
```

Feladatok:

1. `FindFirstActiveByNameAsync`: keresd meg az első aktív kurzust név szerinti sorrendben.
2. `FindByCodeAsync`: keresd meg az egyetlen kurzust pontos kurzuskód alapján. A kurzuskód üzletileg egyedi.
3. `GetActiveListItemsAsync`: add vissza az aktív kurzusokat `CourseListItemDto` listaként, név szerint rendezve.

Figyelj arra, hogy a lekérdezés EF Core által SQL-re fordítható maradjon, és a materializálás FirstOrDefaultAsync, SingleOrDefaultAsync vagy ToListAsync legyen.
