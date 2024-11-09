using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Documento  { get; set; }
        public string Nombre_us  { get; set; }
        public string correo_us     { get; set; }
        public string clave_us { get; set; }
        public Rol oRol { get; set; }
        public bool estado { get; set; }
        public string FechaCreacion_us { get; set; }

    }
}
