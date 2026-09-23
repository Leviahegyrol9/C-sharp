using Microsoft.EntityFrameworkCore;

public class CustomerRetentionReportQuery
{
    private readonly AppDbContext _dbContext;

    public CustomerRetentionReportQuery(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    /// <summary>
    /// Megoldott minta: keszits CustomerRetentionReportDto valaszt ugyfel-elofizetesi adatokbol.
    /// Szamold ki az osszes, aktiv es lemorzsolodott ugyfelek szamat, a churn szazalekot,
    /// valamint az aktiv ugyfelek atlagos havi visszatero bevetelét.
    /// </summary>
    public async Task<CustomerRetentionReportDto> CreateReportAsync()
    {
        int totalCustomerCount = await _dbContext.CustomerSubscriptions.CountAsync();
        int activeCustomerCount = await _dbContext.CustomerSubscriptions.CountAsync(customer => customer.IsActive);
        int churnedCustomerCount = await _dbContext.CustomerSubscriptions.CountAsync(customer => !customer.IsActive);

        decimal averageActiveMonthlyRevenue = activeCustomerCount == 0
            ? 0m
            : await _dbContext.CustomerSubscriptions
                .Where(customer => customer.IsActive)
                .AverageAsync(customer => customer.MonthlyRecurringRevenue);

        double churnPercentage = totalCustomerCount == 0
            ? 0
            : (double)churnedCustomerCount / totalCustomerCount * 100;

        return new CustomerRetentionReportDto
        {
            TotalCustomerCount = totalCustomerCount,
            ActiveCustomerCount = activeCustomerCount,
            ChurnedCustomerCount = churnedCustomerCount,
            ChurnPercentage = churnPercentage,
            AverageActiveMonthlyRevenue = averageActiveMonthlyRevenue
        };
    }
}
