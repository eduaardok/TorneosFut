using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TorneosFut
{
    public partial class AggTorneo : Form
    {
        csConexion conexion;
        static string id;
        static bool agg = true;
        csDatos csDatos;
        csDGV csDGV;
        public AggTorneo(bool a, string i, string u, string c)
        {
            conexion = new csConexion(u, c);
            agg = a;
            id = i;
            csDatos = new csDatos(u, c);
            csDGV = new csDGV(u, c);
            InitializeComponent();
        }
        void Editar()
        {
            if (!agg)
            {
                lblEncabezado.Text = "EDICIÓN DE TORNEO";
                cmbFormato.Enabled = false;
                cmbModoFutbol.Enabled = false;
                btngEnviar.Text = "EDITAR";
            }
        }
        private void AggTorneo_Load(object sender, EventArgs e)
        {
            panel2.Tag = "NoCambiar";
            panel1.Tag = "NoCambiar";
            panel3.Tag = "NoCambiar";
            panel4.Tag = "NoCambiar";
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            Editar();
            csDGV.llenarcmbOrganizador(cmbOrganizador);
            cmbOrganizador.SelectedIndex = -1;
            csDGV.llenarcmbFormato(cmbFormato);
            cmbFormato.SelectedIndex= -1;
            csDGV.llenarcmbModo(cmbModoFutbol);
            cmbModoFutbol.SelectedIndex = -1;
        }

        private void btngSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btngEnviar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Inhabilitado por el momento");
            if (!agg)
            {
                csDatos.EditarTorneo(id, txtNombre.Text, cmbFormato.SelectedValue.ToString(), cmbModoFutbol.SelectedValue.ToString(), cmbOrganizador.SelectedValue.ToString(), dtpInicio.Value.ToString());
            }
            else
            {
                csDatos.InsertarTorneo(txtNombre.Text, cmbFormato.SelectedValue.ToString(), cmbModoFutbol.SelectedValue.ToString(), cmbOrganizador.SelectedValue.ToString(), dtpInicio.Value.ToString());

            }
        }
    }
}
