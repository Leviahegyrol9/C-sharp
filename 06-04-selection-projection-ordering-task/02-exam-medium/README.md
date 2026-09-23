# EF 02 Exam - Medium

Több mezős termékkatalóguson dolgozol, DTO projekcióval és rendezett listákkal.

Nyisd meg:

```text
Exam/Exam.sln
```

Feladatok:

1. `FindFirstActiveProductByNameAsync`: keresd meg a termékkatalógus első aktív termékét név szerinti sorrendben.
2. `FindProductBySkuAsync`: keresd meg az egyetlen terméket pontos SKU alapján. Az SKU üzletileg egyedi.
3. `GetActiveProductListItemsAsync`: készíts név szerint rendezett `ProductListItemDto` listát az aktív termékekből.

Figyelj arra, hogy a lekérdezés EF Core által SQL-re fordítható maradjon, és a materializálás FirstOrDefaultAsync, SingleOrDefaultAsync vagy ToListAsync legyen.
