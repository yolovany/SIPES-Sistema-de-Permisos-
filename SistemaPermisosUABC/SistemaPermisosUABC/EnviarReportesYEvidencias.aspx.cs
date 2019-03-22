using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaPermisosUABC
{
    public partial class EnviarReportesYEvidencias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Boolean fileOK = false;
            String path = Server.MapPath("~/Archivos/");
            if (FileUpload1.HasFile)
            {
                String fileExtension =
                    System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                String[] allowedExtensions =
                    {".gif", ".png", ".jpeg", ".jpg", ".pdf",".docx"};
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOK = true;
                    }
                }
            }

            if (fileOK)
            {
                try
                {
                    FileUpload1.PostedFile.SaveAs(path
                        + FileUpload1.FileName);
                    //lblAviso.Text = "File uploaded!";
                }
                catch (Exception ex)
                {
                    //lblAviso.Text = "File could not be uploaded.";
                }
            }
            else
            {
                //lblAviso.Text = "Cannot accept files of this type.";
            }
        }
    }
}