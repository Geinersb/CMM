using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidadades;

namespace DAL.BD
{
   public class Departamento_DAL
    {

        private string stringConexion = Properties.Settings.Default.cadena;

        //public List<Departamento> ListarDepartamentos()
        //{

        //    List<Departamento> lstEmpleadosDAL = new List<Departamento>();

        //    SqlCommand command;
        //    string query = "SP_CONSULTA_EMPLEADOS";

        //    using (SqlConnection connection = new SqlConnection(stringConexion))
        //    {
        //        command = new SqlCommand(query, connection);
        //        command.CommandType = CommandType.StoredProcedure;

        //        try
        //        {
        //            connection.Open();
        //            SqlDataReader reader = command.ExecuteReader();

        //            while (reader.Read())
        //            {
        //                Empleado oEmpleadoDal = new Empleado();
        //                oEmpleadoDal.Id_empleado = reader.GetInt32(0);
        //                oEmpleadoDal.Nombre = reader.GetString(1);
        //                oEmpleadoDal.Apellido1 = reader.GetString(2);
        //                oEmpleadoDal.Apellido2 = reader.GetString(3);
        //                oEmpleadoDal.Cedula = reader.GetString(4);
        //                oEmpleadoDal.Telefono = reader.GetString(5);
        //                oEmpleadoDal.Correo = reader.GetString(6);
        //                oEmpleadoDal.Usuario = reader.GetString(7);
        //                oEmpleadoDal.Pass = reader.GetString(8);
        //                oEmpleadoDal.Id_perfil = reader.GetInt32(9);
        //                oEmpleadoDal.Id_departamento = reader.GetInt32(10);

        //                lstEmpleadosDAL.Add(oEmpleadoDal);
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
        //    }

        //    return lstEmpleadosDAL;
        //}


        public DataTable FiltrarDepartamentos(string nombre)
        {
            SqlConnection connection = new SqlConnection(stringConexion);
            string query = "SP_FILTRAR_Departamentos '" + nombre + "'";

            SqlCommand cmd = new SqlCommand(query, connection);

            DataTable t1 = new DataTable();
            using (SqlDataAdapter a = new SqlDataAdapter(cmd))
            {
                a.Fill(t1);
            }
            return t1;
        }




        public void AgregarDepartamentos(Departamento oEmpleadoDAL)
        {
            SqlCommand command;
            string query = "sp_INSERTAR_DEPARTAMENTOS";

            using (SqlConnection connection = new SqlConnection(stringConexion))
            {
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", oEmpleadoDAL.Nombre);
                command.Parameters.AddWithValue("@codigo", oEmpleadoDAL.Codigo);
                

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


        public void ActualizarDepartamento(Departamento oEmpleadoDAL)
        {
            SqlCommand command;
            string query = "SP_MODIFICAR_DEPARTAMENTOS ";

            using (SqlConnection connection = new SqlConnection(stringConexion))
            {
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id_departamento", oEmpleadoDAL.Id_departamento);
                command.Parameters.AddWithValue("@nombre", oEmpleadoDAL.Nombre);
                command.Parameters.AddWithValue("@codigo", oEmpleadoDAL.Codigo);
                

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



    }
}
