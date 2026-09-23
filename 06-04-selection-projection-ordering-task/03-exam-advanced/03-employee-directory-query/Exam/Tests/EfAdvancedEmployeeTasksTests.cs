using App;

namespace Tests;

public static class EfAdvancedEmployeeTasksTests
{
    public static async Task RunAllAsync()
    {
        await using var context = await TestData.CreateContextAsync();
        var efAdvancedEmployeeTasks = new EfAdvancedEmployeeTasks(context);
        Assert((await efAdvancedEmployeeTasks.FindFirstActiveByNameAsync())?.Code == "EMP-4", "First active by name should be Api Csilla.");
        Assert((await efAdvancedEmployeeTasks.FindByCodeAsync("EMP-2"))?.Name == "Cloud Bela", "Code EMP-2 should return Cloud Bela.");
        Assert((await efAdvancedEmployeeTasks.GetActiveListItemsAsync())[0].Name == "Api Csilla", "DTO list should be ordered by name.");
    }

    private static void Assert(bool condition, string message)
    {
        if (!condition) throw new Exception(message);
    }
}