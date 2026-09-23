# 07 - Keruljuk a korai kliens oldali szamitast

Kerulendo minta nagy adatnal:

```csharp
var orders = await dbContext.Orders.ToListAsync();
var total = orders.Sum(order => order.Total);
```

Jobb:

```csharp
var total = await dbContext.Orders.SumAsync(order => order.Total);
```

A `ToListAsync` akkor jo, ha tenyleg listara van szukseg. Statisztikai ertekeknel gyakran eleg az aggregalo async metodus.
