using Microsoft.Reporting.WinForms;
using System;
using System.IO;
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
    public partial class frmEquiposEstadisticas: Form
    {
        string idjugador;
        string imagen;
        public frmEquiposEstadisticas(string IDJugador, string Imagen)
        {
            InitializeComponent();
            this.idjugador = IDJugador;
            this.imagen = Imagen;
        }

        private void frmEquiposEstadisticas_Load(object sender, EventArgs e)
        {
            try
            {
                rvwEquipos.ProcessingMode = ProcessingMode.Local;
                rvwEquipos.LocalReport.DataSources.Clear();

                CargarDatos(idjugador, imagen);
                rvwEquipos.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar reporte: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                this.Close();
            }
        }
        void CargarDatos(string IDEquipo, string Imagen)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine($"Iniciando carga de datos. IDEquipo: {IDEquipo}, ImagenEquipo: {Imagen}");

                DataTable dtDatosEquipos = new DataTable();
                csConexion oconSQL = new csConexion();

                rvwEquipos.LocalReport.DataSources.Clear();

                dtDatosEquipos = oconSQL.ListDGV($@"SELECT 
                            IDEquipo, 
                            NombreEquipo, 
                            Presidente, 
                            ImagenEscudo, 
                            COALESCE(PartidosGanados, 0) + COALESCE(PartidosEmpatados, 0) + COALESCE(PartidosPerdidos, 0) AS PartidosJugados,
                            COALESCE(PartidosGanados, 0) AS PartidosGanados, 
                            COALESCE(PartidosEmpatados, 0) AS PartidosEmpatados, 
                            COALESCE(PartidosPerdidos, 0) AS PartidosPerdidos, 
                            COALESCE(GolesFavor, 0) AS GolesFavor, 
                            COALESCE(GolesContra, 0) AS GolesContra,
                            -- Cálculo de puntos (3 puntos por victoria, 1 por empate)
                            (COALESCE(PartidosGanados, 0) * 3 + COALESCE(PartidosEmpatados, 0)) AS Puntos,
                            -- Porcentaje de victorias
                            CAST(ROUND(CAST(COALESCE(PartidosGanados, 0) AS DECIMAL(10,4)) / 
                            NULLIF(COALESCE(PartidosGanados, 0) + COALESCE(PartidosEmpatados, 0) + COALESCE(PartidosPerdidos, 0), 0) * 100, 2) AS DECIMAL(10, 2)) AS PorcentajeVictorias,
                            -- Porcentaje de empates
                            CAST(ROUND(CAST(COALESCE(PartidosEmpatados, 0) AS DECIMAL(10,4)) / 
                            NULLIF(COALESCE(PartidosGanados, 0) + COALESCE(PartidosEmpatados, 0) + COALESCE(PartidosPerdidos, 0), 0) * 100, 2) AS DECIMAL(10, 2)) AS PorcentajeEmpates,
                            -- Porcentaje de derrotas
                            CAST(ROUND(100 - (
                                ROUND(CAST(COALESCE(PartidosGanados, 0) AS DECIMAL(10,4)) / 
                                NULLIF(COALESCE(PartidosGanados, 0) + COALESCE(PartidosEmpatados, 0) + COALESCE(PartidosPerdidos, 0), 0) * 100, 2) +
                                ROUND(CAST(COALESCE(PartidosEmpatados, 0) AS DECIMAL(10,4)) / 
                                NULLIF(COALESCE(PartidosGanados, 0) + COALESCE(PartidosEmpatados, 0) + COALESCE(PartidosPerdidos, 0), 0) * 100, 2)
                            ), 2) AS DECIMAL(10, 2)) AS PorcentajeDerrotas,
                            -- Eficiencia ofensiva (goles anotados por partido)
                            CAST(ROUND(COALESCE(GolesFavor, 0) / NULLIF(COALESCE(PartidosGanados, 0) + COALESCE(PartidosEmpatados, 0) + COALESCE(PartidosPerdidos, 0), 0), 2) AS DECIMAL(10,2)) AS Ofensiva,
                            -- Eficiencia defensiva (goles recibidos por partido)
                            CAST(ROUND(1 / NULLIF(COALESCE(GolesContra, 0) / NULLIF(COALESCE(PartidosGanados, 0) + COALESCE(PartidosEmpatados, 0) + COALESCE(PartidosPerdidos, 0), 0), 0), 2) AS DECIMAL(10,2)) AS Defensiva,
                            -- Porcentaje de efectividad
                            CAST(ROUND(((COALESCE(PartidosGanados, 0) * 3 + COALESCE(PartidosEmpatados, 0)) * 100.0 / 
                            NULLIF((COALESCE(PartidosGanados, 0) + COALESCE(PartidosEmpatados, 0) + COALESCE(PartidosPerdidos, 0)) * 3, 0)), 2) AS DECIMAL(10, 2)) AS PorcentajeEfectividad,
                            -- Estado de forma
                            CASE 
                                WHEN (COALESCE(PartidosGanados, 0) * 100.0 / NULLIF(COALESCE(PartidosGanados, 0) + COALESCE(PartidosEmpatados, 0) + COALESCE(PartidosPerdidos, 0), 0)) > 50 
                                     AND (COALESCE(GolesFavor, 0) - COALESCE(GolesContra, 0)) > 3 
                                THEN 100  
                                WHEN (COALESCE(PartidosGanados, 0) * 100.0 / NULLIF(COALESCE(PartidosGanados, 0) + COALESCE(PartidosEmpatados, 0) + COALESCE(PartidosPerdidos, 0), 0)) < 33 
                                     OR (COALESCE(GolesFavor, 0) - COALESCE(GolesContra, 0)) <= 1 
                                THEN 0    
                                ELSE 50       
                            END AS EstadoForma
                        FROM Equipo
                        WHERE IDEquipo = '{IDEquipo}'");

                if (dtDatosEquipos.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron datos para este equipo.",
                                    "Advertencia",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }

                rvwEquipos.LocalReport.ReportPath = @"rptEquipos.rdlc";

                try
                {
                    ReportDataSource dsEquipos = new ReportDataSource("dsEquipos", dtDatosEquipos);
                    rvwEquipos.LocalReport.DataSources.Add(dsEquipos);
                    rvwEquipos.LocalReport.EnableExternalImages = true;

                    string rutaImagen = Path.Combine(Application.StartupPath, "Imagenes", Imagen);
                    if (string.IsNullOrEmpty(Imagen))
                    {
                        MessageBox.Show("No se proporcionó un nombre de imagen válido.",
                                        "Advertencia",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        rutaImagen = Path.Combine(Application.StartupPath, "Imagenes", "default.png");
                    }
                    if (!File.Exists(rutaImagen))
                    {
                        MessageBox.Show($"No se encontró la imagen: {rutaImagen}\nSe usará una imagen predeterminada.",
                                        "Advertencia",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        rutaImagen = Path.Combine(Application.StartupPath, "Imagenes", "default.png");
                    }

                    ReportParameter paramImagen = new ReportParameter("ImagenEquipo", "file://" + rutaImagen);
                    rvwEquipos.LocalReport.SetParameters(new ReportParameter[] { paramImagen });

                    System.Diagnostics.Debug.WriteLine("Datos cargados exitosamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al configurar el reporte: {ex.Message}",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    System.Diagnostics.Debug.WriteLine($"Error en configuración de reporte: {ex.Message}");
                    System.Diagnostics.Debug.WriteLine($"Stack Trace: {ex.StackTrace}");
                    this.Close();
                }

                rvwEquipos.LocalReport.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en CargarDatos: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine($"Error en CargarDatos: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Stack Trace: {ex.StackTrace}");
                this.Close();
            }
        }
    }
}
