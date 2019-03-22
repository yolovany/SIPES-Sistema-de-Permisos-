using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Web.UI;
using System.Data;
using Datos;

namespace SistemaPermisosUABC
{
    public class EnviaCorreoClass
    {

        private string _pSupjet;
        private string _pMensaje;
        private string _EmailFuente;
        private string _PassFuente;

        public EnviaCorreoClass()
        {
            _pSupjet = string.Empty;
            _pMensaje = string.Empty;
            _EmailFuente = "sipesfiad@gmail.com";
            _PassFuente = "01115368";
        }

        public bool EnviarCorreoDuda(string nombreRemitente, string correoRemitente, string mensaje)
        {
            bool resultado = false;
            _pSupjet = string.Format("{0} HA ESCRITO UN MENSAJE EN EL BUZÓN DE DUDAS O SUGERENCIAS", nombreRemitente.ToUpper());
            _pMensaje = "Nombre: " + nombreRemitente + "\n" + "Correo: " + correoRemitente + "\r\nMENSAJE: \n" + mensaje;
            resultado = enviar("sipesfiad.info@gmail.com");
            return resultado;
        }

        public bool EnviarCorreoResponsable(E_Usuario entidadSolicitante, string RolResponsable)
        {
            SolicitudesDALC service = new SolicitudesDALC();
            List<E_Solicitud> lstPendientes = service.MostrarSolicitudesPorEmailYEstadoDataset(entidadSolicitante.Email,
                "PENDIENTE");
            lstPendientes.Reverse();
            bool success = false;
            string host = HttpContext.Current.Request.Url.Host;
            string enlace;


            //enlace = string.Format("http://{0}/LoginPageResponsable.aspx?ns={1}&es={2}&rRes={3}&is={4}",
            enlace = string.Format("http://{0}/LoginPageResponsable.aspx?ns={1}&es={2}&rRes={3}&is={4}",
            host, entidadSolicitante.Nombre + " " + entidadSolicitante.Apellidos,
            entidadSolicitante.Email, RolResponsable, lstPendientes[0].IdSolicitud,
            lstPendientes[0].NombreEvento);


            enlace = enlace.Replace(" ", "%20");

            if (RolResponsable == "CIVIL" || RolResponsable == "ELECTRONICA" || RolResponsable == "COMPUTACION" ||
                RolResponsable == "INDUSTRIAL" || RolResponsable == "ARQUITECTURA" || RolResponsable == "BIOINGENIERIA"
                || RolResponsable == "NANOTECNOLOGIA" || RolResponsable == "POSGRADO")
            {
                _pMensaje = string.Format("\nESTIMADO COORDINADOR DE {3}:\n\n{0} {1} " +
                    "HA SOLICITADO UN NUEVO PERMISO DE SALIDA Y SE ENCUENTRA EN ESPERA DE SU REVISIÓN. " +
                    "CLICK EN EL SIGUIENTE ENLACE PARA VER LOS REQUERIMIENTOS:\n\n{2}",
                entidadSolicitante.Nombre, entidadSolicitante.Apellidos, enlace, RolResponsable);
                _pSupjet = string.Format("(COORDINADOR DE {0}) NUEVA SOLICITUD EN ESPERA DE APROBACIÓN", RolResponsable);
            }
            else
            {
                _pMensaje = string.Format("\nESTIMADO {3}:\n\n{0} {1} " +
                    "HA SOLICITADO UN NUEVO PERMISO DE SALIDA Y SE ENCUENTRA EN ESPERA DE SU REVISIÓN. " +
                    "CLICK EN EL SIGUIENTE ENLACE PARA VER LOS REQUERIMIENTOS:\n\n{2}",
                entidadSolicitante.Nombre, entidadSolicitante.Apellidos, enlace, RolResponsable);
                _pSupjet = string.Format("({0}) NUEVA SOLICITUD EN ESPERA DE APROBACIÓN", RolResponsable);
            }

            enviar(entidadSolicitante.Email);
            return success;
        }

        public bool EnviarCorreosSolicitudAprobada(E_Usuario entidadSolicitante, E_Solicitud entidadSolicitud)
        {
            bool resultado = false;

            string host = HttpContext.Current.Request.Url.Host;
            string enlace = string.Format("http://{0}:58463/LoginPage.aspx?", host);
            _pMensaje = string.Format("\nESTIMADO {0} {1}:\nSU SOLICITUD DE SALIDA A \"{2}\" " +
                "A SIDO ACEPTADA. QUEDA DISPONIBLE EL OFICIO EN EL PORTAL SIPES\n" +
                "CLICK EN EL ENLACE PARA IR AL PORTAL:\n\n{3}",
                entidadSolicitante.Nombre, entidadSolicitante.Apellidos, entidadSolicitud.NombreEvento, enlace);
            _pSupjet = string.Format("SOLICITUD APROBADA - {0} ", entidadSolicitud.NombreEvento);

            resultado = enviar(entidadSolicitante.Email);
            return resultado;
        }

        public bool EnviarCorreosSolicitudRechazada(E_Solicitud entidadSolicitud, List<E_SolicitudRechazada> lstRechazos)
        {
            bool resultado = false;
            string host = HttpContext.Current.Request.Url.Host;
            string enlace = string.Format("http://{0}:58463/LoginPage.aspx?", host);
            _pMensaje = string.Format("\nESTIMADO {0} :\nSU SOLICITUD DE SALIDA A \"{1}\" " +
                "NO HA SIDO ACEPTADA. LO SENTIMOS, SU SOLICITUD NO HA SIDO ACEPTADA POR LOS SIGUIENTES MOTIVOS:",
                entidadSolicitud.NombreMaestro, entidadSolicitud.NombreEvento);
            _pSupjet = string.Format("SOLICITUD NO APROBADA - {0} ", entidadSolicitud.NombreEvento);
            for(int i = 0;i<lstRechazos.Count;i++)
            {
                _pMensaje += "\n\n";
                _pMensaje += lstRechazos[i].NombreDeRechazante + ":\n";
                _pMensaje += lstRechazos[i].RolRechazante + "\n";
                _pMensaje += "MOTIVO DE RECHAZO: " + lstRechazos[i].MotivoRechazo;
            }
            _pMensaje += "\n\nPOR FAVOR TOME EN CUENTA LAS OBSERVACIONES PARA CREAR UNA NUEVA SOLICITUD EN EL PORTAL\n\n" +
                "ATENTAMENTE: EQUIPO DE SIPES";

            resultado = enviar(entidadSolicitud.EmailSolicitante);
            return resultado;
        }

        private bool enviar(string emailReceptor)
        {
            bool success = false;
            try
            {
                MailMessage Email = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                Email.BodyEncoding = Encoding.UTF8;
                Email.From = new MailAddress("sipesfiad.info@gmail.com", "SIPES");
                    
                Email.Subject = _pSupjet;
                Email.Body = _pMensaje;
                Email.To.Add(emailReceptor); // destinatario
                SmtpServer.Port = 587;

                // verificar que el usuario con la contraseña del que envía indicada exista en la base de datos de Gmail.
                SmtpServer.Credentials = new NetworkCredential(_EmailFuente, _PassFuente);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(Email);
                success = true;
            }
            catch (SmtpException ex)
            {

            }
            return success;
        }
    }
}