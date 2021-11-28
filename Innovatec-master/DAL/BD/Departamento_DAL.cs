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


        public List<Departamento> ListarDepartamentos()
        {

            List<Departamento> lstDepartamentoDAL = new List<Departamento>();

            SqlCommand command;
            string query = "CONSULTA_DEPARTAMENTOS";

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
                        Departamento oDepartamentoDal = new Departamento();
                        oDepartamentoDal.Nombre = reader.GetString(0);

                        lstDepartamentoDAL.Add(oDepartamentoDal);
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

            return lstDepartamentoDAL;
        }

        public List<Departamento> ListarDepartamentoCodigo()
        {

            List<Departamento> lstDepartamentoDAL = new List<Departamento>();

            SqlCommand command;
            string query = "CONSULTA_DEPARTAMENTO_CODIGOS";

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
                        Departamento oDepartamentoDal = new Departamento();
                        oDepartamentoDal.Codigo = reader.GetString(0);

                        lstDepartamentoDAL.Add(oDepartamentoDal);
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

            return lstDepartamentoDAL;
        }

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
