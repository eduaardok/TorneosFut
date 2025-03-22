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
    public partial class AggEditPatrocinador: Form
    {
        bool N;
        string f;
        public AggEditPatrocinador(string u, string c, bool n)
        {
            bool N = n;
            InitializeComponent();

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AggEditPatrocinador_Load(object sender, EventArgs e)
        {
            panel2.Tag = "NoCambiar";
            panel1.Tag = "NoCambiar";
            panel3.Tag = "NoCambiar";
            panel4.Tag = "NoCambiar";
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
        }
    }
}
