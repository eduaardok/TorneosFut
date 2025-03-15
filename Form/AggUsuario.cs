
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
    public partial class AggUsuario: Form
    {
        static bool agg = true;
        static int id;
        DataTable dt;
        csConexion conexion;
        csEncriptar encriptar;
        csUsuario csusuario;
        public AggUsuario(bool a, int i, string u, string c)
        {
            conexion = new csConexion();
            conexion.Usuario = u;
            conexion.Clave = c;
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
                string claveApp = encriptar.Encriptar(txtClaveApp.Text, "futxpert");
                string claveBD = encriptar.Encriptar(txtClaveBD.Text, "futxpert");
                if (agg)
                {
                    conexion.Consulta($"insert into Usuario " +
                    $"(Nombre, UsuarioApp, ClaveApp, Correo, UsuarioBD, ClaveBD) values ('{txtNombre.Text}','{txtUsuarioApp.Text}'," +
                    $"'{claveApp}', '{txtCorreo.Text + cmbCorreos.Text}', '{txtUsuarioBD.Text}', '{claveBD}')");
                    conexion.CrearLoginBD(txtUsuarioBD.Text, txtClaveBD.Text);
                    MessageBox.Show($"Usuario agregado");
                    this.Close();
                }
                else
                {
                   // dt = conexion.ListDGV($"select * from Administrador where IDAdmin= {id}");
                    conexion.Consulta($"update Administrador " +
                    $"set Nombre='{txtNombre.Text}', UsuarioApp= '{txtUsuarioApp.Text}',ClaveApp='{claveApp}', " +
                    $" Correo= '{txtCorreo.Text + cmbCorreos.Text}', UsuarioBD= '{txtUsuarioBD.Text}',ClaveBD='{claveBD}' where IDAdmin={id} ");
                   conexion.ActualizarLoginBD(txtUsuarioBD.Text, txtClaveBD.Text);
                    MessageBox.Show($"Usuario editado");
                    this.Close();
                }
            }
            else
            MessageBox.Show("Verifique los campos ingresados");
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            dt = new DataTable();
            encriptar = new csEncriptar();
            Editar();
        }
        void Editar()
        {
            if(!agg)
            {
                lblEncabezado.Text = "EDICIÓN DE USUARIO";
                txtUsuarioBD.ReadOnly = true;
                btngEnviar.Text = "EDITAR";
                dt = conexion.ListDGV($"select * from Administrador where IDAdmin= {id}");
                txtNombre.Text = dt.Rows[0][1].ToString();
                txtUsuarioApp.Text = dt.Rows[0][2].ToString();
                txtClaveApp.Text = encriptar.Desencriptar(dt.Rows[0][3].ToString(), "futxpert");
                if (dt.Rows[0][4].ToString().Contains('@'))
                {
                    string[] c = dt.Rows[0][4].ToString().Split('@');
                    txtCorreo.Text = c[0];
                    int index = cmbCorreos.Items.IndexOf("@" + c[1]);
                    if (index >= 0)
                        cmbCorreos.SelectedIndex = index; // Selecciona el dominio si está en la lista
                    else
                        cmbCorreos.SelectedIndex = -1; // Deja en blanco si no está en la lista
                }
                txtUsuarioBD.Text = dt.Rows[0][5].ToString();
                txtClaveBD.Text = encriptar.Desencriptar(dt.Rows[0][6].ToString(), "futxpert");

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
                if (!agg)
                    dt = conexion.ListDGV($"select * from Administrador where Nombre = '{txtNombre.Text}' and IDAdmin != {id}");
                else
                    dt = conexion.ListDGV($"select * from Administrador where Nombre = '{txtNombre.Text}'");
                if (dt.Rows.Count > 0)
                {
                    txtNombre.Text= txtNombre.Text+"1";
                }
            }
            if (txtUsuarioApp.Text.Length < 5) //esto para validar el usuario de app ingresado
            {
                lblaUsuarioApp.Text = "Longitud mínima: 5 caracteres";
                return false;
            }
            else
            {
                if (!agg)
                    dt = conexion.ListDGV($"select * from Administrador where UsuarioApp = '{txtUsuarioApp.Text}' and IDAdmin != {id}");
                else
                    dt = conexion.ListDGV($"select * from Administrador where UsuarioApp = '{txtUsuarioApp.Text}'");
                if (dt.Rows.Count > 0)
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
                if (!agg)
                    dt = conexion.ListDGV($"select * from Administrador where UsuarioBD = '{txtUsuarioBD.Text}' and IDAdmin != {id}");
                else
                    dt = conexion.ListDGV($"select * from Administrador where UsuarioBD = '{txtUsuarioBD.Text}'");
                if (dt.Rows.Count > 0)
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
                if (!agg)
                    dt = conexion.ListDGV($"select * from Administrador where Correo = '{txtCorreo.Text+cmbCorreos.Text}' and IDAdmin != {id}");
                else
                    dt = conexion.ListDGV($"select * from Administrador where Correo = '{txtCorreo.Text + cmbCorreos.Text}'");
                if (dt.Rows.Count > 0)
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

    }
}
