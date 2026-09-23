using Microsoft.EntityFrameworkCore;

var options = new DbContextOptionsBuilder<AppDbContext>()
    .UseInMemoryDatabase(Guid.NewGuid().ToString())
    .Options;

await using var dbContext = new AppDbContext(options);
        var subscriptionHealthReportQuery = new SubscriptionHealthReportQuery(dbContext);
TestData.Seed(dbContext);

var report = await subscriptionHealthReportQuery.CreateReportAsync();

AssertEqual(5, report.CustomerCount, nameof(report.CustomerCount));
AssertEqual(3, report.ActiveCustomerCount, nameof(report.ActiveCustomerCount));
AssertEqual(2, report.CancelledCustomerCount, nameof(report.CancelledCustomerCount));
AssertEqual(3000m, report.MonthlyRecurringRevenue, nameof(report.MonthlyRecurringRevenue));
AssertEqual(1000m, report.AverageActiveMonthlyFee, nameof(report.AverageActiveMonthlyFee));
AssertClose(40, report.ChurnPercentage, nameof(report.ChurnPercentage));
AssertClose(66.6666666667, report.TrialConversionPercentage, nameof(report.TrialConversionPercentage));

Console.WriteLine("Minden Subscription Health Report teszt sikeres.");

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
