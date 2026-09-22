namespace LinqWhereCountEfAdvancedSupport;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<Ticket> Tickets { get; set; } = [];
}

public class Ticket
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public string Status { get; set; } = string.Empty;
    public Customer? Customer { get; set; }
    public List<TicketMessage> Messages { get; set; } = [];
}

public class TicketMessage
{
    public int Id { get; set; }
    public int TicketId { get; set; }
    public string Text { get; set; } = string.Empty;
    public Ticket? Ticket { get; set; }
}