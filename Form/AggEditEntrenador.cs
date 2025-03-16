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
using TorneosFut.Class;
using System.Web.ModelBinding;

namespace PruebasTorneos
{
    public partial class AggEditEntrenador: Form
    {
        OpenFileDialog img = new OpenFileDialog();
        csImagenes imagenes = new csImagenes(); 
        csConexion conexion;
        csDatos csDatos;
        static string nombreArchivo = "";
        static bool agregar;
        public AggEditEntrenador(string u, string c, bool n)
        {
            conexion = new csConexion(u,c);
            csDatos = new csDatos(u, c);
            agregar = n;
            InitializeComponent();
        }

        private void frmAggEntrenador_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            if (!agregar)
            {
                lblEncabezado.Text = "EDITAR ENTRENADOR";
                btnGuardar.Text = "EDITAR";
                txtID.Enabled= false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (agregar)
            {
                if (csDatos.InsertarEntrenador(txtID.Text,txtNombre.Text, txtApellido.Text, cmbSexo.Text,dtpNacimiento.Text, nombreArchivo, img.FileName))
                {
                    MessageBox.Show("insertado");
                }
                else
                    MessageBox.Show("no insertado");
            }
            else
            {
                //process
            }
        }
        public string ObtenerNombreArchivo()
        {
            string nombreIMG = "Imagen" + DateTime.Now.Ticks.ToString();
            return nombreIMG;
        }
        private void btngCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            img.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;";
            img.Title = "Selecciona una imagen";
            if (img.ShowDialog() == DialogResult.OK)
            {
                ptbImagen.Image = Image.FromFile(img.FileName);
                nombreArchivo = ObtenerNombreArchivo();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void dtpNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ptbImagen_Click(object sender, EventArgs e)
        {

        }

        private void lblfecha_Click(object sender, EventArgs e)
        {

        }

        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}