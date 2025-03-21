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
    public partial class Estadio: Form
    {
        csConexion conexion;
        public Estadio(string u, string c)
        {
            conexion = new csConexion(u,c);
            InitializeComponent();
        }

        private void Estadio_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AggEditEstadio agg= new AggEditEstadio(conexion.Usuario,conexion.Clave,false);
            agg.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AggEditEstadio agg = new AggEditEstadio(conexion.Usuario, conexion.Clave, true);
            agg.ShowDialog();
        
        }
    }
}
