using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidadades
{
    public class Historico
    {
        public int Id_historico { get; set; }
        public int Id_departamento { get; set; }
        public int Id_proceso { get; set; }
        public string Accion { get; set; }
        public DateTime Fecha { get; set; }
        public int Id_usuario { get; set; }
      
    }
}
