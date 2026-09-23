using Microsoft.EntityFrameworkCore;

var options = new DbContextOptionsBuilder<AppDbContext>()
    .UseInMemoryDatabase(Guid.NewGuid().ToString())
    .Options;

await using var dbContext = new AppDbContext(options);
        var warehouseEfficiencyReportQuery = new WarehouseEfficiencyReportQuery(dbContext);
TestData.Seed(dbContext);

var report = await warehouseEfficiencyReportQuery.CreateReportAsync("BUD-1");

AssertEqual(4, report.ProductCount, nameof(report.ProductCount));
AssertEqual(910000m, report.TotalStockValue, nameof(report.TotalStockValue));
AssertClose(6.75, report.AverageStockLevel, nameof(report.AverageStockLevel));
AssertEqual(2, report.LowestStockLevel, nameof(report.LowestStockLevel));
AssertClose(50, report.LowStockProductPercentage, nameof(report.LowStockProductPercentage));
AssertEqual(280000m, report.EstimatedReorderCost, nameof(report.EstimatedReorderCost));

Console.WriteLine("Minden Warehouse Efficiency Report teszt sikeres.");

static void AssertEqual<T>(T expected, T actual, string name)
{
    if (!EqualityComparer<T>.Default.Equals(expected, actual))
    {
        throw new Exception($"{name}: elvart={expected}, aktualis={actual}");
    }
}

static void AssertClose(double expected, double actual, string name)
{
    if (Math.Abs(expected - actual) > 0.001)
    {
        throw new Exception($"{name}: elvart={expected}, aktualis={actual}");
    }
}
