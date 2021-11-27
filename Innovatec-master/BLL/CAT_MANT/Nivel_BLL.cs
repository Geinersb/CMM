using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidadades;
using DAL.BD;

namespace BLL.CAT_MANT
{
    public class Nivel_BLL
    {
        Niveles_DAL oNivelesAccess = new Niveles_DAL();
        public List<Nivel> ListarNiveles()
        {
            return oNivelesAccess.ListarNiveles();
        }



    }
}
