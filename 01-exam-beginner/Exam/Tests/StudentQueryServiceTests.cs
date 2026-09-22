using LinqWhereCountEfBeginner;
using Microsoft.EntityFrameworkCore;

namespace LinqWhereCountEfBeginner.Tests;

public static class StudentQueryServiceTests
{
    public static async Task RunAllAsync()
    {
        await using var db = CreateDb();
        var service = new StudentQueryService(db);

        Test("GetSuccessfulStudentsAsync returns students with grade at least 2",
            (await service.GetSuccessfulStudentsAsync()).Select(s => s.Name).SequenceEqual(["Anna", "Csaba", "Dora"]));

        Test("CountFailedStudentsAsync counts grade 1 students",
            await service.CountFailedStudentsAsync() == 1);

        Test("GetActiveStudentsAsync returns active students",
            (await service.GetActiveStudentsAsync()).Select(s => s.Name).SequenceEqual(["Anna", "Bela", "Dora"]));

        Test("CountStudentsInCityAsync counts students by city",
            await service.CountStudentsInCityAsync("Budapest") == 2);

        Console.WriteLine("All beginner EF tests passed.");
    }

    private static AppDbContext CreateDb()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        var db = new AppDbContext(options);
        TestData.Seed(db);
        return db;
    }

    private static void Test(string name, bool condition)
    {
        if (!condition)
        {
            throw new Exception($"Test failed: {name}");
        }
    }
}
