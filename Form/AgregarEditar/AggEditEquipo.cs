﻿using System;
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
    public partial class AggEditEquipo : Form
    {
        csConexion conexion;
        OpenFileDialog img = new OpenFileDialog();
        static bool agregar;
        csDatos csDatos;
        csDGV csDGV;
        static string nombreArchivo = "";
        public AggEditEquipo(string u, string c, bool n)
        {
            conexion = new csConexion(u, c);
            csDatos = new csDatos(u, c);
            agregar = n;
            csDGV = new csDGV(u, c);
            InitializeComponent();
        }
        public void lblEntregarVisi(bool visble, bool novisble)
        {
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (CamposVacios())
            {
                try
                {
                    if (agregar)
                    {

                        if (csDatos.InsertarEquipo(txtId.Text, cmbEstadio.SelectedValue.ToString(), txtNombreClub.Text, cmbGenero.Text, cmbEquipacionLocal.Text, cmbequipacionvisitante.Text, nombreArchivo, txtPresidente.Text, img.FileName))
                        {
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Equipo no Agregado");
                        }
                    }
                    else
                    {
                        if (csDatos.EditarEquipo(txtId.Text, cmbEstadio.SelectedValue.ToString(), txtNombreClub.Text, cmbGenero.Text, cmbEquipacionLocal.Text, cmbequipacionvisitante.Text, nombreArchivo, txtPresidente.Text, img.FileName))
                        {
                            MessageBox.Show("Equipo Editado Correctamente");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Equipo no editado");
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Datos invalidos");
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        bool CamposVacios()
        {
            if (txtId.Text == "" || cmbEstadio.Text == "" || txtNombreClub.Text == "" || cmbGenero.Text == "" || cmbEquipacionLocal.Text == "" || cmbequipacionvisitante.Text == "" || txtPresidente.Text == "")
            {
                MessageBox.Show("Faltan datos por llenar");
                return false;
            }
            else return true;
        }
        private void AggEquipo_Load(object sender, EventArgs e)
        {
            panel2.Tag = "NoCambiar";
            panel1.Tag = "NoCambiar";
            panel3.Tag = "NoCambiar";
            panel4.Tag = "NoCambiar";
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            csDGV.LlenarcmbEstadio(cmbEstadio);
            if (!agregar)
            {
                txtId.Enabled = false;
                cmbGenero.Enabled = false;
                lblEncabezado.Text = "EDITAR EQUIPO";
                btnAgregar.Text = "EDITAR";
            }
        }
        public string ObtenerNombreArchivo()
        {
            string nombreIMG = "Imagen" + DateTime.Now.Ticks.ToString();
            return nombreIMG;
        }

        private void btnSeleccionarIMG_Click(object sender, EventArgs e)
        {

            img.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;";
            img.Title = "Selecciona una imagen";
            if (img.ShowDialog() == DialogResult.OK)
            {
                ptbImagen.Image = Image.FromFile(img.FileName);
                nombreArchivo = ObtenerNombreArchivo();
            }
        }
    }
}