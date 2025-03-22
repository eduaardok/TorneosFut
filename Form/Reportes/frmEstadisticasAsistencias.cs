using Microsoft.Reporting.WinForms;
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
    public partial class frmEstadisticasAsistencias: Form
    {
        public frmEstadisticasAsistencias()
        {
            InitializeComponent();
        }

        private void frmEstadisticasAsistencias_Load(object sender, EventArgs e)
        {
            CargarReporte();
            this.rvwAsistidres.RefreshReport();
        }
        void CargarReporte()
        {
            DataTable dtAsistencia = new DataTable();
            csConexion oconSQL = new csConexion();

            rvwAsistidres.LocalReport.DataSources.Clear();

            dtAsistencia = oconSQL.ListDGV(@"Select top 10 J.NombreJugador, J.ApellidoJugador, Q.NombreEquipo, J.Sexo, J.Posicion, E.Asistencias, E.PartidosJugados,
	            cast(round(cast(E.Asistencias as decimal(10, 2)) / cast(E.PartidosJugados as decimal(10, 2)), 2) as decimal(10, 2)) as PromedioAsistencias
	            from Jugador_TEST J inner join Jugador_Equipo_TEST E on J.IDJugador=E.IDJugador 
	            inner join Equipo_TEST Q on Q.IDEquipo=E.IDEquipo
	            where E.PartidosJugados >= 1 and E.Asistencias >= 1
	            order by Asistencias desc");

            rvwAsistidres.LocalReport.ReportPath = @"rptAsistidor.rdlc";

            try
            {
                ReportDataSource dsAsistencia = new ReportDataSource("dsAsistencia", dtAsistencia);
                rvwAsistidres.LocalReport.DataSources.Add(dsAsistencia);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos en el reporte: " + ex.Message);
            }
            rvwAsistidres.LocalReport.Refresh();
            this.rvwAsistidres.RefreshReport();
        }
    }
}