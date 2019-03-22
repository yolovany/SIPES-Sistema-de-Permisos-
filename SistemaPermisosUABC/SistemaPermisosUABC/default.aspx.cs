using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaPermisosUABC
{
    public partial class PrincipalSinSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UsuarioConectado"] != null )
            {
                Session.Remove("UsuarioConectado");
            }
            if(Session["ResponsableConectado"] != null)
            {
                Session.Remove("ResponsableConectado");
            }
        }


        protected void btnEnviarDuda_Click(object sender, EventArgs e)
        {
            EnviaCorreoClass enviarCorreo = new EnviaCorreoClass();
            enviarCorreo.EnviarCorreoDuda(txbNombreRemitente.Text, txtCorreo.Text, tbxAreaTexto.Text);
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {

        }
    }
}