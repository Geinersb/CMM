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
    public class Niveles_DAL
    {


        private string stringConexion = Properties.Settings.Default.cadena;


        public List<Nivel> ListarNiveles()
        {
            List<Nivel> lstNivelesDAL = new List<Nivel>();

            SqlCommand command;
            string query = "SP_CONSULTA_NIVELES";

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
                        Nivel oNivelDal = new Nivel();
                        oNivelDal.Id_nivel = reader.GetInt32(0);
                        oNivelDal.Descripcion = reader.GetString(1);

                        lstNivelesDAL.Add(oNivelDal);
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

            return lstNivelesDAL;
        }


    }
}
