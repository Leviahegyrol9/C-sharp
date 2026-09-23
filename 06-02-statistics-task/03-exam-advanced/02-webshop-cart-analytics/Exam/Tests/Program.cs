using Microsoft.EntityFrameworkCore;

DbContextOptions<AppDbContext> options = new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
await using AppDbContext dbContext = new(options);
        var webshopCartStatisticsService = new WebshopCartStatisticsService(dbContext);
TestData.Seed(dbContext);

AssertDecimal(305m, await webshopCartStatisticsService.CalculateNetRevenueAsync(), "netto bevetel");
AssertDecimal(101.66666666666666666666666667m, await webshopCartStatisticsService.CalculateAverageCartValueAsync(), "atlagos kosarertek");
AssertDouble(33.33333333333333, await webshopCartStatisticsService.CalculateReturnedOrderPercentageAsync(), "visszakuldesi arany");

Console.WriteLine("Minden Webshop Cart Analytics teszt sikeres.");

static void AssertDecimal(decimal expected, decimal actual, string message)
{
    if (Math.Abs(expected - actual) > 0.000001m) throw new Exception($"{message}: elvart={expected}, aktualis={actual}");
}

static void AssertDouble(double expected, double actual, string message)
{
    if (Math.Abs(expected - actual) > 0.000001) throw new Exception($"{message}: elvart={expected}, aktualis={actual}");
}
