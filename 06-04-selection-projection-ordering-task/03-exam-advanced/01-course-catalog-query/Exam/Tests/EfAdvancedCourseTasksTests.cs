using App;

namespace Tests;

public static class EfAdvancedCourseTasksTests
{
    public static async Task RunAllAsync()
    {
        await using var context = await TestData.CreateContextAsync();
        var efAdvancedCourseTasks = new EfAdvancedCourseTasks(context);
        Assert((await efAdvancedCourseTasks.FindFirstActiveByNameAsync())?.Code == "DB-300", "First active by name should be Databases.");
        Assert((await efAdvancedCourseTasks.FindByCodeAsync("API-210"))?.Name == "REST API", "Code API-210 should return REST API.");
        Assert((await efAdvancedCourseTasks.GetActiveListItemsAsync())[0].Name == "Databases", "DTO list should be ordered by name.");
    }

    private static void Assert(bool condition, string message)
    {
        if (!condition) throw new Exception(message);
    }
}