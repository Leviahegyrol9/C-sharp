using Microsoft.EntityFrameworkCore;

public class FinancialMonthlySummaryQuery
{
    private readonly AppDbContext _dbContext;

    public FinancialMonthlySummaryQuery(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    /// <summary>
    /// Keszits havi penzugyi osszesito DTO-t a megadott `year` es `month` alapjan.
    /// Szamold ki a havi bevetelt, havi koltseget, profitot, profit margin szazalekot,
    /// valamint a tervhez kepesti beveteli teljesulest.
    /// Hasznalj EF Core `SumAsync` muveleteket es szazalekszamitast.
    /// </summary>
    public async Task<FinancialMonthlySummaryDto> CreateSummaryAsync(int year, int month)
    {
        await Task.CompletedTask;
        return new FinancialMonthlySummaryDto();
    }
}
