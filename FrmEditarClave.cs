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
    public partial class FrmEditarClave: Form
    {
        static string id;
        csConexion conexion = new csConexion();
        csEncriptar encriptar = new csEncriptar();
        public FrmEditarClave(string i)
        {
            id = i;
            InitializeComponent();
        }

        private void lblNuevaClave_Click(object sender, EventArgs e)
        {

        }

        private void EditarClave_Load(object sender, EventArgs e)
        {
            DataTable dato = conexion.ListDGV($"select Usuario from Administrador where IDAdmin = {id}");
            lblUser.Text = dato.Rows[0][0].ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCambiarClave_Click(object sender, EventArgs e)
        {
           txtClave.Text = txtClave.Text.Trim();
            if (txtClave.Text.Length > 0)
            {
                string claveencrip = encriptar.Encriptar(txtClave.Text, "futxpert");
                conexion.Consulta($"update Administrador set Clave='{claveencrip}' where IDAdmin={id}");
                MessageBox.Show($"Contraseña nueva: {txtClave.Text}");
                this.Close();
            }
            else
                MessageBox.Show("Ingrese una clave válida");
        }
    }
}
