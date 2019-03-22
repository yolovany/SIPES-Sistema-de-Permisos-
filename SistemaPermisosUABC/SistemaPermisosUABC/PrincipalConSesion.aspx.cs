using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace SistemaPermisosUABC
{
    public partial class PrincipalConSesion : System.Web.UI.Page
    {
        E_Usuario usuarioConectado = null;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["UsuarioConectado"] != null)
            {
                usuarioConectado = new E_Usuario();
                usuarioConectado = (E_Usuario)Session["UsuarioConectado"];

                txtNombreEmpleado.Text = usuarioConectado.Nombre + " " + usuarioConectado.Apellidos;
                txtNombreEmpleado.Enabled = false;
                txtNumEmpleado.Text = usuarioConectado.NoEmpleado.ToString();
                txtNumEmpleado.Enabled = false;

                try
                {
                    UsuariosDALC service = new UsuariosDALC();
                    List<E_Usuario> lstUsuario = service.MostrarUsuariosPorEmail(usuarioConectado.Email);
                    GridView1.DataSource = lstUsuario;
                    GridView1.DataBind();

                    SolicitudesDALC service1 = new SolicitudesDALC();
                    List<E_Solicitud> lstSolicitudes1 = service1.MostrarSolicitudesPorEmailYEstadoDataset(
                        usuarioConectado.Email, "PENDIENTE");
                    grvPendientes.DataSource = lstSolicitudes1;
                    grvPendientes.DataBind();

                    SolicitudesDALC service2 = new SolicitudesDALC();
                    List<E_Solicitud> lstSolicitudes2 = service2.MostrarSolicitudesPorEmailYEstadoDataset(
                        usuarioConectado.Email, "APROBADA");
                    grvAprobadas.DataSource = lstSolicitudes2;
                    grvAprobadas.DataBind();

                    SolicitudesDALC service3 = new SolicitudesDALC();
                    List<E_Solicitud> lstSolicitudes3 = service3.MostrarSolicitudesPorEmailYEstadoDataset(
                        usuarioConectado.Email, "RECHAZADA");
                    grvRechazadas.DataSource = lstSolicitudes3;
                    grvRechazadas.DataBind();
                }
                catch (SqlException ex)
                {

                }

            }
            else
            {
                Response.Redirect("~/default.aspx");
            }


        }

        protected void btnEnviarSolicitud_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtCostoEvento.Text))
            {
                txtCostoEvento.Text = 0.ToString();
            }

            if (string.IsNullOrEmpty(txtCantCombustible.Text))
            {
                txtCantCombustible.Text = 0.ToString();
            }


            int numInvolucrados = 0;
            DateTime thisDay = DateTime.Today;
            E_Solicitud entidad = new E_Solicitud();
            entidad.FechaSolicitud = thisDay.ToString();

            if (cbxPosgrado.Checked == true)
            {
                if(usuarioConectado.Rol!="POSGRADO")
                    numInvolucrados++;
            }
            entidad.CarrAsociadaCivilCheck = chbCivil.Checked;
            if (chbCivil.Checked)
            {
                if (usuarioConectado.Rol != "CIVIL")
                    numInvolucrados++;
            }
            if (chbElectronica.Checked)
            {
                if (usuarioConectado.Rol !="ELECTRONICA")
                    numInvolucrados++;
            }
            entidad.CarrAsociadaComputacionCheck = chbComputacion.Checked;
            if (chbComputacion.Checked)
            {
                if (usuarioConectado.Rol !="COMPUTACION")
                    numInvolucrados++;
            }

            if (chbIndustrial.Checked)
            {
                if (usuarioConectado.Rol !="INDUSTRIAL")
                    numInvolucrados++;
            }
            if (chbArquitectura.Checked)
            {
                if (usuarioConectado.Rol !="ARQUITECTURA")
                    numInvolucrados++;
            }
            if (chbBioingeniería.Checked)
            {
                if (usuarioConectado.Rol !="BIOINGENIERIA")
                    numInvolucrados++;
            }
            if (chbNanotecnologia.Checked)
            {
                if(usuarioConectado.Rol != "NANOTECNOLOGIA")
                    numInvolucrados++;
            }

            numInvolucrados = numInvolucrados + 3;
            entidad.Involucrados = numInvolucrados;

            entidad.CarrAsociadaElectronicaCheck = chbElectronica.Checked;
            entidad.CarrAsociadaIndustrialCheck = chbIndustrial.Checked;
            entidad.CarrAsociadaArquitecturaCheck = chbArquitectura.Checked;
            entidad.CarrAsociadaBioingenieriaCheck = chbBioingeniería.Checked;
            entidad.CarrAsociadaNanotecnologiaCheck = chbNanotecnologia.Checked;

            entidad.ActAsociadaCACEICIEESCheckbool = cbxCasei.Checked;


            entidad.ActAsociadaISO90012008Checkbool = cbxIso.Checked;


            entidad.ActAsociadaLicenciaturaCheckbool = cbxLicenciatura.Checked;

            if (!string.IsNullOrEmpty(txtOtraActividadAsociada.Text))
            {
                entidad.ActAsociadaOtraDef = txtOtraActividadAsociada.Text;
            }
            else
            {
                entidad.ActAsociadaOtraDef = string.Empty;
            }

            entidad.RecursoTransporteCheckbool = cbxTransporte.Checked;
            entidad.RecursoCombustibleCheckbool = cbxCombustible.Checked;
            entidad.ActAsociadaPersonalCheckbool = cbxPersonal.Checked;

            entidad.ActAsociadaPosgradoCheckbool = cbxPosgrado.Checked;
            entidad.CategoriaEmpleado = txtCategoria.Text;
            entidad.CostoEvento = int.Parse(txtCostoEvento.Text);
            entidad.EmailSolicitante = usuarioConectado.Email;
            entidad.EstadoSolicitud = "PENDIENTE";
            entidad.FechaRegreso = txtFechaRegreso.Text;
            entidad.FechaSalida = txtFechaSalida.Text;
            entidad.HoraRegreso = txtHoraRegreso.Text;
            entidad.HoraSalida = txtHoraSalida.Text;
            entidad.LugarEvento = txtLugar.Text;
            entidad.NombreEvento = txtNombreEvento.Text;
            entidad.NombreMaestro = txtNombreEmpleado.Text;
            entidad.NumeroEmpleado = int.Parse(txtNumEmpleado.Text);
            entidad.RecursoCombustibleDef = int.Parse(txtCantCombustible.Text);
            entidad.RecursoHospedajeCheckbool = cbxHospedaje.Checked;
            entidad.RecursoOficioComisionbool = cbxOficioComision.Checked;

       

            if (!string.IsNullOrEmpty(txtOtro.Text))
            {
                entidad.RecursoOtroDef = txtOtro.Text;
            }
            else
            {
                entidad.RecursoOtroDef = string.Empty;
            }

            entidad.RecursoTransporteCheckbool = cbxTransporte.Checked;


            //entidad.RecursoTransporteDef = (string)dr["RecursoTransporteDef"];

            //entidad.RecursoViaticosCheckbool = (string)dr["RecursoViaticosCheck"];
            SolicitudesDALC service = new SolicitudesDALC();
            bool resultadoConsulta = service.AgregarSolicitud(entidad);

            if (resultadoConsulta == true)
            {
                EnviaCorreoClass sv = null;
                if (cbxPosgrado.Checked == true && usuarioConectado.Rol != "POSGRADO")
                {

                    sv = new EnviaCorreoClass();
                    sv.EnviarCorreoResponsable((E_Usuario)Session["UsuarioConectado"], "POSGRADO");
                }
                if (chbCivil.Checked && usuarioConectado.Rol != "CIVIL")
                {

                    sv = new EnviaCorreoClass();
                    sv.EnviarCorreoResponsable((E_Usuario)Session["UsuarioConectado"], "CIVIL");
                }
                if (chbElectronica.Checked && usuarioConectado.Rol != "ELECTRONICA")
                {

                    sv = new EnviaCorreoClass();
                    sv.EnviarCorreoResponsable((E_Usuario)Session["UsuarioConectado"], "ELECTRONICA");
                }
                if (chbComputacion.Checked && usuarioConectado.Rol != "COMPUTACION")
                {

                    sv = new EnviaCorreoClass();
                    sv.EnviarCorreoResponsable((E_Usuario)Session["UsuarioConectado"], "COMPUTACION");
                }

                if (chbIndustrial.Checked && usuarioConectado.Rol != "INDUSTRIAL")
                {

                    sv = new EnviaCorreoClass();
                    sv.EnviarCorreoResponsable((E_Usuario)Session["UsuarioConectado"], "INDUSTRIAL");
                }
                if (chbArquitectura.Checked && usuarioConectado.Rol != "ARQUITECTURA")
                {

                    sv = new EnviaCorreoClass();
                    sv.EnviarCorreoResponsable((E_Usuario)Session["UsuarioConectado"], "ARQUITECTURA");
                }
                if (chbBioingeniería.Checked && usuarioConectado.Rol != "BIOINGENIERIA")
                {

                    sv = new EnviaCorreoClass();
                    sv.EnviarCorreoResponsable((E_Usuario)Session["UsuarioConectado"], "BIOINGENIERIA");
                }

                if (chbNanotecnologia.Checked && usuarioConectado.Rol != "NANOTECNOLOGIA")
                {

                    sv = new EnviaCorreoClass();
                    sv.EnviarCorreoResponsable((E_Usuario)Session["UsuarioConectado"], "NANOTECNOLOGIA");
                }

                sv = new EnviaCorreoClass();
                sv.EnviarCorreoResponsable((E_Usuario)Session["UsuarioConectado"], "SUBDIRECTOR");


                sv = new EnviaCorreoClass();
                sv.EnviarCorreoResponsable((E_Usuario)Session["UsuarioConectado"], "ADMINISTRADOR");


                sv = new EnviaCorreoClass();
                sv.EnviarCorreoResponsable((E_Usuario)Session["UsuarioConectado"], "DIRECTOR");

            }
            else
            {
                // Error al registrar solicitud en la base de datos
            }
            Response.Redirect("~/AvisoSolicitudEnviada.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            // ver información de solicitud
            if (string.IsNullOrEmpty(tbxFolioSolicitudGrv1.Text))
            {
                Response.Redirect("~/IndiqueFolio.aspx");
            }
            else
            {
                SolicitudesDALC service = new SolicitudesDALC();
                List<E_Solicitud> lstSolicitudes = service.MostrarSolicitudesPorEmailEstadoFolioDataset(usuarioConectado.Email,
                    "PENDIENTE", int.Parse(tbxFolioSolicitudGrv1.Text));
                if(lstSolicitudes.Count == 0)
                {
                    Response.Redirect("~/SolicitudNoEncontrada.aspx");
                }
                if (lstSolicitudes[0] != null)
                {
                    Session["EntidadSolicitudPendiente"] = lstSolicitudes[0];
                    Response.Redirect("~/InformacionDeSolicitud.aspx");
                }
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
                // ver oficio comision
                if (string.IsNullOrEmpty(tbcFolioSolicitudGrv2.Text))
            {
                Response.Redirect("~/IndiqueFolio.aspx");
            }
            else
            {
                SolicitudesDALC service = new SolicitudesDALC();
                List<E_Solicitud> lstSolicitudes = service.MostrarSolicitudesPorEmailEstadoFolioDataset(usuarioConectado.Email,
                    "APROBADA", int.Parse(tbcFolioSolicitudGrv2.Text));
                if (lstSolicitudes[0] != null)
                {
                    /* string dpath = string.Format("Archivos/ID{0}_Solicitud/", lstSolicitudes[0].FolioSolicitud.ToString());
                     if (!Directory.Exists(dpath))
                     {
                         Directory.CreateDirectory(dpath);
                     }*/
                    Response.Clear();
                    Response.ContentType = "application / pdf";
                    Response.Cache.SetCacheability(HttpCacheability.NoCache);
                    //Para crear una instancia de documento de iTextSharp con el tamaño de pagina y margenes que corresponden
                    Document doc = new Document(PageSize.LETTER, 80, 80, 40, 40);
                    string path = Server.MapPath(string.Format("Archivos/ID{0}_{1}.pdf",
                        lstSolicitudes[0].FolioSolicitud, lstSolicitudes[0].NombreEvento));

                    //Se crean las fuentes
                    BaseFont helvetica = BaseFont.CreateFont("Helvetica", BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    Font fontNormal = new Font(helvetica, 12, Font.NORMAL);
                    Font fontBold = new Font(helvetica, 14, Font.BOLD);

                    //Se usa System.IO para crear o sobreescribir el archivo, si ya existe.
                    FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                    //iTextSharp para escribir el documento PDF
                    PdfWriter.GetInstance(doc, file);
                    doc.Open();

                    doc.AddTitle("UNIVERSIDAD AUTÓNOMA DE BAJA CALIFORNIA");

                    #region escrito
                    Paragraph p = new Paragraph("\n\nUNIVERSIDAD AUTÓNOMA DE BAJA CALIFORNIA", fontBold);
                    p.Alignment = Element.ALIGN_CENTER;
                    doc.Add(p);
                    p.Clear();

                    p = new Paragraph("FACULTAD DE INGENIERÍA ARQUITECTURA Y DISEÑO\n\n", fontBold);
                    p.Alignment = Element.ALIGN_CENTER;
                    doc.Add(p);
                    p.Clear();

                    p = new Paragraph("\n\nSUBDIRECCIÓN");
                    p.Alignment = Element.ALIGN_RIGHT;
                    doc.Add(p);
                    p.Clear();

                    p = new Paragraph(string.Format("No. {0}/17-1", lstSolicitudes[0].FolioSolicitud));
                    p.Alignment = Element.ALIGN_RIGHT;
                    doc.Add(p);
                    p.Clear();

                    p = new Paragraph("ASUNTO: Oficio comisión");
                    p.Alignment = Element.ALIGN_RIGHT;
                    doc.Add(p);
                    p.Clear();

                    DateTime thisDay = DateTime.Today;
                    Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-ES");
                    p = new Paragraph(string.Format("ENSENADA, B. C a {0}", thisDay.ToLongDateString()));
                    p.Alignment = Element.ALIGN_RIGHT;
                    doc.Add(p);
                    p.Clear();

                    p = new Paragraph(string.Format("\n\n\n\nDR. {0}", lstSolicitudes[0].NombreMaestro));
                    p.Alignment = Element.ALIGN_LEFT;
                    doc.Add(p);
                    p.Clear();

                    p = new Paragraph("PRESENTE.\n\n\n");
                    p.Alignment = Element.ALIGN_LEFT;
                    doc.Add(p);
                    p.Clear();

                    p = new Paragraph(string.Format("Por medio del presente, la subdirección a mi cargo comisiona a usted el día {0}" +
                        "a {1}.",
                        lstSolicitudes[0].FechaSalida, lstSolicitudes[0].LugarEvento));
                    p.Alignment = Element.ALIGN_JUSTIFIED;
                    doc.Add(p);
                    p.Clear();

                    p = new Paragraph(string.Format("\nMOTIVO: {0}\n", lstSolicitudes[0].NombreEvento));
                    p.Alignment = Element.ALIGN_LEFT;
                    doc.Add(p);
                    p.Clear();

                    p = new Paragraph("\n\n\nEn espera que reciba de conformidad, le mando un cordial saludo.\n\n\n");
                    p.Alignment = Element.ALIGN_CENTER;
                    doc.Add(p);
                    p.Clear();

                    p = new Paragraph("\nATENTAMENTE\n\n");
                    p.Alignment = Element.ALIGN_CENTER;
                    doc.Add(p);
                    p.Clear();

                    p = new Paragraph("POR LA REALIZACIÓN PLENA DEL HOMBRE\n");
                    p.Alignment = Element.ALIGN_CENTER;
                    doc.Add(p);
                    p.Clear();

                    p = new Paragraph(string.Format("\nDR. {0}", lstSolicitudes[0].NombreMaestro)); // aquí va el nombre del director
                    p.Alignment = Element.ALIGN_CENTER;
                    doc.Add(p);
                    p.Clear();
                    #endregion

                    doc.Close();
                    Process.Start(path);
                    string redirectString = string.Format("Archivos/ID{0}_{1}.pdf",lstSolicitudes[0].FolioSolicitud, lstSolicitudes[0].NombreEvento);
                    Response.Redirect(redirectString);
                }

            }          
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbcFolioSolicitudGrv2.Text))
            {
                Response.Redirect("~/IndiqueFolio.aspx");
            }
        }
    }
}
