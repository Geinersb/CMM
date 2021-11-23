using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidadades;
namespace DAL.BD
{
    public class Empleado_DAL
    {
        private string stringConexion = Properties.Settings.Default.cadena;

        public List<Empleado> ListarEmpleados()
        {

            List<Empleado> lstEmpleadosDAL = new List<Empleado>();

            SqlCommand command;
            string query = "SP_CONSULTA_EMPLEADOS";

            using (SqlConnection connection = new SqlConnection(stringConexion))
            {
                command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Empleado oEmpleadoDal = new Empleado();
                        oEmpleadoDal.Id_empleado = reader.GetInt32(0);
                        oEmpleadoDal.Nombre = reader.GetString(1);
                        oEmpleadoDal.Apellido1 = reader.GetString(2);
                        oEmpleadoDal.Apellido2 = reader.GetString(3);
                        oEmpleadoDal.Cedula = reader.GetString(4);
                        oEmpleadoDal.Telefono = reader.GetString(5);
                        oEmpleadoDal.Correo = reader.GetString(6);
                        oEmpleadoDal.Usuario = reader.GetString(7);
                        oEmpleadoDal.Pass = reader.GetString(8);
                        oEmpleadoDal.Id_perfil = reader.GetInt32(9);
                        oEmpleadoDal.Id_departamento = reader.GetInt32(10);

                        lstEmpleadosDAL.Add(oEmpleadoDal);
                    }
                    connection.Close();
                    reader.Close();
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return lstEmpleadosDAL;
        }


        public DataTable FiltrarEmpleados(string nombre)
        {
            SqlConnection connection = new SqlConnection(stringConexion);
            string query = "SP_FILTRAR_EMPLEADOS '" + nombre + "'";

            SqlCommand cmd = new SqlCommand(query, connection);
                       
            DataTable t1 = new DataTable();
            using (SqlDataAdapter a = new SqlDataAdapter(cmd))
            {
                a.Fill(t1);
            }
            return t1;
        }

        


