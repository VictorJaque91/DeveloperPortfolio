
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using Portfolio.Models;

namespace Portfolio.Services
{
    public interface IEmailService
    {
        Task SendContactMessageAsync(ContactFormModel form);
    }

    public class EmailService : IEmailService
    {
        private readonly EmailSettings _settings;

        public EmailService(IOptions<EmailSettings> settings)
        {
            _settings = settings.Value;
        }

        public async Task SendContactMessageAsync(ContactFormModel form)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("", _settings.SmtpUser));
            message.To.Add(new MailboxAddress("", _settings.ToAddress));
            message.ReplyTo.Add(new MailboxAddress(form.Name, form.Email));
            message.Subject = $"Portfolio contact form: {form.Name}";

            message.Body = new TextPart("plain")
            {
                Text = $"From: {form.Name} ({form.Email})\n\n{form.Message}"
            };

            using var client = new SmtpClient();
            await client.ConnectAsync(_settings.SmtpHost, _settings.SmtpPort, SecureSocketOptions.StartTls);
            await client.AuthenticateAsync(_settings.SmtpUser, _settings.SmtpPass);
            await client.SendAsync(message);
            await client.DisconnectAsync(true);
        }
    }
}