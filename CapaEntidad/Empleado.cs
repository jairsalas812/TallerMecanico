using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    internal class Empleado
    {
        public int id_empleado { get; set; }
        public string nombre_em {  get; set; }
        public string especialidad { get; set; }
        public string telefono_emp { get; set; }
        public DateTime fechaCreacion_em  { get; set; }
        public string direccion_emp     { get; set; }
        public  string rfc_em  { get; set; }
        public string curp_em { get; set; }
        public string nss_em { get; set; }
        public DateTime fechaNacimiento_em { get; set; }
        public Decimal salario_em { get; set; }
        public string estadoCivil_em { get; set; }
        public string cp_em { get; set; }
        public Usuario ousuario { get; set; }

       
        

    }
}
