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
    public partial class AgregarJugadores : Form
    {
        csConexion conexion = new csConexion();
        verjugadores ve;
        csJugador jugador= new csJugador();
        public AgregarJugadores(verjugadores f)
        {
            InitializeComponent();
            ve= f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cmbequipo.DataSource = conexion.ListDGV("select* from Equipo");
            Cmbequipo.ValueMember = "IDEquipo";
            Cmbequipo.DisplayMember = "NombreClub";
            Cmbequipo.SelectedIndex = -1;
        }

        private void lblPosicion_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtaltura.Text != "" && txtapellido.Text != "" && cmbsexo.Text != "" && dtpNacimiento.Text != "" && CmbPosicion.Text != "" && Cmbequipo.Text != "" && TxtNacionalidad.Text != "" && txtpeso.Text != "" && txtaltura.Text != "" && cmbpierna.Text != "")
                {
                    if (!valinombres(Txtnombre) && !valinombres(txtapellido))
                    {
                        if (!validaaltu(txtaltura) && !validaaltu(txtpeso))
                        {
                            jugador.agregarJugador(Txtnombre,txtapellido,cmbsexo,dtpNacimiento,CmbPosicion, Cmbequipo,TxtNacionalidad,txtpeso,txtaltura,cmbpierna);
                            txtaltura.Clear();
                            txtapellido.Clear();
                            txtpeso.Clear();
                            TxtNacionalidad.Clear();
                            Txtnombre.Clear();
                            cmbpierna.SelectedIndex = -1;
                            cmbsexo.SelectedIndex = -1;
                            Cmbequipo.SelectedIndex = -1;
                            CmbPosicion.SelectedIndex = -1;
                            MessageBox.Show("Jugador agregado con exito");
                            ve.dgvJugador.DataSource = jugador.mostrarJugador();

                        }
                        else MessageBox.Show("altura invalida");
                    }
                    else MessageBox.Show("Nombre invalido, solo se permite letras");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        bool validaaltu(TextBox txt)
        {
            for (int i = 1; i < txt.Text.Length; i++)
            {
                for (int j = 46; j < 58; j++)
                {
                    if (txt.Text[i] != j )
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
