using App;

namespace Tests;

public static class EfAdvancedBookingTasksTests
{
    public static async Task RunAllAsync()
    {
        await using var context = await TestData.CreateContextAsync();
        var efAdvancedBookingTasks = new EfAdvancedBookingTasks(context);
        Assert((await efAdvancedBookingTasks.FindFirstActiveByNameAsync())?.Code == "CITY-3", "First active by name should be City Apartment.");
        Assert((await efAdvancedBookingTasks.FindByCodeAsync("SPA-2"))?.Name == "Spa Weekend", "Code SPA-2 should return Spa Weekend.");
        Assert((await efAdvancedBookingTasks.GetActiveListItemsAsync())[0].Name == "City Apartment", "DTO list should be ordered by name.");
    }

    private static void Assert(bool condition, string message)
    {
        if (!condition) throw new Exception(message);
    }
}