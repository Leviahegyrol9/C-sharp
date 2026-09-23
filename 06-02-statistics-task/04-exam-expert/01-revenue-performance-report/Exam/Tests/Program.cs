using Microsoft.EntityFrameworkCore;

var options = new DbContextOptionsBuilder<AppDbContext>()
    .UseInMemoryDatabase(Guid.NewGuid().ToString())
    .Options;

await using var dbContext = new AppDbContext(options);
        var revenuePerformanceReportQuery = new RevenuePerformanceReportQuery(dbContext);
TestData.Seed(dbContext);

var report = await revenuePerformanceReportQuery.CreateReportAsync(2026, 9);

AssertEqual(4, report.ClosedOrderCount, nameof(report.ClosedOrderCount));
AssertEqual(3000m, report.NetRevenue, nameof(report.NetRevenue));
AssertEqual(750m, report.AverageClosedOrderValue, nameof(report.AverageClosedOrderValue));
AssertEqual(1500m, report.LargestClosedOrderValue, nameof(report.LargestClosedOrderValue));
AssertClose(25, report.RefundedOrderPercentage, nameof(report.RefundedOrderPercentage));
AssertClose(75, report.RevenueTargetCompletionPercentage, nameof(report.RevenueTargetCompletionPercentage));

Console.WriteLine("Minden Revenue Performance Report teszt sikeres.");

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
