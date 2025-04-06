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
    public partial class AgregarJugadorEquipo: Form
    {
        csDGV csDGV;
        csDatos csDatos;
        static string id;
        Guna.UI2.WinForms.Guna2MessageDialog msg = new Guna.UI2.WinForms.Guna2MessageDialog();
        public AgregarJugadorEquipo(string u, string c, string i)
        {
            csDGV= new csDGV(u,c);
            id = i;
            csDatos = new csDatos(u, c);
            InitializeComponent();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            csDatos.InsertarJugadorEquipo(tblequiposizq.CurrentRow.Cells["IDJugador"].Value.ToString(), id, int.Parse(numDorsal.Value.ToString()));
            Actualizar();
            To.Text=tblequiposder.Rows.Count.ToString();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            csDatos.JugadorSinEquipo(tblequiposder.CurrentRow.Cells["IDJugador"].Value.ToString(), id);
            Actualizar();
            To.Text = tblequiposder.Rows.Count.ToString();
        }
        void Actualizar()
        {
            csDGV.MostrarJugadoresSinEquipo(tblequiposizq);
            csDGV.MostrarJugadoresEquipo(tblequiposder, id);
        }
        private void AgregarJugadorEquipo_Load(object sender, EventArgs e)
        {

            Actualizar();
            To.Text = tblequiposder.Rows.Count.ToString();
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
            if (GlobalSettings.ModoOscuro)
            {
                msg.Style = MessageDialogStyle.Dark;

            }
        }

        private void btngCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void btnguardar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
