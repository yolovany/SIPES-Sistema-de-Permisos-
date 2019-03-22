using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class UsuariosDALC : ConnectionDB
    {
        
        public bool AgregarUsuario(E_Usuario usuario)
        {
            
            bool success = false;
            SqlCommand command = new SqlCommand("spAgregarUsuario", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Rol", usuario.Rol);
            command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
            command.Parameters.AddWithValue("@Apellidos", usuario.Apellidos);
            command.Parameters.AddWithValue("@NoEmpleado", usuario.NoEmpleado);
            command.Parameters.AddWithValue("@Email", usuario.Email);
            command.Parameters.AddWithValue("@Password", usuario.Password);
            command.Parameters.AddWithValue("@status", usuario.Status);
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
            catch(Exception ex)
            {
                //Excepcion C#
            }
            finally
            {
                connection.Close();
            }

            return success;
        }

        public List<E_Usuario> MostrarUsuariosPorEmail(string email)
        {
            List<E_Usuario> lstUsuarios = new List<E_Usuario>();           
            SqlCommand command = new SqlCommand("spMostrarUsuariosPorEmail", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Email", email);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                E_Usuario entidad = null;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    entidad = new E_Usuario();
                    popule(dr, entidad);
                    lstUsuarios.Add(entidad);
                }
            }
            catch (SqlException ex)
            {
                lstUsuarios = null;
            }
            catch (Exception ex)
            {
                lstUsuarios = null;
            }
            return lstUsuarios;
        }

        private void popule(DataRow dr, E_Usuario entidad)
        {
            entidad.NoEmpleado = (int)dr["NoEmpleado"];
            entidad.Nombre = (string)dr["Nombre"];
            entidad.Apellidos = (string)dr["Apellidos"];
            entidad.Email = (string)dr["Email"];
            entidad.Rol = (string)dr["Rol"];
            entidad.Password = (string)dr["Password"];
            entidad.Status = (string)dr["Status"];
        }

    }
}
