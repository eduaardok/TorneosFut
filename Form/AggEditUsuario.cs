
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
namespace Usuarios
{
    public partial class AggEditUsuario: Form
    {
        static bool agg = true;
        static string id;
        //csConexion conexion;
        csEncriptar csEncriptar;
        csDatos csDatos;
        csValidaciones csValidaciones;
        public AggEditUsuario(bool a, string i, string u, string c)
        {
            //conexion = new csConexion(u,c);
            csDatos = new csDatos(u, c);
            csValidaciones = new csValidaciones(u, c);
            agg = a;
            id = i;
            InitializeComponent();
        }
        private void btngSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btngEnviar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = txtNombre.Text.Trim();
            txtUsuarioApp.Text = txtUsuarioApp.Text.Trim();
            txtClaveApp.Text = txtClaveApp.Text.Trim();
            txtCorreo.Text = txtCorreo.Text.Trim();
            txtUsuarioBD.Text = txtUsuarioBD.Text.Trim();
            txtClaveBD.Text = txtClaveBD.Text.Trim();
            if (Validaciones())
            {
                string claveApp = csEncriptar.Encriptar(txtClaveApp.Text, "futxpert");
                string claveBD = csEncriptar.Encriptar(txtClaveBD.Text, "futxpert");
                if (agg)
                {
                    if (csDatos.InsertarUsuario(txtNombre.Text, txtUsuarioApp.Text, claveApp, txtCorreo.Text + cmbCorreos.Text, txtUsuarioBD.Text, claveBD))
                    {
                        //csDatos.CrearLoginBD(txtUsuarioBD.Text, txtClaveBD.Text);
                        MessageBox.Show($"Usuario agregado");
                        this.Close();
                    }    
                }
                else
                {
                    if (csDatos.ActualizarUsuario(id, txtNombre.Text, txtUsuarioApp.Text, claveApp, txtCorreo.Text + cmbCorreos.Text, txtUsuarioBD.Text, claveBD))
                    {
                        //csDatos.ActualizarClaveBD(txtUsuarioBD.Text, txtClaveBD.Text);
                        MessageBox.Show($"Usuario editado");
                        this.Close();
                    }
                }
            }
            else
                MessageBox.Show("Verifique los campos ingresados");
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            csEncriptar = new csEncriptar();
            Editar();
        }
        void Editar()
        {
            if(!agg)
            {
                lblEncabezado.Text = "EDICIÓN DE USUARIO";
                txtUsuarioBD.ReadOnly = true;
                btngEnviar.Text = "EDITAR";
                txtNombre.Text = csDatos.ObtenerNombrePorID(id);
                txtUsuarioApp.Text = csDatos.ObtenerUsuarioPorID(id);
                txtClaveApp.Text = csEncriptar.Desencriptar(csDatos.ObtenerClavePorID(id), "futxpert");
                if (csDatos.ObtenerCorreoPorID(id).Contains('@'))
                {
                    string[] c = csDatos.ObtenerCorreoPorID(id).Split('@');
                    txtCorreo.Text = c[0];
                    int index = cmbCorreos.Items.IndexOf("@" + c[1]);
                    if (index >= 0)
                        cmbCorreos.SelectedIndex = index; // Selecciona el dominio si está en la lista
                    else
                        cmbCorreos.SelectedIndex = -1; // Deja en blanco si no está en la lista
                }
                txtUsuarioBD.Text = csDatos.ObtenerUsuarioBDPorID(id);
                txtClaveBD.Text = csEncriptar.Desencriptar(csDatos.ObtenerClaveBDPorID(id), "futxpert");
            }
        }
        bool Validaciones()
        {
            if(txtNombre.Text.Length<5) //esto para validar el nombre ingresado
            {
                lblaNombre.Text = "Longitud mínima: 5 caracteres";
                return false;
            }
            else
            {
                if (!csValidaciones.ValidarNombre(txtNombre.Text, id))
                {
                    lblaNombre.Text = "El nombre ya está en uso";
                    return false;
                }
            }
            if (txtUsuarioApp.Text.Length < 5) //esto para validar el usuario de app ingresado
            {
                lblaUsuarioApp.Text = "Longitud mínima: 5 caracteres";
                return false;
            }
            else
            {
                if (!csValidaciones.ValidarUsuario(txtUsuarioApp.Text, id))
                {
                    lblaUsuarioApp.Text = "El nombre de usuario ya está en uso";
                    return false;
                }
            }
            if (txtUsuarioBD.Text.Length < 5) //esto para validar el usuario de bd
            {
                lblaUsuarioBD.Text = "Longitud mínima: 5 caracteres";
                return false;
            }
            else
            {
                if (!csValidaciones.ValidarUsuarioBD(txtUsuarioBD.Text, id))
                {
                    lblaUsuarioBD.Text = "El nombre de usuario ya está en uso";
                    return false;
                }
            }
            if (txtCorreo.Text.Length < 5) //esto para validar el correo
            {
                lblaUsuarioBD.Text = "Longitud mínima: 5 caracteres";
                return false;
            }
            else
            {
                if(cmbCorreos.SelectedIndex==-1)
                {
                    lblaMail.Text = "Seleccione un tipo de correo";
                    return false;
                }
                if (!csValidaciones.ValidarCorreo(txtCorreo.Text+cmbCorreos.Text, id))
                {
                    lblaMail.Text = "El correo ya está en uso";
                    return false;
                }
            }
            if (txtClaveApp.Text.Length < 5) //esto para validar la clave app
            {
                lblaClaveApp.Text = "Longitud mínima: 5 caracteres";
                return false;
            }
            if (txtClaveBD.Text.Length < 5) //esto para validar la clave app
            {
                lblaClaveBD.Text = "Longitud mínima: 5 caracteres";
                return false;
            }
            return true;
        }

        private void lbBorde_Paint(object sender, PaintEventArgs e)
        {
            lbBorde.BackColor = Color.Transparent;
            using (Pen pen = new Pen(ColorTranslator.FromHtml("#FB038C"), 3))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, lbBorde.Width - 1, lbBorde.Height - 1);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
