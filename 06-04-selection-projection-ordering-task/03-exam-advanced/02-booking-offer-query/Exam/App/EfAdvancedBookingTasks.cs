using Microsoft.EntityFrameworkCore;

namespace App;

public class EfAdvancedBookingTasks
{
    private readonly AppDbContext _dbContext;

    public EfAdvancedBookingTasks(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    /// <summary>
    /// Keresd meg az első aktív foglalási ajánlatot név szerinti sorrendben.
    /// Ha nincs aktív rekord, térj vissza null értékkel.
    /// Használj OrderBy-t és FirstOrDefaultAsync-et.
    /// </summary>
    public Task<BookingOffer?> FindFirstActiveByNameAsync()
    {
        return Task.FromResult<BookingOffer?>(null);
    }

    /// <summary>
    /// Keresd meg a foglalási ajánlatot pontos Code alapján.
    /// A Code üzletileg egyedi, ezért SingleOrDefaultAsync használata indokolt.
    /// </summary>
    public Task<BookingOffer?> FindByCodeAsync(string code)
    {
        return Task.FromResult<BookingOffer?>(null);
    }

    /// <summary>
    /// Add vissza az aktív foglalási ajánlatokat BookingOfferListItemDto listaként, név szerint rendezve.
    /// A lekérdezésben Select-et használj, hogy csak a DTO-hoz szükséges mezők kerüljenek ki.
    /// </summary>
    public Task<List<BookingOfferListItemDto>> GetActiveListItemsAsync()
    {
        return Task.FromResult(new List<BookingOfferListItemDto>());
    }
}