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
using Guna.UI2.WinForms;

namespace PruebasTorneos
{
    public partial class AggEditEntrenador: Form
    {
        OpenFileDialog img = new OpenFileDialog();
        csImagenes imagenes = new csImagenes(); 
        csConexion conexion;
        csDatos csDatos;
        static string nombreArchivo = "";
        static string id;
        static bool agregar;
        Guna.UI2.WinForms.Guna2MessageDialog msg = new Guna.UI2.WinForms.Guna2MessageDialog();
        public AggEditEntrenador(string u, string c, bool n, string i)
        {
            conexion = new csConexion(u,c);
            csDatos = new csDatos(u, c);
            agregar = n;
            id = i;
            InitializeComponent();
        }

        private void frmAggEntrenador_Load(object sender, EventArgs e)
        {

            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            if (!GlobalSettings.ModoOscuro)
            {
                panel1.BackColor = Color.FromArgb(251, 3, 140);
                panel2.BackColor = Color.FromArgb(251, 3, 140);
                panel3.BackColor = Color.FromArgb(251, 3, 140);
                panel4.BackColor = Color.FromArgb(251, 3, 140);
            }
            msg.Buttons = MessageDialogButtons.OK;
            msg.Icon = MessageDialogIcon.Information;
            msg.Style = MessageDialogStyle.Light;
            msg.Parent = this;
            if (GlobalSettings.ModoOscuro)
            {
                msg.Style = MessageDialogStyle.Dark;

            }
            if (!agregar)
            {
                lblEncabezado.Text = "EDITAR ENTRENADOR";
                btnGuardar.Text = "EDITAR";
                Editar();
                //txtID.Enabled= false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (agregar)
            {
                if (csDatos.InsertarEntrenador(txtNombre.Text, txtApellido.Text, cmbSexo.Text,dtpNacimiento.Value, nombreArchivo, img.FileName))
                {
                    msg.Text = "Se registró el entrenador correctamente.";
                    msg.Show();
                    Close();
                }
              
            }
            else
            {
               if(csDatos.EditarEntrenador(id, txtNombre.Text, txtApellido.Text, cmbSexo.Text, dtpNacimiento.Value, nombreArchivo, img.FileName))
                {
                    msg.Text = "Entrenador actualizado correctamente";
                    msg.Show();
                    Close();
                }
                
            }
        }
        void Editar()
        {
            txtNombre.Text = csDatos.ObtenerNombreEntrenadorPorID(id);
            txtApellido.Text = csDatos.ObtenerApellidoEntrenadorPorID(id);
            if (cmbSexo.Items.Contains(csDatos.ObtenerSexoEntrenadorPorID(id)))
                cmbSexo.SelectedItem = csDatos.ObtenerSexoEntrenadorPorID(id);
            dtpNacimiento.Value = (DateTime.Parse(csDatos.ObtenerFechaNacEntrenadorPorID(id)).Date);
            csDatos.MostrarImagenEntrenador(id, ptbImagen);
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