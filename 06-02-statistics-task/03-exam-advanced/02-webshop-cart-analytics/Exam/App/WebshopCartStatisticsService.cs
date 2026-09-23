using Microsoft.EntityFrameworkCore;

public class WebshopCartStatisticsService
{
    private readonly AppDbContext _dbContext;

    public WebshopCartStatisticsService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    /// <summary>
    /// Szamitsd ki a teljes netto bevetelt.
    /// A tetelek bruto erteke `UnitPrice * Quantity`, ebbol rendelesenkent le kell vonni a `DiscountAmount` erteket.
    /// Hasznalj EF Core aggregalo muveleteket, es ne kezi ciklust.
    /// </summary>
    public async Task<decimal> CalculateNetRevenueAsync()
    {
        await Task.CompletedTask;
        return 0m;
    }

    /// <summary>
    /// Szamitsd ki az atlagos kosarerteket rendelesenkent.
    /// A netto bevetelt oszd el a rendelesek darabszamaval.
    /// Ha nincs rendeles, az eredmeny legyen 0.
    /// </summary>
    public async Task<decimal> CalculateAverageCartValueAsync()
    {
        await Task.CompletedTask;
        return 0m;
    }

    /// <summary>
    /// Szamitsd ki a visszakuldott rendelesek aranyat szazalekban.
    /// Keplet: visszakuldott rendelesek szama / osszes rendeles szama * 100.
    /// </summary>
    public async Task<double> CalculateReturnedOrderPercentageAsync()
    {
        await Task.CompletedTask;
        return 0;
    }
}
