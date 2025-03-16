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
        public AggTorneo(bool a, int i, string u, string c)
        {
            conexion = new csConexion(u, c);
            agg = a;
            id = i;
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
        }

        private void btngSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btngEnviar_Click(object sender, EventArgs e)
        {

        }
    }
}
