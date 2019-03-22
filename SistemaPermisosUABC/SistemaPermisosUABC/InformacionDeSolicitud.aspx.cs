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
    public partial class VerSolicitudPendiente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string rolResponsable = string.Empty;
            if (!IsPostBack)
            {
                E_Solicitud entidad = new E_Solicitud();
                entidad = (E_Solicitud)Session["EntidadSolicitudPendiente"];

                if (Session["UsuarioConectado"] != null)
                {
                    #region cargar requerimientos de solicitud
                    txtNombreEmpleado.Enabled = false;
                    txtNombreEmpleado.Text = entidad.NombreMaestro;

                    txtNumEmpleado.Enabled = false;
                    txtNumEmpleado.Text = entidad.NumeroEmpleado.ToString();

                    txtCategoria.Enabled = false;
                    txtCategoria.Text = entidad.CategoriaEmpleado;

                    chbCivil.Enabled = false;
                    chbElectronica.Enabled = false;
                    chbComputacion.Enabled = false;
                    chbIndustrial.Enabled = false;
                    chbArquitectura.Enabled = false;
                    chbBioingeniería.Enabled = false;
                    chbNanotecnologia.Enabled = false;


                    txtNombreEvento.Enabled = false;
                    txtNombreEvento.Text = entidad.NombreEvento;

                    txtCostoEvento.Enabled = false;
                    txtCostoEvento.Text = entidad.CostoEvento.ToString();

                    txtLugar.Enabled = false;
                    txtLugar.Text = entidad.LugarEvento;

                    txtFechaSalida.Enabled = false;
                    txtFechaSalida.Text = entidad.FechaSalida;

                    txtHoraSalida.Enabled = false;
                    txtHoraSalida.Text = entidad.HoraSalida;

                    txtFechaRegreso.Enabled = false;
                    txtFechaRegreso.Text = entidad.FechaRegreso;

                    txtHoraRegreso.Enabled = false;
                    txtHoraRegreso.Text = entidad.HoraRegreso;

                    cbxHospedaje.Enabled = false;
                    cbxHospedaje.Checked = entidad.RecursoHospedajeCheckbool;

                    cbxTransporte.Enabled = false;
                    cbxTransporte.Checked = entidad.RecursoTransporteCheckbool;

                    cbxCombustible.Enabled = false;
                    cbxCombustible.Checked = entidad.RecursoCombustibleCheckbool;

                    txtCantCombustible.Enabled = false;
                    txtCantCombustible.Text = entidad.RecursoCombustibleDef.ToString();

                    cbxOficioComision.Enabled = false;
                    cbxOficioComision.Checked = entidad.RecursoOficioComisionbool;

                    txtOtro.Enabled = false;
                    txtOtro.Text = entidad.RecursoOtroDef;

                    //cbxOtro.Enabled = false;
                    //cbxOtro.Checked =

                    cbxCasei.Enabled = false;
                    cbxCasei.Checked = entidad.ActAsociadaCACEICIEESCheckbool;

                    cbxIso.Enabled = false;
                    cbxIso.Checked = entidad.ActAsociadaISO90012008Checkbool;

                    cbxLicenciatura.Enabled = false;
                    cbxLicenciatura.Checked = entidad.ActAsociadaLicenciaturaCheckbool;

                    cbxPosgrado.Enabled = false;
                    cbxPosgrado.Checked = entidad.ActAsociadaPosgradoCheckbool;
                    pnlPosgrado.Visible = entidad.ActAsociadaPosgradoCheckbool;

                    cbxPersonal.Enabled = false;


                    txtOtraActividadAsociada.Enabled = false;
                    txtOtraActividadAsociada.Text = entidad.ActAsociadaOtraDef;

                    chbCivil.Enabled = false;
                    chbCivil.Checked = entidad.CarrAsociadaCivilCheck;
                    pnlCarrAsociadaCivil.Visible = entidad.CarrAsociadaCivilCheck;

                    chbComputacion.Enabled = false;
                    chbComputacion.Checked = entidad.CarrAsociadaComputacionCheck;
                    pnlCarrAsociadaComputacion.Visible = entidad.CarrAsociadaComputacionCheck;

                    chbElectronica.Enabled = false;
                    chbElectronica.Checked = entidad.CarrAsociadaElectronicaCheck;
                    pnlCarrAsociadaElectronica.Visible = entidad.CarrAsociadaElectronicaCheck;

                    chbIndustrial.Enabled = false;
                    chbIndustrial.Checked = entidad.CarrAsociadaIndustrialCheck;
                    pnlCarrAsociadaIndustrial.Visible = entidad.CarrAsociadaIndustrialCheck;

                    chbArquitectura.Enabled = false;
                    chbArquitectura.Checked = entidad.CarrAsociadaArquitecturaCheck;
                    pnlCarrAsociadaArquitectura.Visible = entidad.CarrAsociadaArquitecturaCheck;


                    chbBioingeniería.Enabled = false;
                    chbBioingeniería.Checked = entidad.CarrAsociadaBioingenieriaCheck;
                    pnlCarrAsociadaBioingenieria.Visible = entidad.CarrAsociadaBioingenieriaCheck;

                    chbNanotecnologia.Enabled = false;
                    chbNanotecnologia.Checked = entidad.CarrAsociadaNanotecnologiaCheck;
                    pnlCarrAsociadaNanotecnologia.Visible = entidad.CarrAsociadaNanotecnologiaCheck;

                    cbxCombustible.Enabled = false;
                    cbxCombustible.Checked = entidad.RecursoCombustibleCheckbool;

                    cbxPersonal.Enabled = false;
                    cbxPersonal.Checked = entidad.ActAsociadaPersonalCheckbool;

                    pnlDirector.Visible = true;
                    pnlSubdirector.Visible = true;
                    pnlAdministrador.Visible = true;
                    #endregion
                    #region responsables involucrados
                    if(entidad.RevAdministrador==true)
                    {
                        lblEstadoRevisionAdministrador.Text = "ESTADO: Revisado";
                    }
                    else
                    {
                        lblEstadoRevisionAdministrador.Text = "ESTADO: no revisado";
                    }


                    if (entidad.RevDirector == true)
                    {
                        lblEstadoRevisionDirector.Text = "ESTADO: Revisado";
                    }
                    else
                    {
                        lblEstadoRevisionDirector.Text = "ESTADO: no revisado";
                    }



                    if (entidad.RevSubdirector == true)
                    {
                        lblEstadoRevisionSubdirector.Text = "ESTADO: Revisado";
                    }
                    else
                    {
                        lblEstadoRevisionSubdirector.Text = "ESTADO: no revisado";
                    }



                    if (entidad.RevCoordinadorArquitectura==true) // 1
                    {
                        lblEstadoRevisionArquitectura.Text = "ESTADO: Revisado";
                    }
                    else
                    {
                        lblEstadoRevisionArquitectura.Text = "ESTADO: no revisado";
                    }


                    if (entidad.RevCoordinadorBioingenieria == true) // 2
                    {
                        lblEstadoRevisionBioingenieria.Text = "ESTADO: Revisado";
                    }
                    else
                    {
                        lblEstadoRevisionBioingenieria.Text = "ESTADO: no revisado";
                    }


                    if (entidad.RevCoordinadorCivil == true) // 3
                    {
                        lblEstadoRevisionCivil.Text = "ESTADO: Revisado";
                    }
                    else
                    {
                        lblEstadoRevisionCivil.Text = "ESTADO: no revisado";
                    }


                    if (entidad.RevCoordinadorComputacion == true) // 4
                    {
                        lblEstadoRevisionComputacion.Text = "ESTADO: Revisado";
                    }
                    else
                    {
                        lblEstadoRevisionComputacion.Text = "ESTADO: no revisado";
                    }


                    if (entidad.RevCoordinadorElectronica == true) // 5
                    {
                        lblEstadoRevisionElectronica.Text = "ESTADO: Revisado";
                    }
                    else
                    {
                        lblEstadoRevisionElectronica.Text = "ESTADO: no revisado";
                    }


                    if (entidad.RevCoordinadorIndustrial == true) //6
                    {
                        lblEstadoRevisionIndustrial.Text = "ESTADO: Revisado";
                    }
                    else
                    {
                        lblEstadoRevisionIndustrial.Text = "ESTADO: no revisado";
                    }


                    if (entidad.RevCoordinadorNanotecnologia == true) //7
                    {
                        lblEstadoRevisionNanotecnologia.Text = "ESTADO: Revisado";
                    }
                    else
                    {
                        lblEstadoRevisionNanotecnologia.Text = "ESTADO: no revisado";
                    }

                    if (entidad.RevPosgrado == true)
                    {
                        lblEstadoRevisionPosgrado.Text = "ESTADO: Revisado";
                    }
                    else
                    {
                        lblEstadoRevisionPosgrado.Text = "ESTADO: no revisado";
                    }
                    #endregion
                }
                else
                {
                    Response.Redirect("~/default.aspx");
                }
               
            }
        }
    }
}