using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    internal class Cotizaciones
    {
        public int id_cotizacion { get; set; }
        public List<Servicios> oservicios { get; set; }
        public DateTime fecha_cotizacion { get; set; }
        public Empleado oEmpleado { get; set; }
        public Cliente oCliente { get; set; }
        public bool estado_cotizacion { get; set; }

    }
}
