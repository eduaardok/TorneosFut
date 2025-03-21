using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneosFut.Class;

namespace TorneosFut
{
    public partial class AggEditArbitro: Form
    {
        bool N;
        public AggEditArbitro(string u, string c, bool n)
        {
            N = n;
            InitializeComponent();
        }

        private void btngCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AggEditArbitro_Load(object sender, EventArgs e)
        {
            panel2.Tag = "NoCambiar";
            panel1.Tag = "NoCambiar";
            panel3.Tag = "NoCambiar";
            panel4.Tag = "NoCambiar";
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            if (!N)
            {
                lblEncabezado.Text = "EDITAR ARBITRO";
                btnGuardar.Text = "EDITAR";
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
