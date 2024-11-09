using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Piezas
    {
        public int id_pieza {  get; set; }
        public string sku_pieza { get; set; }
        public string nombre_pieza { get; set; }
        public string desscripcion_pieza{ get; set; }
        public DateTime fechaCreacion_pieza { get; set; }
        public DateTime fechaModificacion_pieza { get; set; }
        public decimal costo_pieza { get; set; }
        public int  cantidad_pieza { get; set; }

        public Servicios oservicios { get; set; }
        public Categoria ocategoria { get; set; }
    }
}
