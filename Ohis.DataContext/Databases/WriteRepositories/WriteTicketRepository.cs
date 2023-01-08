using AutoMapper;
using Ohis.DataContext.Databases.Base;
using Ohis.DataContext.Databases.Interfaces;
using Ohis.DataContext.Entities;
using Ohis.Library.Domain;

namespace Ohis.DataContext.Databases.WriteRepositories;

public class WriteTicketRepository : WriteRepository<TicketEntity, TicketModel>, IWriteTicketRepository
{
    public WriteTicketRepository(IMapper mapper, AppDbContext context) : base(mapper, context)
    {
    }
}
