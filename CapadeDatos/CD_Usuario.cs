using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapadeDatos
{
    public class CD_Usuario
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select IdUsuario,Documento,Nombre_us,correo_us,clave_us,estado from Usuario";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType=CommandType.Text;

                    oconexion.Open();

                    using(SqlDataReader rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) { 
                            lista.Add(new Usuario()
                            {
                                IdUsuario=Convert.ToInt32(rdr["ID"]),
                                Documento=rdr["Documento"].ToString(),
                                Nombre_us=rdr["Nombre"].ToString(),
                                correo_us=rdr["correo"].ToString(),
                                clave_us=rdr["clave"].ToString(),
                                estado=Convert.ToBoolean(rdr["Estado"])


                            });
                        
                        }

                    }

                }
                catch (Exception)
                {
                    lista= new List<Usuario>();
                }
            }
            return lista;
        }
    }
}