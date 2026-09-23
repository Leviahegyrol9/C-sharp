# 05 - Szamitott ertekek

EF Core-ban gyakran nem egyetlen mezot osszegzunk, hanem mezokbol szamitott erteket.

```csharp
await dbContext.InventorySnapshots
    .SumAsync(item => item.StockQuantity * item.UnitCost)
```

Jo peldak:

- `GrossRevenue - DiscountAmount`
- `(UnitPrice - UnitCost) * Quantity`
- `CompletedStudentCount / EnrolledStudentCount * 100`

Kerulendo: sajat C# segedfuggveny hivasa a query belsejeben, ha azt EF nem tudja SQL-re forditani.
