using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneosFut.Class
{
    class csModoFutbol
    {

        public int IDModoFutbol { get; set; }
        public string NombreModo { get; set; }
        public int JugadoresEnJuego { get; set; }
        csConexion csConexion = new csConexion();
    }
}
