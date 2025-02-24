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

namespace agregarUsuario
{
    public partial class AgregarUsuario: Form
    {
        csConexion conexion= new csConexion();
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = txtNombre.Text.Trim();
            txtUsuario.Text = txtUsuario.Text.Trim();
            txtClave.Text = txtClave.Text.Trim();
            txtCorreo.Text = txtCorreo.Text.Trim();
            if(txtNombre.Text.Length>0 && txtUsuario.Text.Length>0 && txtClave.Text.Length>0 && txtCorreo.Text.Length>0 && cmbCorreos.SelectedIndex!=-1)
            {
                conexion.Consulta($"insert into Administrador ([Nombre],[Usuario],[Clave],[Correo]) values" +
                    $" ('{txtNombre.Text}', '{txtUsuario.Text}', '{txtClave.Text}', '{txtUsuario.Text + cmbCorreos.Text}')");
                MessageBox.Show($"Usuario agregado: {txtUsuario.Text}");
                this.Close();
            }
            else
            {
                MessageBox.Show($"Rellene todos los campos correctamente");
            }
        }
    }
}
