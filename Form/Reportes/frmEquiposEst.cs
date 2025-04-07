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
    public partial class frmEquiposEst : Form
    {
        string idequipo;
        public frmEquiposEst(string IDEquipo)
        {
            InitializeComponent();
            this.idequipo = IDEquipo;
        }

        private void frmEquiposEst_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            if (!GlobalSettings.ModoOscuro)
            {
                panel1.BackColor = Color.FromArgb(251, 3, 140);
                panel2.BackColor = Color.FromArgb(251, 3, 140);
                panel3.BackColor = Color.FromArgb(251, 3, 140);
                panel4.BackColor = Color.FromArgb(251, 3, 140);
            }
            CargarDatos(idequipo);
            this.rvwEquipos.RefreshReport();
        }
        void CargarDatos(string IDEquipo)
        {
            DataTable dt = new DataTable();
            csConexion oconSQL = new csConexion();
            //ReportDataSource dataset = new ReportDataSource();
            ReportDataSource dataset = new ReportDataSource();
            rvwEquipos.LocalReport.DataSources.Clear();
            dt = oconSQL.ListDGV($@"SELECT 
                    IDEquipo,
                    NombreEquipo,
                    ISNULL(GolesFavor, 0) AS GolesFavor,
                    ISNULL(GolesContra, 0) AS GolesContra,
                    ISNULL(PartidosGanados, 0) AS PartidosGanados,
                    ISNULL(PartidosEmpatados, 0) AS PartidosEmpatados,
                    ISNULL(PartidosPerdidos, 0) AS PartidosPerdidos,

                    ISNULL(PartidosGanados, 0) + ISNULL(PartidosEmpatados, 0) + ISNULL(PartidosPerdidos, 0) AS PartidosJugados,

                    ISNULL(PartidosGanados, 0) * 3 + ISNULL(PartidosEmpatados, 0) AS PuntosObtenidos,

                    (ISNULL(PartidosGanados, 0) + ISNULL(PartidosEmpatados, 0) + ISNULL(PartidosPerdidos, 0)) * 3 AS PuntosPosibles,

                    CAST(
                        (
                            CAST((ISNULL(PartidosGanados, 0) * 3 + ISNULL(PartidosEmpatados, 0)) AS FLOAT) / 
                            NULLIF((ISNULL(PartidosGanados, 0) + ISNULL(PartidosEmpatados, 0) + ISNULL(PartidosPerdidos, 0)) * 3, 0)
                        ) * 100 AS DECIMAL(10,2)
                    ) AS PorcentajeEfectividad
                FROM Equipo
                WHERE IDEquipo = '{IDEquipo}'"); //Esto de aqui lo cambias por tu consulta


            string reportPath = Path.Combine(Application.StartupPath, "rptEstatsEquipo.rdlc");
            //rvwTablaPos.LocalReport.ReportPath = "rptPosiciones.rdlc"; // Esto por el nombre de tu reporte
            if (File.Exists(reportPath))
            {
                rvwEquipos.LocalReport.ReportPath = reportPath;
            }
            else
            {
                MessageBox.Show("No se encontró el archivo " + reportPath);
                return;
            }

            try
            {
                dataset = new ReportDataSource("dsEquipos", dt); // aqui por el nombre de tus datos, los que le pasas al formulario
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            rvwEquipos.LocalReport.DataSources.Add(dataset); // eso de rvwDatos le cambias por el nombre del report viewer que le hayas puesto
            dataset.Value = dt;
            //9.13132in; 8.44792in
            ConfigurarVistaPrevia(rvwEquipos, 9.13132f, 8.44792f);

            rvwEquipos.LocalReport.Refresh();
            this.rvwEquipos.RefreshReport();
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
                    byte[] bytes = ExportarReportePDF(rvwEquipos);
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