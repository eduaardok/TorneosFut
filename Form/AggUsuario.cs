
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
                    $"(IDUsuario, Nombres, NombreUsuario, ClaveUsuario, Correo, NombreUsuarioBD, ClaveBD) values ({IDNoRepetido()},'{txtNombre.Text}','{txtUsuarioApp.Text}'," +
                    $"'{claveApp}', '{txtCorreo.Text + cmbCorreos.Text}', '{txtUsuarioBD.Text}', '{claveBD}')");
                    conexion.CrearLoginBD(txtUsuarioBD.Text, txtClaveBD.Text);
                    MessageBox.Show($"Usuario agregado");
                    this.Close();
                }
                else
                {
                    // dt = conexion.ListDGV($"select * from Administrador where IDAdmin= {id}");
                    conexion.Consulta($"update Usuario " +
                    $"set Nombres='{txtNombre.Text}', NombreUsuario= '{txtUsuarioApp.Text}',ClaveUsuario='{claveApp}', " +
                    $" Correo= '{txtCorreo.Text + cmbCorreos.Text}', NombreUsuarioBD= '{txtUsuarioBD.Text}',ClaveBD='{claveBD}' where IDUsuario={id} ");
                    conexion.ActualizarLoginBD(txtUsuarioBD.Text, txtClaveBD.Text);
                    MessageBox.Show($"Usuario editado");

                    this.Close();
                }

            }
            else
                MessageBox.Show("Verifique los campos ingresados");
        }
        public int IDNoRepetido()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            int idnuevo;
            DataTable dt = conexion.ListDGV("Select IDUsuario from Usuario");
            bool idExiste = false;
            do
            {
                idnuevo = rnd.Next(1, 100);

                foreach (DataRow row in dt.Rows)
                {
                    if (row["IDUsuario"] != DBNull.Value && Convert.ToInt32(row["IDUsuario"]) == idnuevo)
                    {
                        idExiste = true;
                        break;
                    }
                }
                if (!idExiste)
                    break;

            } while (idExiste);
            return idnuevo;
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
                dt = conexion.ListDGV($"select * from Usuario where IDUsuario= {id}");
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
                    dt = conexion.ListDGV($"select * from Usuario where Nombres = '{txtNombre.Text}' and IDUsuario != {id}");
                else
                    dt = conexion.ListDGV($"select * from Usuario where Nombres = '{txtNombre.Text}'");
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
                    dt = conexion.ListDGV($"select * from Usuario where NombreUsuario = '{txtUsuarioApp.Text}' and IDUsuario != {id}");
                else
                    dt = conexion.ListDGV($"select * from Usuario where NombreUsuario = '{txtUsuarioApp.Text}'");
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
                    dt = conexion.ListDGV($"select * from Usuario where NombreUsuarioBD = '{txtUsuarioBD.Text}' and IDUsuario != {id}");
                else
                    dt = conexion.ListDGV($"select * from Usuario where NombreUsuarioBD = '{txtUsuarioBD.Text}'");
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
                    dt = conexion.ListDGV($"select * from Usuario where Correo = '{txtCorreo.Text+cmbCorreos.Text}' and IDUsuario != {id}");
                else
                    dt = conexion.ListDGV($"select * from Usuario where Correo = '{txtCorreo.Text + cmbCorreos.Text}'");
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
