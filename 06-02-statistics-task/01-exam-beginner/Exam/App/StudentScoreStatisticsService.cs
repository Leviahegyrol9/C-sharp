using Microsoft.EntityFrameworkCore;

public class StudentScoreStatisticsService
{
    private readonly AppDbContext _dbContext;

    public StudentScoreStatisticsService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    /// <summary>
    /// Szamitsd ki az osszes tanuloi pontszam osszeget EF Core `SumAsync` hasznalataval.
    /// A lekerdezes a `StudentScores` DbSet-bol induljon, es minden rekord `Points` erteket vegye figyelembe.
    /// </summary>
    public async Task<int> SumPointsAsync()
    {
        await Task.CompletedTask;
        return 0;
    }

    /// <summary>
    /// Add vissza a legmagasabb tanuloi pontszamot EF Core `MaxAsync` hasznalataval.
    /// A feladatban a tesztadatok mindig tartalmaznak legalabb egy pontszamot.
    /// </summary>
    public async Task<int> GetHighestPointAsync()
    {
        await Task.CompletedTask;
        return 0;
    }

    /// <summary>
    /// Szamitsd ki az atlagos tanuloi pontszamot EF Core `AverageAsync` hasznalataval.
    /// Az eredmeny double legyen, es minden `StudentScore` rekord `Points` erteket hasznalja.
    /// </summary>
    public async Task<double> GetAveragePointAsync()
    {
        await Task.CompletedTask;
        return 0;
    }
}
