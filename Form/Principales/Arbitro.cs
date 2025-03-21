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
      
        csConexion csConexion;
        public Arbitro(string u, string c)
        {
            PagoArbitro = new PagoArbitro(u, c);
            csConexion = new csConexion(u,c);
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AggEditArbitro AggEditArbitro = new AggEditArbitro(csConexion.Usuario,csConexion.Clave,true);
            AggEditArbitro.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AggEditArbitro AggEditArbitro = new AggEditArbitro(csConexion.Usuario, csConexion.Clave, true);
            AggEditArbitro.ShowDialog();
        }
    }
}
