using Microsoft.EntityFrameworkCore;

namespace LinqWhereCountEfAdvancedCourses;

public static class CourseEnrollmentQueryServiceTests
{
    public static async Task RunAllAsync()
    {
        await using var db = CreateDb();
        var courseEnrollmentQueryService = new CourseEnrollmentQueryService(db);
        AssertEqual(3, await courseEnrollmentQueryService.CountActiveEnrollmentsAsync(), "aktiv jelentkezesek");
        AssertEqual(1, (await courseEnrollmentQueryService.GetCoursesWithAtLeastEnrollmentsAsync(3)).Count, "legalabb 3 jelentkezeses kurzus");
        AssertEqual(1, (await courseEnrollmentQueryService.GetStudentsWithAtLeastEnrollmentsAsync(2)).Count, "legalabb 2 kurzusos hallgato");
        AssertEqual(1, (await courseEnrollmentQueryService.GetEnrollmentsByStatusAsync("Cancelled")).Count, "cancelled jelentkezesek");
        AssertEqual(3, await courseEnrollmentQueryService.CountEnrollmentsForCourseTitleAsync("Backend"), "Backend jelentkezesek");
    }

    private static AppDbContext CreateDb()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
        var db = new AppDbContext(options);
        var courseEnrollmentQueryService = new CourseEnrollmentQueryService(db);
        TestData.Seed(db);
        return db;
    }

    private static void AssertEqual<T>(T expected, T actual, string name)
    {
        if (!EqualityComparer<T>.Default.Equals(expected, actual))
        {
            throw new Exception($"{name}: elvart={expected}, aktualis={actual}");
        }
    }
}