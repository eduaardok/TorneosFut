﻿using pruebas;
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
using Usuarios;

namespace TorneosFut
{
    public partial class Torneo: Form
    {
        csConexion conexion;
        Patrocinadores patro;
        Organizadores orga;
        GestionarPartidos partidos;
        InscripcionEquipo inscripcion;
        Principal T;
        csDGV csDGV;
        Arbitro arbi;
        string IDTorneo;
        string IDPartido;

        public Torneo(string u, string c, Principal r)
        {
            conexion = new csConexion(u,c);
            InitializeComponent();
            patro = new Patrocinadores(u,c);
            orga = new Organizadores(u,c);
            csDGV= new csDGV(u ,c);
            arbi = new Arbitro(u,c);
            T = r;

        }
        public static void AbrirFormEnPanel(Panel panel, Form formHijo)
        {
            if (panel.Controls.Count > 0)
                panel.Controls.Clear(); // Limpia cualquier contenido previo

            formHijo.TopLevel = false;  // Indica que no es un formulario independiente
            formHijo.Dock = DockStyle.Fill; // Ajusta al tamaño del panel
            panel.Controls.Add(formHijo); // Agrega el formulario al panel
            panel.Tag = formHijo; // Asocia el formulario con el panel
            formHijo.BringToFront(); // Lo trae al frente
            formHijo.Show(); // Muestra el formulario dentro del panel
            panel.Show();
        }
        private void btnJugadores_Click(object sender, EventArgs e)
        {
               AbrirFormEnPanel(panelmodul, patro);
        }

        private void btnArbitros_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(panelmodul, arbi);
        }

        private void btnEstadios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(panelmodul,orga);
        }

        private void Torneo_Load(object sender, EventArgs e)
        {
            panelmodul.Hide();
            csDGV.MostrarTorneo(dgvTorneo);
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelmodul.Hide();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int id = -1;
            AggTorneo a = new AggTorneo(true, id, conexion.Usuario, conexion.Clave);
            //AbrirFormEnPanel(panelDgv, a);
            a.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = 1;
            AggTorneo a = new AggTorneo(false, id, conexion.Usuario, conexion.Clave);
            //AbrirFormEnPanel(panelDgv, a);
            a.ShowDialog();
        }

        private void btnPartidos_Click(object sender, EventArgs e)
        {
            partidos = new GestionarPartidos(IDTorneo,conexion.Usuario, conexion.Clave,this,T);
            panelmodul.Show();
            T.Hide();
            partidos.ShowDialog();
        }
        private void btnInscripcionEquipos_Click(object sender, EventArgs e)
        {
            inscripcion = new InscripcionEquipo(IDTorneo, conexion.Usuario, conexion.Clave, true);
            //panelmodul.Show();
            //T.Hide();
            inscripcion.ShowDialog();
        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            AggTorneo aggTorneo = new AggTorneo(true, 1, conexion.Usuario, conexion.Clave);
            aggTorneo.ShowDialog();
            
        }

        private void dgvTorneo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTorneo.CurrentRow != null && dgvTorneo.CurrentRow.Index >= 0)
            {
                IDTorneo = dgvTorneo.Rows[dgvTorneo.CurrentRow.Index].Cells[0].Value.ToString();
            }
        }

        private void txtBuscarTorneo_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBuscarTorneo.Text == "Buscar por nombre del Torneo")
            {
                txtBuscarTorneo.Text = "";
                txtBuscarTorneo.ForeColor = Color.Black;
            }
        }

        private void txtBuscarTorneo_TextChanged(object sender, EventArgs e)
        {
            csDGV.MostrarTorneoFiltro(dgvTorneo,  txtBuscarTorneo.Text);
        }
    }
}
