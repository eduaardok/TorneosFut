using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneosFut;

namespace PruebasTorneos
{
    public partial class EditEntrenador: Form
    {
        csConexion conexion ;
        csEntrenador dt;
        public EditEntrenador(string u, string c)
        {

            conexion = new csConexion();
            conexion.Usuario = u;
            conexion.Clave = c;
            dt = new csEntrenador(u,c);
            InitializeComponent();
        }
        private void frmEditarDT_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            dt.Cargar(dgvEntrenador);
            dgvEntrenador.CellFormatting += dgvEntrenador_CellFormatting;
        }

        private void btnEditarIMG_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            img.Filter = "archivos de imagen (*jpg; *png;) | *jpg; *png;";
            if (img.ShowDialog() == DialogResult.OK)
            {
                ptbNewIMG.Image = Image.FromFile(img.FileName);
            }
        }

        private void dgvEntrenador_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvEntrenador.Columns[e.ColumnIndex].Name == "PartidosGanados")
            {
                e.CellStyle.ForeColor = Color.Green;
            }
            if (dgvEntrenador.Columns[e.ColumnIndex].Name == "PartidosEmpatados")
            {
                e.CellStyle.ForeColor = Color.Orange;
            }
            if (dgvEntrenador.Columns[e.ColumnIndex].Name == "PartidosPerdidos")
            {
                e.CellStyle.ForeColor = Color.Red;
            }
            if (dgvEntrenador.Columns[e.ColumnIndex].Name == "Sexo" && e.Value != null)
            {
                string valor = e.Value.ToString().Trim().ToLower();
                if (valor == "masculino")
                {
                    e.CellStyle.ForeColor = Color.Blue;
                }
                else if (valor == "femenino")
                {
                    e.CellStyle.ForeColor = Color.Magenta;
                }
            }
        }

        private void dgvEntrenador_SelectionChanged(object sender, EventArgs e)
        {
            /*try
            {
                if (dgvEntrenador.Rows.Count == 0 || dgvEntrenador.SelectedRows.Count == 0)
                    return;
                int fila = dgvEntrenador.SelectedRows[0].Index;
                string celda = dgvEntrenador.Rows[fila].Cells["IDEntrenador"].Value.ToString();

                string consulta = $"select ImagenEntrenador from Entrenador where IDEntrenador = {celda}";

                byte[] imagenBytes = conexion.ObtenerImagen(consulta, "ImagenEntrenador");
                if (imagenBytes != null && imagenBytes.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imagenBytes))
                    {
                        ptbNewIMG.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    ptbNewIMG.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }*/
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            dt.filtro(txtBuscar.Text.Trim(), dgvEntrenador);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            /*int idEntrenador = Convert.ToInt32(dgvEntrenador.SelectedRows[0].Cells["IDEntrenador"].Value);
            if(ptbNewIMG.Image == null)
            {
                MessageBox.Show("Elija una imagen antes de continuar");
            }
            else
            {
                try
                {
                    if (dgvEntrenador.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Selecciona un entrenador primero.");
                        return;
                    }
                    MemoryStream ms = new MemoryStream();
                    ptbNewIMG.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] imgByte = ms.ToArray();
                    if (conexion.EditarImagen(idEntrenador, imgByte, "Entrenador", "ImagenEntrenador", "IDEntrenador"))
                    {
                        MessageBox.Show("Entrenador actualizado correctamente.");
                        dt.Cargar(dgvEntrenador);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el entrenador.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar entrenador: {ex.Message}");
                }
            }*/
        }

        private void dgvEntrenador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ptbNewIMG_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btngCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
