﻿using Microsoft.Reporting.WinForms;
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
    public partial class frmTablaP : Form
    {
        public frmTablaP()
        {
            InitializeComponent();
        }

        private void frmTablaP_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            if (!GlobalSettings.ModoOscuro)
            {
                panel1.BackColor = Color.FromArgb(251, 3, 140);
                panel2.BackColor = Color.FromArgb(251, 3, 140);
                panel3.BackColor = Color.FromArgb(251, 3, 140);
                panel4.BackColor = Color.FromArgb(251, 3, 140);
            }
            CargarDatos(); 
            this.rvwTablaPos.RefreshReport();
        }
        void CargarDatos()
        {
            DataTable dt = new DataTable();
            csConexion oconSQL = new csConexion();
            //ReportDataSource dataset = new ReportDataSource();
            ReportDataSource dataset = new ReportDataSource(); 
            rvwTablaPos.LocalReport.DataSources.Clear();
            dt = oconSQL.ListDGV($@"WITH EquiposUnicos AS (
                    SELECT IDTorneo, ISNULL(Grupo, 0) AS Grupo, EquipoLocal AS IDEquipo
                    FROM Partido
                    UNION
                    SELECT IDTorneo, ISNULL(Grupo, 0) AS Grupo, EquipoVisitante AS IDEquipo
                    FROM Partido
                ),
                Estadisticas AS (
                    SELECT 
                        IDTorneo,
                        ISNULL(Grupo, 0) AS Grupo,
                        Equipo,
                        COUNT(*) AS PartidosJugados,
                        SUM(CASE 
                                WHEN GolesAFavor > GolesEnContra THEN 1 
                                ELSE 0 
                            END) AS PartidosGanados,
                        SUM(CASE 
                                WHEN GolesAFavor = GolesEnContra THEN 1 
                                ELSE 0 
                            END) AS PartidosEmpatados,
                        SUM(CASE 
                                WHEN GolesAFavor < GolesEnContra THEN 1 
                                ELSE 0 
                            END) AS PartidosPerdidos,
                        SUM(GolesAFavor) AS GolesFavor,
                        SUM(GolesEnContra) AS GolesContra
                    FROM (
                        -- Datos del equipo local
                        SELECT 
                            IDTorneo,
                            ISNULL(Grupo, 0) AS Grupo,
                            EquipoLocal AS Equipo,
                            ISNULL(GolesLocal, 0) AS GolesAFavor,
                            ISNULL(GolesVisitante, 0) AS GolesEnContra,
                            EstadoPartido
                        FROM Partido

                        UNION ALL

                        -- Datos del equipo visitante
                        SELECT 
                            IDTorneo,
                            ISNULL(Grupo, 0) AS Grupo,
                            EquipoVisitante AS Equipo,
                            ISNULL(GolesVisitante, 0) AS GolesAFavor,
                            ISNULL(GolesLocal, 0) AS GolesEnContra,
                            EstadoPartido
                        FROM Partido
                    ) AS Jugados
                    WHERE EstadoPartido = 'FINALIZADO'
                    GROUP BY IDTorneo, Grupo, Equipo
                )
                SELECT 
                    ROW_NUMBER() OVER (
                        ORDER BY 
                            ISNULL(E.PartidosGanados, 0) * 3 + ISNULL(E.PartidosEmpatados, 0) DESC,
                            ISNULL(E.GolesFavor, 0) - ISNULL(E.GolesContra, 0) DESC
                    ) AS Pos,
                    EQ.NombreEquipo,
                    ISNULL(E.PartidosGanados, 0) AS PartidosGanados,
                    ISNULL(E.PartidosEmpatados, 0) AS PartidosEmpatados,
                    ISNULL(E.PartidosPerdidos, 0) AS PartidosPerdidos,
                    ISNULL(E.PartidosGanados, 0) * 3 + ISNULL(E.PartidosEmpatados, 0) AS Puntos,
                    ISNULL(E.GolesFavor, 0) AS GolesFavor,
                    ISNULL(E.GolesContra, 0) AS GolesContra,
                    ISNULL(E.GolesFavor, 0) - ISNULL(E.GolesContra, 0) AS DiferenciaGoles
                FROM EquiposUnicos EU
                LEFT JOIN Estadisticas E
                    ON EU.IDTorneo = E.IDTorneo AND EU.IDEquipo = E.Equipo AND EU.Grupo = E.Grupo
                LEFT JOIN Equipo EQ
                    ON EU.IDEquipo = EQ.IDEquipo
                ORDER BY Puntos DESC, DiferenciaGoles DESC;
                "); //Esto de aqui lo cambias por tu consulta


            string reportPath = Path.Combine(Application.StartupPath, "rptPosiciones.rdlc");
            //rvwTablaPos.LocalReport.ReportPath = "rptPosiciones.rdlc"; // Esto por el nombre de tu reporte
            if (File.Exists(reportPath))
            {
                rvwTablaPos.LocalReport.ReportPath = reportPath;
}
            else
            {
                MessageBox.Show("No se encontró el archivo " + reportPath);
                return;
            }

            try
            {
                dataset = new ReportDataSource("dsTablaPosicion", dt); // aqui por el nombre de tus datos, los que le pasas al formulario
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            rvwTablaPos.LocalReport.DataSources.Add(dataset); // eso de rvwDatos le cambias por el nombre del report viewer que le hayas puesto
            dataset.Value = dt;
            //9,13132in; 3,54167in
            ConfigurarVistaPrevia(rvwTablaPos, 9.13132f, 3.54167f);

            rvwTablaPos.LocalReport.Refresh();
            this.rvwTablaPos.RefreshReport();
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
                    
                    byte[] bytes = ExportarReportePDF(rvwTablaPos);
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