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
    public class Perfil_DAL
    {
        private string stringConexion = Properties.Settings.Default.cadena;

       

        public List<Perfil> ListarPerfiles()
        {
            List<Perfil> lstPerfilesDAL = new List<Perfil>();

            SqlCommand command;
            string query = "CONSULTA_PERFILES";

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
                        Perfil oPerfilDal = new Perfil();
                        oPerfilDal.Nombre = reader.GetString(0);


                        lstPerfilesDAL.Add(oPerfilDal);
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

            return lstPerfilesDAL;
        }






    }

}
