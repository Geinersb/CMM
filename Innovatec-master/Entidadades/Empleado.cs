using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidadades
{
   public class Empleado
    {
        public int Id_empleado { get; set; }
       public string Nombre { get; set; }
      public string Apellido1 { get; set; }
       public  string Apellido2 { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; }
        public int Id_perfil { get; set; }
        public  int Id_departamento { get; set; }

    }
}
