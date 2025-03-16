using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneosFut.Class
{
    class csEstadio
    {
        csConexion conexion;

        public csEstadio(string u, string c)
        {
            conexion = new csConexion(u, c);
        }
        public DataTable ListadeEstadio()
        {
            DataTable dt = conexion.ListDGV("select IDEstadio, NombreEstadio from Estadio");
            return dt;
        }
    }
}
