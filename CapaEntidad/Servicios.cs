using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Servicios
    {
        public int id_servicio {  get; set; }
        public bool estado_servicio { get; set; }
        public string nombre_servicio { get; set; }
        public decimal costo_servicio { get; set; }
        public string duracion_servicoo { get; set; }
        public DateTime fechaCreacion_se {  get; set; }
        public DateTime fechaModificacion {  get; set; }

        
    }
}
