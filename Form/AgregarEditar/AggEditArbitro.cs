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
using TorneosFut.Class;

namespace TorneosFut
{
    public partial class AggEditArbitro: Form
    {
        bool N;
        csDatos csDatos;
        string ID;
        Guna.UI2.WinForms.Guna2MessageDialog msg = new Guna.UI2.WinForms.Guna2MessageDialog();
        public AggEditArbitro(string u, string c, bool n, string id)
        {
            N = n;
            ID = id;
            csDatos= new csDatos(u,c);
            InitializeComponent();
        }

        private void btngCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AggEditArbitro_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            if (!GlobalSettings.ModoOscuro)
            {
                panel1.BackColor = Color.FromArgb(251, 3, 140);
                panel2.BackColor = Color.FromArgb(251, 3, 140);
                panel3.BackColor = Color.FromArgb(251, 3, 140);
                panel4.BackColor = Color.FromArgb(251, 3, 140);
            }
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
                lblEncabezado.Text = "EDITAR ARBITRO";
                btnGuardar.Text = "EDITAR";
                txtNombre.Text = csDatos.NombreArbitro(ID);
                txtApellido.Text=csDatos.apellidoArbitro(ID);
                txtCorreo.Text = csDatos.CorreoArbitro(ID);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!N)
            {
                if(csDatos.EditarArbitro(ID, txtNombre.Text, txtApellido.Text, txtCorreo.Text))
                {
                    msg.Text = "Se Edito Correctamente";
                    msg.Parent = this;
                    msg.Show();
                }
            }
            else if(csDatos.AgregarArbitro("", txtNombre.Text, txtApellido.Text, txtCorreo.Text))
            {
                msg.Text = "Se Agrego Correctamente";
                msg.Parent = this;
                msg.Show();
            }
        }
    }
}
