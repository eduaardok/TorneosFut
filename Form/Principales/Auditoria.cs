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
    public partial class Auditoria: Form
    {
        csDGV csDGV;
        static bool n;
        public Auditoria(string u, string c)
        {
            csDGV = new csDGV(u, c);
            InitializeComponent();
        }

        private void Auditoria_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            csDGV.MostrarAuditoriaSesion(dgvAuditoria);
            csDGV.AdaptarDGV(dgvAuditoria);
            n=false;
        }

        private void btngMostrar_Click(object sender, EventArgs e)
        {
            csDGV.MostrarAuditoriaSesion(dgvAuditoria);
            csDGV.AdaptarDGV(dgvAuditoria);
            n=false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            csDGV.MostrarAuditoriaCambios(dgvAuditoria);
            csDGV.AdaptarDGV(dgvAuditoria);
            n = true;
        }

        private void txtFiltro_Click(object sender, EventArgs e)
        {
            
        }

        private void txtFiltro_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtFiltro.Text == "Buscar por nombre de Usuario")
            {
                txtFiltro.Text = "";
                txtFiltro.ForeColor = Color.Black;
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

         csDGV.MostrarAuditoriaFiltro(dgvAuditoria, n, txtFiltro.Text);
        }

        private void btngLimpiar_Click(object sender, EventArgs e)
        {
            txtFiltro.Clear();
        }

        private void dgvAuditoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
