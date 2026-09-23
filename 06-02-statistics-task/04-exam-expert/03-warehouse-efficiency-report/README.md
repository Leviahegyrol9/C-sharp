# 03 Warehouse Efficiency Report

## Feladat

Raktari vezetoi riportot kell keszitened egy adott raktar keszletadataibol.

## Megoldando metodus

- `CreateReportAsync(string warehouseCode)`

## Elvart DTO mezok

- `ProductCount`: termekek szama az adott raktarban.
- `TotalStockValue`: teljes keszletertek, `Quantity * UnitCost` osszege.
- `AverageStockLevel`: atlagos keszletszint.
- `LowestStockLevel`: legalacsonyabb keszletszint.
- `LowStockProductPercentage`: alacsony keszleten levo termekek aranya.
- `EstimatedReorderCost`: becsult utanrendelesi koltseg, csak az alacsony keszletes termekeknel `ReorderQuantity * UnitCost` osszege.

## Hasznalhato muveletek

`Where`, `CountAsync`, `SumAsync`, `AverageAsync`, `MinAsync` es szazalekszamitas.

## Kerulendo

Ne hasznalj korai `ToListAsync` hivast, `foreach` ciklust vagy olyan sajat fuggvenyt, amelyet EF nem tudna adatbazis-lekerdezesre forditani.

## Ellenorzes

```bash
dotnet run --project Exam/Tests
```

## Navigacio

- [Vissza az Expert feladatokhoz](../README.md)
