using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorneosFut
{
    public partial class frmCalendarioEE : Form
    {
        string idtorneo, idequipo;
        public frmCalendarioEE(string IDTorneo, string IDEquipo)
        {
            InitializeComponent();
            this.idtorneo = IDTorneo;
            this.idequipo = IDEquipo;
        }

        private void frmCalendarioEE_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            if (!GlobalSettings.ModoOscuro)
            {
                panel1.BackColor = Color.FromArgb(251, 3, 140);
                panel2.BackColor = Color.FromArgb(251, 3, 140);
                panel3.BackColor = Color.FromArgb(251, 3, 140);
                panel4.BackColor = Color.FromArgb(251, 3, 140);
            }
            CargarDatos(idtorneo, idequipo);
            this.rvwCalendarioClub.RefreshReport();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Verifica si el botón izquierdo del mouse está presionado
            {
                // Mueve el formulario a la nueva posición
                this.Location = new Point(
                    this.Location.X + e.X - (panel1.Width / 2),
                    this.Location.Y + e.Y - (panel1.Height / 2));
            }
        }

        void CargarDatos(string IDTorneo, String IDEquipo)
        {
            DataTable dt = new DataTable();
            csConexion oconSQL = new csConexion();
            //ReportDataSource dataset = new ReportDataSource();
            ReportDataSource dataset = new ReportDataSource();
            rvwCalendarioClub.LocalReport.DataSources.Clear();
            dt = oconSQL.ListDGV($@"select EquipoLocal, EquipoVisitante, Fecha, EstadoPartido from Partido where (EquipoLocal = '{IDEquipo}' or EquipoVisitante = '{IDEquipo}') and IDTorneo = {IDTorneo}"); //Esto de aqui lo cambias por tu consulta
            string reportPath = Path.Combine(Application.StartupPath, "rptCalendarioEspecifico.rdlc");
            //rvwTablaPos.LocalReport.ReportPath = "rptPosiciones.rdlc"; // Esto por el nombre de tu reporte
            if (File.Exists(reportPath))
            {
                rvwCalendarioClub.LocalReport.ReportPath = reportPath;
            }
            else
            {
                MessageBox.Show("No se encontró el archivo " + reportPath);
                return;
            }

            try
            {
                dataset = new ReportDataSource("dsCEspecifico", dt); // aqui por el nombre de tus datos, los que le pasas al formulario
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            rvwCalendarioClub.LocalReport.DataSources.Add(dataset); // eso de rvwDatos le cambias por el nombre del report viewer que le hayas puesto
            dataset.Value = dt;
            rvwCalendarioClub.LocalReport.Refresh();
            this.rvwCalendarioClub.RefreshReport();
        }
    }
}
