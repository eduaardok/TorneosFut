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
    public partial class EditarHorarios : Form
    {
        static string dia, mes, anio, hora, minuto, estadio;
        csConexion csConex;
        int id;
        public EditarHorarios(string iD, string u, string c)
        {
            csConex = new csConexion(u, c);
            id = int.Parse(iD);
            InitializeComponent();
        }

        private void txthora_TextChanged(object sender, EventArgs e)
        {
            hora = txthora.Text;
        }

        private void txtminuto_Click(object sender, EventArgs e)
        {
            minuto = txthora.Text;
        }

        private void cmbEstadio_SelectedIndexChanged(object sender, EventArgs e)
        {
            estadio = cmbEstadio.SelectedValue.ToString();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            dia = dtpFecha.Value.Day.ToString();
            mes = dtpFecha.Value.Month.ToString();
            anio = dtpFecha.Value.Year.ToString();
        }

        void EstablecerFecha(int id)
        {
            DataTable dataTable = new DataTable();
            //dataTable = csConex.ListDGV($"select Hora from Partido where IDPartido = {id}");
            dataTable = csConex.ListDGV($"select Fecha from Partido where IDPartido = {id}");
            dtpFecha.Value = Convert.ToDateTime(dataTable.Rows[0][0]);
            dia = dtpFecha.Value.Day.ToString();
            mes = dtpFecha.Value.Month.ToString();
            anio = dtpFecha.Value.Year.ToString();
            dataTable = csConex.ListDGV($"select Hora from Partido where IDPartido = {id}");
            TimeSpan horaPartido = (TimeSpan)dataTable.Rows[0][0];
            txthora.Text = horaPartido.Hours.ToString();
            hora = txthora.Text;
            txtminuto.Text = horaPartido.Minutes.ToString();
            minuto = txtminuto.Text;
            //  return Convert.ToDateTime( dataTable.Rows[0][0].ToString());
        }
        private void EditarHorarios_Load(object sender, EventArgs e)
        {
            cmbEstadio.DataSource = csConex.ListDGV("select IDEstadio, NombreEstadio, Ubicacion from Estadio");
            cmbEstadio.ValueMember = "IDEstadio";
            cmbEstadio.DisplayMember = "NombreEstadio";
            EstablecerFecha(id);

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (!ValidarHora()) return;
            if (!ValidarMinuto()) return;
            int h = int.Parse(txthora.Text);
            int m = int.Parse(txtminuto.Text);

            string fecha = dtpFecha.Value.ToString("yyyy-MM-dd");
            string horaSQL = $"{h:D2}:{m:D2}:00";

            if (csConex.Consulta($"UPDATE Partido SET Fecha = '{fecha}', Hora = '{horaSQL}', IDEstadio = {estadio} WHERE IDPartido = {id}"))
            {
                MessageBox.Show("Partido editado correctamente");
                this.Close();
            }
        }
        private bool ValidarHora()
        {
            if (!int.TryParse(txthora.Text, out int h))
            {
                MessageBox.Show("La hora debe ser un número entero.");
                return false;
            }

            if (h < 0 || h > 23)
            {
                MessageBox.Show("La hora debe estar entre 0 y 23.");
                return false;
            }

            return true;
        }
        private bool ValidarMinuto()
        {
            if (!int.TryParse(txtminuto.Text, out int m))
            {
                MessageBox.Show("Los minutos deben ser un número entero.");
                return false;
            }

            if (m < 0 || m > 59)
            {
                MessageBox.Show("Los minutos deben estar entre 0 y 59.");
                return false;
            }

            return true;
        }
    }
}
