using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneosFut;
using TorneosFut.Class;

namespace pruebas
{
    public partial class verjugadores : Form
    {
        csConexion conexion;
        csJugador jugador;
        public verjugadores(string u, string c)
        {
            conexion = new csConexion();
            conexion.Usuario = u;
            conexion.Clave = c;
            jugador = new csJugador(u, c);
            InitializeComponent();
        }

        private void txtBuscador_KeyUp(object sender, KeyEventArgs e)
        {
            string filtro = txtBuscador.Text.Trim().ToString();
            if (string.IsNullOrWhiteSpace(filtro))
            {
                dgvJugador.DataSource = jugador.mostrarJugador();
            }
            else
            {
                string consulta = jugador.filtro(filtro);

                DataTable dt = conexion.ListDGV(consulta);
                dgvJugador.DataSource = dt;
            }
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
        }
        private void dgvJugador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void verjugadores_Load(object sender, EventArgs e)
        {
            dgvJugador.DataSource =jugador.mostrarJugador();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvJugador.RowCount > 0)
                {
                    if (dgvJugador.CurrentRow.Index >= 0)
                    {

                        string id = dgvJugador.Rows[dgvJugador.CurrentRow.Index].Cells[0].Value.ToString();
                        editarjugador edi = new editarjugador(id, this, conexion.Usuario, conexion.Clave);
                        edi.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Seleccione el usuario que desea editar");
                    }
                }
                else
                {
                    MessageBox.Show("La tabla está vacía");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void dgvJugador_SelectionChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (dgvJugador.Rows.Count == 0 || dgvJugador.SelectedRows.Count == 0)
            //        return;

            //    int fila = dgvJugador.SelectedRows[0].Index;
            //    string celda = dgvJugador.Rows[fila].Cells["IDJugador"].Value.ToString();
            //    string consulta = $"select ImagenJugador from Jugador where IDJugador = {celda}";

            //    byte[] imagenBytes = conexion.ObtenerImagen(consulta, "ImagenJugador");

            //    if (imagenBytes != null && imagenBytes.Length > 0)
            //    {
            //        using (MemoryStream ms = new MemoryStream(imagenBytes))
            //        {
            //            ptbIMG.Image = Image.FromStream(ms);
            //        }
            //    }
            //    else
            //    {
            //        ptbIMG.Image = null;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            //}
        }
    }
}