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
        public bool AgregarTorneo(int idTorneo, TextBox Txtnombre, ComboBox formato, ComboBox ModoFutbol, int IdUsuario, ComboBox Organizador, DateTimePicker te)
        {
            if (csConexion.Consulta($"insert into Torneo (IDTorneo, NombreTorneo, IDFormato, IDModoFutbol, IDOrganizador, FechaInicio, IDUsuario, Usuario, Estado)" +
                $" values ({idTorneo}, '{Txtnombre.Text}', {formato.Text}, {ModoFutbol.Text}, {Organizador.Text},'{te.Value.ToString()}' ,{IdUsuario}, system_user, 'PENDIENTE')"))
                return true;
            else
                return false;

        }
    }
}
