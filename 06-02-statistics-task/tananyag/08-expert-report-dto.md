# 08 - Expert riport DTO

Expert szinten a feladat mar nem egyetlen statisztikai ertek visszaadasa, hanem egy uzleti riport osszeallitasa.

Ilyenkor a DTO tobb, egymashoz kapcsolodo mezot tartalmaz:

- darabszam;
- osszeg;
- atlag;
- minimum vagy maximum;
- szazalek;
- uzleti celhoz viszonyitott teljesites.

## Pelda

```csharp
public class RevenuePerformanceReportDto
{
    public int ClosedOrderCount { get; set; }
    public decimal NetRevenue { get; set; }
    public decimal AverageClosedOrderValue { get; set; }
    public decimal LargestClosedOrderValue { get; set; }
    public double RefundedOrderPercentage { get; set; }
    public double RevenueTargetCompletionPercentage { get; set; }
}
```

## Gondolkodasi sorrend

1. Eloszor szurd le a relevans rekordokat `Where` segitsegevel.
2. Utana szamold ki az alap aggregatumokat: `CountAsync`, `SumAsync`, `AverageAsync`, `MinAsync`, `MaxAsync`.
3. A szazalekoknal kulon figyelj a nulla nevezore.
4. A vegen allitsd ossze a DTO-t.

## Kerulendo

Expert statisztika feladatban sem kell mellekesen uj LINQ temat bevezetni.

Ezert itt meg kerulendo:

- `GroupBy`;
- `Any`, `All`, `Contains`;
- rendezes es lapozas;
- sajat C# segedfuggveny meghivasa EF query belsejeben.

## Navigacio

- [Vissza a tananyag attekintesehez](./README.md)
