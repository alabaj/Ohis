using Ohis.DataContext;
using Ohis.Library.Domain;
using System.Net;
using System.Net.Mail;

namespace Ohis.Library.Services.SenderServices;

public class EmailSenderService : ISenderService
{
    public void SendMessage(TicketModel ticket)
    {
        string from = "olegme052@gmail.com";
        string to = ticket.Client.EmailAddress;
        var messageObject = new MailMessage(from, to);
        messageObject.Subject = ticket.Title;
        messageObject.Body = ticket.Text;

        // register a new password at https://myaccount.google.com/apppasswords
        SmtpClient client = new SmtpClient(Constants.PostServer)
        {
            Port = 587,
            Credentials = new NetworkCredential("olegme052@gmail.com", "pbzvcwfytwsynknl"),
            EnableSsl = true
        };

        client.Send(messageObject);
    }
}
