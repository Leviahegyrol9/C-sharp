# EF Advanced 02 - Booking Offer Query

Foglalási ajánlatokhoz hasonló rendezett DTO lekérdezéseket kell írnod.

Nyisd meg:

```text
Exam/Exam.sln
```

Feladatok:

1. `FindFirstActiveByNameAsync`: keresd meg az első aktív foglalási ajánlatot név szerinti sorrendben.
2. `FindByCodeAsync`: keresd meg az egyetlen foglalási ajánlatot pontos ajánlatkód alapján. A kód üzletileg egyedi.
3. `GetActiveListItemsAsync`: add vissza az aktív foglalási ajánlatokat `BookingOfferListItemDto` listaként, név szerint rendezve.

Figyelj arra, hogy a lekérdezés EF Core által SQL-re fordítható maradjon, és a materializálás FirstOrDefaultAsync, SingleOrDefaultAsync vagy ToListAsync legyen.
