﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebasTorneos
{
    public partial class frmEntrenadores: Form
    {
        csConexion conec = new csConexion(); 
        csEntrenador dt = new csEntrenador();
        public frmEntrenadores()
        {
            InitializeComponent();
        }

        private void frmEntrenadores_Load(object sender, EventArgs e)
        {
            dt.Cargar(dgvEntrenador);
            dgvEntrenador.CellFormatting += dgvEntrenador_CellFormatting;
        }

        private void dgvEntrenador_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvEntrenador.Columns[e.ColumnIndex].Name == "PartidosGanados")
            {
                e.CellStyle.ForeColor = Color.Green;
            } 
            if (dgvEntrenador.Columns[e.ColumnIndex].Name == "PartidosEmpatados")
            {
                e.CellStyle.ForeColor = Color.Orange;
            } 
            if (dgvEntrenador.Columns[e.ColumnIndex].Name == "PartidosPerdidos")
            {
                e.CellStyle.ForeColor = Color.Red;
            }
            if (dgvEntrenador.Columns[e.ColumnIndex].Name == "Sexo" && e.Value != null)
            {
                string valor = e.Value.ToString().Trim().ToLower();
                if (valor == "masculino")
                {
                    e.CellStyle.ForeColor = Color.Blue;
                }
                else if (valor == "femenino")
                {
                    e.CellStyle.ForeColor = Color.Magenta;
                }
            }
        }
        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            dt.filtro(txtBuscar.Text.Trim(), dgvEntrenador);
        }

        private void dgvEntrenador_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvEntrenador.Rows.Count == 0 || dgvEntrenador.SelectedRows.Count == 0)
                    return;

                int fila = dgvEntrenador.SelectedRows[0].Index;
                string celda = dgvEntrenador.Rows[fila].Cells["IDEntrenador"].Value.ToString();

                string consulta = $"SELECT ImagenEntrenador FROM Entrenador WHERE IDEntrenador = {celda}";

                byte[] imagenBytes = conec.ObtenerImagen(consulta);

                if (imagenBytes != null && imagenBytes.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imagenBytes))
                    {
                        ptbIMG.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    ptbIMG.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditarDT edit = new frmEditarDT();
            edit.Show();
        }
    }
}
