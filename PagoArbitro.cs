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
    public partial class PagoArbitro: Form
    {
        InscripcionEquipo inscripcionEquipo;
        public PagoArbitro(string u, string c)
        {
            inscripcionEquipo = new InscripcionEquipo("", u, c, true);
            InitializeComponent();
        }
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            inscripcionEquipo.ShowDialog();
            Close();
        }
    }
}
