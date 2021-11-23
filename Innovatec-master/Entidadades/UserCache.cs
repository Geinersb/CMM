using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidadades
{
    public static class UserCache
    {
        public static int Id_empleado { get; set; }
        public static string Nombre { get; set; }
        public static string Apellido1 { get; set; }
        public static string Apellido2 { get; set; }
        public static string Cedula { get; set; }
        public static string Telefono { get; set; }
        public static string Correo { get; set; }
        public static string Usuario { get; set; }
        public static string Pass { get; set; }
        public static int Id_perfil { get; set; }
        public static int Id_departamento { get; set; }
    }
}
