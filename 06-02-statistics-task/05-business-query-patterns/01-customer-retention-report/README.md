# 01 Customer Retention Report - Megoldott Minta

## Cel

Ez teljes megoldott minta. Azt mutatja meg, hogyan keszul uzleti jelentesu statisztikai DTO EF Core aggregalo muveletekkel.

## Uzleti kerdes

Hany ugyfel aktiv, hany ugyfel lemorzsolodott, mekkora a churn arany, es mennyi az atlagos havi koltes az aktiv ugyfeleknel?

## Megfigyelendo

- `CountAsync` tobb kulon feltetelre;
- `AverageAsync` aktiv ugyfelekre;
- szazalekszamitas nulla nevezore figyelve;
- DTO osszeallitasa aggregalt ertekekbol.

## Futtatas

```bash
dotnet run --project Exam/App
dotnet run --project Exam/Tests
```

## Navigacio

- [Vissza a Business Query Patterns blokkhoz](../README.md)
