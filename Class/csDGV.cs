using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorneosFut
{

    class csDGV
    {
        csConexion conexion;
        csUsuario csUsuario;
        public csDGV(string u, string c)
        {
            conexion = new csConexion(u, c);
            csUsuario = new csUsuario(u, c);
        }
        public void AdaptarDGV(DataGridView dgv, Panel pnl)
        {
            dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#14191D");
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            //ActualizarTabla();
            dgv.Width = pnl.Width;
            dgv.Height = pnl.Height;

            int filas, columnas;
            filas = dgv.RowCount;
            columnas = dgv.ColumnCount;
            dgv.ColumnHeadersHeight = 50;//dgvUsuarios.Height / (1+filas);
            for (int i = 0; i < filas; i++)
            {
                dgv.Rows[i].Height = 60;//dgvUsuarios.Height / (1+filas);
            }
            for (int i = 0; i < columnas; i++)
            {
                dgv.Columns[i].Width = dgv.Width / columnas;
            }
        }
        public void MostrarUsuarios(DataGridView dgv)
        {
            dgv.DataSource = csUsuario.ListaDeUsuarios();
        }
        public void MostrarUsuariosFiltro(DataGridView dgv, bool mostrarClave,string filtro)
        {
            dgv.DataSource = csUsuario.ListaDeUsuariosFiltro(mostrarClave, filtro);
        }
    }
}
