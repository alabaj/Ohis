using AutoMapper;
using Ohis.DataContext.Databases.Base;
using Ohis.DataContext.Databases.Interfaces;
using Ohis.DataContext.Entities;
using Ohis.Library.Domain;

namespace Ohis.DataContext.Databases.WriteRepositories;

public class WriteClientRepository : WriteRepository<ClientEntity, ClientModel>, IWriteClientRepository
{
    public WriteClientRepository(IMapper mapper, AppDbContext context) : base(mapper, context)
    {
    }
}
