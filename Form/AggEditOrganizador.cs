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
        public AggEditOrganizador()
        {
            InitializeComponent();
        }

        private void lbBorde_Paint(object sender, PaintEventArgs e)
        {
            lbBorde.BackColor = Color.Transparent;
            using (Pen pen = new Pen(ColorTranslator.FromHtml("#FB038C"), 3))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, lbBorde.Width - 1, lbBorde.Height - 1);
            } 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AggEditOrganizador_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
        }
    }
}
