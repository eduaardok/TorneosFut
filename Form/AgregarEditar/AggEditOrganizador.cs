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
    public partial class AggEditOrganizador: Form
    {
        bool N;
        string ID;
        csDatos csDatos;
        Guna.UI2.WinForms.Guna2MessageDialog msg = new Guna.UI2.WinForms.Guna2MessageDialog();
        public AggEditOrganizador(string Id,string u, string c, bool n)
        {
            N = n;
            ID = Id;
            csDatos=new csDatos(u, c);
            InitializeComponent();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AggEditOrganizador_Load(object sender, EventArgs e)
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
            if (!N)
            {
                btnAgregar.Text = "EDITAR";
                lblEncabezado.Text = "EDITAR ORGANIZADOR";
                txtCorreo.Text = csDatos.CorreoOrganizador(ID);
                txtNombreOrganizador.Text=csDatos.NombreOrganizador(ID);
                txtTelefono.Text = csDatos.TelefonoOrganizador(ID);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (btnAgregar.Text == "EDITAR")
            {
                if (csDatos.EditarOrganizador(ID,txtNombreOrganizador.Text, txtTelefono.Text, txtCorreo.Text ))
                {
                    msg.Text = "Organizador Editado";
                    msg.Show();
                }
            }
            else if (csDatos.AgreegarOrganizador(txtNombreOrganizador.Text, txtTelefono.Text, txtCorreo.Text))
            {
                msg.Text = "Organizador Agregado";
                msg.Show();
            }
        }
    }
}
