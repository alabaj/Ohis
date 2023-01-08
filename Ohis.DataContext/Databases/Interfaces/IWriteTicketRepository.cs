using Ohis.DataContext.Databases.Base;
using Ohis.DataContext.Entities;
using Ohis.Library.Domain;

namespace Ohis.DataContext.Databases.Interfaces;

public interface IWriteTicketRepository : IWriteRepository<ClientEntity, TicketModel>
{
}
