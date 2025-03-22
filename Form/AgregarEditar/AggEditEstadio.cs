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
    public partial class AggEditEstadio: Form
    {
        string id; OpenFileDialog img = new OpenFileDialog();

        bool agg;
        csDatos csDatos;
        csImagenes csImagenes; static string nombreArchivo = "";
        public AggEditEstadio(string u, string c,bool t, string i)
        {
            csDatos = new csDatos(u, c);
            csImagenes = new csImagenes();
            id = i;
            t = agg;
            InitializeComponent();
        }

        public string ObtenerNombreArchivo()
        {
            string nombreIMG = "Imagen" + DateTime.Now.Ticks.ToString();
            return nombreIMG;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AggEditEstadio_Load(object sender, EventArgs e)
        {
            panel2.Tag = "NoCambiar";
            panel1.Tag = "NoCambiar";
            panel3.Tag = "NoCambiar";
            panel4.Tag = "NoCambiar";
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            if (agg == false)
            {
                btnAgregar.Text = "EDITAR ESTADIO";
                Editar();
            }
            else
            {

            }
        }
        void Editar()
        {
            txtNombreEstadio.Text = csDatos.ObtenerNombreEstadio(id);
            txtUbicacion.Text = csDatos.ObtenerUbicacionEstadio(id);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (agg == false)
            {
                if (csDatos.EditarEstadio(id, txtNombreEstadio.Text, txtUbicacion.Text, nombreArchivo, img.FileName))
                {
                    MessageBox.Show("Estadio editado correctamente");
                    Close();
                }
            }
            else
            {
                if (csDatos.InsertarEstadio(id, txtNombreEstadio.Text, txtUbicacion.Text, nombreArchivo, img.FileName))
                {
                    MessageBox.Show("Estadio registrado correctamente");
                    Close();
                }
            }
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
