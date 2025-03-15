﻿using System;
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
    public partial class GestionUsuario: Form
    {
        static bool mostrarClave = false;
        csConexion conexion;
        csDGV csDGV;
        csDatos csDatos;
        public GestionUsuario(string u,string c) 
        {
            conexion = new csConexion(u,c);
            csDGV = new csDGV(u, c);
            csDatos = new csDatos(u, c);
            InitializeComponent();
            ActualizarTabla();
        }
        private void GestionUsuario_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            csDGV.MostrarUsuarios(dgvUsuarios);
            csDGV.AdaptarDGV(dgvUsuarios, panelDgv);

        }
        void ActualizarTabla()
        {
            csDGV.MostrarUsuariosFiltro(dgvUsuarios, mostrarClave, txtFiltro.Text);
            csDGV.AdaptarDGV(dgvUsuarios, panelDgv);
        }
        
        private void dgvUsuarios_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            csDGV.AdaptarDGV(dgvUsuarios, panelDgv);
        }

        private void btngCrear_Click(object sender, EventArgs e)
        {
            AggUsuario a = new AggUsuario(true, -1, conexion.Usuario, conexion.Clave);
            //AbrirFormEnPanel(panelDgv, a);
            a.ShowDialog();

        }

        private void btngEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.RowCount > 0)
            {
                if (dgvUsuarios.CurrentRow.Index >= 0)
                {
                    int id = csDatos.ObtenerIDUsuario(dgvUsuarios);
                    AggUsuario a = new AggUsuario(false, id, conexion.Usuario, conexion.Clave);
                    //AbrirFormEnPanel(panelDgv, a);
                    a.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Seleccione el usuario que desea editar");
                }
            }
            else
            {
                MessageBox.Show("La tabla está vacía");
            }
            csDGV.AdaptarDGV(dgvUsuarios, panelDgv);
        }

        private void btngLimpiar_Click(object sender, EventArgs e)
        {
            txtFiltro.Text = "";
            btngLimpiar.Checked = false;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void btngMostrar_Click(object sender, EventArgs e)
        {
            if (txtFiltro.Text == "Buscar por nombre de Usuario")
                txtFiltro.Text = "";
            if (btngMostrar.Text == "OCULTAR CLAVE")
            {
                btngMostrar.Text = "MOSTRAR CLAVE";
                mostrarClave = false;
                ActualizarTabla();
            }
            else
            {
                btngMostrar.Text = "OCULTAR CLAVE";
                mostrarClave = true;
                ActualizarTabla();
            }
        }

        private void txtFiltro_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtFiltro.Text == "Buscar por nombre de Usuario")
            {
                txtFiltro.Text = "";
                txtFiltro.ForeColor = Color.Black;
            }
        }
    }
}
