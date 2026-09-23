using App;

namespace Tests;

public static class EfProductCatalogQueriesTests
{
    public static async Task RunAllAsync()
    {
        await using var context = await TestData.CreateContextAsync();
        var efProductCatalogQueries = new EfProductCatalogQueries(context);

        Assert((await efProductCatalogQueries.FindFirstActiveProductByNameAsync())?.Sku == "API-300", "First active by name should be API Workshop.");
        Assert((await efProductCatalogQueries.FindProductBySkuAsync("CS-200"))?.Name == "C# Course", "SKU CS-200 should return C# Course.");
        Assert((await efProductCatalogQueries.GetActiveProductListItemsAsync())[0].Name == "API Workshop", "DTO list should be ordered by name.");
    }

    private static void Assert(bool condition, string message)
    {
        if (!condition) throw new Exception(message);
    }
}
