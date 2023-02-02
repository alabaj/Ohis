using Ohis.Library.Domain;

namespace Ohis.Application.Interfaces;

public interface IClientsService
{
    public Task<IEnumerable<ClientModel>> GetAllClients();
    public ClientModel AddModel(ClientModel model);
    public Task<bool> RemoveModel(Guid id);
}
