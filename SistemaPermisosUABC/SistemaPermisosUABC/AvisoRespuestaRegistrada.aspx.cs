using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaPermisosUABC
{
    public partial class AvisoRespuestaRegistrada : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDeAcuerdo_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/default.aspx");
        }
    }
}