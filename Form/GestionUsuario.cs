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
        public GestionUsuario(string u,string c) 
        {
            conexion = new csConexion();
            conexion.Usuario = u;
            conexion.Clave = c;
            InitializeComponent();
            ActualizarTabla();
        }
        private void GestionUsuario_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            dgvUsuarios.DataSource = conexion.ListDGV("Select * from Usuario");
            AdaptarDGV();

        }
        void ActualizarTabla()
        {
            if(mostrarClave)
            dgvUsuarios.DataSource = conexion.ListDGV($"Select * from Usuario where IDUsuario like '%{txtFiltro.Text}%' or Nombres like '%{txtFiltro.Text}%'" +
                                    $" or NombreUsuario like '%{txtFiltro.Text}%' or NombreUsuarioBD like '%{txtFiltro.Text}%'");
            else
                dgvUsuarios.DataSource = conexion.ListDGV($"Select IDUsuario, Nombres, NombreUsuario, Correo, NombreUsuarioBD from Usuario where IDUsuario like '%{txtFiltro.Text}%' or Nombres like '%{txtFiltro.Text}%'" +
                                    $" or NombreUsuario like '%{txtFiltro.Text}%' or NombreUsuarioBD like '%{txtFiltro.Text}%'");
            AdaptarDGV();
        }
        void AdaptarDGV()
        {
            dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#14191D");
            dgvUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            //ActualizarTabla();
            dgvUsuarios.Width = panelDgv.Width;
            dgvUsuarios.Height = panelDgv.Height;

            int filas, columnas;
            filas = dgvUsuarios.RowCount;
            columnas = dgvUsuarios.ColumnCount;
            dgvUsuarios.ColumnHeadersHeight = 50;//dgvUsuarios.Height / (1+filas);
            for (int i = 0; i < filas; i++)
            {
                dgvUsuarios.Rows[i].Height = 60;//dgvUsuarios.Height / (1+filas);
            }
            for (int i = 0; i < columnas; i++)
            {
                dgvUsuarios.Columns[i].Width = dgvUsuarios.Width / columnas;
            }
        }

        private void dgvUsuarios_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AdaptarDGV();
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
                    int id = int.Parse(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[0].Value.ToString());
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
            AdaptarDGV();
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
