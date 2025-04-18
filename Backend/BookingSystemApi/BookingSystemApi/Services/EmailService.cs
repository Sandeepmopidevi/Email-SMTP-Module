using MailKit.Net.Smtp;
using MimeKit;
using System.Threading.Tasks;

namespace BookingSystemApi.Services
{
    public class EmailService
    {
        private const string SmtpServer = "smtp.gmail.com";
        private const int SmtpPort = 587; // Use 465 for SSL if required
        private const string SenderEmail = "hotelmangement454@gmail.com";
        private const string SenderPassword = "spskjduohduykxtd"; // Replace with your working App Password

        public async Task SendEmailAsync(string recipientEmail, string subject, string body)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(SenderEmail));
            email.To.Add(MailboxAddress.Parse(recipientEmail));
            email.Subject = subject;
            email.Body = new TextPart("html") { Text = body };

            using var smtp = new SmtpClient();
            await smtp.ConnectAsync(SmtpServer, SmtpPort, MailKit.Security.SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(SenderEmail, SenderPassword);
            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);
        }
    }
}