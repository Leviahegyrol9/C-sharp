# 02 Support SLA Dashboard

## Feladat

Ugyfelszolgalati SLA dashboard DTO-t kell keszitened hibajegy adatokbol.

## Megoldando metodus

- `CreateDashboardAsync`: toltsd ki a `SupportSlaDashboardDto` mezőit.

## DTO mezok

- `TotalTicketCount`
- `ClosedTicketCount`
- `ClosedWithinSlaPercentage`
- `AverageFirstResponseMinutes`
- `OverloadedAgentCount`

## Ellenorzes

```bash
dotnet run --project Exam/Tests
```

## Navigacio

- [Vissza a Business Query Patterns blokkhoz](../README.md)
