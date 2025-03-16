using PruebasTorneos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneosFut.Class;

namespace TorneosFut
{

    class csDGV
    {
        csConexion conexion;
        csUsuario csUsuario;
        csJugador csJugador;
        csEquipo csEquipo;
        csEntrenador csEntrenador;
        csEstadio csEstadio;
        public csDGV(string u, string c)
        {
            conexion = new csConexion(u, c);
            csUsuario = new csUsuario(u, c);
            csJugador= new csJugador  (u, c);
            csEntrenador = new csEntrenador (u, c);
            csEquipo = new csEquipo(u, c);
            csEstadio= new csEstadio(u, c);
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
        //JUGADORES 
        public void MostrarJugadores(DataGridView dgv)
        {
            dgv.DataSource = csJugador.ListadeJugadores();
        }
        public void MostrarJugadoresFiltro(DataGridView dgv, bool mostrarClave, string filtro)
        {
            dgv.DataSource = csJugador.ListadeJugadoresfiltro(filtro);
        }
        //EQUIPOS
        public void MostrarEquipops(DataGridView dgv)
        {
            dgv.DataSource = csEquipo.ListadeEquipos();
        }
        public void MostrarEquiposFiltro(DataGridView dgv, string filtro)
        {
            dgv.DataSource = csEquipo.ListadeEquiposfiltro(filtro);
        }
        //ENTRENADORES
        public void MostrarEntrenadores(DataGridView dgv)
        {
            dgv.DataSource = csEntrenador.ListadeEntrenadores();
        }
        public void MostrarEntrenadoresFiltro(DataGridView dgv, bool mostrarClave, string filtro)
        {
            dgv.DataSource = csEntrenador.ListadeEntrenadoresfiltro(filtro);
        }
        public void LlenarcmbEstadio(ComboBox cmbEstadio)
        {

            cmbEstadio.DataSource = csEstadio.ListadeEstadio();
            cmbEstadio.ValueMember = "IDEstadio";
            cmbEstadio.DisplayMember = "NombreEstadio";
        }
    }
}
