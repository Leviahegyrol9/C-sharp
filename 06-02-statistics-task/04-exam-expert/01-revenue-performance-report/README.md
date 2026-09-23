# 01 Revenue Performance Report

## Feladat

Webshop havi teljesitmenyriportot kell keszitened EF Core aggregalo muveletekkel.

## Domain

Az adatbazis rendeleseket es havi beveteli celokat tartalmaz.

## Megoldando metodus

- `CreateReportAsync(int year, int month)`

A metodus csak az adott ev es honap lezarult rendeleseivel dolgozzon.

## Elvart DTO mezok

- `ClosedOrderCount`: lezarult rendelesek szama.
- `NetRevenue`: teljes netto bevetel, vagyis `NetAmount - RefundAmount` osszege.
- `AverageClosedOrderValue`: atlagos netto rendelesi ertek.
- `LargestClosedOrderValue`: legnagyobb rendelesi netto ertek.
- `RefundedOrderPercentage`: visszateritett rendelesek aranya szazalekban.
- `RevenueTargetCompletionPercentage`: havi beveteli cel teljesulese szazalekban.

## Hasznalhato muveletek

`Where`, `CountAsync`, `SumAsync`, `AverageAsync`, `MaxAsync` es szazalekszamitas.

## Kerulendo

Ne hasznalj `GroupBy`, `Any`, `All`, `Contains`, korai `ToListAsync` hivast vagy kezi `foreach` szamlalast.

## Ellenorzes

```bash
dotnet run --project Exam/Tests
```

## Navigacio

- [Vissza az Expert feladatokhoz](../README.md)
