using Microsoft.EntityFrameworkCore;

DbContextOptions<AppDbContext> options = new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
await using AppDbContext dbContext = new(options);
        var customerRetentionReportQuery = new CustomerRetentionReportQuery(dbContext);
TestData.Seed(dbContext);

CustomerRetentionReportDto report = await customerRetentionReportQuery.CreateReportAsync();

AssertInt(4, report.TotalCustomerCount, "osszes ugyfel");
AssertInt(2, report.ActiveCustomerCount, "aktiv ugyfel");
AssertInt(2, report.ChurnedCustomerCount, "lemorzsolodott ugyfel");
AssertDouble(50.0, report.ChurnPercentage, "churn szazalek");
AssertDecimal(1000m, report.AverageActiveMonthlyRevenue, "atlagos aktiv MRR");

Console.WriteLine("Minden Customer Retention Report teszt sikeres.");

static void AssertInt(int expected, int actual, string message)
{
    if (expected != actual) throw new Exception($"{message}: elvart={expected}, aktualis={actual}");
}

static void AssertDouble(double expected, double actual, string message)
{
    if (Math.Abs(expected - actual) > 0.000001) throw new Exception($"{message}: elvart={expected}, aktualis={actual}");
}

static void AssertDecimal(decimal expected, decimal actual, string message)
{
    if (Math.Abs(expected - actual) > 0.000001m) throw new Exception($"{message}: elvart={expected}, aktualis={actual}");
}
