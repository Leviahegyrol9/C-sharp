using Microsoft.EntityFrameworkCore;

namespace LinqWhereCountEfAdvancedLibrary;

public class LibraryQueryService
{
    private readonly AppDbContext _dbContext;

    public LibraryQueryService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    /// <summary>
    /// Add vissza azokat az olvasókat, akiknek legalább minBorrowCount darab kölcsönzése van.
    /// A kapcsolt BorrowRecords gyűjtemény darabszámát Count művelettel vizsgáld.
    /// Használj Where szűrést és ToListAsync materializálást.
    /// </summary>
    public async Task<List<Reader>> GetReadersWithAtLeastBorrowsAsync(int minBorrowCount)
    {
        await Task.CompletedTask;
        return [];
    }

    /// <summary>
    /// Számold meg az adatbázisban lévő késedelmes kölcsönzési rekordokat.
    /// Egy rekord akkor késedelmes, ha az IsOverdue értéke true.
    /// Használj CountAsync hívást kézi számláló változó nélkül.
    /// </summary>
    public async Task<int> CountOverdueBorrowRecordsAsync()
    {
        await Task.CompletedTask;
        return 0;
    }

    /// <summary>
    /// Add vissza azokat az olvasókat, akiknek legalább minOverdueCount darab késedelmes kölcsönzése van.
    /// A kapcsolt BorrowRecords elemek közül csak az IsOverdue értékűeket számold.
    /// Használj Where szűrést, Count műveletet és ToListAsync materializálást.
    /// </summary>
    public async Task<List<Reader>> GetReadersWithAtLeastOverdueBorrowsAsync(int minOverdueCount)
    {
        await Task.CompletedTask;
        return [];
    }

    /// <summary>
    /// Add vissza a readerId paraméterrel megadott olvasó kölcsönzési rekordjait.
    /// A szűrést a BorrowRecord.ReaderId mező alapján végezd.
    /// Használj Where szűrést és ToListAsync materializálást.
    /// </summary>
    public async Task<List<BorrowRecord>> GetBorrowRecordsForReaderAsync(int readerId)
    {
        await Task.CompletedTask;
        return [];
    }

    /// <summary>
    /// Számold meg, hány kölcsönzési rekord tartozik a megadott könyvcímhez.
    /// A bookTitle paramétert a BorrowRecord.BookTitle mezővel hasonlítsd össze.
    /// Használj CountAsync hívást kézi számláló változó nélkül.
    /// </summary>
    public async Task<int> CountBorrowRecordsForBookAsync(string bookTitle)
    {
        await Task.CompletedTask;
        return 0;
    }
}