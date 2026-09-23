# 02 - Min/Max es MinAsync/MaxAsync

A `MinAsync` es `MaxAsync` egyetlen erteket ad vissza az adatbazisbol.

```csharp
int highestPoint = await dbContext.StudentScores.MaxAsync(score => score.Points);
```

Fontos: ures halmazon a nem nullable aggregalas kivetelt dobhat. Kezdo feladatokban a tesztadatok tartalmaznak elemet. Valos backend kodban ezt kulon kezelni kell.

Szurt maximum:

```csharp
await dbContext.StudentScores
    .Where(score => score.IsPassed)
    .MaxAsync(score => score.Points)
```
