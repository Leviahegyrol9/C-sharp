using Microsoft.EntityFrameworkCore;

public class SubscriptionHealthReportQuery
{
    private readonly AppDbContext _dbContext;

    public SubscriptionHealthReportQuery(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    /// <summary>
    /// Keszits SaaS elofizetesi egeszseg riportot az osszes ugyfelbol.
    /// Szamold ki az osszes, aktiv es lemondott ugyfelek szamat, az aktiv ugyfelek havi ismetlodo bevetelét,
    /// az aktiv ugyfelek atlagos havi dijat, a churn aranyt, valamint a trialbol fizetosse valt ugyfelek aranyat.
    /// A szazalekszamitasoknal nulla nevezonel 0 legyen az eredmeny.
    /// </summary>
    public async Task<SubscriptionHealthReportDto> CreateReportAsync()
    {
        await Task.CompletedTask;
        return new SubscriptionHealthReportDto();
    }
}
