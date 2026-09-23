# 01 - Sum es SumAsync

Lista alapon gyakori minta:

```csharp
items.Sum(item => item.Amount)
```

EF Core-ban ennek aszinkron megfeleloje:

```csharp
await dbContext.Orders.SumAsync(order => order.Total)
```

Szurt osszegzesnel eloszor `Where`, utana `SumAsync`:

```csharp
await dbContext.Orders
    .Where(order => order.Region == region)
    .SumAsync(order => order.Total)
```

Szamitott osszegnel a kifejezes legyen EF altal SQL-re fordithato:

```csharp
await dbContext.Products.SumAsync(product => product.StockQuantity * product.UnitCost)
```
