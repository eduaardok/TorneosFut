using Microsoft.Reporting.WinForms;
using System;
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
    public partial class frmEstadisticasGol: Form
    {
        public frmEstadisticasGol()
        {
            InitializeComponent();
        }

        private void frmEstadisticasGol_Load(object sender, EventArgs e)
        {
            CargarReporte();
            this.rvwGoleadores.RefreshReport();
        }
        void CargarReporte()
        {
            DataTable dtGoles = new DataTable();
            DataTable dtAsistencia = new DataTable();
            csConexion oconSQL = new csConexion();

            rvwGoleadores.LocalReport.DataSources.Clear();

            dtGoles = oconSQL.ListDGV(@"select row_number() over (order by E.Goles desc) as Pos, J.NombreJugador, J.ApellidoJugador, Q.NombreEquipo, J.Sexo, J.Posicion, E.Goles, E.PartidosJugados,
                    cast(round(cast(E.Goles AS DECIMAL(10, 2)) / cast(E.PartidosJugados as decimal(10, 2)), 2) as decimal(10, 2)) as PromedioGol
                from 
                    Jugador_TEST J 
                    inner join Jugador_Equipo_TEST E ON J.IDJugador = E.IDJugador 
                    inner join Equipo_TEST Q ON Q.IDEquipo = E.IDEquipo
                where E.PartidosJugados >= 1 AND E.Goles >= 1
                order by E.Goles desc");

            rvwGoleadores.LocalReport.ReportPath = @"rptGoleador.rdlc";

            try
            {
                ReportDataSource dsGoles = new ReportDataSource("dsGol", dtGoles);
                rvwGoleadores.LocalReport.DataSources.Add(dsGoles);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos en el reporte: " + ex.Message);
            }
            rvwGoleadores.LocalReport.Refresh();
            this.rvwGoleadores.RefreshReport();
        }
    }
}
