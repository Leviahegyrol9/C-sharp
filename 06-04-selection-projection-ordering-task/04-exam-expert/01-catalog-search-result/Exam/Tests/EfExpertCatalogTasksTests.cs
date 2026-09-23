using App;

namespace Tests;

public static class EfExpertCatalogTasksTests
{
    public static async Task RunAllAsync()
    {
        await using var context = await TestData.CreateContextAsync();
        var efExpertCatalogTasks = new EfExpertCatalogTasks(context);
        Assert((await efExpertCatalogTasks.FindFirstActiveByNameAsync())?.Code == "CAT-4", "First active by name should be Advanced Course.");
        Assert((await efExpertCatalogTasks.FindByCodeAsync("CAT-2"))?.Name == "Api Workshop", "Code CAT-2 should return Api Workshop.");
        Assert((await efExpertCatalogTasks.GetActiveListItemsAsync())[0].Name == "Advanced Course", "DTO list should be ordered by name.");
    }

    private static void Assert(bool condition, string message)
    {
        if (!condition) throw new Exception(message);
    }
}