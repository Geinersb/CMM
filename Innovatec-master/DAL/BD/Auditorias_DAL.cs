using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidadades;
using System.Data;
using System.Data.SqlClient;


namespace DAL.BD
{
     public class Auditorias_DAL
    {
        Empleado_DAL empleadoDal = new Empleado_DAL();
        private string stringConexion = Properties.Settings.Default.cadena;

        public void AgregarAuditoria(Auditoria oAuditoriaDAL)
        {
            SqlCommand command;
            string query = "SP_AGREGAR_AUDITORIAS";

            using (SqlConnection connection = new SqlConnection(stringConexion))
            {
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuario", oAuditoriaDAL.Usuario);
                command.Parameters.AddWithValue("@codigo_departamento", oAuditoriaDAL.Codigo_departamento);
                command.Parameters.AddWithValue("@id_proceso", oAuditoriaDAL.Id_proceso);
                command.Parameters.AddWithValue("@hallazgos", oAuditoriaDAL.Hallasgoz01);
                command.Parameters.AddWithValue("@recomendaciones", oAuditoriaDAL.Recomendaciones);
                command.Parameters.AddWithValue("@fecha_limite", oAuditoriaDAL.Fecha_limite);
                command.Parameters.AddWithValue("@fecha_auditoria", oAuditoriaDAL.Fecha_auditoria);
                
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();
                    command.ExecuteScalar();
                    connection.Close();
                    empleadoDal.EnviarCorreosAuditorias(oAuditoriaDAL);



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

        public List<Auditoria> ListarAuditorias()
        {

            List<Auditoria> lstAuditoriaDAL = new List<Auditoria>();

            SqlCommand command;
            string query = "SP_CONSULTA_AUDITORIAS";

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
                        Auditoria oAuditoriaDal = new Auditoria();
                        oAuditoriaDal.Id_aditoria = reader.GetInt32(0);
                        oAuditoriaDal.Usuario = reader.GetString(1);
                        oAuditoriaDal.Codigo_departamento = reader.GetString(2);
                        oAuditoriaDal.Id_proceso = reader.GetInt32(3);
                        oAuditoriaDal.Hallasgoz01 = reader.GetString(4);
                        oAuditoriaDal.Recomendaciones = reader.GetString(5);
                        oAuditoriaDal.Fecha_limite = reader.GetDateTime(6);
                        oAuditoriaDal.Fecha_auditoria = reader.GetDateTime(7);

                        lstAuditoriaDAL.Add(oAuditoriaDal);
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

            return lstAuditoriaDAL;
        }



        public DataTable FiltrarAuditorias(string codigo)
        {
            SqlConnection connection = new SqlConnection(stringConexion);
            string query = "SP_CONSULTA_AUDITORIAS_CODIGO '" + codigo + "'";

            SqlCommand cmd = new SqlCommand(query, connection);

            DataTable t1 = new DataTable();
            using (SqlDataAdapter a = new SqlDataAdapter(cmd))
            {
                a.Fill(t1);
            }
            return t1;
        }


        public DataTable FiltrarAuditoriasPorIdProceso(int idProceso)
        {
            SqlConnection connection = new SqlConnection(stringConexion);
            string query = "SP_CONSULTA_AUDITORIAS_POR_IDPROCESO '" + idProceso + "'";

            SqlCommand cmd = new SqlCommand(query, connection);

            DataTable t1 = new DataTable();
            using (SqlDataAdapter a = new SqlDataAdapter(cmd))
            {
                a.Fill(t1);
            }
            return t1;
        }


    }
}
