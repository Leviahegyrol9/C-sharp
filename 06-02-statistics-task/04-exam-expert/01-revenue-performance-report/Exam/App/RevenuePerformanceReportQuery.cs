using Microsoft.EntityFrameworkCore;

public class RevenuePerformanceReportQuery
{
    private readonly AppDbContext _dbContext;

    public RevenuePerformanceReportQuery(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    /// <summary>
    /// Keszits havi webshop beveteli riportot az adott ev es honap lezarult rendeleseibol.
    /// Szamold ki a lezarult rendelesek darabszamat, a netto bevetelt, az atlagos es legnagyobb netto rendelesi erteket,
    /// a visszateritett rendelesek aranyat, valamint a havi beveteli cel teljesuleset.
    /// Hasznalj Where szurest, EF Core aggregalo muveleteket es nulla nevezonel adj 0 szazalekot.
    /// </summary>
    public async Task<RevenuePerformanceReportDto> CreateReportAsync(int year, int month)
    {
        await Task.CompletedTask;
        return new RevenuePerformanceReportDto();
    }
}
