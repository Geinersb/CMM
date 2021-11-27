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
