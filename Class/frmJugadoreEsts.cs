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

namespace TorneosFut.Class
{
    public partial class frmJugadoreEsts : Form
    {
        string idjugador; 
        public frmJugadoreEsts(string IDJugador)
        {
            InitializeComponent();
            this.idjugador = IDJugador;
        }

        private void frmJugadoreEsts_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            if (!GlobalSettings.ModoOscuro)
            {
                panel1.BackColor = Color.FromArgb(251, 3, 140);
                panel2.BackColor = Color.FromArgb(251, 3, 140);
                panel3.BackColor = Color.FromArgb(251, 3, 140);
                panel4.BackColor = Color.FromArgb(251, 3, 140);
            }
            CargarDatos(idjugador);
            this.rvwEstadisticaJug.RefreshReport();
        }
        void CargarDatos(string IDJugador)
        {
            DataTable dt = new DataTable();
            csConexion oconSQL = new csConexion();
            //ReportDataSource dataset = new ReportDataSource();
            ReportDataSource dataset = new ReportDataSource();
            rvwEstadisticaJug.LocalReport.DataSources.Clear();
            dt = oconSQL.ListDGV($@"SELECT 
                    J.IDJugador,
                    J.NombreJugador,
                    J.ApellidoJugador,
	                E.GolesFavor,
    
                    -- Goles y asistencias totales
                    ISNULL(JE.Goles, 0) AS TotalGoles,
                    ISNULL(JE.Asistencias, 0) AS TotalAsistencias,

                    -- Participación ofensiva total
                    ISNULL(JE.Goles, 0) + ISNULL(JE.Asistencias, 0) AS TotalParticipaciones,

                    -- Porcentaje de participación ofensiva
                    CAST(
                        (CAST(ISNULL(JE.Goles, 0) AS FLOAT) / NULLIF(ISNULL(JE.Goles, 0) + ISNULL(JE.Asistencias, 0), 0)) * 100
                        AS DECIMAL(5,2)
                    ) AS PorcentajeGoles,
                    CAST(
                        (CAST(ISNULL(JE.Asistencias, 0) AS FLOAT) / NULLIF(ISNULL(JE.Goles, 0) + ISNULL(JE.Asistencias, 0), 0)) * 100
                        AS DECIMAL(5,2)
                    ) AS PorcentajeAsistencias,

                    -- Minuto promedio en que anota (2 decimales)
                    CAST(
                        ISNULL((
                            SELECT AVG(Minuto * 1.0) 
                            FROM Gol 
                            WHERE IDJugador = J.IDJugador
                        ), 0) AS DECIMAL(5,2)
                    ) AS MinutoPromedioGol

                FROM Jugador J
                LEFT JOIN Jugador_Equipo JE ON J.IDJugador = JE.IDJugador inner join Equipo E on JE.IDEquipo = E.IDEquipo
                WHERE J.IDJugador = '{IDJugador}'"); //Esto de aqui lo cambias por tu consulta


            string reportPath = Path.Combine(Application.StartupPath, "rptEstatsJugadores.rdlc");
            //rvwTablaPos.LocalReport.ReportPath = "rptPosiciones.rdlc"; // Esto por el nombre de tu reporte
            if (File.Exists(reportPath))
            {
                rvwEstadisticaJug.LocalReport.ReportPath = reportPath;
            }
            else
            {
                MessageBox.Show("No se encontró el archivo " + reportPath);
                return;
            }

            try
            {
                dataset = new ReportDataSource("dsJugadores", dt); // aqui por el nombre de tus datos, los que le pasas al formulario
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            rvwEstadisticaJug.LocalReport.DataSources.Add(dataset); // eso de rvwDatos le cambias por el nombre del report viewer que le hayas puesto
            dataset.Value = dt;
            rvwEstadisticaJug.LocalReport.Refresh();
            this.rvwEstadisticaJug.RefreshReport();
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
    }
}
