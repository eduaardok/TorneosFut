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
    
    public partial class Arbitro: Form
    {
        PagoArbitro PagoArbitro;
        public Arbitro(string u, string c)
        {
            PagoArbitro = new PagoArbitro(u, c);
            InitializeComponent();
        }

        private void Arbitro_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
        }

        private void btnPagoArbitro_Click(object sender, EventArgs e)
        {
            PagoArbitro.ShowDialog();
        }
    }
}
