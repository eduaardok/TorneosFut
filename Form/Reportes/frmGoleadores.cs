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
    public partial class frmGoleadores : Form
    {
        string idtorneo;
        public frmGoleadores(string IDTorneo)
        {
            InitializeComponent();
            idtorneo = IDTorneo;
        }

        private void frmGoleadores_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            if (!GlobalSettings.ModoOscuro)
            {
                panel1.BackColor = Color.FromArgb(251, 3, 140);
                panel2.BackColor = Color.FromArgb(251, 3, 140);
                panel3.BackColor = Color.FromArgb(251, 3, 140);
                panel4.BackColor = Color.FromArgb(251, 3, 140);
            }
            CargarDatos(idtorneo); 
            this.rvwGoleadores.RefreshReport();
        }
        void CargarDatos(string IDTorneo)
        {
            DataTable dt = new DataTable();
            csConexion oconSQL = new csConexion();
            //ReportDataSource dataset = new ReportDataSource();
            ReportDataSource dataset = new ReportDataSource();
            rvwGoleadores.LocalReport.DataSources.Clear();
            dt = oconSQL.ListDGV($@"WITH Goleadores AS (
                        SELECT 
                            J.NombreJugador,
                            J.ApellidoJugador,
                            YEAR(GETDATE()) - YEAR(J.FechaNacimiento) AS Edad,
                            J.Posicion,
                            E.NombreEquipo AS Equipo,
                            COUNT(g.IDGol) AS TotalGoles
                        FROM 
                            Gol g
                        INNER JOIN Partido p ON g.IDPartido = p.IDPartido
                        INNER JOIN Equipo e ON e.IDEquipo = g.IDEquipo
                        INNER JOIN Jugador_Equipo JE ON JE.IDEquipo = e.IDEquipo AND JE.IDJugador = g.IDJugador
                        INNER JOIN Jugador J ON J.IDJugador = JE.IDJugador
                        WHERE 
                            p.IDTorneo = {IDTorneo}
                        GROUP BY 
                            J.NombreJugador, J.ApellidoJugador, J.FechaNacimiento, J.Posicion, E.NombreEquipo
                    )
                    SELECT TOP 10
                        ROW_NUMBER() OVER (ORDER BY TotalGoles DESC) AS Pos,
                        NombreJugador,
                        ApellidoJugador,
                        Edad,
                        Posicion,
                        Equipo,
                        TotalGoles
                    FROM 
                        Goleadores
                    ORDER BY 
                        TotalGoles DESC;"); //Esto de aqui lo cambias por tu consulta


            string reportPath = Path.Combine(Application.StartupPath, "rptGoleadores.rdlc");
            //rvwTablaPos.LocalReport.ReportPath = "rptPosiciones.rdlc"; // Esto por el nombre de tu reporte
            if (File.Exists(reportPath))
            {
                rvwGoleadores.LocalReport.ReportPath = reportPath;
            }
            else
            {
                MessageBox.Show("No se encontró el archivo " + reportPath);
                return;
            }

            try
            {
                dataset = new ReportDataSource("dsGoleadores", dt); // aqui por el nombre de tus datos, los que le pasas al formulario
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            rvwGoleadores.LocalReport.DataSources.Add(dataset); // eso de rvwDatos le cambias por el nombre del report viewer que le hayas puesto
            dataset.Value = dt;
            rvwGoleadores.LocalReport.Refresh();
            this.rvwGoleadores.RefreshReport();
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
