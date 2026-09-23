# 00 - Altalanos eloismereti elemek

Az EF statisztikai feladatokban az adat nem `List<T>` valtozobol indul, hanem `DbContext` es `DbSet<T>` objektumokbol.

Fontos fogalmak:

- `DbContext`: az adatbazis eleresi pontja.
- `DbSet<T>`: egy tabla vagy entitasgyujtemeny EF Core-os megfeleloje.
- `IQueryable<T>`: meg nem lefuttatott lekerdezes, amely tovabb epitheto.
- `async` / `await`: adatbazis muveleteknel nem blokkoljuk a szalat.
- `ToListAsync`: lista materializalasa.
- `SumAsync`, `CountAsync`, `AverageAsync`, `MinAsync`, `MaxAsync`: aggregalo muveletek adatbazis oldali futtatasa.

A cel az, hogy a szures es statisztika lehetoleg az adatbazis-lekerdezes resze legyen, ne utolag, memoriaban szamolgassunk feleslegesen.
