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
using System.Drawing.Imaging;
using TorneosFut; 

namespace PruebasTorneos
{
    public partial class AggEntrenador: Form
    {
        csConexion conexion;
        public AggEntrenador(string u, string c)
        {
            conexion = new csConexion();
            conexion.Usuario = u;
            conexion.Clave = c;
            InitializeComponent();
        }

        private void frmAggEntrenador_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            img.Filter = "archivos de imagen (*jpg; *png;) | *jpg; *png;";
            if (img.ShowDialog() == DialogResult.OK)
            {
                ptbImagen.Image = Image.FromFile(img.FileName); 
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(cbmSexo.Text))
            {
                MessageBox.Show("Se deben llenar todos los campos");
                return;
            }
            try
            {
                MemoryStream ms = new MemoryStream();
                ptbImagen.Image.Save(ms, ImageFormat.Jpeg);
                byte[] imgByte = ms.ToArray();
                string consultaDatos = $"insert into Entrenador (Nombres, Apellidos, Sexo, PartidosGanados, PartidosEmpatados, PartidosPerdidos) " +
                                       $"values ('{txtNombre.Text}', '{txtApellido.Text}', '{cbmSexo.Text}', 0, 0, 0)";
                string consultaImagen = "update Entrenador set ImagenEntrenador = @imagen where IDEntrenador = @idEntrenador";
                if (conexion.EjecutarTransaccion(consultaDatos, consultaImagen, imgByte))
                {
                    MessageBox.Show("Entrenador registrado correctamente");
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el entrenador.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar: {ex.Message}");
            }
        }
    }
}
