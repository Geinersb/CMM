using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidadades
{
   public class Proceso
    {
        public int Id_proceso { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Id_departamento { get; set; }
        public int Id_nivel { get; set; }
        
       
        public string Inicial { get; set; }
        public string Repetible { get; set; }
        public string Definido { get; set; }
        public string Gestinado { get; set; }
        public string Optimizado { get; set; }
        public int Id_empleado { get; set; }


        public DateTime Fecha_creacion { get; set; }
        public int Estado { get; set; }


    }
}
