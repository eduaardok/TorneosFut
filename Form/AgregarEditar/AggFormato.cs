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
    public partial class AggFormato : Form
    {
        csConexion csConexion;
        public AggFormato(string u, string c)
        {
            csConexion = new csConexion(u, c);
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validarCamposVacios())
            {
                int clasificados = 0;
                if (cmbPlayoff.Text == "Final")
                {
                    clasificados = 2;
                }
                else if (cmbPlayoff.Text == "Semifinal")
                {
                    clasificados = 4;
                }
                else if (cmbPlayoff.Text == "Cuartos de final")
                {
                    clasificados = 8;
                }
                else if (cmbPlayoff.Text == "Octavos de final")
                {
                    clasificados = 16;
                }
                else if (cmbPlayoff.Text == "No")
                {
                    clasificados = 0;
                }
                int idaVuelta = cmbIdaVuelta.Text == "Si" ? 1 : 0;
                int idaVueltaPlayoff = cmbIdaVueltaPlayoff.Text == "Si" ? 1 : 0;
                int rondasPlayoff = 0;
                if (cmbPlayoff.Text == "Final")
                {
                    rondasPlayoff = 1;
                }
                else if (cmbPlayoff.Text == "Semifinal")
                {
                    rondasPlayoff = 2;
                }
                else if (cmbPlayoff.Text == "Cuartos de final")
                {
                    rondasPlayoff = 3;
                }
                else if (cmbPlayoff.Text == "Octavos de final")
                {
                    rondasPlayoff = 4;
                }

                if (csConexion.Consulta("INSERT INTO FORMATO (NombreFormato, IdaVueltaGrupos, IdaVueltaPlayoff, RondasPlayoff, CantidadGrupos, CantidadEquipos) VALUES" +
                     " ('" + txtNombre.Text + "', " + idaVuelta + ", " + idaVueltaPlayoff + ", " + rondasPlayoff + ", " + Convert.ToInt32(numGrupos.Value) + ", " + Convert.ToInt32(numEquipos.Value) + ")"))
                {
                    MessageBox.Show("Formato agregado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar el formato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        bool validarCamposVacios()
        {
            if (txtNombre.Text.Length < 1)
            {
                MessageBox.Show("Debe ingresar un nombre para el formato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbIdaVuelta.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar si el formato es de ida y vuelta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbIdaVueltaPlayoff.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar si el formato es de ida y vuelta en playoff", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbPlayoff.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar si el formato es de playoff", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (numGrupos.Value == numEquipos.Value || numEquipos.Value < numGrupos.Value)
            {
                MessageBox.Show("El número de grupos no puede ser mayor o igual al número de equipos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numGrupos.Value = 1;
                return false;
            }
            if (numEquipos.Value % 2 != 0)
            {
                MessageBox.Show("El número de equipos debe ser par", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numEquipos.Value = 2;
                return false;
            }
            if (cmbPlayoff.Text == "Final" && numGrupos.Value > 2)
            {
                MessageBox.Show("El formato de playoff final solo puede tener máximo 2 grupos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPlayoff.SelectedIndex = -1;
                return false;
            }
            if (cmbPlayoff.Text == "Semifinal" && numGrupos.Value > 4)
            {
                MessageBox.Show("El formato de playoff semifinal solo puede tener máximo 4 grupos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPlayoff.SelectedIndex = -1;
                return false;
            }
            if (cmbPlayoff.Text == "Cuartos de final" && numGrupos.Value > 8)
            {
                MessageBox.Show("El formato de playoff cuartos de final solo puede tener máximo 8 grupos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPlayoff.SelectedIndex = -1;
                return false;
            }
            if (cmbPlayoff.Text == "Octavos de final" && numGrupos.Value > 16)
            {
                MessageBox.Show("El formato de playoff octavos de final solo puede tener máximo 16 grupos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPlayoff.SelectedIndex = -1;
                return false;
            }


            return true;
        }
        private void AjustarGrupos()
        {
            if (cmbPlayoff.Text == "Final")
            {
                numGrupos.Value = Math.Min(2, numEquipos.Value / 2);
            }
            else if (cmbPlayoff.Text == "Semifinal")
            {
                numGrupos.Value = Math.Min(4, numEquipos.Value / 2);
            }
            else if (cmbPlayoff.Text == "Cuartos de final")
            {
                numGrupos.Value = Math.Min(8, numEquipos.Value / 2);
            }
            else if (cmbPlayoff.Text == "Octavos de final")
            {
                numGrupos.Value = Math.Min(16, numEquipos.Value / 2);
            }
            else if (cmbPlayoff.Text == "No")
            {
                numGrupos.Value = 1;
            }
        }

        private void cmbPlayoff_SelectedIndexChanged(object sender, EventArgs e)
        {
            AjustarGrupos();

        }

        private void cmbIdaVueltaPlayoff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numGrupos_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numEquipos_ValueChanged(object sender, EventArgs e)
        {
            AjustarGrupos();

        }
    }
}
