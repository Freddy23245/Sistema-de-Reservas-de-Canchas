using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
namespace Datos.MailServices
{
    public abstract class MasterMailServer
    {

        //Atributos
        private SmtpClient smtpClient;
        protected string senderMail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

        //Inicializar propiedades del cliente SMTP
        protected void initializeSmtpClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(senderMail, password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;
        }
        public void sendMail(string subject, string body, List<string> recipientMail)
        {
            //var mailMessage = new MailMessage();
            ////try
            ////{
            //mailMessage.From = new MailAddress(senderMail);
            //foreach (string mail in recipientMail)
            //{
            //    mailMessage.To.Add(mail);
            //}
            //mailMessage.Subject = subject;
            //mailMessage.Body = body;
            //mailMessage.Priority = MailPriority.Normal;
            //smtpClient.Send(mailMessage);//Enviar mensaje
            ////}
            ////catch (Exception ex) { }
            ////finally
            ////{
            ////    mailMessage.Dispose();
            ////    smtpClient.Dispose();
            ////}
            ///
            // CONFIGURACIÓN DEL CORREO DEL REMITENTE
            string senderMail = "morrisongym630@gmail.com";
            string password = "fvmb iasx friu vymv";
            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587; // O 465 según el proveedor
            bool enableSSL = true;

            var smtpClient = new SmtpClient(smtpServer, smtpPort)
            {
                Credentials = new NetworkCredential(senderMail, password),
                EnableSsl = enableSSL
            };

            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(senderMail);

                foreach (string mail in recipientMail)
                {
                    mailMessage.To.Add(mail);
                }

                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.IsBodyHtml = true; // Poner en false si es texto plano
                mailMessage.Priority = MailPriority.Normal;

                smtpClient.Send(mailMessage);
                //Console.WriteLine("Correo enviado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al enviar el correo: " + ex.Message);
            }
            finally
            {
                mailMessage.Dispose();
                smtpClient.Dispose();
            }
        }

    }

    }

