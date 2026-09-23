# 04 Subscription Health Report

## Feladat

SaaS szolgaltatas elofizetesi egeszseg riportjat kell elkeszitened.

## Megoldando metodus

- `CreateReportAsync()`

## Elvart DTO mezok

- `CustomerCount`: osszes ugyfel.
- `ActiveCustomerCount`: aktiv ugyfelek szama.
- `CancelledCustomerCount`: lemondott ugyfelek szama.
- `MonthlyRecurringRevenue`: aktiv ugyfelek havi elofizetesi dija osszesen.
- `AverageActiveMonthlyFee`: aktiv ugyfelek atlagos havi dija.
- `ChurnPercentage`: lemondott ugyfelek aranya az osszes ugyfelhez kepest.
- `TrialConversionPercentage`: trialbol fizetosse valt ugyfelek aranya a trialbol indult ugyfelek kozott.

## Hasznalhato muveletek

`Where`, `CountAsync`, `SumAsync`, `AverageAsync` es szazalekszamitas.

## Kerulendo

Ne hasznalj `Any`, `All`, `Contains`, `GroupBy`, rendezes vagy lapozas logikat. Ez meg mindig statisztikai riport feladat.

## Ellenorzes

```bash
dotnet run --project Exam/Tests
```

## Navigacio

- [Vissza az Expert feladatokhoz](../README.md)
