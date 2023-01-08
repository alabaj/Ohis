using Ohis.DataContext.Databases.ReadRepositories;
using Ohis.DataContext.Databases.WriteRepositories;
using Ohis.Library.Domain;
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
        var client = new ClientModel
        {
            Id = Guid.NewGuid(),
            Name = "Test",
            EmailAddress = "zalp833@gmail.com"
        };

        _writeClientRepository.Add(client);

        SemanticScreenReader.Announce("Client was added");
    }

    private async void GetAllClients_Clicked(object sender, EventArgs e)
    {
        var clients = await _readClientRepository.GetAll();

        SemanticScreenReader.Announce(clients.Count.ToString());
    }
}

