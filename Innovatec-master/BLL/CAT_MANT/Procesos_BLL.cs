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

        public DataTable ListarProcesosArchivados()
        {
            return oProcesosAccess.ListarProcesosArchivados();

        }

        public DataTable ListarProcesosArchivadosPorDescripcion(string descripcion)
        {
            return oProcesosAccess.FiltrarProcesosArchivadosPorDescripcion(descripcion);

        }

        public void AgregarProceso(Proceso proceso)
        {
            //agrega el empleado a la base
            oProcesosAccess.AgregarProceso(proceso);
            //agrega el historial


        }

        public void ModificarProceso(Proceso proceso)
        {
            oProcesosAccess.ActualizarProceso(proceso);
        }


        public List<Proceso> ListarCantidadProcesos()
        {
            return oProcesosAccess.ListarCantidadProcesos();
        }

        public List<Proceso> ListarCantidadProcesosActivos()
        {
            return oProcesosAccess.ListarCantidadProcesosActivos();
        }

        public List<Proceso> ListarCantidadProcesosArchivados()
        {
            return oProcesosAccess.ListarCantidadProcesosArchivados();
        }

    }
}
