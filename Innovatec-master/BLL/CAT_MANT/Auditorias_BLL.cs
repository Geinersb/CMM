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
    public class Auditorias_BLL
    {
        Auditorias_DAL oAuditoriaAccess = new Auditorias_DAL();
        Departamento_DAL oDepartamento = new Departamento_DAL();

        public void AgregarAuditoria(Auditoria auditoria)
        {
            //agrega el empleado a la base
            oAuditoriaAccess.AgregarAuditoria(auditoria);
            //agrega el historial


        }

        public List<Departamento> ListarCodigosDepartamento()
        {
            return oDepartamento.ListarDepartamentoCodigo();
        }

        public List<Auditoria> ListarAuditorias()
        {
            return oAuditoriaAccess.ListarAuditorias();
        }

        public DataTable FiltarAuditoriasCodigo(string codigo)
        {
            return oAuditoriaAccess.FiltrarAuditorias(codigo);
        }

        public DataTable FiltarAuditoriasPorIdProceso(int idProceso)
        {
            return oAuditoriaAccess.FiltrarAuditoriasPorIdProceso(idProceso);
        }

    }
}
