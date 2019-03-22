using Datos;
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
    public partial class RevisionSolicitud : System.Web.UI.Page
    {
             
        string rolResponsable = string.Empty;
        List<E_Solicitud> lstPendientes = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["RolResponsable"] != null)
                {
                    rolResponsable = (string)Session["RolResponsable"];
                    string emailSolicitante = (string)Session["EmailSolicitante"];
                    string folioSolicitud = (string)Session["FolioSolicitud"];
                    int folio = int.Parse(folioSolicitud);
                    string nombreEvento = (string)Session["NombreEvento"];

                    SolicitudesDALC service1 = new SolicitudesDALC();
                    lstPendientes = new List<E_Solicitud>();

                    lstPendientes = new List<E_Solicitud>();
                    lstPendientes = service1.MostrarSolicitudesPorEmailEstadoFolioDataset(emailSolicitante, "PENDIENTE", folio);
                    lstPendientes.Reverse();

                    txtNombreEmpleado.Enabled = false;
                    txtNombreEmpleado.Text = (string)Session["NombreSolicitante"];

                    txtNumEmpleado.Enabled = false;
                    txtNumEmpleado.Text = lstPendientes[0].NumeroEmpleado.ToString();

                    txtCategoria.Enabled = false;
                    txtCategoria.Text = lstPendientes[0].CategoriaEmpleado;

                    chbCivil.Enabled = false;
                    chbElectronica.Enabled = false;
                    chbComputacion.Enabled = false;
                    chbIndustrial.Enabled = false;
                    chbArquitectura.Enabled = false;
                    chbBioingeniería.Enabled = false;
                    chbNanotecnologia.Enabled = false;


                    txtNombreEvento.Enabled = false;
                    txtNombreEvento.Text = lstPendientes[0].NombreEvento;

                    txtCostoEvento.Enabled = false;
                    txtCostoEvento.Text = lstPendientes[0].CostoEvento.ToString();

                    txtLugar.Enabled = false;
                    txtLugar.Text = lstPendientes[0].LugarEvento;

                    txtFechaSalida.Enabled = false;
                    txtFechaSalida.Text = lstPendientes[0].FechaSalida;

                    txtHoraSalida.Enabled = false;
                    txtHoraSalida.Text = lstPendientes[0].HoraSalida;

                    txtFechaRegreso.Enabled = false;
                    txtFechaRegreso.Text = lstPendientes[0].FechaRegreso;

                    txtHoraRegreso.Enabled = false;
                    txtHoraRegreso.Text = lstPendientes[0].HoraRegreso;

                    cbxHospedaje.Enabled = false;
                    cbxHospedaje.Checked = lstPendientes[0].RecursoHospedajeCheckbool;

                    cbxTransporte.Enabled = false;
                    cbxTransporte.Checked = lstPendientes[0].RecursoTransporteCheckbool;

                    cbxCombustible.Enabled = false;
                    cbxCombustible.Checked = lstPendientes[0].RecursoCombustibleCheckbool;

                    txtCantCombustible.Enabled = false;
                    txtCantCombustible.Text = lstPendientes[0].RecursoCombustibleDef.ToString();

                    cbxOficioComision.Enabled = false;
                    cbxOficioComision.Checked = lstPendientes[0].RecursoOficioComisionbool;

                    txtOtro.Enabled = false;
                    txtOtro.Text = lstPendientes[0].RecursoOtroDef;

                    //cbxOtro.Enabled = false;
                    //cbxOtro.Checked =

                    cbxCasei.Enabled = false;
                    cbxCasei.Checked = lstPendientes[0].ActAsociadaCACEICIEESCheckbool;

                    cbxIso.Enabled = false;
                    cbxIso.Checked = lstPendientes[0].ActAsociadaISO90012008Checkbool;

                    cbxLicenciatura.Enabled = false;
                    cbxLicenciatura.Checked = lstPendientes[0].ActAsociadaLicenciaturaCheckbool;

                    cbxPosgrado.Enabled = false;
                    cbxPosgrado.Checked = lstPendientes[0].ActAsociadaPosgradoCheckbool;

                    cbxPersonal.Enabled = false;


                    txtOtraActividadAsociada.Enabled = false;
                    txtOtraActividadAsociada.Text = lstPendientes[0].ActAsociadaOtraDef;

                    chbCivil.Enabled = false;
                    chbCivil.Checked = lstPendientes[0].CarrAsociadaCivilCheck;

                    chbComputacion.Enabled = false;
                    chbComputacion.Checked = lstPendientes[0].CarrAsociadaComputacionCheck;

                    chbElectronica.Enabled = false;
                    chbElectronica.Checked = lstPendientes[0].CarrAsociadaElectronicaCheck;

                    chbIndustrial.Enabled = false;
                    chbIndustrial.Checked = lstPendientes[0].CarrAsociadaIndustrialCheck;

                    chbArquitectura.Enabled = false;
                    chbArquitectura.Checked = lstPendientes[0].CarrAsociadaArquitecturaCheck;

                    chbBioingeniería.Enabled = false;
                    chbBioingeniería.Checked = lstPendientes[0].CarrAsociadaBioingenieriaCheck;

                    chbNanotecnologia.Enabled = false;
                    chbNanotecnologia.Checked = lstPendientes[0].CarrAsociadaNanotecnologiaCheck;

                    cbxCombustible.Enabled = false;
                    cbxCombustible.Checked = lstPendientes[0].RecursoCombustibleCheckbool;

                    cbxPersonal.Enabled = false;
                    cbxPersonal.Checked = lstPendientes[0].ActAsociadaPersonalCheckbool;

                }
                else
                {
                    Response.Redirect("~/default.aspx");
                }
            }
        }

        protected void btnAceptarSolicitud_Click(object sender, EventArgs e)
        {
            string folioSolicitud = (string)Session["FolioSolicitud"];
            int folio = int.Parse(folioSolicitud);
            string rolResponsable = (string)Session["rolResponsable"];

            SolicitudesDALC aprobarPermiso = new SolicitudesDALC();
            aprobarPermiso.EnviarRespuestaASolicitud(rolResponsable, folio, "APROBADO");

            SolicitudesDALC service = new SolicitudesDALC();
            SolicitudesDALC newService = new SolicitudesDALC();
            List<bool> lstRevisiones = newService.MostrarRevisionDeSolicitudesBool(folio);

            int i;
            int j=0;
            for (i = 0; i<lstRevisiones.Count; i++)
            {
                // revisa el número de revisiones que se han hecho
                if(lstRevisiones[i]==true)
                {
                    j++;
                }
            }

            SolicitudesDALC obtenNumInvolucrados = new SolicitudesDALC();
            List<E_Solicitud> lstIdentidad = obtenNumInvolucrados.MostrarSolicitudesPorEmailEstadoFolioDataset(
                (string)Session["EmailSolicitante"], "PENDIENTE", folio);

            // revisa si la solicitud ya ha sido revisada por todos los involucrados
            // comprobando que el número de revisiones contado previamente sea igual al número de involucrados.
            if (j == lstIdentidad[0].Involucrados)
            {
                SolicitudesDALC service2 = new SolicitudesDALC();
                List<bool> lstAprobados = service2.MostrarSoloAprobadas(folio);
                EnviaCorreoClass correo = new EnviaCorreoClass();
                if (lstAprobados.Count < lstIdentidad[0].Involucrados)
                {
                    // a este punto, si alguno de los bits de control se encuentran en false, significa
                    // que ha sido rechazado por alguno de los responsables.
                    // para ello ya se registró en la base de datos de solicitudesRechazadas.
                    // las razones de rechazo de cada uno de los responsables.
                    SolicitudesDALC rechazarPermiso = new SolicitudesDALC();
                    rechazarPermiso.RechazarSolicitudPorFolio(folio);
                    SolicitudesDALC service3 = new SolicitudesDALC();
                    List<E_SolicitudRechazada> lstRechazos = service3.MostrarRechazosYMotivosPorFolio(lstIdentidad[0].FolioSolicitud);

                    correo.EnviarCorreosSolicitudRechazada(lstIdentidad[0], lstRechazos);
                    Response.Redirect("~/AvisoRespuestaRegistrada.aspx");
                }
                SolicitudesDALC accionAprobar = new SolicitudesDALC();
                accionAprobar.AprobarSolicitudPorFolio(folio); // aprueba solicitud
                string email = (string)Session["EmailSolicitante"];
                UsuariosDALC services = new UsuariosDALC(); 
                List<E_Usuario> entidad = services.MostrarUsuariosPorEmail(email);
               
                bool result = correo.EnviarCorreosSolicitudAprobada(entidad[0], lstIdentidad[0]);
            }
            Response.Redirect("~/AvisoRespuestaRegistrada.aspx");
        }
        protected void btnRechazarSolicitud_Click(object sender, EventArgs e)
        {
            // en este caso los bits de control se mantiene en false.
            string folioSolicitud = (string)Session["FolioSolicitud"];
            int folio = int.Parse(folioSolicitud);
            string rolResponsable = (string)Session["rolResponsable"];

            SolicitudesDALC aprobarPermiso = new SolicitudesDALC();
            aprobarPermiso.EnviarRespuestaASolicitud(rolResponsable, folio, "RECHAZADO");

            SolicitudesDALC service = new SolicitudesDALC();
            SolicitudesDALC newService = new SolicitudesDALC();
            List<bool> lstRevisiones = newService.MostrarRevisionDeSolicitudesBool(folio);

            int i;
            int j = 0;
            for (i = 0; i < lstRevisiones.Count; i++)
            {
                // revisa el número de revisiones que se han hecho
                if (lstRevisiones[i] == true)
                {
                    j++;
                }
            }

            SolicitudesDALC obtenNumInvolucrados = new SolicitudesDALC();
            List<E_Solicitud> lstIdentidad = obtenNumInvolucrados.MostrarSolicitudesPorEmailEstadoFolioDataset(
                (string)Session["EmailSolicitante"], "PENDIENTE", folio);

            // revisa si la solicitud ya ha sido revisada por todos los involucrados
            // comprobando que el número de revisiones contado previamente sea igual al número de involucrados.
            if (j == lstIdentidad[0].Involucrados)
            {
                SolicitudesDALC service2 = new SolicitudesDALC();
                List<bool> lstAprobados = service2.MostrarSoloAprobadas(folio);

                if (lstAprobados.Count < lstIdentidad[0].Involucrados)
                {
                    // a este punto, si alguno de los bits de control se encuentran en false, significa
                    // que ha sido rechazado por alguno de los responsables.
                    // para ello ya se registró en la base de datos de solicitudesRechazadas.
                    // las razones de rechazo de cada uno de los responsables.
                    SolicitudesDALC rechazarPermiso = new SolicitudesDALC();
                    rechazarPermiso.RechazarSolicitudPorFolio(folio);
                    EnviaCorreoClass correo = new EnviaCorreoClass();

                    SolicitudesDALC service3 = new SolicitudesDALC();
                    List<E_SolicitudRechazada> lstRechazos = service3.MostrarRechazosYMotivosPorFolio(lstIdentidad[0].FolioSolicitud);
                    correo.EnviarCorreosSolicitudRechazada(lstIdentidad[0], lstRechazos);
                    Response.Redirect("~/AvisoRespuestaRegistrada.aspx");
                }
            }
            Response.Redirect("~/AvisoRespuestaNegadaRegistrada.aspx");
        }
    }
}