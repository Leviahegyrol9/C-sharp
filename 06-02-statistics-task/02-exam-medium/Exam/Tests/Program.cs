using Microsoft.EntityFrameworkCore;

DbContextOptions<AppDbContext> options = new DbContextOptionsBuilder<AppDbContext>()
    .UseInMemoryDatabase(Guid.NewGuid().ToString())
    .Options;

await using AppDbContext dbContext = new(options);
        var productInventoryStatisticsService = new ProductInventoryStatisticsService(dbContext);
TestData.Seed(dbContext);

AssertDecimal(3485m, await productInventoryStatisticsService.CalculateStockValueAsync(), "keszletertek");
AssertDecimal(44.666666666666666666666666667m, await productInventoryStatisticsService.CalculateAverageUnitPriceAsync(), "atlagos eladasi ar");
AssertDouble(33.33333333333333, await productInventoryStatisticsService.CalculateLowStockPercentageAsync(), "alacsony keszlet aranya");

Console.WriteLine("Minden medium EF statisztika teszt sikeres.");

static void AssertDecimal(decimal expected, decimal actual, string message)
{
    if (Math.Abs(expected - actual) > 0.000001m)
    {
        throw new Exception($"{message}: elvart={expected}, aktualis={actual}");
    }
}

static void AssertDouble(double expected, double actual, string message)
{
    if (Math.Abs(expected - actual) > 0.000001)
    {
        throw new Exception($"{message}: elvart={expected}, aktualis={actual}");
    }
}
