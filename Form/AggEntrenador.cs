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
    public partial class AggEntrenador: Form
    {
        OpenFileDialog img = new OpenFileDialog();
        csImagenes imagenes = new csImagenes(); 
        csConexion conexion;
        csDatos csDatos;
        static string nombreArchivo = "";
        public AggEntrenador(string u, string c)
        {
            conexion = new csConexion(u,c);
            csDatos = new csDatos(u, c);
            InitializeComponent();
        }

        private void frmAggEntrenador_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (csDatos.InsertarEntrenador(txtNombre.Text, txtApellido.Text, cmbSexo.Text, nombreArchivo, img.FileName))
            {
                MessageBox.Show("insertado");
            }
            else
                MessageBox.Show("no insertado");
                
                /*
            if (img.FileName != "")
            {
                string nombreIMG = "Imagen" + DateTime.Now.Ticks.ToString();
                string nombreARCH = imagenes.guardarIMG(img.FileName, nombreIMG);

                if (conexion.Consulta($"update Estadio set ImagenEstadio = '{nombreARCH}' where IDEstadio = 2"))
                {
                    MessageBox.Show("Foto guardada con exito");
                }
            }*/
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
    }
}