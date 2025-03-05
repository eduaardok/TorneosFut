using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneosFut;

namespace PruebasTorneos
{
    public partial class Padre: Form
    {
        csConexion conexion;
        public Padre(string u, string c)
        {
            conexion = new csConexion();
            conexion.Usuario = u;
            conexion.Clave = c;
            InitializeComponent();
            frmEntrenadores dt = new frmEntrenadores(conexion.Usuario, conexion.Clave);
            addForm(dt);
        }
        private void btnVerDT_Click_1(object sender, EventArgs e)
        {
            frmEntrenadores dt = new frmEntrenadores(conexion.Usuario, conexion.Clave);
            addForm(dt);
        }
        private void addForm(Form form)
        {
            panelContenedor.Controls.Clear();

            form.TopLevel = false;


            panelContenedor.Controls.Add(form);
            form.Show();
        }

        private void Padre_Load(object sender, EventArgs e)
        {

        }

        private void btnAggDT_Click(object sender, EventArgs e)
        {
            frmAggEntrenador agg = new frmAggEntrenador(conexion.Usuario, conexion.Clave);
            addForm(agg); 
        }
    }
}
