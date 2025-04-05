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
    public partial class frmEstatsGenerales : Form
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
                rvwEstadisticas.ProcessingMode = ProcessingMode.Local;
                rvwEstadisticas.LocalReport.DataSources.Clear();

                CargarDatos(idjugador, imagen);
                rvwEstadisticas.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar reporte: {ex.Message}",
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

                DataTable dtDatosJugador = new DataTable();
                csConexion conec = new csConexion();

                rvwEstadisticas.LocalReport.DataSources.Clear();

                dtDatosJugador = conec.ListDGV($@"SELECT 
                        j.IDJugador,
                        CONCAT(j.NombreJugador, ' ', j.ApellidoJugador) AS NombreCompleto,
                        e.NombreEquipo,
                        j.ImagenJugador,
                        je.Dorsal,
                        je.PartidosJugados,
                        je.Goles,
                        je.Asistencias,
                        CAST(
                            ROUND(
                                CASE 
                                    WHEN je.PartidosJugados > 0 
                                    THEN CAST(je.Goles AS DECIMAL(10,2)) / je.PartidosJugados 
                                    ELSE 0 
                                END, 
                            2)
                        AS DECIMAL(10,2)) AS PromedioGoles,
                        CAST(
                            ROUND(
                                CASE 
                                    WHEN je.PartidosJugados > 0 
                                    THEN CAST(je.Asistencias AS DECIMAL(10,2)) / je.PartidosJugados 
                                    ELSE 0 
                                END, 
                            2)
                        AS DECIMAL(10,2)) AS PromedioAsistencias,
                        (SELECT COUNT(*) FROM Partido p 
                         WHERE (p.EquipoLocal = je.IDEquipo OR p.EquipoVisitante = je.IDEquipo)
                         AND p.EstadoPartido = 'Finalizado') AS PartidosTotalesEquipo,
                        CAST(
                            ROUND(
                                CASE 
                                    WHEN je.PartidosJugados > 0 
                                        AND (SELECT COUNT(*) FROM Partido p 
                                             WHERE (p.EquipoLocal = je.IDEquipo OR p.EquipoVisitante = je.IDEquipo)
                                             AND p.EstadoPartido = 'Finalizado') > 0 
                                    THEN CAST(je.PartidosJugados AS DECIMAL(10,2)) / 
                                         (SELECT COUNT(*) FROM Partido p 
                                          WHERE (p.EquipoLocal = je.IDEquipo OR p.EquipoVisitante = je.IDEquipo)
                                          AND p.EstadoPartido = 'Finalizado') * 100
                                    ELSE 0 
                                END, 
                            2)
                        AS DECIMAL(10,2)) AS PorcentajeParticipacion,
                        (SELECT COUNT(g.IDGol) FROM Gol g WHERE g.IDJugador = j.IDJugador) AS GolesEnTorneos,
                        (SELECT COUNT(a.IDAsistencia) FROM Asistencia a WHERE a.IDJugador = j.IDJugador) AS AsistenciasEnTorneos
                    FROM 
                        Jugador j
                        INNER JOIN Jugador_Equipo je ON j.IDJugador = je.IDJugador
                        INNER JOIN Equipo e ON je.IDEquipo = e.IDEquipo
                    WHERE 
                        (je.FechaSalida IS NULL OR je.FechaSalida > GETDATE())
                        AND j.IDJugador = '{IDJugador}'     
                    ORDER BY 
                        e.NombreEquipo, je.Dorsal;");

                if (dtDatosJugador.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron datos para este equipo.",
                                    "Advertencia",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
                //rptDatos.rdlc
                rvwEstadisticas.LocalReport.ReportPath = Path.Combine(Application.StartupPath, "rptDatos.rdlc");

                try
                {
                    ReportDataSource dsJugador = new ReportDataSource("dsGeneral", dtDatosJugador);
                    rvwEstadisticas.LocalReport.DataSources.Add(dsJugador);
                    rvwEstadisticas.LocalReport.EnableExternalImages = true;

                    string rutaImagen = Path.Combine(Application.StartupPath, "Imagenes", Imagen);
                    if (string.IsNullOrEmpty(Imagen))
                    {
                        MessageBox.Show("No se proporcionó un nombre de imagen válido.\nIngrese una o actualice la actual para poder visualizarla en el reporte.",
                                        "Advertencia",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        rutaImagen = Path.Combine(Application.StartupPath, "Imagenes", "defaultE.png");
                    }
                    if (!File.Exists(rutaImagen))
                    {
                        MessageBox.Show($"No se encontró la imagen: {rutaImagen}\nIngrese una o actualice la actual para poder visualizarla en el reporte.",
                                        "Advertencia",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        rutaImagen = Path.Combine(Application.StartupPath, "Imagenes", "defaultE.png");
                    }

                    ReportParameter paramImagen = new ReportParameter("ImagenJugador", "file://" + rutaImagen);
                    rvwEstadisticas.LocalReport.SetParameters(new ReportParameter[] { paramImagen });

                    System.Diagnostics.Debug.WriteLine("Datos cargados correctamente");
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

                rvwEstadisticas.LocalReport.Refresh();
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