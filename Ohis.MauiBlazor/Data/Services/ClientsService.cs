using Ohis.Application.Interfaces;
using Ohis.DataContext.Databases.Interfaces;
using Ohis.Library.Domain;

namespace Ohis.MauiBlazor.Data.Services;

public class ClientsService : IClientsService
{
    private readonly IReadClientRepository _readClientRepository;
    private readonly IWriteClientRepository _writeClientRepository;

    public ClientsService(IReadClientRepository readClientRepository, IWriteClientRepository writeClientRepository)
    {
        _readClientRepository = readClientRepository;
        _writeClientRepository = writeClientRepository;
    }

    public async Task<IEnumerable<ClientModel>> GetAllClients()
    {
        var clients = await _readClientRepository.GetAll();

        return clients;
    }

    public ClientModel AddModel(ClientModel model)
    {
        var client = _writeClientRepository.Add(model);

        return client;
    }

    public async Task<bool> RemoveModel(Guid id)
    {
        var model = await _readClientRepository.FindByProperty(x => x.Id == id);

        if (model == null)
        {
            return false;
        }

        _writeClientRepository.Delete(model);

        return true;
    }
}
