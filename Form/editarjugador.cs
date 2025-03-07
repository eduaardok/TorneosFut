using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneosFut;
using TorneosFut.Class;

namespace pruebas
{
    public partial class editarjugador: Form
    {
        int ID;
        csConexion conexion;
        verjugadores f;
        csJugador jugadorr;
        public editarjugador(string id, verjugadores jugador, string u, string c)
        {
            jugadorr = new csJugador(u,c);
            conexion = new csConexion();
            conexion.Usuario = u;
            conexion.Clave = c;

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
            try
            {
                if (txtaltura.Text != "" && txtapellido.Text != "" && CmbPosicion.Text != "" && Cmbequipo.Text != "" && txtpeso.Text != "" && txtaltura.Text != "")
                {
                    if (!valinombres(Txtnombre) && !valinombres(txtapellido))
                    {
                        if (!validaaltu(txtaltura) && !validaaltu(txtpeso))
                        {
                            jugadorr.editarjugador(Txtnombre, txtapellido, CmbPosicion, Cmbequipo, txtpeso, txtaltura, ID);
                            txtaltura.Clear();
                            txtapellido.Clear();
                            txtpeso.Clear();
                            Txtnombre.Clear();
                            Cmbequipo.SelectedIndex = -1;
                            CmbPosicion.SelectedIndex = -1;
                            MessageBox.Show("Jugador editado con exito");
                            f.dgvJugador.DataSource = jugadorr.mostrarJugador();
                            Close();
                        }
                        else MessageBox.Show("Altura/Peso invalida");
                    }
                    else MessageBox.Show("Nombre/Apellido invalido, solo se permite letras");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        bool validaaltu(TextBox txt)
        {
            foreach (char c in txt.Text)
            {
                if (!char.IsDigit(c) && c != '.')
                {
                    return true;
                }
            }
            return false;
        }

        bool valinombres(TextBox txt)
        {
            foreach (char c in txt.Text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return true;
                }
            }
            return false;
        }

        private void btnEditarIMG_Click(object sender, EventArgs e)
        {

        }
    }
}
