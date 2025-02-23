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
    public partial class Usuarios: Form
    {
        csConexion conexion = new csConexion();
        public Usuarios()
        {
            InitializeComponent();
            dgvUsuarios.DataSource = conexion.ListDGV("Select * from Administrador");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
