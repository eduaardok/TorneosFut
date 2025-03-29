using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneosFut.Class;

namespace TorneosFut
{
    public partial class AgregarTitulares: Form
    {
        csDGV csDGV;
        csDatos csDatos;
        string IDPartid;
        int limit;
        string IdTorneo;
        public AgregarTitulares(string idP, string idt, string u, string c)
        {
            InitializeComponent();

            csDGV = new csDGV(u, c);
            csDatos = new csDatos(u, c);
            IDPartid = idP;
            IdTorneo = idt;
            limit = csDatos.LimiteJugador(IdTorneo);
            MessageBox.Show(limit.ToString());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> filasAEliminar = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dgvjugadores.SelectedRows)
            {
                string idJugador = row.Cells["IdJugador"].Value.ToString();  
                string nombreJugador = row.Cells["NombreJugador"].Value.ToString(); 
                listBox1.Items.Add($"{idJugador}: {nombreJugador}");
                filasAEliminar.Add(row);
            }
            foreach (DataGridViewRow row in filasAEliminar)
            {
                dgvjugadores.Rows.Remove(row);
            }
        }

        private void AgregarTitulares_Load(object sender, EventArgs e)
        {
            csDGV.MostrarEquiposCMBID(cmbModoFutbol, IDPartid);
            To.Text = dgvtitulares.Rows.Count.ToString();
        }

        private void btngCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbModoFutbol_SelectedValueChanged(object sender, EventArgs e)
        {
            csDGV.mostrarJugadoresTitulares(dgvtitulares, cmbModoFutbol.SelectedValue.ToString(),IDPartid);
            csDGV.mostrarJugadoresnoTitulares(dgvjugadores, cmbModoFutbol.SelectedValue.ToString(), IDPartid);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count <= limit)
            {
                int jugadoresEnDataGridView = dgvtitulares.Rows.Count;
                if (jugadoresEnDataGridView < limit)
                {
                    foreach (string item in listBox1.Items)
                    {
                        string IDJugador = item.Split(':')[0].Trim();

                        if (!csDatos.InsertarJugadorTitular(IDJugador, int.Parse(IDPartid)))
                        {
                            MessageBox.Show($"No se pudo agregar al jugador {IDJugador}.");
                        }

                    }

                }
                else
                {
                    MessageBox.Show($"No se pueden agregar más jugadores. El límite es {limit}.");
                }
            }
            else
            {
                MessageBox.Show($"No se pueden agregar más jugadores. El límite es {limit}.");
            }
            csDGV.mostrarJugadoresTitulares(dgvtitulares, cmbModoFutbol.SelectedValue.ToString(), IDPartid);
            csDGV.mostrarJugadoresnoTitulares(dgvjugadores, cmbModoFutbol.SelectedValue.ToString(), IDPartid);
            To.Text = dgvtitulares.Rows.Count.ToString();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0) // Verificar si hay jugadores en la lista
            {
                foreach (string item in listBox1.Items)
                {
                    string IDJugador = item.Split(':')[0].Trim(); // Extraer IDJugador

                    if (!csDatos.QuitarJugadorTitular(IDJugador, int.Parse(IDPartid)))
                    {
                        MessageBox.Show($"No se pudo actualizar al jugador {IDJugador}.");
                    }
                }
                listBox1.Items.Clear();
                csDGV.mostrarJugadoresTitulares(dgvtitulares, cmbModoFutbol.SelectedValue.ToString(), IDPartid);
                csDGV.mostrarJugadoresnoTitulares(dgvjugadores, cmbModoFutbol.SelectedValue.ToString(), IDPartid);

            }
            else
            {
                MessageBox.Show("No hay jugadores en la lista para quitar.");
            }
                MessageBox.Show("Jugadores actualizados como no titulares.");

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un jugador en el ListBox
            if (listBox1.SelectedItem != null)
            {
                // Mostrar mensaje de confirmación antes de quitar al jugador del ListBox
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas quitar al jugador seleccionado del ListBox?",
                                                       "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Obtener el ID del jugador seleccionado del ListBox
                    string seleccionado = listBox1.SelectedItem.ToString();
                    string IDJugador = seleccionado.Split(':')[0].Trim();  // Extraer el ID del jugador

                    // Quitar el jugador del ListBox
                    listBox1.Items.Remove(listBox1.SelectedItem);

                    // Recargar el DataGridView para reflejar el cambio
                    // Esto recarga todos los jugadores disponibles en el DataGridView
                }
            }
            else
            {
                MessageBox.Show("Seleccione un jugador para quitar del ListBox.");
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            // Crear una lista para almacenar las filas a eliminar
            List<DataGridViewRow> filasAEliminar = new List<DataGridViewRow>();

            // Verificar si se ha seleccionado alguna fila en el DataGridView
            if (dgvtitulares.SelectedRows.Count > 0)
            {
                // Obtener los jugadores seleccionados
                foreach (DataGridViewRow row in dgvtitulares.SelectedRows)
                {
                    string idJugador = row.Cells["IdJugador"].Value.ToString();  // Extraer IDJugador
                    string nombreJugador = row.Cells["NombreJugador"].Value.ToString();  // Extraer NombreJugador

                    // Agregar al ListBox
                    listBox1.Items.Add($"{idJugador}: {nombreJugador}");

                    // Agregar la fila a la lista de eliminación
                    filasAEliminar.Add(row);
                }

                // Eliminar las filas seleccionadas del DataGridView
                foreach (DataGridViewRow row in filasAEliminar)
                {
                    dgvtitulares.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Seleccione al menos un jugador para quitar.");
            }
        }
    }
}

