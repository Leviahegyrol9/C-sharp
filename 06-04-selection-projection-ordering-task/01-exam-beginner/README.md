# EF 01 Exam - Beginner

Egyszerű Product DbSet felett kell FirstOrDefaultAsync, SingleOrDefaultAsync, Select és OrderBy műveleteket használnod.

Nyisd meg:

```text
Exam/Exam.sln
```

Feladatok:

1. `FindFirstActiveProductByNameAsync`: keresd meg az első aktív terméket név szerinti sorrendben.
2. `FindProductBySkuAsync`: keresd meg az egyetlen terméket pontos SKU alapján. Az SKU üzletileg egyedi.
3. `GetActiveProductListItemsAsync`: add vissza az aktív termékeket `ProductListItemDto` listaként, név szerint rendezve.

Figyelj arra, hogy a lekérdezés EF Core által SQL-re fordítható maradjon, és a materializálás FirstOrDefaultAsync, SingleOrDefaultAsync vagy ToListAsync legyen.
