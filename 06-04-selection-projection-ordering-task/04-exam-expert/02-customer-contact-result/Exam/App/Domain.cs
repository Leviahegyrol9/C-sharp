using Microsoft.EntityFrameworkCore;

namespace App;

public sealed class CustomerContact
{
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public int Priority { get; set; }
    public bool IsActive { get; set; }
}

public sealed record CustomerContactResultDto(int Id, string Code, string Name, string Category, int Priority);

public sealed class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<CustomerContact> CustomerContacts => Set<CustomerContact>();
}

public static class TestData
{
    public static async Task<AppDbContext> CreateContextAsync()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        var context = new AppDbContext(options);
        context.CustomerContacts.AddRange(
            new CustomerContact { Id = 1, Code = "CUS-1", Name = "Beta Ltd", Category = "Partner", Priority = 3, IsActive = true },
            new CustomerContact { Id = 2, Code = "CUS-2", Name = "Acme Corp", Category = "Enterprise", Priority = 5, IsActive = true },
            new CustomerContact { Id = 3, Code = "CUS-3", Name = "Old Client", Category = "Archive", Priority = 1, IsActive = false },
            new CustomerContact { Id = 4, Code = "CUS-4", Name = "Alpha Kft", Category = "SMB", Priority = 4, IsActive = true });
        await context.SaveChangesAsync();
        return context;
    }
}