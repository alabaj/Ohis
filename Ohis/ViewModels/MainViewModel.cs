using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Ohis.DataContext.Entities;
using Ohis.Library.Domain.Enums;
using Ohis.Library.Services.SenderServices;

namespace Ohis.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;

        [RelayCommand]
        public void Add()
        {
            EmailSenderService service = new EmailSenderService();

            var client = new ClientEntity()
            {
                Id = Guid.NewGuid(),
                EmailAddress = "zalp833@gmail.com"
            };

            var ticket = new TicketEntity()
            {
                Client = client,
                ClientId = client.Id,
                Text = "hello!",
                Title = "smpt test",
                SendingDate = DateTime.Now,
                Status = TicketStatuses.Active
            };

            service.SendMessage(ticket);
        }
    }
}
