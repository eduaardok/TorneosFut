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
        csTorneo csTorneo;
        csPartido csPartido;
        csAuditorias csAuditorias;
        csIncripcionEquipo csIncripcion;
        csPatrocinador csPatrocinador;
        csArbitro csArbitro;
        csOrganizador csOrganizador;
        public csDGV(string u, string c, string IDTorneo = "0", string IDpartido = "0")
        {
            conexion = new csConexion(u, c);
            csUsuario = new csUsuario(u, c);
            csJugador = new csJugador(u, c);
            csEntrenador = new csEntrenador(u, c);
            csEquipo = new csEquipo(u, c);
            csEstadio = new csEstadio(u, c);
            csTorneo = new csTorneo(u, c);
            csPartido = new csPartido(u, c, IDTorneo, IDpartido);
            csAuditorias = new csAuditorias(u, c);
            csIncripcion = new csIncripcionEquipo(u, c);
            csPatrocinador = new csPatrocinador(u, c);
            csArbitro= new csArbitro(u, c);
            csOrganizador=new csOrganizador(u,c);
        }
        //Adaptar DataGridView en panel
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
        //Adaptar DataGridView sin panel
        public void AdaptarDGV(DataGridView dgv)
        {
            dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#14191D");
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            //ActualizarTabla();

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
        //USUARIOS
        public void MostrarUsuarios(DataGridView dgv)
        {
            dgv.DataSource = csUsuario.ListaDeUsuarios();
            AdaptarDGV(dgv);
        }
        public void MostrarUsuariosFiltro(DataGridView dgv, bool mostrarClave, string filtro)
        {
            dgv.DataSource = csUsuario.ListaDeUsuariosFiltro(mostrarClave, filtro);
        }
        //AUDITORIAS
        public void MostrarAuditoriaFiltro(DataGridView dgv, bool audit, string filtro)
        {
            dgv.DataSource = csAuditorias.ListaDeAuditoriaFiltro(audit, filtro);
        }
        public void MostrarAuditoriaSesion(DataGridView dgv)
        {
            dgv.DataSource = csAuditorias.AuditoriaSesion();
        }
        public void MostrarAuditoriaCambios(DataGridView dgv)
        {
            dgv.DataSource = csAuditorias.AuditoriaCambios();
        }
        //JUGADORES 
        public void MostrarJugadores(DataGridView dgv)
        {
            dgv.DataSource = csJugador.mostrarJugador();
        }
        public void MostrarJugadoresFiltro(DataGridView dgv, string filtro)
        {
            dgv.DataSource = csJugador.ListadeJugadoresFiltro(filtro);
        }
        public void MostrarJugadoresSinEquipo (DataGridView dgv)
        {
            dgv.DataSource = csJugador.ListadeJugadoresSinEquipo();
        }

        //EQUIPOS
        public void MostrarEquipos(DataGridView dgv)
        {
            dgv.DataSource = csEquipo.ListadeEquipos();
        }
        public void MostrarNameEquipos(DataGridView dgv)
        {
            dgv.DataSource = csEquipo.ListadeNameEquipos();
        }
        public void MostrarEquiposFiltro(DataGridView dgv, string filtro)
        {
            dgv.DataSource = csEquipo.ListadeEquiposFiltro(filtro);
        }
        public void MostrarNameEquiposFiltro(DataGridView dgv, string filtro)
        {
            dgv.DataSource = csEquipo.ListadeNameEquiposFiltro(filtro);
        }
        public void MostrarJugadoresEquipo(DataGridView dgv, string id)
        {
            dgv.DataSource = csEquipo.ListaDeJugadoresEquipo(id);
        }
        //ENTRENADORES
        public void MostrarEntrenadores(DataGridView dgv)
        {
            dgv.DataSource = csEntrenador.ListadeEntrenadores();
        }
        public void MostrarEntrenadoresFiltro(DataGridView dgv, string filtro)
        {
            dgv.DataSource = csEntrenador.ListadeEntrenadoresFiltro(filtro);
        }
        
        //PARTIDOS
        public void MostrarPartidos(DataGridView dgv)
        {
            dgv.DataSource = csPartido.ListadePartido();
        }
        public void MostrarEquiposCMB(ComboBox cmbEquipo)
        {
            cmbEquipo.DataSource = csPartido.ListaDeEquipos();
            cmbEquipo.ValueMember = "IDPartido";
            cmbEquipo.DisplayMember = "Equipo";
        }
        //TORNEOS
        public void MostrarTorneo(DataGridView dgv)
        {
            dgv.DataSource = csTorneo.ListadeTorneo();
        }
        public void MostrarTorneoFiltro(DataGridView dgv, string Filtro)
        {
            dgv.DataSource = csTorneo.ListadeTorneofiltro(Filtro);
        }

        // ESTADIOS

        public void MostrarEstadios(DataGridView dgv)
        {
            dgv.DataSource = csEstadio.ListaDeEstadios();
        }
        public void MostrarEstadiosFiltro(DataGridView dgv, string Filtro)
        {
            dgv.DataSource = csEstadio.ListaDeEstadiosFiltro(Filtro);
        }
        //PATROCINADORES
        public void MostrarPatrocinadores(DataGridView dgv)
        {
            dgv.DataSource = csPatrocinador.ListaDePatrocinadores();
        }
        public void MostrarPatrocinadoresFiltro(DataGridView dgv, string Filtro)
        {
            dgv.DataSource = csPatrocinador.ListaDePatrocinadoresFiltro(Filtro);
        }

        //INSCRIPCIONES 
        public void MostrarEquiposInsc(string idTorneo, DataGridView dgv)
        {
            dgv.DataSource = csIncripcion.ListadeEquiposInc(idTorneo);
        }
        //ARBITROS
        public void MostrarArbitros(DataGridView dgv)
        {
            dgv.DataSource = csArbitro.ListaIdArbitros();
        }
        //ORGANIZADORES
        public void MostrarOrganizadores(DataGridView dgv)
        {
            dgv.DataSource = csOrganizador.Listaorganizadores();
        }


        #region cmb
        public void LlenarcmbEstadio(ComboBox cmbEstadio)
        {
            cmbEstadio.DataSource = csEstadio.ListaDeEstadios();
            cmbEstadio.ValueMember = "IDEstadio";
            cmbEstadio.DisplayMember = "NombreEstadio";
        }
        public void llenarcmbOrganizador(ComboBox cmborganizad)
        {
            cmborganizad.DataSource= csTorneo.LlenarOrganizadores();
            cmborganizad.ValueMember = "IDOrganizador";
            cmborganizad.DisplayMember = "NombreEmpresa";
        }
        public void llenarcmbFormato(ComboBox cmbFormato)
        {
            cmbFormato.DataSource=csTorneo.LlenarFormato();
            cmbFormato.ValueMember = "IDFormato";
            cmbFormato.DisplayMember = "NombreFormato";
        }
        #endregion
       
    }
}
