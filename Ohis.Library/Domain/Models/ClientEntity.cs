namespace Ohis.Library.Domain;

public class ClientEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string EmailAddress { get; set; }

    public IEnumerable<TicketEntity> Tickets { get; set; }
}
