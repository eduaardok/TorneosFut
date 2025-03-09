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
    public partial class CambiarClave: Form
    {
        csConexion conexion;
        static csEncriptar encriptar;
        static string id;
        public CambiarClave(string u, string c, string pass, string i)
        {
            conexion = new csConexion();
            conexion.Usuario = u;
            conexion.Clave = c;
            id = i;
            encriptar = new csEncriptar();
            InitializeComponent();
            lblClaveAct.Text = pass;

        }
        private void frmCambiarClave_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
        }
        private void btngEnviar_Click(object sender, EventArgs e)
        {
            string claveApp = encriptar.Encriptar(txtClaveApp.Text, "futxpert");
            if (txtClaveApp.Text.Length<5)
            {
                MessageBox.Show("Longitud mínima de 5 caracteres");
                return;
            }
            else
            {
                conexion.Consulta($"update Administrador set ClaveApp='{claveApp}' where IDAdmin={id}");
                MessageBox.Show($"Usuario editado");
                this.Close();
            }
        }
    }
}
