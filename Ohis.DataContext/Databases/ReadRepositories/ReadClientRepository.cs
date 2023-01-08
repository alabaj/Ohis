using AutoMapper;
using Ohis.DataContext.Databases.Base;
using Ohis.DataContext.Databases.Interfaces;
using Ohis.DataContext.Entities;
using Ohis.Library.Domain;

namespace Ohis.DataContext.Databases.ReadRepositories;

public class ReadClientRepository : ReadRepository<ClientEntity, ClientModel>, IReadClientRepository
{
    public ReadClientRepository(IMapper mapper, AppDbContext context) : base(mapper, context)
    {
    }
}
