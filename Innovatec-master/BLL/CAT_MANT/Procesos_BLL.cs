using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.BD;
using System.Data;
using Entidadades;

namespace BLL.CAT_MANT
{
    public class Procesos_BLL
    {
        Procesos_DAL oProcesosAccess = new Procesos_DAL();

        public DataTable FiltrarProcesosDescripcion(string descripcion)
        {
            return oProcesosAccess.FiltrarProcesosDescripcion(descripcion);

        }

        public DataTable FiltrarProcesosNivel(int nivel)
        {
            return oProcesosAccess.FiltrarProcesosNiveles(nivel);

        }

        public DataTable ListarProcesos()
        {
            return oProcesosAccess.ListarProcesos();

        }


        public void AgregarProceso(Proceso proceso)
        {
            //agrega el empleado a la base
            oProcesosAccess.AgregarProceso(proceso);
            //agrega el historial


        }



    }
}
