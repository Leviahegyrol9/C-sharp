namespace LinqWhereCountEfAdvancedSupport;

public static class TestData
{
    public static void Seed(AppDbContext db)
    {
        db.Customers.AddRange(new Customer { Id = 1, Name = "Contoso" }, new Customer { Id = 2, Name = "Northwind" });
        db.Tickets.AddRange(
            new Ticket { Id = 1, CustomerId = 1, Status = "Open" },
            new Ticket { Id = 2, CustomerId = 1, Status = "Closed" },
            new Ticket { Id = 3, CustomerId = 2, Status = "Open" }
        );
        db.TicketMessages.AddRange(
            new TicketMessage { Id = 1, TicketId = 1, Text = "First" },
            new TicketMessage { Id = 2, TicketId = 1, Text = "Second" },
            new TicketMessage { Id = 3, TicketId = 2, Text = "Done" }
        );
        db.SaveChanges();
    }
}