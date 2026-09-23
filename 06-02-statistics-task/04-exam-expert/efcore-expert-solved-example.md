# Expert EF Core statisztikai minta

Expert szinten a feladat tipikusan nem egyetlen szam visszaadasa, hanem egy riport DTO osszeallitasa.

A gondolkodasi sorrend:

1. Szukitsd le az adatokat `Where` feltetellel.
2. Szamold ki kulon az alap aggregatumokat: darabszam, osszeg, atlag, minimum, maximum.
3. A szazalekoknal mindig kezeld a nulla nevezot.
4. A vegeredmenyt DTO-ban add vissza.

Pelda gondolatmenet:

```csharp
var totalCount = await query.CountAsync();
var selectedCount = await query.CountAsync(item => item.IsSelected);
var selectedPercentage = totalCount == 0 ? 0 : selectedCount * 100.0 / totalCount;
```

Fontos: a query belsejebe ne tegyel sajat C# segedfuggvenyt. Olyan kifejezeseket hasznalj, amelyeket EF Core adatbazis-lekerdezesre tud forditani.
