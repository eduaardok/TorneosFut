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
    public partial class FrmUsuarios: Form
    {
        csConexion conexion = new csConexion();
        public FrmUsuarios()
        {
            InitializeComponent();
            dgvUsuarios.DataSource = conexion.ListDGV("Select * from Administrador");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void AdaptarDGV()
        {
            //EN PROCESO
            //dgvUsuarios.Width = this.Width;
            //dgvUsuarios.Height = this.Height;

            int filas, columnas;
            filas = dgvUsuarios.RowCount;
            columnas = dgvUsuarios.ColumnCount;
            for (int i = 0; i < filas; i++)
            {
                dgvUsuarios.Rows[i].Height = dgvUsuarios.Height / filas;
            }
            for (int i = 0; i < columnas; i++)
            {
                dgvUsuarios.Columns[i].Width = dgvUsuarios.Width / columnas;
            }
            dgvUsuarios.DataSource = conexion.ListDGV("Select * from Administrador");
        }
        private void btnEditarClave_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.RowCount > 0)
            {
                if (dgvUsuarios.CurrentRow.Index >= 0)
                {
                    string id= dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[0].Value.ToString();
                    FrmEditarClave ed = new FrmEditarClave(id);
                    ed.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Seleccione el usuario que desea editar");
                }
            }
            else
            {
                MessageBox.Show("La tabla está vacía");
            }
            AdaptarDGV();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            AdaptarDGV();
        }

        private void btnEditarCorreo_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.RowCount > 0)
            {
                if (dgvUsuarios.CurrentRow.Index >= 0)
                {
                    string id = dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[0].Value.ToString();
                    FrmEditarCorreo ed = new FrmEditarCorreo(id);
                    ed.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Seleccione el usuario que desea editar");
                }
            }
            else
            {
                MessageBox.Show("La tabla está vacía");
            }
            AdaptarDGV();
        }
    }
}
