#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace Ohis.DataContext.Entities;
public class ClientEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string EmailAddress { get; set; }

    public ICollection<TicketEntity> Tickets { get; set; }
}
