using Guna.UI2.WinForms;
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
        Guna.UI2.WinForms.Guna2MessageDialog msg = new Guna.UI2.WinForms.Guna2MessageDialog();
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
                    msg.Text = "Formato agregado correctamente";
                    msg.Caption = "Correcto";
                    msg.Icon = MessageDialogIcon.Information;
                    msg.Show();
                    Close();
                }
                else
                {
                    msg.Text = "Error al agregar el formato";
                    msg.Caption = "Error";
                    msg.Icon = MessageDialogIcon.Error;
                    msg.Show();
                }
            }
        }
        bool validarCamposVacios()
        {
            if (txtNombre.Text.Length < 1)
            {
                msg.Text = "Debe ingresar un nombre para el formato";
                msg.Caption = "Error";
                msg.Icon = MessageDialogIcon.Error;
                msg.Show();
                return false;
            }
            if (cmbIdaVuelta.SelectedIndex < 0)
            {
                msg.Text = "Debe seleccionar si el formato es de ida y vuelta";
                msg.Caption = "Error";
                msg.Icon = MessageDialogIcon.Error;
                msg.Show();

                return false;
            }
            if (cmbIdaVueltaPlayoff.SelectedIndex < 0)
            {
                msg.Text = "Debe seleccionar si el formato es de ida y vuelta en playoff";
                msg.Caption = "Error";
                msg.Icon = MessageDialogIcon.Error;
                msg.Show();

                return false;
            }
            if (cmbPlayoff.SelectedIndex < 0)
            {
                msg.Text = "Debe seleccionar si el formato es de playoff";
                msg.Caption = "Error";
                msg.Icon = MessageDialogIcon.Error;
                msg.Show();
                return false;
            }
            if (numGrupos.Value == numEquipos.Value || numEquipos.Value < numGrupos.Value)
            {
                msg.Text = "El número de grupos no puede ser mayor o igual al número de equipos";
                msg.Caption = "Error";
                msg.Icon = MessageDialogIcon.Error;
                msg.Show();
                numGrupos.Value = 1;
                return false;
            }
            if (numEquipos.Value % 2 != 0)
            {
                msg.Text = "El número de equipos debe ser par";
                msg.Caption = "Error";
                msg.Icon = MessageDialogIcon.Error;
                msg.Show();
                numEquipos.Value = 2;
                return false;
            }
            if (cmbPlayoff.Text == "Final" && numGrupos.Value > 2)
            {
                msg.Text = "El formato de playoff final solo puede tener máximo 2 grupos";
                msg.Caption = "Error";
                msg.Icon = MessageDialogIcon.Error;
                msg.Show();
                cmbPlayoff.SelectedIndex = -1;
                return false;
            }
            if (cmbPlayoff.Text == "Semifinal" && numGrupos.Value > 4)
            {
                msg.Text = "El formato de playoff semifinal solo puede tener máximo 4 grupos";
                msg.Caption = "Error";
                msg.Icon = MessageDialogIcon.Error;
                msg.Show();
                cmbPlayoff.SelectedIndex = -1;
                return false;
            }
            if (cmbPlayoff.Text == "Cuartos de final" && numGrupos.Value > 8)
            {
                msg.Text = "El formato de playoff cuartos de final solo puede tener máximo 8 grupos";
                msg.Caption = "Error";
                msg.Icon = MessageDialogIcon.Error;
                msg.Show();
                cmbPlayoff.SelectedIndex = -1;
                return false;
            }
            if (cmbPlayoff.Text == "Octavos de final" && numGrupos.Value > 16)
            {
                msg.Text = "El formato de playoff octavos de final solo puede tener máximo 16 grupos";
                msg.Caption = "Error";
                msg.Icon = MessageDialogIcon.Error;
                msg.Show();
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

        private void AggFormato_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            if (!GlobalSettings.ModoOscuro)
            {
                panel1.BackColor = Color.FromArgb(251, 3, 140);
                panel2.BackColor = Color.FromArgb(251, 3, 140);
                panel3.BackColor = Color.FromArgb(251, 3, 140);
                panel4.BackColor = Color.FromArgb(251, 3, 140);
            }
            msg.Buttons = MessageDialogButtons.OK;
            msg.Icon = MessageDialogIcon.Information;
            msg.Style = MessageDialogStyle.Light;
            msg.Parent = this;
            if (GlobalSettings.ModoOscuro)
            {
                msg.Style = MessageDialogStyle.Dark;

            }
        }
    }
}
