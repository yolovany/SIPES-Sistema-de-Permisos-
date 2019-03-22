using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaPermisosUABC
{
    public partial class Formulario_web1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            UsuariosDALC service = new UsuariosDALC();
            DataSet dsSolicitudesPendientes = new DataSet();
            DataSet dsSolicitudesAprobadas = new DataSet();
            DataSet dsSolicitudesRechazadas = new DataSet();
            List<E_Usuario> lstUsuarios = new List<E_Usuario>();
            if(txtCorreoFacultativo.Text!=string.Empty&&txtContraseña.Text!=string.Empty)
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

                        Session["UsuarioConectado"] = lstUsuarios[0];
                        Response.Redirect("~/PrincipalConSesion.aspx");
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

