using Ohis.Library.Domain.Enums;

namespace Ohis.Library.Domain;

public class TicketModel
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    public DateTime SendingDate { get; set; }
    public TicketStatuses Status { get; set; }

    public Guid ClientId { get; set; }
    public ClientModel Client { get; set; }
}
