using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneosFut;
using TorneosFut.Class;
namespace pruebas
{
    public partial class AggJugadores : Form
    {
        OpenFileDialog img= new OpenFileDialog();
        csImagenes imagenes;
        csConexion conexion;
        csDatos csDatos;
        static bool agregar;
        static string nombreArchivo = "";
        public AggJugadores( string u, string c, bool n)
        {
            img = new OpenFileDialog();
            imagenes = new csImagenes();
            conexion = new csConexion(u,c);
            csDatos = new csDatos(u, c);
            agregar = n;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            panel2.Tag = "NoCambiar";
            panel1.Tag = "NoCambiar";
            panel3.Tag = "NoCambiar";
            panel4.Tag = "NoCambiar";
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            if (!agregar)
            {
                lblEncabezado.Text = "EDITAR JUGADOR";
                txtIDJugador.Enabled=false;
                btnAgregar.Text = "EDITAR";
            }
        }
        private void lblPosicion_Click(object sender, EventArgs e)
        {
        }
        public string ObtenerNombreArchivo()
        {
            string nombreIMG = "Imagen" + DateTime.Now.Ticks.ToString();
            return nombreIMG;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (agregar)
            {
                if (csDatos.InsertarJugador(txtIDJugador.Text, Txtnombre, txtapellido, cmbsexo, dtpNacimiento,
                                            CmbPosicion, TxtNacionalidad, txtpeso, txtaltura,
                                            cmbpierna, nombreArchivo, img.FileName))
                {
                    MessageBox.Show("Jugador agregado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al agregar el jugador");
                }
            }
            else
            {
                string query = $"UPDATE Jugador SET " +
                               $"NombreJugador = '{Txtnombre.Text}', " +
                               $"ApellidoJugador = '{txtapellido.Text}', " +
                               $"Sexo = '{cmbsexo.Text}', " +
                               $"FechaNacimiento = '{dtpNacimiento.Value:yyyy-MM-dd}', " +
                               $"Posicion = '{CmbPosicion.Text}', " +
                               $"Nacionalidad = '{TxtNacionalidad.Text}', " +
                               $"Peso = '{txtpeso.Text}', " +
                               $"Altura = '{txtaltura.Text}', " +
                               $"PiernaHabil = '{cmbpierna.Text}', " +
                               $"ImagenJugador = '{nombreArchivo}' " +
                               $"WHERE IDJugador = '{txtIDJugador.Text}';";

                if (conexion.Consulta(query))
                {
                    MessageBox.Show("Jugador actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al actualizar el jugador");
                }
            }
        }
        private void btngCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnCargarimagen_Click(object sender, EventArgs e)
        {
               img.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;";
            img.Title = "Selecciona una imagen";
            if (img.ShowDialog() == DialogResult.OK)
            {
                ptbImagen.Image = Image.FromFile(img.FileName);
                nombreArchivo = ObtenerNombreArchivo();
            }
        }
    }
}