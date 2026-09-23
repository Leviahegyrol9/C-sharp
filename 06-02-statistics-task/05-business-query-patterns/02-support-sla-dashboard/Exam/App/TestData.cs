public static class TestData
{
    public static void Seed(AppDbContext dbContext)
    {
        dbContext.SupportTickets.AddRange(
            new SupportTicket { Id = 1, AssignedAgent = "Anna", IsClosed = true, ClosedWithinSla = true, FirstResponseMinutes = 15 },
            new SupportTicket { Id = 2, AssignedAgent = "Anna", IsClosed = true, ClosedWithinSla = false, FirstResponseMinutes = 45 },
            new SupportTicket { Id = 3, AssignedAgent = "Anna", IsClosed = false, ClosedWithinSla = false, FirstResponseMinutes = 60 },
            new SupportTicket { Id = 4, AssignedAgent = "Bela", IsClosed = true, ClosedWithinSla = true, FirstResponseMinutes = 20 },
            new SupportTicket { Id = 5, AssignedAgent = "Csilla", IsClosed = false, ClosedWithinSla = false, FirstResponseMinutes = 30 });
        dbContext.SaveChanges();
    }
}
