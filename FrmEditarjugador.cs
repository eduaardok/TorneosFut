using System;
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
    public partial class FrmEditarjugador: Form
    {
        csConexion conexion = new csConexion();
        int ID;
        public FrmEditarjugador(string id)
        {
            InitializeComponent();
            ID = int.Parse(id);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtaltura.Text != "" && txtapellido.Text != "" && CmbPosicion.Text != "" &&
         Cmbequipo.Text != "" && txtpeso.Text != "" && txtaltura.Text != "")
                {
                    if (!vali(txtaltura))
                    {
                        conexion.Consulta("UPDATE Jugador SET " +
                                        $"Nombres = '{Txtnombre.Text}', " +
                                        $"Apellidos = '{txtapellido.Text}', " +
                                        $"Posicion = '{CmbPosicion.Text}', " +
                                        $"EquipoActual = {int.Parse(Cmbequipo.Text)}, " +
                                        $"Peso = {decimal.Parse(txtpeso.Text)}, " +
                                        $"Altura = {decimal.Parse(txtaltura.Text)} " +
                                        $"WHERE IDJugador = {ID}");
                    }
                    else
                    {
                        MessageBox.Show("Altura inválida");
                    }
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

        private void FrmEditarjugador_Load(object sender, EventArgs e)
        {
           dgv.DataSource=conexion.ListDGV($"select * from Jugador where IDJugador={ID}");
            Txtnombre.Text = dgv.Rows[0].Cells[1].Value.ToString();
            txtapellido.Text= dgv.Rows[0].Cells[2].Value.ToString();
            txtaltura.Text= dgv.Rows[0].Cells[13].Value.ToString();
            txtpeso.Text= dgv.Rows[0].Cells[12].Value.ToString();
                 Cmbequipo.DataSource = conexion.ListDGV("select* from Equipo");
            Cmbequipo.ValueMember = "IDEquipo";
            Cmbequipo.DisplayMember = "NombreClub";
            Cmbequipo.SelectedIndex = -1;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
