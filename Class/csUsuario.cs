using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;


namespace TorneosFut
{
    class csUsuario
    {
        csConexion conexion;
        public csUsuario(string u, string c)
        {
            conexion = new csConexion(u, c);
        }
        
        public int IDUsuario(DataGridView dgv)
        {
            int id = int.Parse(dgv.Rows[dgv.CurrentRow.Index].Cells[0].Value.ToString());
            return id;
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

        public DataTable ListaDeAuditoriaFiltro(bool m, string filtro)
        {
            DataTable dt;
            if (m)
                dt = conexion.ListDGV($"Select * from AuditoriaCambios where IDUsuario like '%{filtro}%' or TipoCambio like '%{filtro}%'" +
                                         $" or TablaAfectada like '%{filtro}%'");
            else
                dt = conexion.ListDGV($"Select * from AuditoriaIniciosDeSesion where Usuario like '%{filtro}%'");

            return dt;
        }

        public DataTable AuditoriaInicioSesion()
        {
            DataTable dt = conexion.ListDGV("Select * from AuditoriaIniciosDeSesion");
            return dt;
        }
        public DataTable AuditoriaCambios()
        {
            DataTable dt = conexion.ListDGV("Select * from AuditoriaCambios");
            return dt;
        }

    }
}
