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
    public partial class Equipos: Form
    {
        csConexion conexion = new csConexion();
        public Equipos()
        {
            InitializeComponent();
            dgvEquipos.DataSource = conexion.ListDGV("Select * from Equipo");
            AdaptarDGV();
        }
        void AdaptarDGV()
        {
            int filas, columnas;
            filas = dgvEquipos.RowCount;
            columnas = dgvEquipos.ColumnCount;
            for (int i = 0; i < filas; i++)
            {
                dgvEquipos.Rows[i].Height = dgvEquipos.Height / filas;
            }
            for (int i = 0; i < columnas; i++)
            {
                dgvEquipos.Columns[i].Width = dgvEquipos.Width / columnas;
            }
            dgvEquipos.DataSource = conexion.ListDGV("Select * from Equipo");
        }
    }
}
