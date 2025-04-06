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
            CargarDatos(idtorneo, idequipo);
            this.rvwCalendarioClub.RefreshReport();
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
