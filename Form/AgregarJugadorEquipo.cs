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
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            csDatos.JugadorSinEquipo(tblequiposder.CurrentRow.Cells["IDJugador"].Value.ToString(), id);
            Actualizar();
        }
        //private void btnquitar_Click(object sender, EventArgs e)
        //{
        //    // Verificar si hay una fila seleccionada en el DataGridView derecho
        //    //if (tblequiposder.CurrentCell != null && tblequiposder.CurrentCell.RowIndex >= 0)
        //    //{
        //    //    // Obtener la fila seleccionada
        //    //    int rowIndex = tblequiposder.CurrentCell.RowIndex;
        //    //    DataGridViewRow filaSeleccionada = tblequiposder.Rows[rowIndex];

        //    //    // Agregar la fila al DataGridView izquierdo
        //    //    tblequiposizq.Rows.Add(filaSeleccionada.Cells[0].Value, filaSeleccionada.Cells[1].Value);

        //    //    // Eliminar la fila del DataGridView derecho
        //    //    tblequiposder.Rows.RemoveAt(rowIndex);
        //    //}
        //    csDatos.JugadorSinEquipo(tblequiposder.CurrentRow.Cells["IDJugador"].Value.ToString(), id);
        //    Actualizar();

        //}

        //private void btnagregar_Click(object sender, EventArgs e)
        //{
        //    //// Verificar si hay una fila seleccionada en el DataGridView izquierdo
        //    //if (tblequiposizq.CurrentCell != null && tblequiposizq.CurrentCell.RowIndex >= 0)
        //    //{
        //    //    // Obtener la fila seleccionada
        //    //    int rowIndex = tblequiposizq.CurrentCell.RowIndex;
        //    //    DataGridViewRow filaSeleccionada = tblequiposizq.Rows[rowIndex];

        //    //    // Agregar la fila al DataGridView derecho
        //    //    tblequiposder.Rows.Add(filaSeleccionada.Cells[0].Value, filaSeleccionada.Cells[1].Value);

        //    //    // Eliminar la fila del DataGridView izquierdo
        //    //    tblequiposizq.Rows.RemoveAt(rowIndex);
        //    //}

        //    csDatos.InsertarJugadorEquipo(tblequiposizq.CurrentRow.Cells["IDJugador"].Value.ToString(), id, int.Parse(numDorsal.Value.ToString()));
        //    Actualizar();
        //}
        void Actualizar()
        {
            csDGV.MostrarJugadoresSinEquipo(tblequiposizq);
            csDGV.MostrarJugadoresEquipo(tblequiposder, id);
        }
        private void AgregarJugadorEquipo_Load(object sender, EventArgs e)
        {
            Actualizar();
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            //tblequiposizq.Columns["IDJugador"].Visible=false;
        }

        private void btngCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbBorde_Paint(object sender, PaintEventArgs e)
        {
            lbBorde.BackColor = Color.Transparent;
            using (Pen pen = new Pen(ColorTranslator.FromHtml("#FB038C"), 3))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, lbBorde.Width - 1, lbBorde.Height - 1);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
