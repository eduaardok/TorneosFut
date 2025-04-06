using pruebas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneosFut.Class;
using Usuarios;

namespace TorneosFut
{
    public partial class Torneo : Form
    {
        csConexion conexion;
        Patrocinadores patro;
        Organizadores orga;
        btnTablaPos partidos;
        PagoInscripcion inscripcion;
        csDGV csDGV;
        Arbitro arbi;
        GestionInscripcion gestionInscripcion;
        string IDTorneo;
        string IDPartido;
        csValidaciones csValidaciones;
        csDatos csDatos;
        Formato formato;
        public Torneo(string u, string c)
        {
            conexion = new csConexion(u, c);
            csDatos = new csDatos(u, c);
            InitializeComponent();
            patro = new Patrocinadores(u, c);
            orga = new Organizadores(u, c);
            csDGV = new csDGV(u, c);
            arbi = new Arbitro(u, c);
            formato = new Formato();
            csValidaciones = new csValidaciones(u, c);
        }
        public static void AbrirFormEnPanel(Panel panel, Form formHijo)
        {
            if (panel.Controls.Count > 0)
                panel.Controls.Clear(); // Limpia cualquier contenido previo

            formHijo.TopLevel = false;  // Indica que no es un formulario independiente
            formHijo.Dock = DockStyle.Fill; // Ajusta al tamaño del panel
            panel.Controls.Add(formHijo); // Agrega el formulario al panel
            panel.Tag = formHijo; // Asocia el formulario con el panel
            formHijo.BringToFront(); // Lo trae al frente
            formHijo.Show(); // Muestra el formulario dentro del panel
            panel.Show();
        }
        private void btnJugadores_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(panelmodul, patro);
        }

        private void btnArbitros_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(panelmodul, arbi);
        }

        private void btnEstadios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(panelmodul, orga);
        }

        private void Torneo_Load(object sender, EventArgs e)
        {
            csDGV.MostrarTorneo(dgvTorneo);
            panelmodul.Hide();
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelmodul.Hide();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string id = "-1";
            AggTorneo a = new AggTorneo(true, id, conexion.Usuario, conexion.Clave);
            //AbrirFormEnPanel(panelDgv, a);
            a.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string id = csDatos.ObtenerIDTorneoDesdeDGV(dgvTorneo);
            AggTorneo a = new AggTorneo(false, id, conexion.Usuario, conexion.Clave);
            a.ShowDialog();
        }

        private void btnPartidos_Click(object sender, EventArgs e)
        {
            if(IDTorneo != null || IDTorneo == "")
            {
                if (csValidaciones.ValidarEquiposInscritos(IDTorneo))
                {
                    partidos = new btnTablaPos(IDTorneo, conexion.Usuario, conexion.Clave);
                    partidos.ShowDialog();
                }
            }
        }
        private void btnInscripcionEquipos_Click(object sender, EventArgs e)
        {
            gestionInscripcion = new GestionInscripcion(IDTorneo, conexion.Usuario, conexion.Clave);
            gestionInscripcion.ShowDialog();

        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            AggTorneo aggTorneo = new AggTorneo(true, "-1", conexion.Usuario, conexion.Clave);
            aggTorneo.ShowDialog();
            ActualizarTabla();

        }
        void ActualizarTabla()
        {
            if (txtBuscarTorneo.Text == "Buscar por nombre del Torneo")
                txtBuscarTorneo.Text = ""; 
           // csDGV.MostrarTorneoFiltro(dgvTorneo, txtBuscarTorneo.Text);
           // ActualizarTabla();
            csDGV.MostrarTorneoFiltro(dgvTorneo, txtBuscarTorneo.Text);
            csDGV.AdaptarDGV(dgvTorneo, panelDgv);
        }
     

        private void txtBuscarTorneo_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBuscarTorneo.Text == "Buscar por nombre del Torneo")
            {
                txtBuscarTorneo.Text = "";
                txtBuscarTorneo.ForeColor = Color.Black;
            }
        }
        private void txtBuscarTorneo_TextChanged(object sender, EventArgs e)
        {
            csDGV.MostrarTorneoFiltro(dgvTorneo, txtBuscarTorneo.Text);
        }

        private void btngoleadores_Click(object sender, EventArgs e)
        {
            
        }

        private void btnasistidores_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReglas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(panelmodul, formato);

        }

        private void btnGanador_Click(object sender, EventArgs e)
        {
            ObtenerGanadorTorneo(int.Parse(IDTorneo));
        }
        private void ObtenerGanadorTorneo(int torneoID)
        {
            try
            {
                conexion.AbrirCon();

                using (SqlCommand cmd = new SqlCommand("ObtenerGanadorTorneo", conexion.Conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@torneoID", torneoID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            // Verifica si la columna "Mensaje" existe
                            bool tieneMensaje = false;
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                if (reader.GetName(i) == "Mensaje")
                                {
                                    tieneMensaje = true;
                                    break;
                                }
                            }

                            if (tieneMensaje)
                            {
                                string mensaje = reader["Mensaje"].ToString();
                                MessageBox.Show(mensaje);
                            }
                            else
                            {
                                // Obtener GanadorID y Puntos
                                string ganadorID = reader["GanadorID"].ToString();
                                int puntos = Convert.ToInt32(reader["Puntos"]);

                                MessageBox.Show($"Ganador: {ganadorID} con {puntos} puntos.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se devolvió ningún resultado.");
                        }
                    }
                }
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("Error SQL: " + sqlex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexion.CerrarCon();
            }
        }

        private void btnAsistir_Click(object sender, EventArgs e)
        {
            string IDTorneo = dgvTorneo.SelectedRows[0].Cells["IDTorneo"].Value.ToString();
            frmAsistidores asistencia = new frmAsistidores(IDTorneo);
            asistencia.ShowDialog();
        }

        private void btnGolear_Click(object sender, EventArgs e)
        {
            string IDTorneo = dgvTorneo.SelectedRows[0].Cells["IDTorneo"].Value.ToString();
            frmGoleadores goles = new frmGoleadores(IDTorneo);
            goles.ShowDialog();
        }

        private void Torneo_Shown(object sender, EventArgs e)
        {
            csDGV.AdaptarDGV(dgvTorneo, panelDgv);
        }

        private void dgvTorneo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTorneo_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvTorneo.CurrentRow != null && dgvTorneo.CurrentRow.Index >= 0)
            {
                IDTorneo = dgvTorneo.Rows[dgvTorneo.CurrentRow.Index].Cells[0].Value.ToString();
            }
        }
    }
}
