using System;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace MailSender
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Configurando el mensaje

            MailMessage msg = new MailMessage(); //Se crea una instancia el mensaje (MailMessage) 

            msg.To.Add("receptor1@gmail.com"); //Se establecen los destinatarios
            msg.To.Add("receptor2@hotmail.com");

            msg.Subject = "Enviado desde C#";   // Asunto o Titulo del mensaje
            msg.SubjectEncoding = Encoding.UTF8; //Se codifica a UTF-8. para que pueda ser procesdo por el servidor

            msg.Body = "<h1> Mensaje de HTML prueba </h1>"; //Cuerpo del mensaje
            msg.BodyEncoding = Encoding.UTF8; //Tambien se codifica a UTF-8
            msg.IsBodyHtml = true; //Se establece que el cuerpo es HTML

            msg.Bcc.Add("reptorcopia@gmail.com"); //(Opcional) Se agregan destinatarios para una copia del mensaje

            msg.From = new MailAddress("emisor@hotmail.com"); //Se establece el correo de quien envia el mensaje

            //Configurando el Cliente - Para enviar en mensaje

            SmtpClient cliente = new SmtpClient(); //Se crea un cliente (SmtpClient)

            cliente.Credentials = new NetworkCredential("emisor@hotmail.com", "contraseña"); //Se le otorgan las credenciales del emisor

            cliente.Port = 587; //Se establece el puerto del cliente. este caso es de GMAIL = 587.
            cliente.EnableSsl = true; //activa la seguridad SSL
            cliente.Host = "smtp.office.com"; //Host o servidor de salida del emisor.  Patron:<mail.dominio.com>

            


        }
    }
}
