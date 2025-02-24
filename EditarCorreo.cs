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
    public partial class EditarCorreo: Form
    {
        csConexion conexion = new csConexion();
        string id;
        public EditarCorreo(string i)
        {
            InitializeComponent();
            id = i;
        }

        private void EditarCorreo_Load(object sender, EventArgs e)
        {
            DataTable dato = conexion.ListDGV($"select Usuario from Administrador where IDAdmin = {id}");
            lblUser.Text = dato.Rows[0][0].ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCambiarCorreo_Click(object sender, EventArgs e)
        {
            txtCorreo.Text = txtCorreo.Text.Trim();
            if(txtCorreo.Text.Length>0&&cmbCorreos.SelectedIndex!=-1)
            {
                conexion.Consulta($"update Administrador set Correo='{txtCorreo.Text + cmbCorreos.Text}' where IDAdmin={id}");
                MessageBox.Show($"Correo nuevo: {txtCorreo.Text + cmbCorreos.Text}");
                this.Close();
            }
            else
            {
                MessageBox.Show($"Ingrese una dirección de correo electrónico válida");
            }
        }
    }
}
