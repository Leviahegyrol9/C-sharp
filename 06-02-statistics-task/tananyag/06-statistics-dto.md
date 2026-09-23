# 06 - Statisztikai DTO

Backend API-ban a statisztika gyakran DTO-kent jelenik meg.

```csharp
public class RevenueStatisticsDto
{
    public decimal TotalRevenue { get; set; }
    public decimal AverageOrderValue { get; set; }
    public double ReturnRatePercentage { get; set; }
}
```

A DTO tobb aggregalt erteket fog ossze. Ezeket kezdoknel kulon query-kbol is ki lehet szamolni. Expert szinten mar fontos tema, hogy mikor fut le hany adatbazis-lekerdezes.
