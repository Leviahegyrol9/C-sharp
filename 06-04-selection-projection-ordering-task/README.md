# 06-04 - EF Core: Selection, Projection, Ordering EF Core-ban

Ebben az ágban ugyanazt a gondolkodást gyakoroljuk EF Core környezetben.

A cél nem az, hogy a diák mechanikusan lemásolja a listás megoldásokat, hanem hogy felismerje:

- `DbSet<T>` és `IQueryable<T>` esetén a lekérdezés adatbázis-lekérdezéssé fordul;
- `FirstOrDefaultAsync` és `SingleOrDefaultAsync` más üzleti jelentést hordoz;
- `Select` esetén DTO-ba érdemes vetíteni, ha csak bizonyos mezők kellenek;
- `OrderBy` és `OrderByDescending` adatbázis oldalon rendez;
- a materializálás pontja fontos: `ToListAsync`, `FirstOrDefaultAsync`, `SingleOrDefaultAsync`.

## Tananyag és példák

- [Tananyag](./tananyag/README.md)
- [Példakód](./peldakod/README.md)

## Feladatok

- [01 Exam - Beginner](./01-exam-beginner/README.md)
- [02 Exam - Medium](./02-exam-medium/README.md)
- [03 Exam - Advanced](./03-exam-advanced/README.md)
- [04 Exam - Expert](./04-exam-expert/README.md)
- [05 Business Query Patterns](./05-business-query-patterns/README.md)