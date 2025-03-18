using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneosFut
{
    class csAuditorias
    {
        csConexion csConexion;
        public csAuditorias(string u, string c)
        {
            csConexion = new csConexion(u, c);
        }

        public DataTable ListaDeAuditoriaFiltro(bool audCambios, string filtro)
        {
            DataTable dt;
            if (audCambios)
                dt = csConexion.ListDGV($"Select * from AuditoriaCambios where IDUsuario like '%{filtro}%' or TipoCambio like '%{filtro}%'" +
                                         $" or TablaAfectada like '%{filtro}%'");
            else
                dt = csConexion.ListDGV($"Select * from AuditoriaSesion where Usuario like '%{filtro}%'");

            return dt;
        }

        public DataTable AuditoriaSesion()
        {
            DataTable dt = csConexion.ListDGV("Select * from AuditoriaSesion");
            return dt;
        }
        public DataTable AuditoriaCambios()
        {
            DataTable dt = csConexion.ListDGV("Select * from AuditoriaCambios");
            return dt;
        }
    }
}
