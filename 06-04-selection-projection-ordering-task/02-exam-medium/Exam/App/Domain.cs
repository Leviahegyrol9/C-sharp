using Microsoft.EntityFrameworkCore;

namespace App;

public sealed class Product
{
    public int Id { get; set; }
    public string Sku { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public bool IsActive { get; set; }
}

public sealed record ProductListItemDto(int Id, string Name, string Category, decimal Price);

public sealed class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products => Set<Product>();
}

public static class TestData
{
    public static async Task<AppDbContext> CreateContextAsync()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        var context = new AppDbContext(options);
        context.Products.AddRange(
            new Product { Id = 1, Sku = "BK-100", Name = "Backend Book", Category = "Book", Price = 12900m, IsActive = true },
            new Product { Id = 2, Sku = "CS-200", Name = "C# Course", Category = "Course", Price = 49000m, IsActive = true },
            new Product { Id = 3, Sku = "OLD-1", Name = "Old Package", Category = "Archive", Price = 9900m, IsActive = false },
            new Product { Id = 4, Sku = "API-300", Name = "API Workshop", Category = "Course", Price = 59000m, IsActive = true });
        await context.SaveChangesAsync();
        return context;
    }
}