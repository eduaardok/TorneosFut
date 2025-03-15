using System;
using System.Collections.Generic;
using System.Data;
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
        public DataTable ListaDeUsuarios()
        {
           DataTable dt = conexion.ListDGV("Select * from Usuario");
           return dt;
        }
        public DataTable ListaDeUsuariosFiltro(bool m, string filtro)
        {
            DataTable dt;
            if (m)
               dt = conexion.ListDGV($"Select * from Usuario where IDUsuario like '%{filtro}%' or Nombres like '%{filtro}%'" +
                                        $" or NombreUsuario like '%{filtro}%' or NombreUsuarioBD like '%{filtro}%'");
            else
                dt = conexion.ListDGV($"Select IDUsuario, Nombres, NombreUsuario, Correo, NombreUsuarioBD from Usuario where IDUsuario like '%{filtro}%' or Nombres like '%{filtro}%'" +
                                    $" or NombreUsuario like '%{filtro}%' or NombreUsuarioBD like '%{filtro}%'");

            return dt;
        }
    }
}
