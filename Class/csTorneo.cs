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
        public DataTable ListadeTorneofiltro(string filtro)
        {
            DataTable dt;
            dt = csConexion.ListDGV($"select * from Torneo where NombreTorneo like '%{filtro}%'");


            return dt;
        }
        public bool AgregarTorneo(TextBox idTorneo, TextBox Txtnombre, ComboBox formato, ComboBox ModoFutbol, int IdUsuario, ComboBox Organizador, DateTimePicker)
        {


        }
    }
}
