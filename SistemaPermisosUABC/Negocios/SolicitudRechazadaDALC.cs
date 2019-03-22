using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Negocios
{
    public class SolicitudRechazadaDALC : ConnectionDB
    {
        public bool AgregarSolicitudRechazada(E_SolicitudRechazada solicitud)
        {
            bool success = false;
            SqlCommand command = new SqlCommand("spAgregarRechazosYMotivos", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@FolioSolicitudRechazada", solicitud.FolioSolicitudRechazada);
            command.Parameters.AddWithValue("@NombreDeRechazante", solicitud.NombreDeRechazante);
            command.Parameters.AddWithValue("@RolRechazante", solicitud.RolRechazante);
            command.Parameters.AddWithValue("@CorreoRechazante", solicitud.CorreoRechazante);
            command.Parameters.AddWithValue("@MotivoRechazo", solicitud.MotivoRechazo);
            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                    success = true;

            }
            catch (SqlException ex)
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return success;
        }

        public List<E_SolicitudRechazada> MostrarMotivosRechazosPorFolio(int folioSolicitud)
        {
            List<E_SolicitudRechazada> lstMotivos = new List<E_SolicitudRechazada>();
            SqlCommand command = new SqlCommand("spMostrarRechazosYMotivosPorFolio", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@FolioSolicitudRechazada", folioSolicitud);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                E_SolicitudRechazada entidad = null;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    entidad = new E_SolicitudRechazada();
                    popule(dr, entidad);
                    lstMotivos.Add(entidad);
                }
            }
            catch (SqlException ex)
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return lstMotivos;
        }

        public List<E_SolicitudRechazada> MostrarMotivosRechazosPorFolioYRol(int folioSolicitud, string rol)
        {
            List<E_SolicitudRechazada> lstMotivos = new List<E_SolicitudRechazada>();
            SqlCommand command = new SqlCommand("spMostrarRechazosYMotivosPorFolioYRol", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@FolioSolicitudRechazada", folioSolicitud);
            command.Parameters.AddWithValue("@RolRechazante", rol);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                E_SolicitudRechazada entidad = null;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    entidad = new E_SolicitudRechazada();
                    popule(dr, entidad);
                    lstMotivos.Add(entidad);
                }
            }
            catch (SqlException ex)
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return lstMotivos;
        }

        public bool popule(DataRow dr, E_SolicitudRechazada entidad)
        {
            bool success = false;
            entidad.CorreoRechazante = (string)dr["CorreoRechazante"];
            entidad.FolioSolicitudRechazada = (int)dr["FolioSolicitudRechazada"];
            entidad.MotivoRechazo = (string)dr["MotivoRechazo"];
            entidad.NombreDeRechazante = (string)dr["NombreDeRechazante"];
            entidad.RolRechazante = (string)dr["RolRechazante"];
            return success;
        }

        public bool EliminarMotivosRechazoPorFolio(int folioSolicitudRechazada, string responsable)
        {
            bool success = false;
            SqlCommand command = new SqlCommand("spEliminarMotivoRechazoPorFolio", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@FolioSolicitudRechazada", folioSolicitudRechazada);
            command.Parameters.AddWithValue("@RolResponsable", responsable);

            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                    success = true;
            }
            catch(SqlException ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return success;
        }
    }
}
