# Advanced EF Core Megoldási Minta

Kapcsolt adatoknál gyakori, hogy nem egyetlen mező alapján szűrünk, hanem egy kapcsolódó gyűjtemény darabszámát vizsgáljuk.

```csharp
public async Task<List<Reader>> GetReadersWithAtLeastBorrowsAsync(int minBorrowCount)
{
    return await _dbContext.Readers
        .Where(reader => reader.BorrowRecords.Count() >= minBorrowCount)
        .ToListAsync();
}
```

Késedelmes kapcsolt elemek számolásánál a Count kap egy feltételt:

```csharp
public async Task<List<Reader>> GetReadersWithAtLeastOverdueBorrowsAsync(int minOverdueCount)
{
    return await _dbContext.Readers
        .Where(reader => reader.BorrowRecords.Count(record => record.IsOverdue) >= minOverdueCount)
        .ToListAsync();
}
```

Az önálló tábla darabszámolásánál `CountAsync`-ot használunk:

```csharp
public async Task<int> CountOverdueBorrowRecordsAsync()
{
    return await _dbContext.BorrowRecords
        .CountAsync(record => record.IsOverdue);
}
```

A lényeg: a lekérdezés maradjon EF által fordítható kifejezés. Ne hozz létre saját segédfüggvényt a `Where` belsejében, és ne hívd meg korán a `ToListAsync()` metódust.
