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
            SubPanelTorneo.Visible = true;
            SubPanelEquipos.Visible = false;
            SubPanelJugadores.Visible = false;
            SubPanelArbitros.Visible = false;
            SubPanelEstadios.Visible = false;
            SubPanelReportes.Visible = false;
            SubPanelUsuarios.Visible = false;
            SubPanelCaja.Visible = false;

            btnTorneo.Visible = false;
            btnEquipos.Visible = true;
            btnJugadores.Visible = true;
            btnArbitros.Visible = true;
            btnEstadios.Visible = true;
            btnReportes.Visible = true;
            btnUsuarios.Visible = true;
            btnCaja.Visible = true;
        }

        private void btnTor_Click(object sender, EventArgs e)
        {
            btnTorneo.Visible = true;
            SubPanelTorneo.Visible = false;
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            btnEquipos.Visible = false;
            SubPanelTorneo.Visible = false;
            SubPanelEquipos.Visible = true;
            SubPanelJugadores.Visible = false;
            SubPanelArbitros.Visible = false;
            SubPanelEstadios.Visible = false;
            SubPanelReportes.Visible = false;
            SubPanelUsuarios.Visible = false;
            SubPanelCaja.Visible = false;

            btnTorneo.Visible = true;
            btnEquipos.Visible = false;
            btnJugadores.Visible = true;
            btnArbitros.Visible = true;
            btnEstadios.Visible = true;
            btnReportes.Visible = true;
            btnUsuarios.Visible = true;
            btnCaja.Visible = true;
        }

        private void btnEqui_Click(object sender, EventArgs e)
        {
            btnEquipos.Visible = true;
            SubPanelEquipos.Visible = false;
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            btnJugadores.Visible = false;
            SubPanelTorneo.Visible = false;
            SubPanelEquipos.Visible = false;
            SubPanelJugadores.Visible = true;
            SubPanelArbitros.Visible = false;
            SubPanelEstadios.Visible = false;
            SubPanelReportes.Visible = false;
            SubPanelUsuarios.Visible = false;
            SubPanelCaja.Visible = false;

            btnTorneo.Visible = true;
            btnEquipos.Visible = true;
            btnJugadores.Visible = false;
            btnArbitros.Visible = true;
            btnEstadios.Visible = true;
            btnReportes.Visible = true;
            btnUsuarios.Visible = true;
            btnCaja.Visible = true;
        }

        private void btnJug_Click(object sender, EventArgs e)
        {
            btnJugadores.Visible = true;
            SubPanelJugadores.Visible = false;
        }

        private void btnArbitros_Click(object sender, EventArgs e)
        {
            btnArbitros.Visible = false;
            SubPanelTorneo.Visible = false;
            SubPanelEquipos.Visible = false;
            SubPanelJugadores.Visible = false;
            SubPanelArbitros.Visible = true;
            SubPanelEstadios.Visible = false;
            SubPanelReportes.Visible = false;
            SubPanelUsuarios.Visible = false;
            SubPanelCaja.Visible = false;

            btnTorneo.Visible = true;
            btnEquipos.Visible = true;
            btnJugadores.Visible = true;
            btnArbitros.Visible = false;
            btnEstadios.Visible = true;
            btnReportes.Visible = true;
            btnUsuarios.Visible = true;
            btnCaja.Visible = true;
        }

        private void btnArb_Click(object sender, EventArgs e)
        {
            btnArbitros.Visible = true;
            SubPanelArbitros.Visible = false;
        }

        private void btnEstadios_Click(object sender, EventArgs e)
        {
            btnEstadios.Visible = false;
            SubPanelTorneo.Visible = false;
            SubPanelEquipos.Visible = false;
            SubPanelJugadores.Visible = false;
            SubPanelArbitros.Visible = false;
            SubPanelEstadios.Visible = true;
            SubPanelReportes.Visible = false;
            SubPanelUsuarios.Visible = false;
            SubPanelCaja.Visible = false;

            btnTorneo.Visible = true;
            btnEquipos.Visible = true;
            btnJugadores.Visible = true;
            btnArbitros.Visible = true;
            btnEstadios.Visible = false;
            btnReportes.Visible = true;
            btnUsuarios.Visible = true;
            btnCaja.Visible = true;
        }

        private void btnEst_Click(object sender, EventArgs e)
        {
            btnEstadios.Visible = true;
            SubPanelEstadios.Visible = false;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            btnReportes.Visible = false;
            SubPanelTorneo.Visible = false;
            SubPanelEquipos.Visible = false;
            SubPanelJugadores.Visible = false;
            SubPanelArbitros.Visible = false;
            SubPanelEstadios.Visible = false;
            SubPanelReportes.Visible = true;
            SubPanelUsuarios.Visible = false;
            SubPanelCaja.Visible = false;

            btnTorneo.Visible = true;
            btnEquipos.Visible = true;
            btnJugadores.Visible = true;
            btnArbitros.Visible = true;
            btnEstadios.Visible = true;
            btnReportes.Visible = false;
            btnUsuarios.Visible = true;
            btnCaja.Visible = true;
        }

        private void btnRep_Click(object sender, EventArgs e)
        {
            btnReportes.Visible = true;
            SubPanelReportes.Visible = false;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            btnUsuarios.Visible = false;
            SubPanelTorneo.Visible = false;
            SubPanelEquipos.Visible = false;
            SubPanelJugadores.Visible = false;
            SubPanelArbitros.Visible = false;
            SubPanelEstadios.Visible = false;
            SubPanelReportes.Visible = false;
            SubPanelUsuarios.Visible = true;
            SubPanelCaja.Visible = false;

            btnTorneo.Visible = true;
            btnEquipos.Visible = true;
            btnJugadores.Visible = true;
            btnArbitros.Visible = true;
            btnEstadios.Visible = true;
            btnReportes.Visible = true;
            btnUsuarios.Visible = false;
            btnCaja.Visible = true;
        }

        private void btnUsu_Click(object sender, EventArgs e)
        {
            btnUsuarios.Visible = true;
            SubPanelUsuarios.Visible = false;
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            btnCaja.Visible = false;
            SubPanelTorneo.Visible = false;
            SubPanelEquipos.Visible = false;
            SubPanelJugadores.Visible = false;
            SubPanelArbitros.Visible = false;
            SubPanelEstadios.Visible = false;
            SubPanelReportes.Visible = false;
            SubPanelUsuarios.Visible = false;
            SubPanelCaja.Visible = true;

            btnTorneo.Visible = true;
            btnEquipos.Visible = true;
            btnJugadores.Visible = true;
            btnArbitros.Visible = true;
            btnEstadios.Visible = true;
            btnReportes.Visible = true;
            btnUsuarios.Visible = true;
            btnCaja.Visible = false;
        }

        private void btnCj_Click(object sender, EventArgs e)
        {
            btnCaja.Visible = true;
            SubPanelCaja.Visible = false;
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            btnCaja.Visible = false;
            SubPanelTorneo.Visible = false;
            SubPanelEquipos.Visible = false;
            SubPanelJugadores.Visible = false;
            SubPanelArbitros.Visible = false;
            SubPanelEstadios.Visible = false;
            SubPanelReportes.Visible = false;
            SubPanelUsuarios.Visible = false;
            SubPanelCaja.Visible = false;

            btnTorneo.Visible = true;
            btnEquipos.Visible = true;
            btnJugadores.Visible = true;
            btnArbitros.Visible = true;
            btnEstadios.Visible = true;
            btnReportes.Visible = true;
            btnUsuarios.Visible = true;
            btnCaja.Visible = true;
        }
    }
}
