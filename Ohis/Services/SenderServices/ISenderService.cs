using Ohis.DataContext.Entities;

namespace Ohis.Library.Services.SenderServices
{
    public interface ISenderService
    {
        void SendMessage(TicketEntity ticket);
    }
}
