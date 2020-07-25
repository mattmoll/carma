using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using Carm.Shr;
using TNGS.NetRoutines;
using TNGS.NetAppBll;
using System.Net.Mime;
using System.IO;

namespace Carm.Shr
{
    public static class MailSender
    {
        public static void enviarMail(Bel.EVendedor sender, Bel.EDominio dominio, List<string> destinatarios, string titulo, string textoMail, int nroCliente, string nombreArchivoAdjunto, decimal precio, StatMsg p_smResult)
        {
            try
            {
                // Creamos el objeto mensaje de mail.
                MailMessage msg = new MailMessage();

                // Agregamos todos los destinatarios del mail.
                foreach(string destinatario in destinatarios)
                    msg.To.Add(new MailAddress(destinatario));

                // Cargamos el emisor
                msg.From = new MailAddress(sender.Mailremitente);

                // Cargamos el subject del mail y el cuerpo, sacados de la pantalla.
                msg.Subject = titulo;
                msg.Body = textoMail;
                msg.IsBodyHtml = true;

                // Recuperamos a partir de los aprametros el servidor a utilizar.
                string servidorCorreo = dominio.Direccionsmtp;
                int puerto = dominio.Puertosmtp;
                SmtpClient client = new SmtpClient(servidorCorreo, puerto);
                string mailSeguro = AppRuts.ParaGet("SAFEMAIL", true, p_smResult).VStr;

                client.EnableSsl = (mailSeguro == "S");

                NetworkCredential credentials = new NetworkCredential(sender.Email, CriptoRuts.DESShow(sender.Contrasenia), "");
                client.Credentials = credentials;

                // Si hay archivo adjunto => lo adjuntamos
                if (nombreArchivoAdjunto != "")
                {
                    Attachment attachment = new Attachment(nombreArchivoAdjunto, MediaTypeNames.Application.Octet);
                    ContentDisposition disposition = attachment.ContentDisposition;
                    disposition.CreationDate = File.GetCreationTime(nombreArchivoAdjunto);
                    disposition.ModificationDate = File.GetLastWriteTime(nombreArchivoAdjunto);
                    disposition.ReadDate = File.GetLastAccessTime(nombreArchivoAdjunto);
                    disposition.FileName = Path.GetFileName(nombreArchivoAdjunto);
                    disposition.Size = new FileInfo(nombreArchivoAdjunto).Length;
                    disposition.DispositionType = DispositionTypeNames.Attachment;
                    msg.Attachments.Add(attachment);

                    msg.Body = "Ante cualquier duda, ya sea comercial u operativa, nos encontramos a su disposición.";
                }

                client.Send(msg);

                Bel.ECartasEnv cartaEnviada = Bel.ECartasEnv.NewEmpty();
                cartaEnviada.Numero = (int)TNGS.NetAppBll.AppRuts.TaloGet("nroCartaEn", p_smResult).Valor;
                cartaEnviada.Remitente = sender.Mailremitente;
                cartaEnviada.Des = titulo;
                string destinatariosString = "";
                destinatarios.ForEach(unDest => destinatariosString += unDest);
                cartaEnviada.Destinatarios = destinatariosString;
                cartaEnviada.Fecha = Bll.Clientes.fGetDate(p_smResult);
                cartaEnviada.Nrocliente = nroCliente;
                cartaEnviada.Precio = precio;
                cartaEnviada.Texto = msg.Body;
                Bll.CartasEnv.Save(cartaEnviada, p_smResult);
            }
            catch (Exception e)
            {
                p_smResult.BllWarning(e.ToString());
            }
        }
    }
}
