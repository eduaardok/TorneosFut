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
    public partial class EditarJugador: Form
    {

        csConexion conexion= new csConexion();
        int ID;
        public EditarJugador(string id)
        {
            InitializeComponent();
            ID=int.Parse(id);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
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
                                        $"EquipoActual = {int.Parse(Cmbequipo.SelectedValue.ToString())}, " +
                                        $"Peso = {double.Parse(txtpeso.Text)}, " +
                                        $"Altura = {double.Parse(txtaltura.Text)} " +
                                        $"WHERE IDJugador = {ID}");

                        MessageBox.Show("Editado correctamente");
                        Close();
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

        private void EditarJugador_Load(object sender, EventArgs e)
        {
           
        }
    }
}
