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
        public AgregarJugadorEquipo(string u, string c)
        {
            csDGV= new csDGV(u,c);
            InitializeComponent();
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            //// Verificar si hay una fila seleccionada en el DataGridView izquierdo
            //if (tblequiposizq.CurrentCell != null && tblequiposizq.CurrentCell.RowIndex >= 0)
            //{
            //    // Obtener la fila seleccionada
            //    int rowIndex = tblequiposizq.CurrentCell.RowIndex;
            //    DataGridViewRow filaSeleccionada = tblequiposizq.Rows[rowIndex];

            //    // Agregar la fila al DataGridView derecho
            //    tblequiposder.Rows.Add(filaSeleccionada.Cells[0].Value, filaSeleccionada.Cells[1].Value);

            //    // Eliminar la fila del DataGridView izquierdo
            //    tblequiposizq.Rows.RemoveAt(rowIndex);
            //}
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            //// Verificar si hay una fila seleccionada en el DataGridView derecho
            //if (tblequiposder.CurrentCell != null && tblequiposder.CurrentCell.RowIndex >= 0)
            //{
            //    // Obtener la fila seleccionada
            //    int rowIndex = tblequiposder.CurrentCell.RowIndex;
            //    DataGridViewRow filaSeleccionada = tblequiposder.Rows[rowIndex];

            //    // Agregar la fila al DataGridView izquierdo
            //    tblequiposizq.Rows.Add(filaSeleccionada.Cells[0].Value, filaSeleccionada.Cells[1].Value);

            //    // Eliminar la fila del DataGridView derecho
            //    tblequiposder.Rows.RemoveAt(rowIndex);
            //}



        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

        }

        private void AgregarJugadorEquipo_Load(object sender, EventArgs e)
        {
             csDGV.MostrarJugadoresE(tblequiposizq);
            csDGV.MostrarJugadoresEquipo(tblequiposder);
            tblequiposizq.Columns["IDJugador"].Visible=false;
        }
    }
}
