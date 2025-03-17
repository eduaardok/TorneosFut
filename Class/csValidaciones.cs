using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneosFut
{
    class csValidaciones
    {
        csDGV csDGV;
        csUsuario csUsuario;
        public csValidaciones(string u, string c)
        {
            csDGV = new csDGV(u, c);
            csUsuario= new csUsuario(u, c);
        }
        #region ValidacionesUsuario
        public bool ValidarNombre(string nombre, string id="-1")
        {
            int cont = 0;
            if (id == "-1")
                cont = -1;
            DataTable dt = csUsuario.ListaNombres();
            for(int i=0; i<dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == nombre)
                    cont++;
            }
            if (cont > 0)
                return false;
            return true;
        }
        public bool ValidarUsuario(string nombreusuario, string id = "-1")
        {
            int cont = 0;
            if (id == "-1")
                cont = -1;
            DataTable dt = csUsuario.ListaUsuarios();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == nombreusuario)
                    cont++;
            }
            if (cont > 0)
                return false;
            return true;
        }
        public bool ValidarUsuarioBD(string nombreusuariobd, string id = "-1")
        {
            int cont = 0;
            if (id == "-1")
                cont = -1;
            DataTable dt = csUsuario.ListaUsuariosBD();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == nombreusuariobd)
                    cont++;
            }
            if (cont > 0)
                return false;
            return true;
        }
        public bool ValidarCorreo(string correo, string id = "-1")
        {
            int cont = 0;
            if (id == "-1")
                cont = -1;
            DataTable dt = csUsuario.ListaUsuariosBD();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == correo)
                    cont++;
            }
            if (cont > 0)
                return false;
            return true;
        }
        #endregion

    }
}
