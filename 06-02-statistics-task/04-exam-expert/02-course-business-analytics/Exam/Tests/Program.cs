using Microsoft.EntityFrameworkCore;

var options = new DbContextOptionsBuilder<AppDbContext>()
    .UseInMemoryDatabase(Guid.NewGuid().ToString())
    .Options;

await using var dbContext = new AppDbContext(options);
        var courseBusinessAnalyticsQuery = new CourseBusinessAnalyticsQuery(dbContext);
TestData.Seed(dbContext);

var report = await courseBusinessAnalyticsQuery.CreateReportAsync("Backend");

AssertEqual(3, report.PublishedCourseCount, nameof(report.PublishedCourseCount));
AssertEqual(100, report.TotalEnrollmentCount, nameof(report.TotalEnrollmentCount));
AssertClose(75, report.AverageCompletionPercentage, nameof(report.AverageCompletionPercentage));
AssertClose(60, report.LowestCompletionPercentage, nameof(report.LowestCompletionPercentage));
AssertEqual(12550m, report.TotalRevenue, nameof(report.TotalRevenue));
AssertClose(78, report.SuccessfulCompletionPercentage, nameof(report.SuccessfulCompletionPercentage));

Console.WriteLine("Minden Course Business Analytics teszt sikeres.");

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
