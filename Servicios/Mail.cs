using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Servicios
{
    public class Mail
    {
        private MailMessage email;
        private SmtpClient server;

        public Mail()
        {
            server = new SmtpClient();
            server.Credentials = new NetworkCredential("yonaalbino5@gmail.com", "ccaiclilcvglltcv");
            server.EnableSsl = true;
            server.Port = 587;
            server.Host = "smtp.gmail.com";
        }

        public void armarCorreo(string nombre, string apellido, string asunto, string emailOrigen, string cuerpo)
        {
            email = new MailMessage();
            email.From = new MailAddress("pepito@gmail.com");
            email.To.Add("yonathan96@outlook.com.ar");
            email.Subject = asunto;
            email.IsBodyHtml = true;
            email.Body = "<p style=\"text-align: center; font-weight: 600; font-size: 22px;\">Correo recibido de: " + emailOrigen + "</p> <br> <p style=\"font-size: 18px; font-weight: 600;\">Nombre: " + nombre + "</p> <p style=\"font-size: 18px; font-weight: 600;\">Apellido: " + apellido + "</p> <p style=\"padding: 10px; border: 1px solid #000; font-size: 22px; border-radius: 5px;\">" + cuerpo + "</p>";
        }
        public void CorreoBienvenida(string nombre, string apellido, string asunto, string correo)
        {
            email = new MailMessage();
            email.From = new MailAddress("pepito@gmail.com");
            email.To.Add(correo);
            email.Subject = asunto;
            email.Body = nombre + " " + apellido + " Gracias por registrarte en mi App";
        }
        public void correoError(string cuerpo, string asunto)
        {
            try
            {
                email = new MailMessage();
                email.From = new MailAddress("Error@gmail.com");
                email.To.Add("yonathan96@outlook.com.ar");
                email.Subject = asunto;
                email.Body = cuerpo;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void enviarEmail()
        {
            try
            {
                server.Send(email);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
