# 04 - Count, arany es szazalek

A szazalek gyakran `CountAsync` eredmenyekbol epul fel.

```csharp
int all = await dbContext.Tickets.CountAsync();
int closedInSla = await dbContext.Tickets.CountAsync(ticket => ticket.ClosedInSla);
double percentage = all == 0 ? 0 : (double)closedInSla / all * 100;
```

A lenyeg: az aranynak legyen uzleti jelentese. Peldaul SLA teljesulesi arany, lemorzsolodasi arany, visszakuldesi arany.
