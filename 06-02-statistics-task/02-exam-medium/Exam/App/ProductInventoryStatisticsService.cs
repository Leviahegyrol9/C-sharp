using Microsoft.EntityFrameworkCore;

public class ProductInventoryStatisticsService
{
    private readonly AppDbContext _dbContext;

    public ProductInventoryStatisticsService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    /// <summary>
    /// Szamitsd ki a teljes keszleterteket bekerulesi aron.
    /// Minden termeknel a `StockQuantity * UnitCost` szamitott erteket kell osszegezni EF Core `SumAsync` hasznalataval.
    /// </summary>
    public async Task<decimal> CalculateStockValueAsync()
    {
        await Task.CompletedTask;
        return 0m;
    }

    /// <summary>
    /// Szamitsd ki az atlagos eladasi arat az osszes termek `UnitPrice` mezoje alapjan.
    /// Hasznalj EF Core `AverageAsync` muveletet.
    /// </summary>
    public async Task<decimal> CalculateAverageUnitPriceAsync()
    {
        await Task.CompletedTask;
        return 0m;
    }

    /// <summary>
    /// Szamitsd ki, hogy a termekek hany szazaleka van ujrarendelesi szint alatt.
    /// Egy termek alacsony keszletu, ha `StockQuantity < ReorderLevel`.
    /// Hasznalj `CountAsync` muveleteket es szazalekszamitast.
    /// </summary>
    public async Task<double> CalculateLowStockPercentageAsync()
    {
        await Task.CompletedTask;
        return 0;
    }
}
