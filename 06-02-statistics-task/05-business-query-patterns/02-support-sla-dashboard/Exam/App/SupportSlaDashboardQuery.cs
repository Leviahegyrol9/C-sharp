using Microsoft.EntityFrameworkCore;

public class SupportSlaDashboardQuery
{
    private readonly AppDbContext _dbContext;

    public SupportSlaDashboardQuery(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    /// <summary>
    /// Keszits SupportSlaDashboardDto valaszt a hibajegyekbol.
    /// Szamold ki az osszes es lezart hibajegyet, a lezart hibajegyek SLA-n beluli aranyat,
    /// az atlagos elso valaszidot, valamint azoknak az ugyintezoknek a szamat,
    /// akikhez legalabb `overloadedTicketThreshold` hibajegy tartozik.
    /// Hasznalj EF Core aggregalo muveleteket es szazalekszamitast.
    /// </summary>
    public async Task<SupportSlaDashboardDto> CreateDashboardAsync(int overloadedTicketThreshold)
    {
        await Task.CompletedTask;
        return new SupportSlaDashboardDto();
    }
}
