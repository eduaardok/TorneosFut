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
            //9.13132in; 8.44792in
            ConfigurarVistaPrevia(rvwEstadisticaJug, 9.13132f, 8.44792f);

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

        private byte[] ExportarReportePDF(ReportViewer viewer)
        {
            // Configuración para forzar una sola página con contenido completo
            string deviceInfo = @"<DeviceInfo>
                            <OutputFormat>PDF</OutputFormat>
                            <PageWidth>9.13132in</PageWidth>
                            <PageHeight>500in</PageHeight>
                            <MarginTop>0in</MarginTop>
                            <MarginLeft>0in</MarginLeft>
                            <MarginRight>0in</MarginRight>
                            <MarginBottom>0in</MarginBottom>
                            <HugePageBreak>false</HugePageBreak>
                            <EmbedFonts>true</EmbedFonts>
                          </DeviceInfo>";

            Warning[] warnings;
            string[] streamIds;
            string mimeType = string.Empty;
            string encoding = string.Empty;
            string extension = string.Empty;

            byte[] bytes = viewer.LocalReport.Render(
                "PDF", deviceInfo, out mimeType, out encoding, out extension,
                out streamIds, out warnings);

            return bytes;
        }

        private void ConfigurarVistaPrevia(ReportViewer viewer, float anchoOriginal, float altoOriginal)
        {
            System.Drawing.Printing.PageSettings configuracionPagina = new System.Drawing.Printing.PageSettings();

            int anchoEnCentesimasPulgada = (int)(anchoOriginal * 100);
            int altoEnCentesimasPulgada = (int)(altoOriginal * 100);

            configuracionPagina.PaperSize = new System.Drawing.Printing.PaperSize("Personalizado",
                anchoEnCentesimasPulgada, altoEnCentesimasPulgada);

            configuracionPagina.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);

            viewer.SetPageSettings(configuracionPagina);
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                saveDialog.Title = "Guardar reporte como PDF";
                saveDialog.FileName = "Reporte.pdf";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    byte[] bytes = ExportarReportePDF(rvwEstadisticaJug);
                    File.WriteAllBytes(saveDialog.FileName, bytes);

                    MessageBox.Show("Reporte exportado exitosamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    System.Diagnostics.Process.Start(saveDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
