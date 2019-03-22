using Datos;
using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaPermisosUABC
{
    public partial class LoginPageResponsable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Session["RolResponsable"] = Page.Request.QueryString["rRes"];
                Session["NombreSolicitante"] = Page.Request.QueryString["ns"].ToUpper();
                Session["EmailSolicitante"] = Page.Request.QueryString["es"].ToLower();
                Session["FolioSolicitud"] = Page.Request.QueryString["is"];
                Session["NombreEvento"] = Page.Request.QueryString["ne"];

                string folioSolicitud = (string)Session["FolioSolicitud"];
                int folio = int.Parse(folioSolicitud);

                SolicitudesDALC service1 = new SolicitudesDALC();
                List<E_Solicitud> lstPendientes = new List<E_Solicitud>();
                lstPendientes = service1.MostrarSolicitudesPorEmailEstadoFolioDataset((string)Session["EmailSolicitante"],
                    "PENDIENTE", folio);
                
                if (lstPendientes.Count == 0)
                {
                    // se hace una consulta previa para saber el estado de la solicitud
                    // si lstPendientes es nula, significa que la solicitud ha sido rechazada por alguno de los responsables.
                    // en este caso ya no es necesario la aprobación de los demás responsables.
                    // por lo que deberá mostrarse un aviso de que ha concluido el resultado de la solicitud.
                    Response.Redirect("~/AvisoSolicitudRevisada.aspx"); // aviso 
                }
                Session["EntidadSolicitud"] = lstPendientes[0];
            }
           
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            UsuariosDALC service = new UsuariosDALC();
            DataSet dsSolicitudesPendientes = new DataSet();
            DataSet dsSolicitudesAprobadas = new DataSet();
            DataSet dsSolicitudesRechazadas = new DataSet();
            List<E_Usuario> lstUsuarios = new List<E_Usuario>();
            if (txtCorreoFacultativo.Text != string.Empty && txtContraseña.Text != string.Empty)
            {
                lstUsuarios = service.MostrarUsuariosPorEmail(txtCorreoFacultativo.Text);
            }
            else
            {
                lblResultadoSolicitud.Text = "Ambos campos son requeridos";
                pnlResultadoSolicitud.Visible = true;
                txtCorreoFacultativo.Text = string.Empty;
                txtContraseña.Text = string.Empty;
                return;
            }

            if (lstUsuarios != null)
            {
                if (lstUsuarios.Count > 0)
                {
                    if (lstUsuarios[0].Password.ToString() == txtContraseña.Text)
                    {
                        lblResultadoSolicitud.Text = "BIENVENIDO PAPU :')";
                        pnlResultadoSolicitud.Visible = true;
                        txtCorreoFacultativo.Text = string.Empty;
                        txtContraseña.Text = string.Empty;

                        Session["ResponsableConectado"] = lstUsuarios[0];
                        Response.Redirect("~/RevisionSolicitud.aspx");
                    }
                    else
                    {
                        lblResultadoSolicitud.Text = "Se encontró el usuario pero la contraseña es incorrecta";
                        pnlResultadoSolicitud.Visible = true;
                        txtContraseña.Text = string.Empty;
                    }
                }
                else
                {
                    lblResultadoSolicitud.Text = "No se encontró el usuario con el correo especificado";
                    pnlResultadoSolicitud.Visible = true;
                    txtCorreoFacultativo.Text = string.Empty;
                    txtContraseña.Text = string.Empty;
                }
            }
        }
    }
}