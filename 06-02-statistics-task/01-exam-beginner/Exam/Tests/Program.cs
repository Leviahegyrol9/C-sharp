using Microsoft.EntityFrameworkCore;

DbContextOptions<AppDbContext> options = new DbContextOptionsBuilder<AppDbContext>()
    .UseInMemoryDatabase(Guid.NewGuid().ToString())
    .Options;

await using AppDbContext dbContext = new(options);
        var studentScoreStatisticsService = new StudentScoreStatisticsService(dbContext);
TestData.Seed(dbContext);

AssertEqual(191, await studentScoreStatisticsService.SumPointsAsync(), "osszes pontszam");
AssertEqual(82, await studentScoreStatisticsService.GetHighestPointAsync(), "legmagasabb pontszam");
AssertDouble(63.666666666666664, await studentScoreStatisticsService.GetAveragePointAsync(), "atlagpontszam");

Console.WriteLine("Minden beginner EF statisztika teszt sikeres.");

static void AssertEqual(int expected, int actual, string message)
{
    if (expected != actual)
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
