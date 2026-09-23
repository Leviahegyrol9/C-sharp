using Microsoft.EntityFrameworkCore;

DbContextOptions<AppDbContext> options = new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
await using AppDbContext dbContext = new(options);
        var inventoryMarginStatisticsService = new InventoryMarginStatisticsService(dbContext);
TestData.Seed(dbContext);

AssertDecimal(1085m, await inventoryMarginStatisticsService.CalculateStockValueForCategoryAsync("Hardware"), "Hardware keszletertek");
AssertDecimal(5102m, await inventoryMarginStatisticsService.CalculatePotentialGrossMarginForCategoryAsync("Software"), "Software potencialis haszon");
AssertDouble(50.0, await inventoryMarginStatisticsService.CalculateLowStockProductPercentageAsync(), "alacsony keszlet aranya");

Console.WriteLine("Minden Inventory Margin Analytics teszt sikeres.");

static void AssertDecimal(decimal expected, decimal actual, string message)
{
    if (Math.Abs(expected - actual) > 0.000001m) throw new Exception($"{message}: elvart={expected}, aktualis={actual}");
}

static void AssertDouble(double expected, double actual, string message)
{
    if (Math.Abs(expected - actual) > 0.000001) throw new Exception($"{message}: elvart={expected}, aktualis={actual}");
}
