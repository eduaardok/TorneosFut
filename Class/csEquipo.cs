using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public string Imagen(string i)
        {

            DataGridView dt = new DataGridView();
            dt.DataSource = conexion.ListDGV($"Select ImagenEntrenador from Entrenador where IDEntrenador = '{i}'");
            string img = dt.Rows[0].Cells[0].Value.ToString();
            return img;
        }
        public bool AgregarEquipo(string IdEquipo, string IdEstadio, string nombre, string genero, string EquipacionLocal, string Equipacionvisitante, string imagen, string presidente)
        {
            if (conexion.Consulta($"insert into Entrenador (IDEquipo,IDEstadio, NombreEquipo, Genero, EquipacionLocal, EquipacionVisitante, ImagenEscudo,Presidente)" +
                $" values ('{IdEquipo}',{IdEstadio},'{nombre}', '{genero}', '{EquipacionLocal}', '{Equipacionvisitante}','{imagen}','{presidente}')"))
                return true;
            else
                return false;
        }

    }
}
