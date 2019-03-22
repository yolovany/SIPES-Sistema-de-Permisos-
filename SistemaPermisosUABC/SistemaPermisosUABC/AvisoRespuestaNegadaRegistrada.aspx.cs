using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaPermisosUABC
{
    public partial class AvisoRespuestaNegadaRegistrada : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDeAcuerdo_Click(object sender, EventArgs e)
        {
            string folioSolicitud = (string)Session["FolioSolicitud"];
            int folio = int.Parse(folioSolicitud);
            E_Usuario responsable = (E_Usuario)Session["ResponsableConectado"];

            E_SolicitudRechazada solicitud = new E_SolicitudRechazada();
            solicitud.CorreoRechazante = responsable.Email;
            solicitud.FolioSolicitudRechazada = folio;
            solicitud.MotivoRechazo = tbxAreaTexto.Text;
            solicitud.NombreDeRechazante = responsable.Nombre + " " + responsable.Apellidos;
            solicitud.RolRechazante = responsable.Rol;

            SolicitudRechazadaDALC service1 = new SolicitudRechazadaDALC();
            List<E_SolicitudRechazada> lstMotivos = new List<E_SolicitudRechazada>();
            lstMotivos = service1.MostrarMotivosRechazosPorFolioYRol(folio, responsable.Rol);
            if(lstMotivos.Count > 0)
            {
                service1 = new SolicitudRechazadaDALC();
                service1.EliminarMotivosRechazoPorFolio(folio,responsable.Rol);
            }
            else
            {
                SolicitudRechazadaDALC service = new SolicitudRechazadaDALC();
                bool result = service.AgregarSolicitudRechazada(solicitud);  
            }
            Response.Redirect("~/AvisoRespuestaRegistrada.aspx");
        }
    }
}