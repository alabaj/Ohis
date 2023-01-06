using Ohis.Library.Domain;

namespace Ohis.Library.Services.SenderServices;

public interface ISenderService
{
    void SendMessage(TicketEntity ticket);
}
