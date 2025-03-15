using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorneosFut
{

    class csDGV
    {
        csConexion conexion;
        csUsuario csUsuario;
        public csDGV(string u, string c)
        {
            conexion = new csConexion(u, c);
            csUsuario = new csUsuario(u, c);
        }
         public void MostrarUsuarios(DataGridView dgv)
        {
            dgv.DataSource = csUsuario.ListaDeUsuarios();
        }

    }
}
