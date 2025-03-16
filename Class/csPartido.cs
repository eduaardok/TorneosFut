using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorneosFut.Class
{
    class csPartido
    {
        csConexion csConexion;
        string IDTorneo;
        string IDPartido;
        string IDEquipo;
        public csPartido(string u, string c, string iDtorneo="0",string Idpartido="0")
        {
            csConexion = new csConexion(u, c);
            IDTorneo = iDtorneo;
            IDPartido = Idpartido;
        }
        public DataTable ListadePartido()
        {
            DataTable dt = csConexion.ListDGV($"select IDPartido, IDTorneo,CONCAT(EquipoLocal, '  vs  ', EquipoVisitante)as Partido, Fecha, EstadoPartido from  Partido where IDTorneo={IDTorneo}");
            return dt;
        }
        public DataTable ListaDeEquipos()
        {
            DataTable dt = csConexion.ListDGV($"SELECT IDPartido, EquipoLocal AS Equipo FROM Partido where IDPartido={IDPartido} UNION ALL SELECT  IDPartido, EquipoVisitante AS Equipo FROM Partido where IDPartido={IDPartido} ");
            return dt;
        }
        public DataTable ListaJugador()
        {
            DataTable dt = csConexion.ListDGV($"Select JE.IDJugador,JE.IDEquipo, J.NombreJugador from Jugador_Equipo JE inner join Jugador J on JE.IDJugador=J.IDJugador where IDEquipo='{IDEquipo}' ");
            return dt;
        }
        public DataTable ListaDeJugadoresEquipo(string id)
        {
            DataTable dt = csConexion.ListDGV($"Select JE.IDJugador,JE.IDEquipo, J.NombreJugador from Jugador_Equipo JE " +
                $"inner join Jugador J on JE.IDJugador=J.IDJugador where JE.IDEquipo='{id}' and FechaSalida is null");
            return dt;
        }
        public string IDEquipoLocal()
        {
            DataTable dt = csConexion.ListDGV($"select EquipoLocal from  Partido where IDPartido={IDPartido}");
            return dt.Rows[0][0].ToString();
        }
        public string IDEquipoVisitante()
        {
            DataTable dt = csConexion.ListDGV($"select EquipoVisitante from  Partido where IDPartido={IDPartido}");
            return dt.Rows[0][0].ToString();
        }
    }
}
