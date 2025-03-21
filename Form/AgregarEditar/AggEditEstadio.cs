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
    public partial class AggEditEstadio: Form
    {
        bool tt;
        public AggEditEstadio(string u, string c,bool t)
        {
          
            t = tt;
            InitializeComponent();
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AggEditEstadio_Load(object sender, EventArgs e)
        {
            panel2.Tag = "NoCambiar";
            panel1.Tag = "NoCambiar";
            panel3.Tag = "NoCambiar";
            panel4.Tag = "NoCambiar";
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            if (tt == false)
            {
                btnAgregar.Text = "EDITAR";
            }
            else
            {

            }
        }
    }
}
