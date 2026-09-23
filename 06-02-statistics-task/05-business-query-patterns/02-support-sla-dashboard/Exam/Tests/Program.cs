using Microsoft.EntityFrameworkCore;

DbContextOptions<AppDbContext> options = new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
await using AppDbContext dbContext = new(options);
        var supportSlaDashboardQuery = new SupportSlaDashboardQuery(dbContext);
TestData.Seed(dbContext);

SupportSlaDashboardDto dashboard = await supportSlaDashboardQuery.CreateDashboardAsync(3);

AssertInt(5, dashboard.TotalTicketCount, "osszes ticket");
AssertInt(3, dashboard.ClosedTicketCount, "lezart ticket");
AssertDouble(66.66666666666666, dashboard.ClosedWithinSlaPercentage, "SLA arany");
AssertDouble(34.0, dashboard.AverageFirstResponseMinutes, "atlagos elso valaszido");
AssertInt(1, dashboard.OverloadedAgentCount, "tulterhelt ugyintezok");

Console.WriteLine("Minden Support SLA Dashboard teszt sikeres.");

static void AssertInt(int expected, int actual, string message)
{
    if (expected != actual) throw new Exception($"{message}: elvart={expected}, aktualis={actual}");
}

static void AssertDouble(double expected, double actual, string message)
{
    if (Math.Abs(expected - actual) > 0.000001) throw new Exception($"{message}: elvart={expected}, aktualis={actual}");
}
