using Ohis.Library.Domain;

namespace Ohis.Application.Interfaces;

public interface IClientsService
{
    public Task<IEnumerable<ClientModel>> GetAllClients();
}