        public void AgregarUsuario(Empleado oEmpleadoDAL)
        {
            SqlCommand command;
            string query = "sp_insertar_empleados";

            using (SqlConnection connection = new SqlConnection(stringConexion))
            {
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", oEmpleadoDAL.Nombre);
                command.Parameters.AddWithValue("@apellido1", oEmpleadoDAL.Apellido1);
                command.Parameters.AddWithValue("@apellido2", oEmpleadoDAL.Apellido2);
                command.Parameters.AddWithValue("@cedula", oEmpleadoDAL.Cedula);
                command.Parameters.AddWithValue("@telefono", oEmpleadoDAL.Telefono);
                command.Parameters.AddWithValue("@correo", oEmpleadoDAL.Correo);
                command.Parameters.AddWithValue("@usuario", oEmpleadoDAL.Usuario);
                command.Parameters.AddWithValue("@pass", oEmpleadoDAL.Pass);
                command.Parameters.AddWithValue("@perfil", oEmpleadoDAL.Id_perfil);
                command.Parameters.AddWithValue("@departamento", oEmpleadoDAL.Id_departamento);

                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();
                    command.ExecuteScalar();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }


        public void ActualizarUsuario(Empleado oEmpleadoDAL)
        {
            SqlCommand command;
            string query = "sp_actualizar_empleado";

            using (SqlConnection connection = new SqlConnection(stringConexion))
            {
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", oEmpleadoDAL.Nombre);
                command.Parameters.AddWithValue("@apellido1", oEmpleadoDAL.Apellido1);
                command.Parameters.AddWithValue("@apellido2", oEmpleadoDAL.Apellido2);
                command.Parameters.AddWithValue("@cedula", oEmpleadoDAL.Cedula);
                command.Parameters.AddWithValue("@telefono", oEmpleadoDAL.Telefono);
                command.Parameters.AddWithValue("@correo", oEmpleadoDAL.Correo);
                command.Parameters.AddWithValue("@usuario", oEmpleadoDAL.Usuario);
                command.Parameters.AddWithValue("@pass", oEmpleadoDAL.Pass);
                command.Parameters.AddWithValue("@id_perfil", oEmpleadoDAL.Id_perfil);
                command.Parameters.AddWithValue("@id_departamento", oEmpleadoDAL.Id_departamento);

                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

            }
        }


        public void EliminarUsuario(Empleado oEmpleadoDAL)
        {
            SqlCommand command;
            string query = "sp_eliminar_empleado";

            using (SqlConnection connection = new SqlConnection(stringConexion))
            {
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id_empleado", oEmpleadoDAL.Id_empleado);
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }


        public Empleado Login(string user, string pass)
        {

            Empleado oEmpleadoDal = new Empleado();
            //oEmpleadoDal.Usuario = user;
            //oEmpleadoDal.Pass = pass;
            SqlCommand command;
            string query = "sp_login";
            //List<Empleado> lstEmpleadosDAL = new List<Empleado>();
            using (SqlConnection connection = new SqlConnection(stringConexion))
            {
               
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuario", user);
                command.Parameters.AddWithValue("@pass", pass);
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        
                      
                        oEmpleadoDal.Id_empleado = reader.GetInt32(0);
                        oEmpleadoDal.Nombre = reader.GetString(1);
                        oEmpleadoDal.Apellido1 = reader.GetString(2);
                        oEmpleadoDal.Apellido2 = reader.GetString(3);
                        oEmpleadoDal.Cedula = reader.GetString(4);
                        oEmpleadoDal.Telefono = reader.GetString(5);
                        oEmpleadoDal.Correo = reader.GetString(6);
                        oEmpleadoDal.Usuario = reader.GetString(7);
                        oEmpleadoDal.Pass = reader.GetString(8);
                        oEmpleadoDal.Id_perfil = reader.GetInt32(9);
                        oEmpleadoDal.Id_departamento = reader.GetInt32(10);
                       // lstEmpleadosDAL.Add(oEmpleadoDal);
                    }
                    connection.Close();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

            }
            // return lstEmpleadosDAL;
            return oEmpleadoDal;
        }


        /// <summary>
        /// metodo para asignar el token que vamos a usar cuando cambiemos la contraseña
        /// </summary>
        /// <param name="oUsuarioDAL"></param>
        /// <returns></returns>
        //public bool RecuperarContraseña(UsuarioEntitie oUsuarioDAL)
        //{
        //    SqlCommand command;

        //    using (SqlConnection connection = new SqlConnection(stringConexion))
        //    {
        //        command = new SqlCommand("update Tbl_Usuario set Token_recovery = " + "'" +
        //                                oUsuarioDAL.tokenRecovery + "'" + " where Correo = " + "'" +
        //                                oUsuarioDAL._Correo + "'", connection);

        //        try
        //        {
        //            connection.Open();
        //            command.ExecuteNonQuery();
        //            connection.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception(ex.Message);
        //        }
        //        finally
        //        {
        //            connection.Close();
        //        }
        //        return true;
        //    }
        //}

        /// <summary>
        /// metodo para cambiar la contraseña cuando se recupera la contraseña 
        /// </summary>
        /// <param name="oUsuarioDAL"></param>
        /// <returns></returns>
        //public bool CambiarContraseña(UsuarioEntitie oUsuarioDAL)
        //{
        //    SqlCommand command;
        //    string query;
        //    if (oUsuarioDAL._Id > 0)
        //    {
        //        query = "sp_cambiarContraseñaConId";
        //    }
        //    else
        //    {
        //        query = "sp_cambiarContraseña";
        //    }

        //    using (SqlConnection connection = new SqlConnection(stringConexion))
        //    {
        //        command = new SqlCommand(query, connection);
        //        if (oUsuarioDAL._Id > 0)
        //        {
        //            command.Parameters.AddWithValue("@id", oUsuarioDAL._Id);
        //            command.Parameters.AddWithValue("@contraseña", oUsuarioDAL._Pass);
        //        }
        //        else
        //        {
        //            command.Parameters.AddWithValue("@token", oUsuarioDAL.tokenRecovery);
        //            command.Parameters.AddWithValue("@contraseña", oUsuarioDAL._Pass);
        //        }
        //        command.CommandType = CommandType.StoredProcedure;
        //        try
        //        {
        //            connection.Open();
        //            command.ExecuteNonQuery();
        //            connection.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception(ex.Message);
        //        }
        //        finally
        //        {
        //            connection.Close();
        //        }
        //        return true;
        //    }
        //}

        //public string obtenerToken(UsuarioEntitie oUsuarioDAL)
        //{
        //    SqlCommand command;
        //    string token = "";
        //    using (SqlConnection connection = new SqlConnection(stringConexion))
        //    {
        //        command = new SqlCommand("SELECT Token_recovery FROM Tbl_Usuario where Correo = " + "'" +
        //                                oUsuarioDAL._Correo + "'", connection);

        //        try
        //        {
        //            connection.Open();
        //            SqlDataReader reader = command.ExecuteReader();
        //            while (reader.Read())
        //            {
        //                token = reader.GetString(0);
        //            }

        //            connection.Close();
        //            reader.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception(ex.Message);
        //        }
        //        finally
        //        {
        //            connection.Close();
        //        }

        //        if (!(token == ""))
        //        {
        //            return token;
        //        }
        //        else
        //        {
        //            return "no token";
        //        }
        //    }
        //}
    }
}
