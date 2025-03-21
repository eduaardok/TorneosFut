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
        csDatos csDatos;
        static csEncriptar encriptar;
        static string id;
        public CambiarClave(string u, string c, string pass, string i)
        {
            conexion = new csConexion(u, c);
            id = i;
            encriptar = new csEncriptar();
            csDatos = new csDatos(u, c);
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
                if (csDatos.ActualizarClaveUsuario(claveApp, id))
                {
                    MessageBox.Show($"Su clave ha sido actualizada");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"No se pudo actualizar la clave, inténtelo de nuevo");
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
