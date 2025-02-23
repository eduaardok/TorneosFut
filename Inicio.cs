using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorneosFut
{
    public partial class Inicio: Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnTorneo_Click(object sender, EventArgs e)
        {
            btnTorneo.Visible = false;
            SubPanelTorneo.Visible = true;
        }

        private void btnTor_Click(object sender, EventArgs e)
        {
            btnTorneo.Visible = true;
            SubPanelTorneo.Visible = false;
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            btnEquipos.Visible = false;
            SubPanelEquipos.Visible = true;
        }

        private void btnEqui_Click(object sender, EventArgs e)
        {
            btnEquipos.Visible = true;
            SubPanelEquipos.Visible = false;
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            btnJugadores.Visible = false;
            SubPanelJugadores.Visible = true;
        }

        private void btnJug_Click(object sender, EventArgs e)
        {
            btnJugadores.Visible = true;
            SubPanelJugadores.Visible = false;
        }

        private void btnArbitros_Click(object sender, EventArgs e)
        {
            btnArbitros.Visible = false;
            SubPanelArbitros.Visible = true;
        }

        private void btnArb_Click(object sender, EventArgs e)
        {
            btnArbitros.Visible = true;
            SubPanelArbitros.Visible = false;
        }

        private void btnEstadios_Click(object sender, EventArgs e)
        {
            btnEstadios.Visible = false;
            SubPanelEstadios.Visible = true;
        }

        private void btnEst_Click(object sender, EventArgs e)
        {
            btnEstadios.Visible = true;
            SubPanelEstadios.Visible = false;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            btnReportes.Visible = false;
            SubPanelReportes.Visible = true;
        }

        private void btnRep_Click(object sender, EventArgs e)
        {
            btnReportes.Visible = true;
            SubPanelReportes.Visible = false;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            btnUsuarios.Visible = false;
            SubPanelUsuarios.Visible = true;
        }

        private void btnUsu_Click(object sender, EventArgs e)
        {
            btnUsuarios.Visible = true;
            SubPanelUsuarios.Visible = false;
        }

    }
}
