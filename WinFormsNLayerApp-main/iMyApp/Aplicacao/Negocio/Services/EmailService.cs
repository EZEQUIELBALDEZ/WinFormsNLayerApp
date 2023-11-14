using MailKit.Net.Smtp;
using MimeKit;

namespace Negocio.Services
{
    public class EmailService
    {
        private const string SenhaApp = "tbsh pywu dsax gzqd";
        private const string UsuarioApp = "welton.castoldi@docente.senai.br";
        private const string GmailSmtp = "smtp.gmail.com";
        private const int GmailPorta = 587;

        public string Remetente { get; private set; }
        public string Destinatario { get; private set; }
        public string Assunto { get; private set; }
        public string Mensagem { get; private set; }    

        public EmailService(string remetente, string destinatario, string assunto, string mensagem)
        {
            Remetente = remetente;
            Destinatario = destinatario;
            Assunto = assunto;
            Mensagem = mensagem;
        }

        public bool EnviarEmail()
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("", Remetente));
            message.To.Add(new MailboxAddress("", Destinatario));
            message.Subject = Assunto;

            message.Body = new TextPart("plain")
            {
                Text = Mensagem
            };

            using (var client = new SmtpClient())
            {
                client.Connect(GmailSmtp, GmailPorta, false);

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate(UsuarioApp, SenhaApp);

                client.Send(message);
                client.Disconnect(true);
            }

            return true;
        }
    }
}
