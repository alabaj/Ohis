using Ohis.DataContext.Databases.Base;
using Ohis.DataContext.Databases.Interfaces;
using Ohis.Library.Domain;

namespace Ohis.DataContext.Databases.WriteRepositories;

public class WriteTicketRepository : WriteRepository<TicketEntity>, IWriteTicketRepository
{
}
