using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorneosFut.Class
{
    class csTorneo
    {
        csConexion csConexion;
        public csTorneo(string u, string c)
        {
            csConexion = new csConexion(u, c);
        }

        public DataTable ListadeTorneo()
        {
            DataTable dt = csConexion.ListDGV("Select * from Torneo");
            return dt;
        }
        public DataTable ListaIDTorneo()
        {
            DataTable dt = csConexion.ListDGV("Select IDTorneo from Torneo");
            return dt;
        }
        public DataTable ListadeTorneofiltro(string filtro)
        {
            DataTable dt;
            dt = csConexion.ListDGV($"select * from Torneo where NombreTorneo like '%{filtro}%'");


            return dt;
        }
        public bool AgregarTorneo(int idTorneo, string Txtnombre, string formato, string ModoFutbol, int IdUsuario, string Organizador, string te)
        {
            if (csConexion.Consulta($"insert into Torneo (IDTorneo, NombreTorneo, IDFormato, IDModoFutbol, IDOrganizador, FechaInicio, IDUsuario, Usuario, Estado)" +
                $" values ({idTorneo}, '{Txtnombre}', {formato}, {ModoFutbol}, '{Organizador}','{te}' ,{IdUsuario}, system_user, 'PENDIENTE')"))
                return true;
            else
                return false;

        }
        public DataTable LlenarOrganizadores()
        {
            DataTable dt = csConexion.ListDGV("Select* from Organizador");
            return dt;
        }
        public DataTable LlenarFormato()
        {
            DataTable dt = csConexion.ListDGV("Select* from Formato");
            return dt;
        }
    }
}
