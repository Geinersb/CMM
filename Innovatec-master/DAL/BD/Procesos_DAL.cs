﻿using System;
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


        public void AgregarProceso(Proceso oEmpleadoDAL)
        {
            SqlCommand command;
            string query = "AGREGAR_PROCESOS";

            using (SqlConnection connection = new SqlConnection(stringConexion))
            {
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", oEmpleadoDAL.Nombre);
                command.Parameters.AddWithValue("@descripcion", oEmpleadoDAL.Descripcion);
                command.Parameters.AddWithValue("@id_nivel", oEmpleadoDAL.Id_nivel);
                command.Parameters.AddWithValue("@inicial", oEmpleadoDAL.Inicial);
                command.Parameters.AddWithValue("@repetible", oEmpleadoDAL.Repetible);
                command.Parameters.AddWithValue("@definido", oEmpleadoDAL.Definido);
                command.Parameters.AddWithValue("@gestionado", oEmpleadoDAL.Gestinado);
                command.Parameters.AddWithValue("@optimizado", oEmpleadoDAL.Optimizado);
                command.Parameters.AddWithValue("@id_empleado", oEmpleadoDAL.Id_empleado);
                command.Parameters.AddWithValue("@fecha_creacion", oEmpleadoDAL.Fecha_creacion);
                command.Parameters.AddWithValue("@estado", oEmpleadoDAL.Estado);

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
