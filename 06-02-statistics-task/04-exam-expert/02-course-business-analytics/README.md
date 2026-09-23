# 02 Course Business Analytics

## Feladat

Online oktatasi platformhoz kell kategoria alapu uzleti statisztikat keszitened.

## Megoldando metodus

- `CreateReportAsync(string category)`

A metodus csak a megadott kategoria publikus kurzusaival dolgozzon.

## Elvart DTO mezok

- `PublishedCourseCount`: publikus kurzusok szama a kategoriaban.
- `TotalEnrollmentCount`: osszes beiratkozas.
- `AverageCompletionPercentage`: atlagos teljesitesi szazalek.
- `LowestCompletionPercentage`: legalacsonyabb teljesitesi szazalek.
- `TotalRevenue`: becsult bevetel, `EnrollmentCount * Price` osszege.
- `SuccessfulCompletionPercentage`: sikeres teljesitesek aranya az osszes beiratkozashoz kepest.

## Hasznalhato muveletek

`Where`, `CountAsync`, `SumAsync`, `AverageAsync`, `MinAsync` es szazalekszamitas.

## Kerulendo

Ne vezess be `GroupBy`, `Any`, `All`, `Contains` vagy lapozasi logikat.

## Ellenorzes

```bash
dotnet run --project Exam/Tests
```

## Navigacio

- [Vissza az Expert feladatokhoz](../README.md)
