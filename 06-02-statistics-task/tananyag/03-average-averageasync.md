# 03 - Average es AverageAsync

Az `AverageAsync` atlagot szamol.

```csharp
double average = await dbContext.StudentScores.AverageAsync(score => score.Points);
```

Decimal mezoknel decimal eredmenyt is kaphatunk:

```csharp
decimal averagePrice = await dbContext.Products.AverageAsync(product => product.UnitPrice);
```

Szazalekszamitasnal sokszor nem egyetlen `AverageAsync` kell, hanem ket kulon aggregalt ertek aranya.
