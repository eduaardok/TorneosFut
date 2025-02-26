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

namespace pruebas
{
    public partial class editarjugador: Form
    {
        int ID;
        csConexion conexion = new csConexion();
        verjugadores f;
        public editarjugador(string id, verjugadores jugador)
        {
            InitializeComponent();
            ID = int.Parse(id);
            f = jugador;
        }

        private void editarjugador_Load(object sender, EventArgs e)
        {

            dgvDatos.DataSource = conexion.ListDGV($"Select* from Jugador where IDJugador={ID}");
            Txtnombre.Text = dgvDatos.Rows[0].Cells[1].Value.ToString();  
            txtapellido.Text= dgvDatos.Rows[0].Cells[2].Value.ToString();
            txtpeso.Text= dgvDatos.Rows[0].Cells[12].Value.ToString();
            txtaltura.Text= dgvDatos.Rows[0].Cells[13].Value.ToString();
            Cmbequipo.DataSource= conexion.ListDGV($"Select* from Equipo ");
            CmbPosicion.Text = dgvDatos.Rows[0].Cells[5].Value.ToString();
            Cmbequipo.DisplayMember = "NombreClub";
            Cmbequipo.ValueMember = "IDEquipo";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtaltura.Text != "" && txtapellido.Text != "" && CmbPosicion.Text != "" && Cmbequipo.Text != "" && txtpeso.Text != "" && txtaltura.Text != "")
            {
                if (!valinombres(Txtnombre) && !valinombres(txtapellido))
                {
                    if (!validaaltu(txtaltura) && !validaaltu(txtpeso))
                    {
                        conexion.Consulta($"UPDATE Jugador set Nombres='{Txtnombre.Text}', Apellidos='{txtapellido.Text}'" +
                            $",Posicion='{CmbPosicion.Text}', EquipoActual={int.Parse(Cmbequipo.SelectedValue.ToString())}, Peso={decimal.Parse(txtpeso.Text)}, Altura= {decimal.Parse(txtaltura.Text)}  where IDJugador={ID}");
                        txtaltura.Clear();
                        txtapellido.Clear();
                        txtpeso.Clear();
                        Txtnombre.Clear();
                        Cmbequipo.SelectedIndex = -1;
                        CmbPosicion.SelectedIndex = -1;
                        MessageBox.Show("Jugador editado con exito");
                        f.dgvJugador.DataSource = conexion.ListDGV("Select* from Jugador");
                        Close();
                    }
                    else MessageBox.Show("altura invalida");
                }
                else MessageBox.Show("Nombre invalido, solo se permite letras");
            }
        }
        bool validaaltu(TextBox txt)
        {
            for (int i = 1; i < txt.Text.Length; i++)
            {
                for (int j = 46; j < 58; j++)
                {
                    if (txt.Text[i] != j)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        bool valinombres(TextBox txt)
        {
            for (int i = 1; i < txt.Text.Length; i++)
            {
                for (int j = 97; j < 123; j++)
                {
                    if (txt.Text[i] != j)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
