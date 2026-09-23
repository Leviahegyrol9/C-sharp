using Microsoft.EntityFrameworkCore;

namespace App;

public sealed class Course
{
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public int Priority { get; set; }
    public bool IsActive { get; set; }
}

public sealed record CourseListItemDto(int Id, string Code, string Name, string Category, int Priority);

public sealed class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Course> Courses => Set<Course>();
}

public static class TestData
{
    public static async Task<AppDbContext> CreateContextAsync()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        var context = new AppDbContext(options);
        context.Courses.AddRange(
            new Course { Id = 1, Code = "CS-101", Name = "CSharp Basics", Category = "Backend", Priority = 2, IsActive = true },
            new Course { Id = 2, Code = "API-210", Name = "REST API", Category = "Backend", Priority = 4, IsActive = true },
            new Course { Id = 3, Code = "OLD-1", Name = "Legacy Tools", Category = "Archive", Priority = 1, IsActive = false },
            new Course { Id = 4, Code = "DB-300", Name = "Databases", Category = "Data", Priority = 3, IsActive = true });
        await context.SaveChangesAsync();
        return context;
    }
}