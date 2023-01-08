namespace Ohis.Library.Domain;

public class ClientModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string EmailAddress { get; set; }

    public IEnumerable<TicketModel> Tickets { get; set; }
}
