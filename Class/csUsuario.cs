using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneosFut
{
    class csUsuario
    {
        csConexion conexion;
        public csUsuario(string u, string c)
        {
            conexion = new csConexion(u, c);
        }
    }
}
