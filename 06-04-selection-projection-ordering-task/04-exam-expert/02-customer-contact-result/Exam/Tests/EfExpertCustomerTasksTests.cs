using App;

namespace Tests;

public static class EfExpertCustomerTasksTests
{
    public static async Task RunAllAsync()
    {
        await using var context = await TestData.CreateContextAsync();
        var efExpertCustomerTasks = new EfExpertCustomerTasks(context);
        Assert((await efExpertCustomerTasks.FindFirstActiveByNameAsync())?.Code == "CUS-4", "First active by name should be Alpha Kft.");
        Assert((await efExpertCustomerTasks.FindByCodeAsync("CUS-2"))?.Name == "Acme Corp", "Code CUS-2 should return Acme Corp.");
        Assert((await efExpertCustomerTasks.GetActiveListItemsAsync())[0].Name == "Alpha Kft", "DTO list should be ordered by name.");
    }

    private static void Assert(bool condition, string message)
    {
        if (!condition) throw new Exception(message);
    }
}