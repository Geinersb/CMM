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
   public class Procesos_DAL
    {
        private string stringConexion = Properties.Settings.Default.cadena;

        public DataTable FiltrarProcesosDescripcion(string descripcion)
        {
            SqlConnection connection = new SqlConnection(stringConexion);
            string query = "SP_CONSULTA_PROCESOS_descripcion '" + descripcion + "'";
          
            SqlCommand cmd = new SqlCommand(query, connection);

            DataTable t1 = new DataTable();
            using (SqlDataAdapter a = new SqlDataAdapter(cmd))
            {
                a.Fill(t1);
            }
            return t1;
        }


        public DataTable FiltrarProcesosNiveles(int nivel)
        {
            SqlConnection connection = new SqlConnection(stringConexion);
            string query = "SP_CONSULTA_PROCESOS_niveles '" + nivel + "'";

            SqlCommand cmd = new SqlCommand(query, connection);

            DataTable t1 = new DataTable();
            using (SqlDataAdapter a = new SqlDataAdapter(cmd))
            {
                a.Fill(t1);
            }
            return t1;
        }

        public DataTable ListarProcesos()
        {
            SqlConnection connection = new SqlConnection(stringConexion);
            string query = "SP_CONSULTA_PROCESOS ";

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
