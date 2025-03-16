using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorneosFut
{
    public partial class AggEditEquipo: Form
    {
        csConexion conexion;
        OpenFileDialog img = new OpenFileDialog();
        static bool agregar;
        csDatos csDatos;
        static string nombreArchivo = "";
        public AggEditEquipo(string u, string c, bool n)
        {
            conexion = new csConexion(u,c);
            csDatos = new csDatos(u,c);
            conexion.Usuario = u;
            conexion.Clave = c;
            agregar = n;
            InitializeComponent();
        }
        public void lblEntregarVisi(bool visble, bool novisble)
        {
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (agregar)
            {
                if(csDatos.InsertarEquipo(txtId.Text, cmbEstadio.SelectedValue.ToString(), txtNombreClub.Text, cmbGenero.Text, cmbEquipacionLocal.Text, cmbequipacionvisitante.Text, nombreArchivo, txtPresidente.Text, img.FileName))
                {
                    MessageBox.Show("Equipo Agregado Correctamente");
                }
                else MessageBox.Show("Equipo no Agregado");
            }
            else
            { 
                //
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblBodr2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblBorde1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void lblBorde1_Click(object sender, EventArgs e)
        {

        }

        private void AggEquipo_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            if (!agregar)
            {
                txtId.Enabled = false;
                cmbGenero.Enabled = false;
                lblEncabezado.Text = "EDITAR EQUIPO";
                btnAgregar.Text = "EDITAR";
            }
        }
        public string ObtenerNombreArchivo()
        {
            string nombreIMG = "Imagen" + DateTime.Now.Ticks.ToString();
            return nombreIMG;
        }

        private void btnSeleccionarIMG_Click(object sender, EventArgs e)
        {

            img.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;";
            img.Title = "Selecciona una imagen";
            if (img.ShowDialog() == DialogResult.OK)
            {
                ptbImagen.Image = Image.FromFile(img.FileName);
                nombreArchivo = ObtenerNombreArchivo();
            }
        }

        private void cmbEquipacionLocal_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
