using Ohis.Application.Interfaces;
using Ohis.DataContext.Databases.Interfaces;
using Ohis.Library.Domain;

namespace Ohis.MauiBlazor.Data.Services;

public class ClientsService : IClientsService
{
    private readonly IReadClientRepository _clientRepository;

    public ClientsService(IReadClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public async Task<IEnumerable<ClientModel>> GetAllClients()
    {
        var clients = await _clientRepository.GetAll();

        return clients;
    }
}
