using Microsoft.EntityFrameworkCore;

namespace LinqWhereCountEfAdvancedSupport;

public static class SupportTicketActivityServiceTests
{
    public static async Task RunAllAsync()
    {
        await using var db = CreateDb();
        var supportTicketActivityService = new SupportTicketActivityService(db);
        AssertEqual(2, await supportTicketActivityService.CountOpenTicketsAsync(), "nyitott ticketek");
        AssertEqual(1, (await supportTicketActivityService.GetCustomersWithAtLeastTicketsAsync(2)).Count, "legalabb 2 ticketes ugyfel");
        AssertEqual(1, (await supportTicketActivityService.GetTicketsWithAtLeastMessagesAsync(2)).Count, "legalabb 2 uzenetes ticket");
        AssertEqual(1, await supportTicketActivityService.CountTicketsByStatusAsync("Closed"), "lezart ticketek");
        AssertEqual(2, (await supportTicketActivityService.GetTicketsForCustomerAsync(1)).Count, "Contoso ticketek");
    }

    private static AppDbContext CreateDb()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
        var db = new AppDbContext(options);
        var supportTicketActivityService = new SupportTicketActivityService(db);
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