using Microsoft.EntityFrameworkCore;

namespace LinqWhereCountEfMedium;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public bool IsDiscounted { get; set; }
}

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products => Set<Product>();
}

public static class TestData
{
    public static void Seed(AppDbContext db)
    {
        db.Products.AddRange(
            new Product { Id = 1, Name = "Notebook", Category = "Tech", Price = 250000m, Stock = 4, IsDiscounted = false },
            new Product { Id = 2, Name = "Mouse", Category = "Tech", Price = 8000m, Stock = 20, IsDiscounted = true },
            new Product { Id = 3, Name = "Keyboard", Category = "Tech", Price = 18000m, Stock = 0, IsDiscounted = true },
            new Product { Id = 4, Name = "Desk", Category = "Office", Price = 70000m, Stock = 3, IsDiscounted = false },
            new Product { Id = 5, Name = "Chair", Category = "Office", Price = 45000m, Stock = 0, IsDiscounted = false });
        db.SaveChanges();
    }
}
