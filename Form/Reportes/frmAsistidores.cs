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
    public partial class frmAsistidores : Form
    {
        string idtorneo;
        public frmAsistidores(string IDTorneos)
        {
            InitializeComponent();
            idtorneo = IDTorneos; 
        }

        private void frmAsistidores_Load(object sender, EventArgs e)
        {
            CargarDatos(idtorneo);
            this.rvwAsistencia.RefreshReport();
        }
        void CargarDatos(string IDTorneo)
        {
            DataTable dt = new DataTable();
            csConexion oconSQL = new csConexion();
            //ReportDataSource dataset = new ReportDataSource();
            ReportDataSource dataset = new ReportDataSource();
            rvwAsistencia.LocalReport.DataSources.Clear();
            dt = oconSQL.ListDGV($@"WITH Asistentes AS (
                    SELECT 
                        J.NombreJugador,
                        J.ApellidoJugador,
                        YEAR(GETDATE()) - YEAR(J.FechaNacimiento) AS Edad,
                        J.Posicion,
                        E.NombreEquipo AS Equipo,
                        COUNT(A.IDAsistencia) AS TotalAsistencia
                    FROM 
                        Asistencia A
                    INNER JOIN Partido p ON A.IDPartido = p.IDPartido
                    INNER JOIN Equipo e ON e.IDEquipo = A.IDEquipo
                    INNER JOIN Jugador_Equipo JE ON JE.IDEquipo = e.IDEquipo AND JE.IDJugador = A.IDJugador
                    INNER JOIN Jugador J ON J.IDJugador = JE.IDJugador
                    WHERE 
                        p.IDTorneo = {IDTorneo}
                    GROUP BY 
                        J.NombreJugador, J.ApellidoJugador, J.FechaNacimiento, J.Posicion, E.NombreEquipo
                )
                SELECT TOP 10
                    ROW_NUMBER() OVER (ORDER BY TotalAsistencia DESC) AS Pos,
                    NombreJugador,
                    ApellidoJugador,
                    Edad,
                    Posicion,
                    Equipo,
                    TotalAsistencia
                FROM 
                    Asistentes
                ORDER BY 
                    TotalAsistencia DESC;"); //Esto de aqui lo cambias por tu consulta


            string reportPath = Path.Combine(Application.StartupPath, "rptAsistidores.rdlc");
            //rvwTablaPos.LocalReport.ReportPath = "rptPosiciones.rdlc"; // Esto por el nombre de tu reporte
            if (File.Exists(reportPath))
            {
                rvwAsistencia.LocalReport.ReportPath = reportPath;
            }
            else
            {
                MessageBox.Show("No se encontró el archivo " + reportPath);
                return;
            }

            try
            {
                dataset = new ReportDataSource("dsAsistencias", dt); // aqui por el nombre de tus datos, los que le pasas al formulario
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            rvwAsistencia.LocalReport.DataSources.Add(dataset); // eso de rvwDatos le cambias por el nombre del report viewer que le hayas puesto
            dataset.Value = dt;
            rvwAsistencia.LocalReport.Refresh();
            this.rvwAsistencia.RefreshReport();
        }
    }
}
