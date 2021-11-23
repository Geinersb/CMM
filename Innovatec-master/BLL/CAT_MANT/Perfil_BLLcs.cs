using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.BD;
using Entidadades;

namespace BLL.CAT_MANT
{
   public class Perfil_BLLcs
    {
        public List<Perfil> ListarPerfiles()
        {
            Perfil_DAL oPuestoAccess = new Perfil_DAL();

            return oPuestoAccess.ListarPerfiles();
        }





    }
}
