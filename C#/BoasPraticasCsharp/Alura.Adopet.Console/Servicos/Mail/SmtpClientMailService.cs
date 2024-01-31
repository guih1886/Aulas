using System.Net.Mail;

namespace Alura.Adopet.Console.Servicos.Mail
{
    public class SmtpClientMailService : IMailService
    {
        private readonly SmtpClient smtpClient;

        public SmtpClientMailService(SmtpClient smtpClient)
        {
            this.smtpClient = smtpClient;
        }

        public Task SendMailAsync(string remetente, string destinatario, string titulo, string corpoEmail)
        {
            MailMessage msg = new()
            {
                From = new MailAddress(remetente),
                Subject = titulo,
                Body = corpoEmail,
            };
            msg.To.Add(new MailAddress(destinatario));
            smtpClient.Send(msg);
            return Task.CompletedTask;
        }
    }
}
