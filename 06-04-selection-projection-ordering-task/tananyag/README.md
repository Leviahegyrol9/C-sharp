# EF Core tananyag - Kiválasztás, projekció, rendezés

## 1. DbSet és IQueryable

EF Core-ban a `DbSet<T>` lekérdezhető adatforrás. A LINQ kifejezés nem azonnal fut le, hanem `IQueryable<T>` formában épül, majd az EF Core SQL-lekérdezéssé fordítja.

## 2. FirstOrDefaultAsync és SingleOrDefaultAsync

`FirstOrDefaultAsync` akkor jó, ha több találat is lehet, de az első kell.

`SingleOrDefaultAsync` akkor jó, ha üzletileg legfeljebb egy találat lehet, például egyedi cikkszám vagy azonosító alapján.

## 3. Select DTO-ba

EF Core-ban a `Select` különösen fontos, mert csak a szükséges mezőket kérjük le az adatbázisból.

```csharp
List<ProductListItemDto> products = await context.Products
    .Where(product => product.IsActive)
    .OrderBy(product => product.Name)
    .Select(product => new ProductListItemDto(product.Id, product.Name, product.Price))
    .ToListAsync();
```

## 4. Rendezés adatbázis oldalon

Az `OrderBy` és `OrderByDescending` az SQL lekérdezés részeként fut, ha a materializálás előtt használjuk őket.

## 5. Saját függvények kerülése

Query belsejében ne hívjunk olyan saját C# függvényt, amelyet az EF Core nem tud SQL-re fordítani. Először a fordítható lekérdezést építsük fel, majd csak materializálás után használjunk összetettebb C# logikát.