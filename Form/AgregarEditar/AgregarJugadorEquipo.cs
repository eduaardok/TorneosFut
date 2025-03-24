using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneosFut.Class;

namespace TorneosFut
{
    public partial class AgregarJugadorEquipo: Form
    {
        csDGV csDGV;
        csDatos csDatos;
        static string id;
        public AgregarJugadorEquipo(string u, string c, string i)
        {
            csDGV= new csDGV(u,c);
            id = i;
            csDatos = new csDatos(u, c);
            InitializeComponent();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            csDatos.InsertarJugadorEquipo(tblequiposizq.CurrentRow.Cells["IDJugador"].Value.ToString(), id, int.Parse(numDorsal.Value.ToString()));
            Actualizar();
            To.Text=tblequiposder.Rows.Count.ToString();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            csDatos.JugadorSinEquipo(tblequiposder.CurrentRow.Cells["IDJugador"].Value.ToString(), id);
            Actualizar();
            To.Text = tblequiposder.Rows.Count.ToString();
        }
        void Actualizar()
        {
            csDGV.MostrarJugadoresSinEquipo(tblequiposizq);
            csDGV.MostrarJugadoresEquipo(tblequiposder, id);
        }
        private void AgregarJugadorEquipo_Load(object sender, EventArgs e)
        {
            Actualizar();
            To.Text = tblequiposder.Rows.Count.ToString();
            panel2.Tag = "NoCambiar";
            panel1.Tag = "NoCambiar";
            panel3.Tag = "NoCambiar";
            panel4.Tag = "NoCambiar";
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
        }

        private void btngCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void btnguardar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
