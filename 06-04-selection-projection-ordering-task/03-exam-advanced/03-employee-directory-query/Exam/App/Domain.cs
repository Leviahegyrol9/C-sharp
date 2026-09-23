using Microsoft.EntityFrameworkCore;

namespace App;

public sealed class EmployeeProfile
{
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public int Priority { get; set; }
    public bool IsActive { get; set; }
}

public sealed record EmployeeListItemDto(int Id, string Code, string Name, string Category, int Priority);

public sealed class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<EmployeeProfile> EmployeeProfiles => Set<EmployeeProfile>();
}

public static class TestData
{
    public static async Task<AppDbContext> CreateContextAsync()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        var context = new AppDbContext(options);
        context.EmployeeProfiles.AddRange(
            new EmployeeProfile { Id = 1, Code = "EMP-1", Name = "Backend Anna", Category = "Development", Priority = 3, IsActive = true },
            new EmployeeProfile { Id = 2, Code = "EMP-2", Name = "Cloud Bela", Category = "Operations", Priority = 5, IsActive = true },
            new EmployeeProfile { Id = 3, Code = "EMP-3", Name = "Old Contractor", Category = "Archive", Priority = 1, IsActive = false },
            new EmployeeProfile { Id = 4, Code = "EMP-4", Name = "Api Csilla", Category = "Integration", Priority = 4, IsActive = true });
        await context.SaveChangesAsync();
        return context;
    }
}