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
        string idtorneo;
        public frmEstadisticasAsistencias(string IDTorneo)
        {
            InitializeComponent();
            this.idtorneo = IDTorneo; 
        }

        private void frmEstadisticasAsistencias_Load(object sender, EventArgs e)
        {
            CargarReporte(idtorneo);
            this.rvwAsistidres.RefreshReport();
        }
        void CargarReporte(string IDTorneo)
        {
            DataTable dtAsistencia = new DataTable();
            csConexion oconSQL = new csConexion();

            rvwAsistidres.LocalReport.DataSources.Clear();

            dtAsistencia = oconSQL.ListDGV($@"SELECT 
                    ROW_NUMBER() OVER (ORDER BY TotalAsistencias DESC) AS Pos,
                    Nombre,
                    Apellido,
                    NombreEquipo,
                    TotalAsistencias
                FROM (
                    SELECT 
                        j.NombreJugador AS Nombre,
                        j.ApellidoJugador AS Apellido,
                        e.NombreEquipo,
                        COUNT(a.IDAsistencia) AS TotalAsistencias
                    FROM 
                        Torneo t
                        INNER JOIN dbo.Partido p ON t.IDTorneo = p.IDTorneo
                        INNER JOIN dbo.Asistencia a ON p.IDPartido = a.IDPartido
                        INNER JOIN dbo.Jugador j ON a.IDJugador = j.IDJugador
                        INNER JOIN dbo.Jugador_Equipo je ON j.IDJugador = je.IDJugador
                        INNER JOIN dbo.Equipo e ON je.IDEquipo = e.IDEquipo
                    WHERE
                        t.IDTorneo = {IDTorneo}
                    GROUP BY 
                        j.NombreJugador,
                        j.ApellidoJugador,
                        e.NombreEquipo
                ) AS sub
                ORDER BY 
                    TotalAsistencias DESC;");

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
