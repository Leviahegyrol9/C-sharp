# Advanced EF Core statisztikai minta

Advanced szinten mar tobb aggregalt ertekbol all ossze egy uzletileg ertelmezheto eredmeny.

```csharp
int enrolled = await dbContext.CourseCompletions
    .Where(course => course.Department == department)
    .SumAsync(course => course.EnrolledStudentCount);

int completed = await dbContext.CourseCompletions
    .Where(course => course.Department == department)
    .SumAsync(course => course.CompletedStudentCount);

double completionPercentage = enrolled == 0 ? 0 : (double)completed / enrolled * 100;
```

A lenyeg: a szamitasok legyenek egyszeruek, EF altal fordithatok, es a szazalekszamitasnal mindig kezeld a nulla nevezot.
