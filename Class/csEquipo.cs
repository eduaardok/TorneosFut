using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneosFut.Class
{
    class csEquipo
    {
        csConexion conexion;

        public csEquipo(string u, string c)
        {
            conexion = new csConexion();
            conexion.Usuario = u;
            conexion.Clave = c;
        }

        public DataTable mostrarequipo()
        {
            return conexion.ListDGV("select * from Equipo");
        }

    }
}
