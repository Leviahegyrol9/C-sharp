using Microsoft.EntityFrameworkCore;

DbContextOptions<AppDbContext> options = new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
await using AppDbContext dbContext = new(options);
        var courseCompletionStatisticsService = new CourseCompletionStatisticsService(dbContext);
TestData.Seed(dbContext);

AssertDouble(70.0, await courseCompletionStatisticsService.CalculateCompletionPercentageForDepartmentAsync("Backend"), "Backend teljesitesi arany");
AssertDouble(118.33333333333333, await courseCompletionStatisticsService.CalculateAverageWatchMinutesPerStudentForRequiredCoursesAsync(), "perc / hallgato");
AssertInt(1, await courseCompletionStatisticsService.CountRequiredCoursesBelowCompletionAsync(70), "kuszob alatti kotelezo kurzusok");

Console.WriteLine("Minden Course Completion Analytics teszt sikeres.");

static void AssertDouble(double expected, double actual, string message)
{
    if (Math.Abs(expected - actual) > 0.000001) throw new Exception($"{message}: elvart={expected}, aktualis={actual}");
}

static void AssertInt(int expected, int actual, string message)
{
    if (expected != actual) throw new Exception($"{message}: elvart={expected}, aktualis={actual}");
}
