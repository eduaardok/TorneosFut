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
    public partial class frmCalendarioGeneral : Form
    {
        string idtorneo;
        public frmCalendarioGeneral(string IDTorneo)
        {
            InitializeComponent();
            this.idtorneo = IDTorneo;
        }

        private void frmCalendarioGeneral_Load(object sender, EventArgs e)
        {
            CargarDatos(idtorneo);
            this.rvwCalendarioGen.RefreshReport();
        }
        void CargarDatos(string IDTorneo)
        {
            DataTable dt = new DataTable();
            csConexion oconSQL = new csConexion();
            //ReportDataSource dataset = new ReportDataSource();
            ReportDataSource dataset = new ReportDataSource();
            rvwCalendarioGen.LocalReport.DataSources.Clear();
            dt = oconSQL.ListDGV($@"select EquipoLocal, EquipoVisitante, Fecha, EstadoPartido from Partido where IDTorneo = {IDTorneo}"); //Esto de aqui lo cambias por tu consulta


            string reportPath = Path.Combine(Application.StartupPath, "rptCalendarioGeneral.rdlc");
            //rvwTablaPos.LocalReport.ReportPath = "rptPosiciones.rdlc"; // Esto por el nombre de tu reporte
            if (File.Exists(reportPath))
            {
                rvwCalendarioGen.LocalReport.ReportPath = reportPath;
            }
            else
            {
                MessageBox.Show("No se encontró el archivo " + reportPath);
                return;
            }

            try
            {
                dataset = new ReportDataSource("dsCGeneral", dt); // aqui por el nombre de tus datos, los que le pasas al formulario
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            rvwCalendarioGen.LocalReport.DataSources.Add(dataset); // eso de rvwDatos le cambias por el nombre del report viewer que le hayas puesto
            dataset.Value = dt;
            rvwCalendarioGen.LocalReport.Refresh();
            this.rvwCalendarioGen.RefreshReport();
        }
    }
}
