using App;

namespace Tests;

public static class EfMediumCatalogTasksTests
{
    public static async Task RunAllAsync()
    {
        await using var context = await TestData.CreateContextAsync();
        var efMediumCatalogTasks = new EfMediumCatalogTasks(context);
        Assert((await efMediumCatalogTasks.FindFirstActiveProductByNameAsync())?.Sku == "API-300", "First active by name should be API Workshop.");
        Assert((await efMediumCatalogTasks.FindProductBySkuAsync("CS-200"))?.Name == "C# Course", "SKU CS-200 should return C# Course.");
        Assert((await efMediumCatalogTasks.GetActiveProductListItemsAsync())[0].Name == "API Workshop", "DTO list should be ordered by name.");
    }

    private static void Assert(bool condition, string message)
    {
        if (!condition) throw new Exception(message);
    }
}