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
    public partial class AgregarEquipo: Form
    {
        csConexion conexion;
        public AgregarEquipo(string u, string c)
        {
            conexion = new csConexion();
            conexion.Usuario = u;
            conexion.Clave = c;
            InitializeComponent();
            cmbEntrenador.DataSource = conexion.ListDGV("select* from Entrenador");
            cmbEntrenador.ValueMember = "IDEntrenador";
            cmbEntrenador.DisplayMember = "Nombres";
            cmbEstadio.DataSource = conexion.ListDGV("select* from Estadio");
            cmbEstadio.ValueMember = "IDEstadio";
            cmbEstadio.DisplayMember = "Nombre";
        }
        public void lblEntregarVisi(bool visble, bool novisble)
        {
            lblEditarEqui.Visible = visble;
            lblAggEquipo.Visible = novisble;
            btnEditar.Visible = visble;
            btnAgregar.Visible = novisble;
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (txtNombreClub.Text != "" && txtPresidente.Text != "" && cmbEntrenador.Text != "" && cmbEstadio.Text != "" && cmbGenero.Text != "")
                {
                    conexion.Consulta($"insert into Equipo values ('{txtNombreClub.Text}', '{txtPresidente.Text}', '{cmbGenero.Text}', {int.Parse(cmbEstadio.SelectedValue.ToString())} , {int.Parse(cmbEntrenador.SelectedValue.ToString())})");

                    MessageBox.Show("Se agrego correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblBodr2_Paint(object sender, PaintEventArgs e)
        {
            lblBodr2.BackColor = Color.Transparent;
            using (Pen pen = new Pen(ColorTranslator.FromHtml("#FB038C"), 3))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, lblBodr2.Width - 1, lblBodr2.Height - 1);
            }
        }

        private void lblBorde1_Paint(object sender, PaintEventArgs e)
        {
            lblBorde1.BackColor = Color.Transparent;
            using (Pen pen = new Pen(ColorTranslator.FromHtml("#FB038C"), 3))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, lblBorde1.Width - 1, lblBorde1.Height - 1);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblBorde1.Paint += lblBorde1_Paint;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lblBodr2.Paint += lblBodr2_Paint;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreClub.Text != "" && txtPresidente.Text != "" && cmbEntrenador.Text != "" && cmbEstadio.Text != "" && cmbGenero.Text != "")
                {
                    conexion.Consulta($"UPDATE Equipo SET NombreClub = '{txtNombreClub.Text}', Presidente = '{txtPresidente.Text}', Genero = '{cmbGenero.Text}', IDEstadio = {int.Parse(cmbEstadio.SelectedValue.ToString())}, IDEntrenador = {int.Parse(cmbEntrenador.SelectedValue.ToString())}" +
                                      $"WHERE IDEquipo = {int.Parse(txtId.Text)}");

                    MessageBox.Show("Se editó correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error" + ex.ToString());
            }
        }

        private void lblBorde1_Click(object sender, EventArgs e)
        {

        }
    }
}
