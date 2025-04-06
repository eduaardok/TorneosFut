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
    public partial class frmListaDeJugadores : Form
    {
        string idequipo;
        public frmListaDeJugadores(string IDEquipo)
        {
            InitializeComponent();
            this.idequipo = IDEquipo;
        }

        private void frmListaDeJugadores_Load(object sender, EventArgs e)
        {
            CargarDatos(idequipo);
            this.rvwListaEqu.RefreshReport();
        }
        void CargarDatos(string IDEquipo)
        {
            DataTable dt = new DataTable();
            csConexion oconSQL = new csConexion();
            //ReportDataSource dataset = new ReportDataSource();
            ReportDataSource dataset = new ReportDataSource();
            rvwListaEqu.LocalReport.DataSources.Clear();
            dt = oconSQL.ListDGV($@"SELECT
	                E.NombreEquipo,
                    J.IDJugador,
                    J.NombreJugador,
                    J.ApellidoJugador,
                    J.Posicion,
                    JE.Dorsal,
                    ISNULL(JE.Goles, 0) AS Goles,
                    ISNULL(JE.Asistencias, 0) AS Asistencias
                FROM Jugador J
                inner JOIN Jugador_Equipo JE ON J.IDJugador = JE.IDJugador inner join Equipo E on E.IDEquipo=JE.IDEquipo
                WHERE JE.IDEquipo = '{IDEquipo}'"); //Esto de aqui lo cambias por tu consulta


            string reportPath = Path.Combine(Application.StartupPath, "rptListJugador.rdlc");
            //rvwTablaPos.LocalReport.ReportPath = "rptPosiciones.rdlc"; // Esto por el nombre de tu reporte
            if (File.Exists(reportPath))
            {
                rvwListaEqu.LocalReport.ReportPath = reportPath;
            }
            else
            {
                MessageBox.Show("No se encontró el archivo " + reportPath);
                return;
            }

            try
            {
                dataset = new ReportDataSource("dsLista", dt); // aqui por el nombre de tus datos, los que le pasas al formulario
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            rvwListaEqu.LocalReport.DataSources.Add(dataset); // eso de rvwDatos le cambias por el nombre del report viewer que le hayas puesto
            dataset.Value = dt;
            rvwListaEqu.LocalReport.Refresh();
            this.rvwListaEqu.RefreshReport();
        }
    }
}