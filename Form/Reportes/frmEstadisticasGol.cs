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
    public partial class frmEstadisticasGol: Form
    {
        string idtorneo;
        public frmEstadisticasGol(string IDTorneo)
        {
            InitializeComponent();
            this.idtorneo = IDTorneo; 
        }

        private void frmEstadisticasGol_Load(object sender, EventArgs e)
        {
            CargarReporte(idtorneo);
            this.rvwGoleadores.RefreshReport();
        }
        void CargarReporte(string IDTorneo)
        {
            DataTable dtGoles = new DataTable();
            DataTable dtAsistencia = new DataTable();
            csConexion oconSQL = new csConexion();

            rvwGoleadores.LocalReport.DataSources.Clear();

            dtGoles = oconSQL.ListDGV($@"SELECT 
                    ROW_NUMBER() OVER (ORDER BY TotalGoles DESC) AS Pos,
                    NombreJugador,
                    ApellidoJugador,
                    Posicion,
                    NombreEquipo,
                    TotalGoles
                FROM (
                    SELECT 
                        j.NombreJugador,
                        j.ApellidoJugador,
                        j.Posicion,
                        e.NombreEquipo,
                        COUNT(g.IDGol) AS TotalGoles
                    FROM 
                        Torneo t
                        INNER JOIN dbo.Partido p ON t.IDTorneo = p.IDTorneo
                        INNER JOIN dbo.Gol g ON p.IDPartido = g.IDPartido
                        INNER JOIN dbo.Jugador j ON g.IDJugador = j.IDJugador
                        INNER JOIN dbo.Jugador_Equipo je ON j.IDJugador = je.IDJugador
                        INNER JOIN dbo.Equipo e ON je.IDEquipo = e.IDEquipo
                    WHERE
                        t.IDTorneo = {IDTorneo}
                    GROUP BY 
                        j.NombreJugador,
                        j.ApellidoJugador,
                        j.Posicion,
                        e.NombreEquipo
                ) AS sub
                ORDER BY 
                    TotalGoles DESC;");

            rvwGoleadores.LocalReport.ReportPath = @"rptGoleador.rdlc";

            try
            {
                ReportDataSource dsGoles = new ReportDataSource("dsGol", dtGoles);
                rvwGoleadores.LocalReport.DataSources.Add(dsGoles);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos en el reporte: " + ex.Message);
            }
            rvwGoleadores.LocalReport.Refresh();
            this.rvwGoleadores.RefreshReport();
        }
    }
}