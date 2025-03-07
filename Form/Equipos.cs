using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneosFut.BotonesEquipos;

namespace TorneosFut
{
    public partial class Equipos: Form
    {
        csConexion conexion ;
        AgregarEquipo aggEquipo;
        public Equipos(string u, string c)
        {
            conexion = new csConexion();
            conexion.Usuario = u;
            conexion.Clave = c;
            InitializeComponent();
            UC_MisEquipos uc = new UC_MisEquipos(conexion.Usuario, conexion.Clave);
            addUserControl(uc);
        }
        private void addUserControl(UserControl userControll)
        {
            userControll.Dock = DockStyle.Fill;
            panelequiposs.Controls.Clear();
            panelequiposs.Controls.Add(userControll);
            userControll.BringToFront();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            UC_TodosEquipos uc = new UC_TodosEquipos(conexion.Usuario, conexion.Clave);
            addUserControl(uc);
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            UC_MisEquipos uc = new UC_MisEquipos(conexion.Usuario, conexion.Clave);
            addUserControl(uc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aggEquipo = new AgregarEquipo(conexion.Usuario, conexion.Clave);
            aggEquipo.lblEntregarVisi(false, true);
            aggEquipo.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
