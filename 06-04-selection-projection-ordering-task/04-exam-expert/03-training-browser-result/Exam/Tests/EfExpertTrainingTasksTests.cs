using App;

namespace Tests;

public static class EfExpertTrainingTasksTests
{
    public static async Task RunAllAsync()
    {
        await using var context = await TestData.CreateContextAsync();
        var efExpertTrainingTasks = new EfExpertTrainingTasks(context);
        Assert((await efExpertTrainingTasks.FindFirstActiveByNameAsync())?.Code == "TR-4", "First active by name should be Api Design.");
        Assert((await efExpertTrainingTasks.FindByCodeAsync("TR-2"))?.Name == "EF Core Deep Dive", "Code TR-2 should return EF Core Deep Dive.");
        Assert((await efExpertTrainingTasks.GetActiveListItemsAsync())[0].Name == "Api Design", "DTO list should be ordered by name.");
    }

    private static void Assert(bool condition, string message)
    {
        if (!condition) throw new Exception(message);
    }
}