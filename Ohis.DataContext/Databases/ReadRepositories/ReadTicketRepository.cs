using AutoMapper;
using Ohis.DataContext.Databases.Base;
using Ohis.DataContext.Databases.Interfaces;
using Ohis.DataContext.Entities;
using Ohis.Library.Domain;

namespace Ohis.DataContext.Databases.ReadRepositories;

public class ReadTicketRepository : ReadRepository<TicketEntity, TicketModel>, IReadTicketRepository
{
    public ReadTicketRepository(IMapper mapper, AppDbContext context) : base(mapper, context)
    {
    }
}
