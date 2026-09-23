# 02 Exam - Medium EF Statistics

## Tema

Tobb mezos `ProductInventory` domainen gyakoroljuk az EF Core statisztikai szamitasokat.

## Feladat

Toltsd ki a `ProductInventoryStatisticsService` metodusait.

## Megoldando metodusok

- `CalculateStockValueAsync`: teljes keszletertek `StockQuantity * UnitCost` alapjan.
- `CalculateAverageUnitPriceAsync`: atlagos eladasi ar.
- `CalculateLowStockPercentageAsync`: alacsony keszletu termekek aranya szazalekban.

## Ellenorzes

```bash
dotnet run --project Exam/Tests
```

## Navigacio

- [Vissza az EF statisztika agahoz](../README.md)
