using LinqWhereCountEfMedium;
using Microsoft.EntityFrameworkCore;

namespace LinqWhereCountEfMedium.Tests;

public static class ProductQueryServiceTests
{
    public static async Task RunAllAsync()
    {
        await using var db = CreateDb();
        var productQueryService = new ProductQueryService(db);

        Test("GetProductsInStockAsync returns products with positive stock",
            (await productQueryService.GetProductsInStockAsync()).Select(p => p.Name).SequenceEqual(["Notebook", "Mouse", "Desk"]));

        Test("CountOutOfStockProductsAsync counts products with zero stock",
            await productQueryService.CountOutOfStockProductsAsync() == 2);

        Test("GetProductsCheaperThanAsync returns products below max price",
            (await productQueryService.GetProductsCheaperThanAsync(50000m)).Select(p => p.Name).SequenceEqual(["Mouse", "Keyboard", "Chair"]));

        Test("CountProductsInPriceRangeAsync counts products inside inclusive range",
            await productQueryService.CountProductsInPriceRangeAsync(10000m, 80000m) == 3);

        Test("GetDiscountedProductsInStockAsync returns discounted products with positive stock",
            (await productQueryService.GetDiscountedProductsInStockAsync()).Select(p => p.Name).SequenceEqual(["Mouse"]));

        Console.WriteLine("All medium EF tests passed.");
    }

    private static AppDbContext CreateDb()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        var db = new AppDbContext(options);
        var productQueryService = new ProductQueryService(db);
        TestData.Seed(db);
        return db;
    }

    private static void Test(string name, bool condition)
    {
        if (!condition)
        {
            throw new Exception($"Test failed: {name}");
        }
    }
}
