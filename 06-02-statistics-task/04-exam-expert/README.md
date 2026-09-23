# 04 Exam - Expert EF Statistics

## Tema

Expert szinten a statisztikai EF Core feladatok mar tobb uzleti mutatot kapcsolnak ossze egy riport DTO-ban.

Itt nem uj LINQ muveletet tanulunk, hanem a korabbi elemeket hasznaljuk egyutt:

- `Where`
- `CountAsync`
- `SumAsync`
- `AverageAsync`
- `MinAsync`
- `MaxAsync`
- szazalekszamitas
- szamitott DTO mezok

## Megoldott gondolkodasi minta

- [Expert EF Core statisztikai minta](./efcore-expert-solved-example.md)

## Exam projektek

- [01 Revenue Performance Report](./01-revenue-performance-report/README.md)
- [02 Course Business Analytics](./02-course-business-analytics/README.md)
- [03 Warehouse Efficiency Report](./03-warehouse-efficiency-report/README.md)
- [04 Subscription Health Report](./04-subscription-health-report/README.md)

## Didaktikai szerep

Az expert szint abban ad tobbet az advanced szinthez kepest, hogy egyetlen valasz DTO-ban tobb, egymashoz kapcsolodo uzleti mutatot kell osszerakni.

Nem cel:

- `GroupBy` bevezetese;
- `Any`, `All`, `Contains` gyakoroltatasa;
- rendezes vagy lapozas bevezetese;
- sajat C# helper fuggveny hasznalata EF query belsejeben.

## Navigacio

- [Vissza az EF statisztika agahoz](../README.md)
