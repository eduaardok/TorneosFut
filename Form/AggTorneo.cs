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
    public partial class AggTorneo : Form
    {
        csConexion conexion;
        static int id;
        static bool agg = true;
        csDatos csDatos;
        csDGV csDGV;
        public AggTorneo(bool a, int i, string u, string c)
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
            Editar();
            csDGV.llenarcmbOrganizador(cmbOrganizador);
            cmbOrganizador.SelectedIndex = -1;
            csDGV.llenarcmbFormato(cmbFormato);
            cmbFormato.SelectedIndex= -1;
        }

        private void btngSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int GenerarIDRandom()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            return rnd.Next(0, 100);
        }
        private void btngEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inhabilitado por el momento");
            //csDatos.InsertarTorneo(GenerarIDRandom(), txtNombre.Text, cmbFormato.SelectedValue.ToString(), cmbModoFutbol.SelectedValue.ToString(), id, cmbOrganizador.SelectedValue.ToString(), dtpInicio.Value.ToString()) ;
        }
    }
}
