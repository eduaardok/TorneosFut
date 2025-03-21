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
    public partial class AggEditOrganizador: Form
    {
        bool N;
        public AggEditOrganizador(string u, string c, bool n)
        {
            N = n;
            InitializeComponent();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AggEditOrganizador_Load(object sender, EventArgs e)
        {
            panel2.Tag = "NoCambiar";
            panel1.Tag = "NoCambiar";
            panel3.Tag = "NoCambiar";
            panel4.Tag = "NoCambiar";
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
        }
    }
}
