using Ohis.DataContext.Databases.ReadRepositories;
using Ohis.DataContext.Databases.WriteRepositories;
using Ohis.DataContext.Entities;
using Ohis.ViewModels;

namespace Ohis;

public partial class MainPage : ContentPage
{
    ReadClientRepository _readClientRepository;
    WriteClientRepository _writeClientRepository;

    public MainPage(MainViewModel vm, ReadClientRepository database)
    {
        InitializeComponent();
        _readClientRepository = database;
        BindingContext = vm;
    }

    private async void AddClient_Clicked(object sender, EventArgs e)
    {
        var client = new ClientEntity
        {
            Id = Guid.NewGuid(),
            Name = "Test",
            EmailAddress = "zalp833@gmail.com"
        };

        await _writeClientRepository.Add(client);

        SemanticScreenReader.Announce("Client was added");
    }

    private async void GetAllClients_Clicked(object sender, EventArgs e)
    {
        var clients = await _readClientRepository.GetAll();

        SemanticScreenReader.Announce(clients.Count.ToString());
    }
}

