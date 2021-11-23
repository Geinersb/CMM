using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidadades;
using DAL.BD;
using System.Data; 

namespace BLL.CAT_MANT

{
    public class Empleado_BLL
    {
        Empleado_DAL oEmpleadoAccess = new Empleado_DAL();


        //public Empleado LoginBLL(string user, string pass)
        //{

        //    // Empleado empleado = new Empleado();
        //    //empleado.Usuario = user;
        //    //empleado.Pass = pass;
        //   // return oEmpleadoAccess.Login(user, pass);

        //}

        public bool LoginBLL(string user, string pass)
        {

          
           return  oEmpleadoAccess.Login(user, pass);

        }

        public string RecuperarPass(string dato)
        {


            return oEmpleadoAccess.RecoverPassword(dato);

        }



        public List<Empleado> ConsultarEmpleado()
        {

            List<Empleado> lista = new List<Empleado>();
            lista = oEmpleadoAccess.ListarEmpleados();
            return lista;

        }

        public DataTable FiltrarEmpleado(string nombre)
        {

            //List<Empleado> lista = new List<Empleado>();

            //lista = oEmpleadoAccess.ListarEmpleados();
            return oEmpleadoAccess.FiltrarEmpleados(nombre);

        }



        public void AgregarEmpleado(Empleado empleado)
        {
            //agrega el empleado a la base
            oEmpleadoAccess.AgregarUsuario(empleado);
            //agrega el historial


        }

        public void ModificarEmpleado(Empleado empleado)
        {
            oEmpleadoAccess.ActualizarUsuario(empleado);
        }




    }
}
