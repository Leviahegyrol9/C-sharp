using Microsoft.EntityFrameworkCore;

public class InventoryMarginStatisticsService
{
    private readonly AppDbContext _dbContext;

    public InventoryMarginStatisticsService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    /// <summary>
    /// Szamitsd ki egy kategoria teljes keszleterteket bekerulesi aron.
    /// Csak a `category` parameterrel megegyezo sorokat hasznald.
    /// Soronkent a keszletertek: `StockQuantity * UnitCost`.
    /// </summary>
    public async Task<decimal> CalculateStockValueForCategoryAsync(string category)
    {
        await Task.CompletedTask;
        return 0m;
    }

    /// <summary>
    /// Szamitsd ki egy kategoria potencialis brutto hasznat az eladhato keszlet alapjan.
    /// Az eladhato darab: `StockQuantity - ReservedQuantity`.
    /// Soronkent a potencialis haszon: `(UnitPrice - UnitCost) * eladhato darab`.
    /// </summary>
    public async Task<decimal> CalculatePotentialGrossMarginForCategoryAsync(string category)
    {
        await Task.CompletedTask;
        return 0m;
    }

    /// <summary>
    /// Szamitsd ki, hogy a termekek hany szazaleka van ujrarendelesi szint alatt.
    /// Egy termek alacsony keszletu, ha `StockQuantity < ReorderLevel`.
    /// </summary>
    public async Task<double> CalculateLowStockProductPercentageAsync()
    {
        await Task.CompletedTask;
        return 0;
    }
}
