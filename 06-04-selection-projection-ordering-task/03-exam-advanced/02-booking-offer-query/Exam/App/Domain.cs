using Microsoft.EntityFrameworkCore;

namespace App;

public sealed class BookingOffer
{
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public int Priority { get; set; }
    public bool IsActive { get; set; }
}

public sealed record BookingOfferListItemDto(int Id, string Code, string Name, string Category, int Priority);

public sealed class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<BookingOffer> BookingOffers => Set<BookingOffer>();
}

public static class TestData
{
    public static async Task<AppDbContext> CreateContextAsync()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        var context = new AppDbContext(options);
        context.BookingOffers.AddRange(
            new BookingOffer { Id = 1, Code = "ROOM-1", Name = "Budget Room", Category = "Hotel", Priority = 2, IsActive = true },
            new BookingOffer { Id = 2, Code = "SPA-2", Name = "Spa Weekend", Category = "Package", Priority = 5, IsActive = true },
            new BookingOffer { Id = 3, Code = "OLD-1", Name = "Old Offer", Category = "Archive", Priority = 1, IsActive = false },
            new BookingOffer { Id = 4, Code = "CITY-3", Name = "City Apartment", Category = "Apartment", Priority = 4, IsActive = true });
        await context.SaveChangesAsync();
        return context;
    }
}