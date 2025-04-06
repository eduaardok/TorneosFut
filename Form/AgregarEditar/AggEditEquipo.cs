using Guna.UI2.WinForms;
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
    public partial class AggEditEquipo : Form
    {
        csConexion conexion;
        OpenFileDialog img = new OpenFileDialog();
        static bool agregar;
        csDatos csDatos;
        csDGV csDGV;
        static string nombreArchivo = "";
        Guna.UI2.WinForms.Guna2MessageDialog msg = new Guna.UI2.WinForms.Guna2MessageDialog();
        public AggEditEquipo(string u, string c, bool n)
        {
            conexion = new csConexion(u, c);
            csDatos = new csDatos(u, c);
            agregar = n;
            csDGV = new csDGV(u, c);
            InitializeComponent();
        }
        public void lblEntregarVisi(bool visble, bool novisble)
        {
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (CamposVacios())
            {
                try
                {
                    if (agregar)
                    {

                        if (csDatos.InsertarEquipo(txtId.Text, cmbEstadio.SelectedValue.ToString(), txtNombreClub.Text, cmbGenero.Text, cmbEquipacionLocal.Text, cmbequipacionvisitante.Text, nombreArchivo, txtPresidente.Text, img.FileName))
                        {
                            msg.Text = "Equipo Agregado";
                            msg.Show();

                            Close();
                        }
                        else
                        {
                        }
                    }
                    else
                    {
                        if (csDatos.EditarEquipo(txtId.Text, cmbEstadio.SelectedValue.ToString(), txtNombreClub.Text, cmbGenero.Text, cmbEquipacionLocal.Text, cmbequipacionvisitante.Text, nombreArchivo, txtPresidente.Text, img.FileName))
                        {
                            msg.Text = "Equipo Editado";
                            msg.Show();

                            Close();
                        }
                    }
                }
                catch (Exception)
                {
                    msg.Text = "Datos invalidos";
                    msg.Show();
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        bool CamposVacios()
        {
            if (txtId.Text == "" || cmbEstadio.Text == "" || txtNombreClub.Text == "" || cmbGenero.Text == "" || cmbEquipacionLocal.Text == "" || cmbequipacionvisitante.Text == "" || txtPresidente.Text == "")
            {
                msg.Text = "Faltan datos por llenar";
                return false;
            }
            else return true;
        }
        private void AggEquipo_Load(object sender, EventArgs e)
        {
        
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            if (!GlobalSettings.ModoOscuro)
            {
                panel1.BackColor = Color.FromArgb(251, 3, 140);
                panel2.BackColor = Color.FromArgb(251, 3, 140);
                panel3.BackColor = Color.FromArgb(251, 3, 140);
                panel4.BackColor = Color.FromArgb(251, 3, 140);
            }
            csDGV.LlenarcmbEstadio(cmbEstadio);
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
    }
}