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

namespace PruebasTorneos
{
    public partial class AggEntrenador: Form
    {
        OpenFileDialog img = new OpenFileDialog();
        csImagenes imagenes = new csImagenes(); 
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
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            img.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;";
            img.Title = "Selecciona una imagen";

            if (img.ShowDialog() == DialogResult.OK)
            {
                ptbImagen.Image = Image.FromFile(img.FileName);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (img.FileName != "")
            {
                string nombreIMG = "Imagen" + DateTime.Now.Ticks.ToString();
                string nombreARCH = imagenes.guardarIMG(img.FileName, nombreIMG);

                if (conexion.Consulta($"update Estadio set ImagenEstadio = '{nombreARCH}' where IDEstadio = 2"))
                {
                    MessageBox.Show("Foto guardada con exito");
                }
            }
        }

        private void btngCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}