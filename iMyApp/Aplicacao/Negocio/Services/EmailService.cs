using MimeKit;
using MailKit.Net.Smtp;
using MailKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Services
{
    public class EmailService
    { 

        private const string SenhaApp = "vqsq gnpm dmly plkk";
        private const string UsuarioApp = "danillo.sousa@es.estudante.senai.br";
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

                client.Authenticate(UsuarioApp, SenhaApp);

                client.Send(message);
                client.Disconnect(true);
            }
                return true;
        }
    }
}
