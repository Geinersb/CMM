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
    public class Departamento_BLL
    {
        Departamento_DAL oEmpleadoAccess = new Departamento_DAL();

        public DataTable FiltrarDepartameto(string nombre)
        {

            //List<Empleado> lista = new List<Empleado>();

            //lista = oEmpleadoAccess.ListarEmpleados();
            return oEmpleadoAccess.FiltrarDepartamentos(nombre);

        }


        public void AgregarDepartamento(Departamento Departamento)
        {
            oEmpleadoAccess.AgregarDepartamentos(Departamento);
        }


        public void ModificarDepartamento(Departamento Departamento)
        {
            oEmpleadoAccess.ActualizarDepartamento(Departamento);
        }


        public List<Departamento> ListarDepartamento()
        {
            return oEmpleadoAccess.ListarDepartamentos();
        }

        public List<Departamento> ListarDepartamentoCodigo()
        {
            return oEmpleadoAccess.ListarDepartamentoCodigo();
        }

    }
}
