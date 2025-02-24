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

namespace pruebas
{
    public partial class FrmAgregarJugadores : Form
    {
        csConexion conexion = new csConexion();
        public FrmAgregarJugadores()
        {
            InitializeComponent();
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

                    if (!vali(txtaltura))
                    {
                        conexion.Consulta("INSERT INTO Jugador (Nombres, Apellidos, Sexo, FechaNacimiento, Posicion, EquipoActual, Goles, Asistencias," +
        " Disponibilidad, PartidosJugados, Nacionalidad, Peso, Altura, PiernaHabil, ImagenJugador) " +
          $"VALUES ('{Txtnombre.Text}', '{txtapellido.Text}', '{cmbsexo.Text}', '{dtpNacimiento.Text}', '{CmbPosicion.Text}', {int.Parse(Cmbequipo.Text)}, {0}, {0}, {1}, {0}, " +
          $"'{TxtNacionalidad.Text}', {decimal.Parse(txtpeso.Text)}, {decimal.Parse(txtaltura.Text)}, '{cmbpierna.Text}', 'imangens')");
                    }
                    else MessageBox.Show("altura invalida");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        bool vali(TextBox txt)
        {
            for (int i = 0; i < txt.Text.Length; i++)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Close();
        }
    }
}
