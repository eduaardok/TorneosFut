using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace TorneosFut
{
    class csCorreo

    {
        MailMessage email = new MailMessage();
        string usuario, clave, servidor;
        bool ssl;
        int puerto = 587;
        string nombreemisor, destinatario, concopia, asunto, cuerpo, rutaadjunto;
        public string Nombreemisor
        {
            get { return nombreemisor; }
            set { nombreemisor = value; email.From = new MailAddress(usuario, nombreemisor); }
        }
        public string Destinatario
        {
            get { return destinatario; }
            set { destinatario = value; email.To.Add(destinatario); }
        }
        public string ConCopia
        {
            get { return concopia; }
            set { concopia = value; email.CC.Add(concopia); }
        }
        public string Asunto
        {
            get { return asunto; }
            set { asunto = value; email.Subject = asunto; }
        }
        public string Cuerpo
        {
            get { return cuerpo; }
            set { cuerpo = value; email.Body = cuerpo; }
        }
        public string RutaAdjunto
        {
            get { return rutaadjunto; }
            set { rutaadjunto = value; email.Attachments.Add(new Attachment(rutaadjunto)); }
        }
        public void DatosCorreo(string user, string password, string server, int port)
        {
            usuario = user;
            clave = password;
            servidor = server;
            puerto = port;
            ssl = true;
        }
        public csCorreo()
        {
            DatosCorreo("futxpertbd@gmail.com", "ixtj ykue mdry tygb", "smtp.gmail.com", 587); //correo del futxpert
        }
        public Boolean EnviarCorreo(string mensaje)
        {
            SmtpClient cliente = new SmtpClient(servidor, puerto);
            cliente.Credentials = new NetworkCredential(usuario, clave);
            cliente.EnableSsl = true;
            email.Body = mensaje;

            try
            {
                cliente.Send(email);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Se ha producido un error, verifique que los datos ingresados sean válidos. Clic en aceptar.");
                email.Dispose();
                return false;
            }
            email.Dispose();
            return true;
        }
    }
}