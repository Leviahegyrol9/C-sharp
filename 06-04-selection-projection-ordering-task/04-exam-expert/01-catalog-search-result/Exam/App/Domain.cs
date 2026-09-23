using Microsoft.EntityFrameworkCore;

namespace App;

public sealed class CatalogItem
{
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public int Priority { get; set; }
    public bool IsActive { get; set; }
}

public sealed record CatalogSearchResultDto(int Id, string Code, string Name, string Category, int Priority);

public sealed class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<CatalogItem> CatalogItems => Set<CatalogItem>();
}

public static class TestData
{
    public static async Task<AppDbContext> CreateContextAsync()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        var context = new AppDbContext(options);
        context.CatalogItems.AddRange(
            new CatalogItem { Id = 1, Code = "CAT-1", Name = "Backend Book", Category = "Book", Priority = 3, IsActive = true },
            new CatalogItem { Id = 2, Code = "CAT-2", Name = "Api Workshop", Category = "Training", Priority = 5, IsActive = true },
            new CatalogItem { Id = 3, Code = "CAT-3", Name = "Old Bundle", Category = "Archive", Priority = 1, IsActive = false },
            new CatalogItem { Id = 4, Code = "CAT-4", Name = "Advanced Course", Category = "Course", Priority = 4, IsActive = true });
        await context.SaveChangesAsync();
        return context;
    }
}