using Microsoft.EntityFrameworkCore;

public class WarehouseEfficiencyReportQuery
{
    private readonly AppDbContext _dbContext;

    public WarehouseEfficiencyReportQuery(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    /// <summary>
    /// Keszits keszlet hatekonysagi riportot a megadott raktar termekeibol.
    /// Szamold ki a termekek szamat, a teljes keszleterteket, az atlagos es legalacsonyabb keszletszintet,
    /// az alacsony keszleten levo termekek aranyat, valamint az alacsony keszletes termekek becsult utanrendelesi koltseget.
    /// Alacsony keszletnek az szamit, ahol Quantity kisebb, mint ReorderLevel.
    /// </summary>
    public async Task<WarehouseEfficiencyReportDto> CreateReportAsync(string warehouseCode)
    {
        await Task.CompletedTask;
        return new WarehouseEfficiencyReportDto();
    }
}
