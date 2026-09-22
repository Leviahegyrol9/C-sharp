using Microsoft.EntityFrameworkCore;

namespace LinqWhereCountEfAdvancedLibrary;

public static class LibraryQueryServiceTests
{
    public static async Task RunAllAsync()
    {
        await using var db = CreateDb();
        var libraryQueryService = new LibraryQueryService(db);
        AssertEqual(1, (await libraryQueryService.GetReadersWithAtLeastBorrowsAsync(3)).Count, "legalabb 3 kolcsonzes");
        AssertEqual(2, await libraryQueryService.CountOverdueBorrowRecordsAsync(), "kesedelmes kolcsonzesek");
        AssertEqual(2, (await libraryQueryService.GetReadersWithAtLeastOverdueBorrowsAsync(1)).Count, "legalabb 1 kesedelmes");
        AssertEqual(3, (await libraryQueryService.GetBorrowRecordsForReaderAsync(1)).Count, "Anna kolcsonzesei");
        AssertEqual(2, await libraryQueryService.CountBorrowRecordsForBookAsync("Clean Code"), "Clean Code darab");
    }

    private static AppDbContext CreateDb()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
        var db = new AppDbContext(options);
        var libraryQueryService = new LibraryQueryService(db);
        TestData.Seed(db);
        return db;
    }

    private static void AssertEqual<T>(T expected, T actual, string name)
    {
        if (!EqualityComparer<T>.Default.Equals(expected, actual))
        {
            throw new Exception($"{name}: elvart={expected}, aktualis={actual}");
        }
    }
}