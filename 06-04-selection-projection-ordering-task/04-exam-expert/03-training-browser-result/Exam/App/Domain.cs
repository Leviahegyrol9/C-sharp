using Microsoft.EntityFrameworkCore;

namespace App;

public sealed class TrainingProgram
{
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public int Priority { get; set; }
    public bool IsActive { get; set; }
}

public sealed record TrainingBrowserResultDto(int Id, string Code, string Name, string Category, int Priority);

public sealed class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<TrainingProgram> TrainingPrograms => Set<TrainingProgram>();
}

public static class TestData
{
    public static async Task<AppDbContext> CreateContextAsync()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        var context = new AppDbContext(options);
        context.TrainingPrograms.AddRange(
            new TrainingProgram { Id = 1, Code = "TR-1", Name = "Backend Intro", Category = "Backend", Priority = 2, IsActive = true },
            new TrainingProgram { Id = 2, Code = "TR-2", Name = "EF Core Deep Dive", Category = "Backend", Priority = 5, IsActive = true },
            new TrainingProgram { Id = 3, Code = "TR-3", Name = "Old Training", Category = "Archive", Priority = 1, IsActive = false },
            new TrainingProgram { Id = 4, Code = "TR-4", Name = "Api Design", Category = "API", Priority = 4, IsActive = true });
        await context.SaveChangesAsync();
        return context;
    }
}