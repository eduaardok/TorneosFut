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
    public partial class frmEstatsGenerales: Form
    {
        string idjugador;
        string imagen;
        public frmEstatsGenerales(string IDJugador, string Imagen)
        {
            InitializeComponent();
            this.idjugador = IDJugador;
            this.imagen = Imagen;
        }

        private void frmEstatsGenerales_Load(object sender, EventArgs e)
        {
            try
            {
                string reportPath = Path.Combine(Application.StartupPath, "rptDatos.rdlc");

                if (!File.Exists(reportPath))
                {
                    MessageBox.Show($"El archivo de reporte NO EXISTE en: {reportPath}\n" +
                                   $"Directorio actual: {Application.StartupPath}",
                                   "Error crítico",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"Archivo de reporte encontrado: {reportPath}");
                }
                rvwEstadisticas.Reset();
                rvwEstadisticas.ProcessingMode = ProcessingMode.Local;
                rvwEstadisticas.LocalReport.ReportPath = reportPath;
                rvwEstadisticas.LocalReport.EnableExternalImages = true;
                rvwEstadisticas.LocalReport.DataSources.Clear();
                CargarDatos(idjugador, imagen);
                rvwEstadisticas.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar reporte: {ex.Message}\n" +
                               $"Stack Trace: {ex.StackTrace}",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }
        void CargarDatos(string IDJugador, string Imagen)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine($"Iniciando carga de datos. IDJugador: {IDJugador}, Imagen: {Imagen}");

                DataTable dtDatosGenerales = new DataTable();
                csConexion oconSQL = new csConexion();

                rvwEstadisticas.LocalReport.DataSources.Clear();

                dtDatosGenerales = oconSQL.ListDGV($@"
                    SELECT 
                        J.IDJugador,
                        J.NombreJugador,
                        J.ApellidoJugador,
                        J.ImagenJugador,
                        (YEAR(GETDATE()) - YEAR(J.FechaNacimiento)) AS Edad,
                        J.Posicion,
                        J.Nacionalidad,
                        J.Peso,
                        J.Altura,
                        J.PiernaHabil,
                        Q.NombreEquipo,
                        COALESCE(E.PartidosJugados, 0) AS PartidosJugados,
                        COALESCE(E.Goles, 0) AS Goles,
                        COALESCE(E.Asistencias, 0) AS Asistencias,
                        -- Promedio de goles por partido
                        CASE 
                            WHEN COALESCE(E.PartidosJugados, 0) > 0 
                            THEN CAST(ROUND(CAST(E.Goles AS DECIMAL(10,2)) / E.PartidosJugados, 2) AS DECIMAL(10,2)) 
                            ELSE 0 
                        END AS PromedioGol,
                        -- Promedio de asistencias por partido
                        CASE 
                            WHEN COALESCE(E.PartidosJugados, 0) > 0 
                            THEN CAST(ROUND(CAST(E.Asistencias AS DECIMAL(10,2)) / E.PartidosJugados, 2) AS DECIMAL(10,2)) 
                            ELSE 0 
                        END AS PromedioAsistencias,
                        -- Goles + asistencias
                        (COALESCE(E.Goles, 0) + COALESCE(E.Asistencias, 0)) AS GolesAsistencias,
                        -- Probabilidad de anotar en un partido
                        CASE 
                            WHEN COALESCE(E.PartidosJugados, 0) > 0 
                            THEN CAST(ROUND((CAST(E.Goles AS DECIMAL(10,2)) / E.PartidosJugados) * 100, 2) AS DECIMAL(10,2)) 
                            ELSE 0 
                        END AS ProbabilidadGol,
                        -- Probabilidad de no anotar
                        CASE 
                            WHEN COALESCE(E.PartidosJugados, 0) > 0 
                            THEN CAST(ROUND(100 - ((CAST(E.Goles AS DECIMAL(10,2)) / E.PartidosJugados) * 100), 2) AS DECIMAL(10,2)) 
                            ELSE 100 
                        END AS ProbabilidadNoGol,
                        -- Eficiencia (contribuciones por partido titular)
                        CASE 
                            WHEN COALESCE(P.PartidosTitular, 0) > 0 
                            THEN CAST(ROUND(CAST((E.Goles + E.Asistencias) AS DECIMAL(10,2)) / P.PartidosTitular, 2) AS DECIMAL(10,2)) 
                            ELSE 0 
                        END AS EficienciaTitular
                    FROM 
                        Jugador J
                        INNER JOIN Jugador_Equipo E ON J.IDJugador = E.IDJugador
                        INNER JOIN Equipo Q ON Q.IDEquipo = E.IDEquipo
                        LEFT JOIN (
                            SELECT IDJugador, COUNT(*) AS PartidosTitular
                            FROM JugadorPartido 
                            WHERE EsTitular = 1 and IDJugador = {IDJugador}
                            GROUP BY IDJugador
                        ) P ON J.IDJugador = P.IDJugador
                    WHERE 
                        E.PartidosJugados >= 1 
                        AND E.Goles >= 1;");

                if (dtDatosGenerales.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron datos para este jugador.",
                                    "Advertencia",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                rvwEstadisticas.LocalReport.ReportPath = Path.Combine(Application.StartupPath, "rptDatos.rdlc");

                try
                {
                    // Primero agrega la fuente de datos
                    ReportDataSource dsGeneral = new ReportDataSource("dsGeneral", dtDatosGenerales);
                    rvwEstadisticas.LocalReport.DataSources.Add(dsGeneral);

                    // Manejo mejorado de la ruta de imagen
                    string rutaImagen;

                    // Verifica si la imagen existe
                    if (string.IsNullOrEmpty(Imagen))
                    {
                        System.Diagnostics.Debug.WriteLine("No se proporcionó nombre de imagen. Usando imagen por defecto.");
                        rutaImagen = Path.Combine(Application.StartupPath, "Imagenes", "defaultE.png");
                    }
                    else
                    {
                        rutaImagen = Path.Combine(Application.StartupPath, "Imagenes", Imagen);
                        if (!File.Exists(rutaImagen))
                        {
                            System.Diagnostics.Debug.WriteLine($"Imagen no encontrada: {rutaImagen}. Usando imagen por defecto.");
                            rutaImagen = Path.Combine(Application.StartupPath, "Imagenes", "defaultE.png");
                        }
                    }

                    // Verifica que la imagen por defecto exista
                    if (!File.Exists(rutaImagen))
                    {
                        // Si ni siquiera la imagen por defecto existe, usa una URL vacía pero válida
                        MessageBox.Show("No se encontró ni la imagen del jugador ni la imagen por defecto.",
                                      "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        // Usa un placeholder o una imagen vacía que sepas que existe
                        rutaImagen = Path.Combine(Application.StartupPath, "Imagenes"); // Solo el directorio
                                                                                        // En caso extremo, si nada funciona, crear un valor de parámetro que no falle
                        ReportParameter paramImagen = new ReportParameter("ImagenJugador", "");
                        rvwEstadisticas.LocalReport.SetParameters(new ReportParameter[] { paramImagen });
                    }
                    else
                    {
                        // La imagen existe, úsala
                        string imageUrl = new Uri(rutaImagen).AbsoluteUri;
                        ReportParameter paramImagen = new ReportParameter("ImagenJugador", imageUrl);
                        rvwEstadisticas.LocalReport.SetParameters(new ReportParameter[] { paramImagen });
                    }

                    System.Diagnostics.Debug.WriteLine("Datos e imagen cargados exitosamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al configurar el reporte: {ex.Message}",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    System.Diagnostics.Debug.WriteLine($"Error en configuración de reporte: {ex.Message}");
                    System.Diagnostics.Debug.WriteLine($"Stack Trace: {ex.StackTrace}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en CargarDatos: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine($"Error en CargarDatos: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Stack Trace: {ex.StackTrace}");
            }
        }

        private void rvwEstadisticas_Load(object sender, EventArgs e)
        {

        }
    }
}