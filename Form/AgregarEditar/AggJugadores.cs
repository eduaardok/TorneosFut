using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
        string ID;
        static string rutaArchivoOrigen;
        public AggJugadores(string id, string u, string c, bool n)
        {
            img = new OpenFileDialog();
            imagenes = new csImagenes();
            conexion = new csConexion(u,c);
            csDatos = new csDatos(u, c);
            agregar = n;
            ID=id;
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
                guardarIMG(rutaArchivoOrigen, nombreArchivo);
                if (csDatos.InsertarJugador( Txtnombre, txtapellido, cmbsexo, dtpNacimiento,
                                            CmbPosicion, TxtNacionalidad, txtpeso, txtaltura,
                                            cmbpierna, nombreArchivo, img.FileName))
                {
                    MessageBox.Show("Jugador agregado correctamente");
                     Txtnombre.Clear(); txtapellido.Clear(); cmbsexo.SelectedIndex = -1; dtpNacimiento.ResetText();
                    CmbPosicion.SelectedIndex = -1; TxtNacionalidad.Clear(); txtpeso.Clear(); txtaltura.Clear();
                    cmbpierna.SelectedIndex = -1;  ptbImagen.BackgroundImage = null;
                }
                else
                {
                    MessageBox.Show("Error al agregar el jugador");
                }
            }
            else
            {
                if (csDatos.EditarJugador( ID,Txtnombre, txtapellido, cmbsexo, dtpNacimiento,
                                            CmbPosicion, TxtNacionalidad, txtpeso, txtaltura,
                                            cmbpierna, nombreArchivo, img.FileName))
                {
                    MessageBox.Show("Jugador editado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al editar el jugador");
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
                rutaArchivoOrigen = img.FileName;
            }
        }
        private void guardarIMG(string rutaOriginal, string nombreArchivo)
        {
            if (string.IsNullOrEmpty(rutaOriginal))
            {
                return;
            }
            string carpetaDestino = Path.Combine(Application.StartupPath, "Imagenes");

            if (!Directory.Exists(carpetaDestino))
                Directory.CreateDirectory(carpetaDestino);
            string rutaDestino = Path.Combine(carpetaDestino, nombreArchivo);
            File.Copy(rutaOriginal, rutaDestino, true);
        }
    }
}