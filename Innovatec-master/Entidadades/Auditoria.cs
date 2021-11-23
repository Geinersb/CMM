using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidadades
{
    public class Auditoria
    {
        public int Id_aditoria { get; set; }
        public int Id_empleado { get; set; }
        public int Id_departamento { get; set; }
        public int Id_proceso { get; set; }
        public string Hallasgoz01 { get; set; }
        public DateTime Fecha_limite { get; set; }
        public DateTime Fecha_auditoria { get; set; }
            }
}
