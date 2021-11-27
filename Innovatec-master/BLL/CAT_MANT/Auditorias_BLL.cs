using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidadades;
using DAL.BD;

namespace BLL.CAT_MANT
{
    public class Auditorias_BLL
    {
        Auditorias_DAL oAuditoriaAccess = new Auditorias_DAL();



        public void AgregarAuditoria(Auditoria auditoria)
        {
            //agrega el empleado a la base
            oAuditoriaAccess.AgregarAuditoria(auditoria);
            //agrega el historial


        }


    }
}
