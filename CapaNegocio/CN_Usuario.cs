using CapadeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objtcd_usuario= new CD_Usuario();

        public List<Usuario> Listar()
        {
            return objtcd_usuario.Listar();
        }
    }
}
