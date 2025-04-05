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
    public partial class AggEditPatrocinador : Form
    {
        bool t;
        string f;
        string id;
        csDatos csDatos;
        Guna.UI2.WinForms.Guna2MessageDialog msg = new Guna.UI2.WinForms.Guna2MessageDialog();

        public AggEditPatrocinador(string u, string c, bool n, string ID)
        {
            csDatos = new csDatos(u, c);
            id = ID;
            InitializeComponent();
            t = n;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AggEditPatrocinador_Load(object sender, EventArgs e)
        {

            panel2.Tag = "NoCambiar";
            panel1.Tag = "NoCambiar";
            panel3.Tag = "NoCambiar";
            panel4.Tag = "NoCambiar";
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            msg.Buttons = MessageDialogButtons.OK;
            msg.Icon = MessageDialogIcon.Information;
            msg.Style = MessageDialogStyle.Light;
            msg.Parent = this;
            if (GlobalSettings.ModoOscuro)
            {
                msg.Style = MessageDialogStyle.Dark;

            }
            if (t == false)
            {
                lblEncabezado.Text = "EDITAR PATROCINADOR";
                btnAgregar.Text = "EDITAR";
                editar();
            }
        }
        void editar()
        {
            txtNombreEmpresa.Text = csDatos.NombrePatrocinador(id);
            txtNombreContacto.Text = csDatos.DescripcionPatrocinador(id);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (t == false)
            {
                if (csDatos.EditarPatrocinador(id, txtNombreEmpresa.Text, txtNombreContacto.Text, txtTelefono.Text))
                {
                    msg.Text = "Patrocinador Editado";
                    msg.Show();
                }
            }
            else if (csDatos.AgregarPatrocinador(id, txtNombreEmpresa.Text, txtNombreContacto.Text, txtTelefono.Text))
            {
                msg.Text = "Patrocinador Agregado";
                msg.Show();
            }
        }
    }
}
