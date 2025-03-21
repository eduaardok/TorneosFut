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
    public partial class GestionInscripcion: Form
    {
        public GestionInscripcion(string IDtorneo, string u, string c)
        {
            InitializeComponent();
        }

        private void btngSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
