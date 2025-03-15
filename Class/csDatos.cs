using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorneosFut
{
    class csDatos
    {
        csConexion conexion;
        csUsuario csUsuario;
        public csDatos(string u, string c)
        {
            conexion = new csConexion(u, c);
            csUsuario = new csUsuario(u, c);
        }
        public int ObtenerIDUsuario(DataGridView dgv)
        {
            return csUsuario.IDUsuario(dgv);
        }
    }
}
