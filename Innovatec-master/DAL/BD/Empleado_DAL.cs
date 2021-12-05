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

            string nuevoPassword = this.generarPassword();
            oEmpleadoDAL.Pass = nuevoPassword;
            //generar un nuevo usuario
            oEmpleadoDAL.Usuario = this.generarUsuario(oEmpleadoDAL.Nombre);

            //comprobar que no exista ese usuario sino hay que volverlo a generar

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
                    this.enviarPass(nuevoPassword, oEmpleadoDAL.Correo, oEmpleadoDAL.Nombre,oEmpleadoDAL.Usuario);

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
                command.Parameters.AddWithValue("@id_empleado", oEmpleadoDAL.Id_empleado);
                command.Parameters.AddWithValue("@nombre", oEmpleadoDAL.Nombre);
                command.Parameters.AddWithValue("@apellido1", oEmpleadoDAL.Apellido1);
                command.Parameters.AddWithValue("@apellido2", oEmpleadoDAL.Apellido2);
                command.Parameters.AddWithValue("@cedula", oEmpleadoDAL.Cedula);
                command.Parameters.AddWithValue("@telefono", oEmpleadoDAL.Telefono);
                command.Parameters.AddWithValue("@correo", oEmpleadoDAL.Correo);
                command.Parameters.AddWithValue("@usuario", oEmpleadoDAL.Usuario);                
                command.Parameters.AddWithValue("@perfil", oEmpleadoDAL.Id_perfil);
                command.Parameters.AddWithValue("@departamento", oEmpleadoDAL.Id_departamento);

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

        public bool Login(string user, string pass)
        {

          
            SqlCommand command;
            string query = "sp_login";
            //List<Empleado> lstEmpleadosDAL = new List<Empleado>();
            using (SqlConnection connection = new SqlConnection(stringConexion))
            {

                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuario", user);
                command.Parameters.AddWithValue("@pass", pass);
                command.CommandType = CommandType.StoredProcedure;

               
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {


                        UserCache.Id_empleado = reader.GetInt32(0);
                        UserCache.Nombre = reader.GetString(1);
                        UserCache.Apellido1 = reader.GetString(2);
                        UserCache.Apellido2 = reader.GetString(3);
                        UserCache.Cedula = reader.GetString(4);
                        UserCache.Telefono = reader.GetString(5);
                        UserCache.Correo = reader.GetString(6);
                        UserCache.Usuario = reader.GetString(7);
                        UserCache.Pass = reader.GetString(8);
                        UserCache.Id_perfil = reader.GetInt32(9);
                        UserCache.Id_departamento = reader.GetInt32(10);

                    }
                    connection.Close();
                    reader.Close();
                    return true;
                }
                else
                    return false;

            
            }
            
        }


        public string RecoverPassword(string userRequesting)
        {
            SqlCommand command;
            string query = "SP_olvido_passwor";
            string respuesta="";
            using (SqlConnection connection = new SqlConnection(stringConexion))
            {

                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userRequesting ", userRequesting);
               // command.Parameters.AddWithValue("@pass", userRequesting);
                command.CommandType = CommandType.StoredProcedure;


                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        string nombre = reader.GetString(0);
                        string correo = reader.GetString(1);
                        string cedula = reader.GetString(2);
                        var mailService = new Entidadades.SystemSupportMail();

                        //generar el nuevo password
                        var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                        var Charsarr = new char[8];
                        var random = new Random();

                        for (int i = 0; i < Charsarr.Length; i++)
                        {
                            Charsarr[i] = characters[random.Next(characters.Length)];
                        }

                        var resultString = new String(Charsarr);

                        ActualizarPass(cedula, resultString);



                        mailService.sendMail(
                          subject: "SYSTEM: Recuperación de contraseña",
                          body: "Hola, " + nombre + "\nRecibimos una solicitud de cambio de contraseña.\n" +
                          "Su nueva contraseña es : " + resultString +
                          "\n",
                          recipientMail: new List<string> { correo }
                          );
                        respuesta= "Hola, " + nombre + "\n Se envió una nueva contraseña a su correo asociado.\n" +
                          "Por favor verifique su correo : " + correo +
                          "\nBuen día";


                    }
                    connection.Close();
                    reader.Close();

                }
                else
                   respuesta= "Lo sentimos, usted no tiene una cuenta \n con el correo o usuario brindado";


            }
            return respuesta;
        }


        public string generarPassword()
        {
            //generar el password
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var Charsarr = new char[8];
            var random = new Random();

            for (int i = 0; i < Charsarr.Length; i++)
            {
                Charsarr[i] = characters[random.Next(characters.Length)];
            }

            var resultString = new String(Charsarr);
            return resultString;
        }


        public string generarUsuario(string nombreEmpleado)
        {
            //generar el usuario
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var Charsarr = new char[5];
            var random = new Random();
            string nuevoUser;
            for (int i = 0; i < Charsarr.Length; i++)
            {
                Charsarr[i] = characters[random.Next(characters.Length)];
            }

            var resultString = new String(Charsarr);
            nuevoUser= nombreEmpleado + resultString;
            return nuevoUser;
        }


        public void enviarPass(string pass,string correo,string nombre,string user)
        {
                        string contraseña = pass;
                        string email = correo;
                        var mailService = new Entidadades.SystemSupportMail();
                        mailService.sendMail(
                          subject: "SYSTEM:  Envío de usuario y contraseña ",
                          body: "Buen día, " + nombre + "\nSe agregó su usuario correctamente al sistema.\n" +
                          "Su usuario es : " + user +
                          "\n"+
                          "Su contraseña es :"+pass + "\n",
                          recipientMail: new List<string> { correo }
                          );
                       

        }






        public void ActualizarPass(string cedula ,string pass)
        { 
            SqlCommand command;
            string query = "SP_cambio_password";

            using (SqlConnection connection = new SqlConnection(stringConexion))
            {
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@cedula",cedula);
                command.Parameters.AddWithValue("@pass", pass);
                
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



        public void EnviarCorreosAuditorias(Auditoria auditoria)
        {
            SqlCommand command;
            string query = "CONSULTA_CORREOS";
           
            using (SqlConnection connection = new SqlConnection(stringConexion))
            {

                command = new SqlCommand(query, connection);
                //command.Parameters.AddWithValue("@userRequesting ", );
                
                // command.Parameters.AddWithValue("@pass", userRequesting);
                command.CommandType = CommandType.StoredProcedure;


                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //nombre del correo
                        
                        string correo = reader.GetString(0);
                       
                        var mailService = new Entidadades.SystemSupportMail();

                        
                       


                        mailService.sendMail(
                          subject: "SYSTEM: Nueva Auditoria",
                          body: "Hola, " + "se ha realizado un proceso de auditoría .\n" +
                          "Auditoría: " +auditoria.Codigo_departamento + auditoria.Id_proceso +" "+auditoria.Hallasgoz01+" "+auditoria.Recomendaciones+" "+auditoria.Fecha_auditoria +
                          "\n",
                          recipientMail: new List<string> { correo }
                          );
                       


                    }
                    connection.Close();
                    reader.Close();

                }
               

            }
            
        }



        public List<string> ListarCorreosEmpleados()
        {

            List<string> lstcorreos = new List<string>();

            SqlCommand command;
            string query = "CONSULTA_CORREOS";

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
                        string correos;
                       correos = reader.GetString(0);

                        lstcorreos.Add(correos);
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

            return lstcorreos;
        }




        //public Empleado Login(string user, string pass)
        //{

        //    Empleado oEmpleadoDal = new Empleado();
        //    //oEmpleadoDal.Usuario = user;
        //    //oEmpleadoDal.Pass = pass;
        //    SqlCommand command;
        //    string query = "sp_login";
        //    //List<Empleado> lstEmpleadosDAL = new List<Empleado>();
        //    using (SqlConnection connection = new SqlConnection(stringConexion))
        //    {

        //        command = new SqlCommand(query, connection);
        //        command.Parameters.AddWithValue("@usuario", user);
        //        command.Parameters.AddWithValue("@pass", pass);
        //        command.CommandType = CommandType.StoredProcedure;

        //        try
        //        {
        //            connection.Open();
        //            SqlDataReader reader = command.ExecuteReader();
        //            while (reader.Read())
        //            {


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
        //    // return lstEmpleadosDAL;
        //    return oEmpleadoDal;
        //}


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
