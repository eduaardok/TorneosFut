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
    public partial class TablaDePosiciones: Form
    {
        csConexion csConexion;
        string Torneo;
        csDGV csDGV;
        public TablaDePosiciones(string u, string c, string torneo)
        {
            csConexion = new csConexion(u, c);
            Torneo = torneo;
            csDGV = new csDGV(u, c);
            InitializeComponent();
        }

        private void TablaDePosiciones_Load(object sender, EventArgs e)
        {
            DataTable dt = csConexion.ListDGV($"SELECT * FROM TablaDePosiciones" +
                $" WHERE IDTorneo = {Torneo} ORDER BY Grupo asc , Puntos DESC, DiferenciaGoles DESC, GolesAFavor DESC");
            dgvPosiciones.DataSource = dt;
            csDGV.AdaptarDGV(dgvPosiciones);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
