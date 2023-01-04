using Ohis.Library.Domain.Enums;

namespace Ohis.DataContext.Entities
{
    public class TicketEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime SendingDate { get; set; }
        public TicketStatuses Status { get; set; }

        public Guid ClientId { get; set; }
        public ClientEntity Client { get; set; }
    }
}
