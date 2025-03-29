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
                this.Close();
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

                dtDatosGenerales = oconSQL.ListDGV($@"");

                if (dtDatosGenerales.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron datos para este jugador.",
                                    "Advertencia",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }

                rvwEstadisticas.LocalReport.ReportPath = @"rptDatos.rdlc";

                try
                {
                    ReportDataSource dsGeneral = new ReportDataSource("dsGeneral", dtDatosGenerales);
                    rvwEstadisticas.LocalReport.DataSources.Add(dsGeneral);
                    rvwEstadisticas.LocalReport.EnableExternalImages = true;
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
                    ReportParameter paramImagen = new ReportParameter("ImagenJugador", "file://" + rutaImagen);
                    rvwEstadisticas.LocalReport.SetParameters(new ReportParameter[] { paramImagen });

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
                this.Close();
            }
        }
    }
}