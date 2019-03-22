using System;
using System.Collections.Generic;
using Datos;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Negocios
{
    public class SolicitudesDALC : ConnectionDB
    {
        public bool AgregarSolicitud(E_Solicitud entidad)
        {
            bool success = false;
            // Instanseando conexion
            SqlCommand command = new SqlCommand("spAgregarSolicitud", connection);

            // Indicar el tipo de comando.
            command.CommandType = CommandType.StoredProcedure;

            // Declarando parámetros.
            // es probable que tenga errores en esta parte:

            command.Parameters.Add("@FechaDeSolicitud", SqlDbType.NVarChar);
            command.Parameters["@FechaDeSolicitud"].Value = entidad.FechaSolicitud;

            command.Parameters.Add("@ActAsociadaCACEICIEESCheck", SqlDbType.Bit);
            command.Parameters["@ActAsociadaCACEICIEESCheck"].Value = entidad.ActAsociadaCACEICIEESCheckbool;

            command.Parameters.Add("@ActAsociadaISO90012008Check", SqlDbType.Bit);
            command.Parameters["@ActAsociadaISO90012008Check"].Value = entidad.ActAsociadaISO90012008Checkbool;

            command.Parameters.Add("@ActAsociadaLicenciaturaCheck", SqlDbType.Bit);
            command.Parameters["@ActAsociadaLicenciaturaCheck"].Value = entidad.ActAsociadaLicenciaturaCheckbool;

            command.Parameters.Add("@ActAsociadaOtraCheck", SqlDbType.Bit);
            command.Parameters["@ActAsociadaOtraCheck"].Value = entidad.ActAsociadaOtraCheckbool;

            command.Parameters.Add("@ActAsociadaOtraDef", SqlDbType.NVarChar);
            command.Parameters["@ActAsociadaOtraDef"].Value = entidad.ActAsociadaOtraDef;

            command.Parameters.Add("@ActAsociadaPersonalCheck", SqlDbType.Bit);
            command.Parameters["@ActAsociadaPersonalCheck"].Value = entidad.ActAsociadaPersonalCheckbool;

            command.Parameters.Add("@ActAsociadaPosgradoCheck", SqlDbType.Bit);
            command.Parameters["@ActAsociadaPosgradoCheck"].Value = entidad.ActAsociadaPosgradoCheckbool;

            command.Parameters.Add("@CategoriaEmpleado", SqlDbType.NVarChar);
            command.Parameters["@CategoriaEmpleado"].Value = entidad.CategoriaEmpleado;

            command.Parameters.Add("@CostoEvento", SqlDbType.NVarChar);
            command.Parameters["@CostoEvento"].Value = entidad.CostoEvento;

            command.Parameters.Add("@EmailSolicitante", SqlDbType.NVarChar);
            command.Parameters["@EmailSolicitante"].Value = entidad.EmailSolicitante;

            command.Parameters.Add("@EstadoSolicitud", SqlDbType.NVarChar);
            command.Parameters["@EstadoSolicitud"].Value = entidad.EstadoSolicitud;

            command.Parameters.Add("@FechaRegreso", SqlDbType.NVarChar);
            command.Parameters["@FechaRegreso"].Value = entidad.FechaRegreso;

            command.Parameters.Add("@FechaSalida", SqlDbType.NVarChar);
            command.Parameters["@FechaSalida"].Value = entidad.FechaSalida;

            command.Parameters.Add("@HoraRegreso", SqlDbType.NVarChar);
            command.Parameters["@HoraRegreso"].Value = entidad.HoraRegreso;

            command.Parameters.Add("@HoraSalida", SqlDbType.NVarChar);
            command.Parameters["@HoraSalida"].Value = entidad.HoraSalida;

            command.Parameters.Add("@LugarEvento", SqlDbType.NVarChar);
            command.Parameters["@LugarEvento"].Value = entidad.LugarEvento;

            command.Parameters.Add("@NombreEvento", SqlDbType.NVarChar);
            command.Parameters["@NombreEvento"].Value = entidad.NombreEvento;

            command.Parameters.Add("@NombreMaestro", SqlDbType.NVarChar);
            command.Parameters["@NombreMaestro"].Value = entidad.NombreMaestro;

            command.Parameters.Add("@NumeroEmpleado", SqlDbType.NVarChar);
            command.Parameters["@NumeroEmpleado"].Value = entidad.NumeroEmpleado;

            command.Parameters.Add("@RecursoCombustibleCheck", SqlDbType.Bit);
            command.Parameters["@RecursoCombustibleCheck"].Value = entidad.RecursoCombustibleCheckbool;

            command.Parameters.Add("@RecursoCombustibleDef", SqlDbType.NVarChar);
            command.Parameters["@RecursoCombustibleDef"].Value = entidad.RecursoCombustibleDef;

            command.Parameters.Add("@RecursoHospedajeCheck", SqlDbType.Bit);
            command.Parameters["@RecursoHospedajeCheck"].Value = entidad.RecursoHospedajeCheckbool;

            command.Parameters.Add("@RecursoOficioComision", SqlDbType.NVarChar);
            command.Parameters["@RecursoOficioComision"].Value = entidad.RecursoOficioComisionbool;

            command.Parameters.Add("@RecursoOtroCheck", SqlDbType.Bit);
            command.Parameters["@RecursoOtroCheck"].Value = entidad.RecursoOtroCheckbool;

            command.Parameters.Add("@RecursoOtroDef", SqlDbType.NVarChar);
            command.Parameters["@RecursoOtroDef"].Value = entidad.RecursoOtroDef;

            command.Parameters.Add("@RecursoTransporteCheck", SqlDbType.Bit);
            command.Parameters["@RecursoTransporteCheck"].Value = entidad.RecursoTransporteCheckbool;

            command.Parameters.Add("@RecursoTransporteDef", SqlDbType.NVarChar);
            command.Parameters["@RecursoTransporteDef"].Value = entidad.RecursoTransporteDef;

            command.Parameters.Add("@RecursoViaticosCheck", SqlDbType.Bit);
            command.Parameters["@RecursoViaticosCheck"].Value = entidad.RecursoViaticosCheckbool;

            command.Parameters.Add("@CarrAsociadaCivilCheck", SqlDbType.Bit);
            command.Parameters["@CarrAsociadaCivilCheck"].Value = entidad.CarrAsociadaCivilCheck;

            command.Parameters.Add("@CarrAsociadaComputacionCheck", SqlDbType.Bit);
            command.Parameters["@CarrAsociadaComputacionCheck"].Value = entidad.CarrAsociadaComputacionCheck;

            command.Parameters.Add("@CarrAsociadaElectronicaCheck", SqlDbType.Bit);
            command.Parameters["@CarrAsociadaElectronicaCheck"].Value = entidad.CarrAsociadaElectronicaCheck;

            command.Parameters.Add("@CarrAsociadaIndustrialCheck", SqlDbType.Bit);
            command.Parameters["@CarrAsociadaIndustrialCheck"].Value = entidad.CarrAsociadaIndustrialCheck;

            command.Parameters.Add("@CarrAsociadaArquitecturaCheck", SqlDbType.Bit);
            command.Parameters["@CarrAsociadaArquitecturaCheck"].Value = entidad.CarrAsociadaArquitecturaCheck;

            command.Parameters.Add("@CarrAsociadaBioingenieriaCheck", SqlDbType.Bit);
            command.Parameters["@CarrAsociadaBioingenieriaCheck"].Value = entidad.CarrAsociadaBioingenieriaCheck;

            command.Parameters.Add("@CarrAsociadaNanotecnologiaCheck", SqlDbType.Bit);
            command.Parameters["@CarrAsociadaNanotecnologiaCheck"].Value = entidad.CarrAsociadaNanotecnologiaCheck;

            command.Parameters.Add("@RevCoordinadorCivil", SqlDbType.Bit);
            command.Parameters["@RevCoordinadorCivil"].Value = entidad.RevCoordinadorCivil;

            command.Parameters.Add("@RevCoordinadorElectronica", SqlDbType.Bit);
            command.Parameters["@RevCoordinadorElectronica"].Value = entidad.RevCoordinadorElectronica;

            command.Parameters.Add("@RevCoordinadorComputacion", SqlDbType.Bit);
            command.Parameters["@RevCoordinadorComputacion"].Value = entidad.RevCoordinadorComputacion;

            command.Parameters.Add("@RevCoordinadorIndustrial", SqlDbType.Bit);
            command.Parameters["@RevCoordinadorIndustrial"].Value = entidad.RevCoordinadorIndustrial;

            command.Parameters.Add("@RevCoordinadorArquitectura", SqlDbType.Bit);
            command.Parameters["@RevCoordinadorArquitectura"].Value = entidad.RevCoordinadorArquitectura;

            command.Parameters.Add("@RevCoordinadorBioingenieria", SqlDbType.Bit);
            command.Parameters["@RevCoordinadorBioingenieria"].Value = entidad.RevCoordinadorBioingenieria;

            command.Parameters.Add("@RevCoordinadorNanotecnologia", SqlDbType.Bit);
            command.Parameters["@RevCoordinadorNanotecnologia"].Value = entidad.RevCoordinadorNanotecnologia;

            command.Parameters.Add("@RevDirector", SqlDbType.Bit);
            command.Parameters["@RevDirector"].Value = entidad.RevDirector;

            command.Parameters.Add("@RevSubdirector", SqlDbType.Bit);
            command.Parameters["@RevSubdirector"].Value = entidad.RevDirector;

            command.Parameters.Add("@RevAdministrador", SqlDbType.Bit);
            command.Parameters["@RevAdministrador"].Value = entidad.RevAdministrador;

            command.Parameters.Add("@RevPosgrado", SqlDbType.Bit);
            command.Parameters["@RevPosgrado"].Value = entidad.RevPosgrado;

            command.Parameters.Add("@NumInvolucrados", SqlDbType.Int);
            command.Parameters["@NumInvolucrados"].Value = entidad.Involucrados;

            command.Parameters.Add("@AprobadoCoordinadorCivil", SqlDbType.Bit);
            command.Parameters["@AprobadoCoordinadorCivil"].Value = entidad.AprobadoCoordinadorCivil;

            command.Parameters.Add("@AprobadoCoordinadorElectronica", SqlDbType.Bit);
            command.Parameters["@AprobadoCoordinadorElectronica"].Value = entidad.AprobadoCoordinadorElectronica;

            command.Parameters.Add("@AprobadoCoordinadorComputacion", SqlDbType.Bit);
            command.Parameters["@AprobadoCoordinadorComputacion"].Value = entidad.AprobadoCoordinadorComputacion;

            command.Parameters.Add("@AprobadoCoordinadorIndustrial", SqlDbType.Bit);
            command.Parameters["@AprobadoCoordinadorIndustrial"].Value = entidad.AprobadoCoordinadorIndustrial;

            command.Parameters.Add("@AprobadoCoordinadorArquitectura", SqlDbType.Bit);
            command.Parameters["@AprobadoCoordinadorArquitectura"].Value = entidad.AprobadoCoordinadorArquitectura;

            command.Parameters.Add("@AprobadoCoordinadorBioingenieria", SqlDbType.Bit);
            command.Parameters["@AprobadoCoordinadorBioingenieria"].Value = entidad.AprobadoCoordinadorBioingenieria;

            command.Parameters.Add("@AprobadoCoordinadorNanotecnologia", SqlDbType.Bit);
            command.Parameters["@AprobadoCoordinadorNanotecnologia"].Value = entidad.AprobadoCoordinadorNanotecnologia;

            command.Parameters.Add("@AprobadoSubDirector", SqlDbType.Bit);
            command.Parameters["@AprobadoSubDirector"].Value = entidad.AprobadoSubDirector;

            command.Parameters.Add("@AprobadoAdministrador", SqlDbType.Bit);
            command.Parameters["@AprobadoAdministrador"].Value = entidad.AprobadoAdministrador;

            command.Parameters.Add("@AprobadoDirector", SqlDbType.Bit);
            command.Parameters["@AprobadoDirector"].Value = entidad.AprobadoDirector;

            command.Parameters.Add("@AprobadoPosgrado", SqlDbType.Bit);
            command.Parameters["@AprobadoPosgrado"].Value = entidad.AprobadoPosgrado;

            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                    success = true;
            }
            catch (SqlException ex)  // EXCEPCION DEMASIADOS ARGUMENTOS
            {
                //Excepcion de SQL
            }
            catch (Exception ex)
            {
                //Excepcion C#
            }
            finally
            {
                connection.Close();
            }

            return success;
        }

        public bool RechazarSolicitudPorFolio(int folio)
        {
            bool success = false;

            SqlCommand command = null;
            command = new SqlCommand("spRechazarSolicitudPorFolio", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@FolioSolicitud", folio);

            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                    success = true;
            }
            catch (SqlException ex)  
            {
                //Excepcion de SQL
            }
            catch (Exception ex)
            {
                //Excepcion C#
            }
            finally
            {
                connection.Close();
            }


            return success;
        }
        public bool AprobarSolicitudPorFolio(int folio)
        {
            bool success=false;
            SqlCommand command = null;
            command = new SqlCommand("spAprobarSolicitudPorFolio", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@FolioSolicitud", folio);

            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                    success = true;
            }
            catch (SqlException ex)  // EXCEPCION DEMASIADOS ARGUMENTOS
            {
                //Excepcion de SQL
            }
            catch (Exception ex)
            {
                //Excepcion C#
            }
            finally
            {
                connection.Close();
            }

            return success;
        }

        public List<E_Solicitud> MostrarSolicitudesPorEmailYEstadoDataset(string email, string estadoSolicitud)
        {
            List<E_Solicitud> lstSolicitudes = new List<E_Solicitud>();
            SqlCommand command = null;
            command = new SqlCommand("spMostrarSolicitudesPorEmailYEstado", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Status", estadoSolicitud);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                E_Solicitud entidad = null;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    entidad = new E_Solicitud();
                    popule(dr, entidad);
                    lstSolicitudes.Add(entidad);
                }
            }
            catch (SqlException ex)
            {
                lstSolicitudes = null;
            }
            catch (Exception ex)
            {
                lstSolicitudes = null;
            }
            finally
            {
                connection.Close();
            }
            return lstSolicitudes;
        }

        public List<E_Solicitud> MostrarSolicitudesPorEmailEstadoFolioDataset(string email, string estadoSolicitud, 
            int FolioSolicitud)
        {
            List<E_Solicitud> lstSolicitudes = new List<E_Solicitud>();
            SqlCommand command = null;
            command = new SqlCommand("[spMostrarSolicitudesPorEmailEstadoFolio]", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Status", estadoSolicitud);
            command.Parameters.AddWithValue("@FolioSolicitud", FolioSolicitud);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                E_Solicitud entidad = null;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    entidad = new E_Solicitud();
                    popule(dr, entidad);
                    lstSolicitudes.Add(entidad);
                }
            }
            catch (SqlException ex)
            {
                lstSolicitudes = null;
            }
            catch (Exception ex)
            {
                lstSolicitudes = null;
            }
            finally
            {
                connection.Close();
            }
            return lstSolicitudes;
        }
 
        private void popule(DataRow dr, E_Solicitud entidad)
        {
            // Cuando es SQlServer podemos hacerlo así
            entidad.FechaSolicitud = (string)dr["FechaDeSolicitud"];
            entidad.FolioSolicitud = (int)dr["FolioSolicitud"];
            entidad.ActAsociadaCACEICIEESCheckbool = (bool)dr["ActAsociadaCACEICIEESCheck"];
            entidad.ActAsociadaISO90012008Checkbool = (bool)dr["ActAsociadaISO90012008Check"];
            entidad.ActAsociadaLicenciaturaCheckbool = (bool)dr["ActAsociadaLicenciaturaCheck"];
            entidad.ActAsociadaOtraCheckbool = (bool)dr["ActAsociadaOtraCheck"];
            entidad.ActAsociadaOtraDef = (string)dr["ActAsociadaOtraDef"];
            entidad.ActAsociadaPersonalCheckbool = (bool)dr["ActAsociadaPersonalCheck"];
            entidad.ActAsociadaPosgradoCheckbool = (bool)dr["ActAsociadaPosgradoCheck"];
            entidad.CategoriaEmpleado = (string)dr["CategoriaEmpleado"];
            entidad.CostoEvento = (int)dr["CostoEvento"];
            entidad.EmailSolicitante = (string)dr["EmailSolicitante"];
            entidad.EstadoSolicitud = (string)dr["EstadoSolicitud"];
            entidad.FechaRegreso = (string)dr["FechaRegreso"];
            entidad.FechaSalida = (string)dr["FechaSalida"];
            entidad.HoraRegreso = (string)dr["HoraRegreso"];
            entidad.HoraSalida = (string)dr["HoraSalida"];
            entidad.LugarEvento = (string)dr["LugarEvento"];
            entidad.NombreEvento = (string)dr["NombreEvento"];
            entidad.NombreMaestro = (string)dr["NombreMaestro"];
            entidad.NumeroEmpleado = (int)dr["NumeroEmpleado"];
            entidad.RecursoCombustibleCheckbool = (bool)dr["RecursoCombustibleCheck"];
            entidad.RecursoCombustibleDef = (int)dr["RecursoCombustibleDef"];
            entidad.RecursoHospedajeCheckbool = (bool)dr["RecursoHospedajeCheck"];
            entidad.RecursoOficioComisionbool = (bool)dr["RecursoOficioComision"];
            entidad.RecursoOtroCheckbool = (bool)dr["RecursoOtroCheck"];
            entidad.RecursoOtroDef = (string)dr["RecursoOtroDef"];
            entidad.RecursoTransporteCheckbool = (bool)dr["RecursoTransporteCheck"];
            entidad.RecursoTransporteDef = (string)dr["RecursoTransporteDef"];
            entidad.RecursoViaticosCheckbool = (bool)dr["RecursoViaticosCheck"];
            entidad.IdSolicitud = (int)dr["FolioSolicitud"];

            entidad.CarrAsociadaCivilCheck = (bool)dr["CarrAsociadaCivilCheck"];
            entidad.CarrAsociadaComputacionCheck = (bool)dr["CarrAsociadaComputacionCheck"];
            entidad.CarrAsociadaElectronicaCheck = (bool)dr["CarrAsociadaElectronicaCheck"];
            entidad.CarrAsociadaIndustrialCheck = (bool)dr["CarrAsociadaIndustrialCheck"];
            entidad.CarrAsociadaArquitecturaCheck = (bool)dr["CarrAsociadaArquitecturaCheck"];
            entidad.CarrAsociadaBioingenieriaCheck = (bool)dr["CarrAsociadaBioingenieriaCheck"];
            entidad.CarrAsociadaNanotecnologiaCheck = (bool)dr["CarrAsociadaNanotecnologiaCheck"];

            entidad.RevCoordinadorCivil = (bool)dr["RevCoordinadorCivil"];
            entidad.RevCoordinadorElectronica = (bool)dr["RevCoordinadorElectronica"];
            entidad.RevCoordinadorComputacion = (bool)dr["RevCoordinadorComputacion"];
            entidad.RevCoordinadorIndustrial = (bool)dr["RevCoordinadorIndustrial"];
            entidad.RevCoordinadorArquitectura = (bool)dr["RevCoordinadorArquitectura"];
            entidad.RevCoordinadorBioingenieria = (bool)dr["RevCoordinadorBioingenieria"];
            entidad.RevCoordinadorNanotecnologia = (bool)dr["RevCoordinadorNanotecnologia"];
            entidad.RevDirector = (bool)dr["RevDirector"];
            entidad.RevSubdirector = (bool)dr["RevSubdirector"];
            entidad.RevAdministrador = (bool)dr["RevAdministrador"];
            entidad.RevPosgrado = (bool)dr["RevPosgrado"];

            entidad.AprobadoCoordinadorCivil = (bool)dr["AprobadoCoordinadorCivil"];
            entidad.AprobadoCoordinadorElectronica = (bool)dr["AprobadoCoordinadorElectronica"];
            entidad.AprobadoCoordinadorComputacion = (bool)dr["AprobadoCoordinadorComputacion"];
            entidad.AprobadoCoordinadorIndustrial = (bool)dr["AprobadoCoordinadorIndustrial"];
            entidad.AprobadoCoordinadorArquitectura = (bool)dr["AprobadoCoordinadorArquitectura"];
            entidad.AprobadoCoordinadorBioingenieria = (bool)dr["AprobadoCoordinadorBioingenieria"];
            entidad.AprobadoCoordinadorNanotecnologia = (bool)dr["AprobadoCoordinadorNanotecnologia"];
            entidad.AprobadoDirector = (bool)dr["AprobadoDirector"];
            entidad.AprobadoSubDirector = (bool)dr["AprobadoSubDirector"];
            entidad.AprobadoAdministrador = (bool)dr["AprobadoAdministrador"];
            entidad.AprobadoPosgrado = (bool)dr["AprobadoPosgrado"];

            entidad.Involucrados = (int)dr["numInvolucrados"];

            // Cuando no es SQLServer se hace de ésta manera.
            //entidad.NoEmpleado = Convert.ToInt32(dr["NoEmpleado"].ToString());
            //entidad.NombreMaestro = dr["NombreMaestro"].ToString();

        }

        public bool EnviarRespuestaASolicitud(string rolResponsable, int folioSolicitud, string decision)
        {
            bool success = false;
            SqlCommand command = null;

            // este método actualiza tanto revResponsable como AprobadoResponsable
            if(decision=="APROBADO")
            {
                command = new SqlCommand("spActualizarBitsAprobadoPorFolio", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Rol", rolResponsable);
                command.Parameters.AddWithValue("@FolioSolicitud", folioSolicitud);
            }

            // le faltan modificaciones
            if(decision=="RECHAZADO")
            {
                command = new SqlCommand("spActualizarBitsRechazadoPorFolio", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Rol", rolResponsable);
                command.Parameters.AddWithValue("@FolioSolicitud", folioSolicitud);
            }
            

             try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                    success = true;
                    
            }
            catch (SqlException ex)  // EXCEPCION DEMASIADOS ARGUMENTOS
            {
                //Excepcion de SQL
            }
            catch (Exception ex)
            {
                //Excepcion C#
            }
            finally
            {
                connection.Close();
            }
            return success;
        }

        public List<E_SolicitudRechazada> MostrarRechazosYMotivosPorFolio(int FolioSolicitudRechazada)
        {
            List<E_SolicitudRechazada> lstSolicitudRechazada = new List<E_SolicitudRechazada>();
            SqlCommand command = null;
            command = new SqlCommand("spMostrarRechazosYMotivosPorFolio", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@FolioSolicitudRechazada", FolioSolicitudRechazada);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                E_SolicitudRechazada entidad = null;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    entidad = new E_SolicitudRechazada();
                    popule1(dr, entidad);
                    lstSolicitudRechazada.Add(entidad);
                }
            }
            catch (SqlException ex)
            {
                lstSolicitudRechazada = null;
            }
            catch (Exception ex)
            {
                lstSolicitudRechazada = null;
            }
            finally
            {
                connection.Close();
            }
            return lstSolicitudRechazada;
        }

        private void popule1(DataRow dr, E_SolicitudRechazada entidad)
        {
            entidad.CorreoRechazante = (string)dr["CorreoRechazante"];
            entidad.FolioSolicitudRechazada = (int)dr["FolioSolicitudRechazada"];
            entidad.MotivoRechazo = (string)dr["MotivoRechazo"];
            entidad.NombreDeRechazante = (string)dr["NombreDeRechazante"];
            entidad.RolRechazante = (string)dr["RolRechazante"];
        }

        public List<bool> MostrarRevisionDeSolicitudesBool(int FolioSolicitud)
        {
            List<bool> lstEntidad = new List<bool>();
            SqlCommand command = null;
            command = new SqlCommand("spMostrarRevisionesDeSolicitud", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@FolioSolicitud", FolioSolicitud);


            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                
                foreach (DataRow dr in ds.Tables[0].Rows)
                {

                    lstEntidad = new List<bool>();
                    popule2(dr, lstEntidad);
                }
            }
            catch (SqlException ex)
            {
                lstEntidad = null;
            }
            catch (Exception ex)
            {
                lstEntidad = null;
            }
            finally
            {
                connection.Close();
            }
            return lstEntidad;
        }

        private void popule2(DataRow dr, List<bool> entidad)
        {
            // Cuando es SQlServer podemos hacerlo así
            entidad.Add((bool)dr["RevCoordinadorCivil"]);
            entidad.Add((bool)dr["RevCoordinadorElectronica"]);
            entidad.Add((bool)dr["RevCoordinadorComputacion"]);
            entidad.Add((bool)dr["RevCoordinadorIndustrial"]);
            entidad.Add((bool)dr["RevCoordinadorArquitectura"]);
            entidad.Add((bool)dr["RevCoordinadorBioingenieria"]);
            entidad.Add((bool)dr["RevCoordinadorNanotecnologia"]);
            entidad.Add((bool)dr["RevDirector"]);
            entidad.Add((bool)dr["RevSubdirector"]);
            entidad.Add((bool)dr["RevAdministrador"]);
            entidad.Add((bool)dr["RevPosgrado"]);

        }

        public List<bool> MostrarSoloAprobadas(int FolioSolicitud)
        {
            List<bool> lstBool = null;
            SqlCommand command = null;
            command = new SqlCommand("spMostrarAprobacionesDenegaciones", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@FolioSolicitud", FolioSolicitud);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    lstBool = new List<bool>();
                    popule3(dr, lstBool);
                }
            }
            catch (SqlException ex)
            {
                lstBool = null;
            }
            catch (Exception ex)
            {
                lstBool = null;
            }
            finally
            {
                connection.Close();
            }
            return lstBool;
        }

        private void popule3(DataRow dr, List<bool> lstBool)
        {
            // Cuando es SQlServer podemos hacerlo así
            if((bool)dr["AprobadoCoordinadorCivil"]==true)
            {
                lstBool.Add((bool)dr["AprobadoCoordinadorCivil"]);
            }

            if((bool)dr["AprobadoCoordinadorElectronica"]==true)
            {
                lstBool.Add((bool)dr["AprobadoCoordinadorElectronica"]);
            }
            
            if((bool)dr["AprobadoCoordinadorComputacion"]==true)
            {
                lstBool.Add((bool)dr["AprobadoCoordinadorComputacion"]);
            }

            if((bool)dr["AprobadoCoordinadorIndustrial"])
            {
                lstBool.Add((bool)dr["AprobadoCoordinadorIndustrial"]);
            }
           
            if((bool)dr["AprobadoCoordinadorArquitectura"])
            {
                lstBool.Add((bool)dr["AprobadoCoordinadorArquitectura"]);
            }

            if((bool)dr["AprobadoCoordinadorBioingenieria"])
            {
                lstBool.Add((bool)dr["AprobadoCoordinadorBioingenieria"]);
            }
            
            if((bool)dr["AprobadoCoordinadorNanotecnologia"])
            {
                lstBool.Add((bool)dr["AprobadoCoordinadorNanotecnologia"]);
            }
            
            if((bool)dr["AprobadoDirector"])
            {
                lstBool.Add((bool)dr["AprobadoDirector"]);
            }

            if((bool)dr["AprobadoSubDirector"])
            {
                lstBool.Add((bool)dr["AprobadoSubDirector"]);
            }
            
            if((bool)dr["AprobadoAdministrador"])
            {
                lstBool.Add((bool)dr["AprobadoAdministrador"]);
            }
            
            if((bool)dr["AprobadoPosgrado"])
            {
                lstBool.Add((bool)dr["AprobadoPosgrado"]);
            }
        }

    }
}
