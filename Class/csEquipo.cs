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
            conexion = new csConexion(u,c);
        }
        public DataTable ListadeEquipos()
        {
            DataTable dt = conexion.ListDGV("select IDEquipo,IDEstadio,NombreEquipo,Genero,EquipacionLocal,EquipacionVisitante from Equipo");
            return dt;
        }
        public DataTable ListadeEquiposfiltro(string filtro)
        {
            DataTable dt;
            dt = conexion.ListDGV($@"select * from Equipo where IDEquipo like '%{filtro}%' " +
                                 $"or NombreEquipo like '%{filtro}%' or Genero like '%{filtro}%'");
            return dt;
        }

    }
}
