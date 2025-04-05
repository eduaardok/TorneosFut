using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneosFut.Class;

namespace TorneosFut
{
    public partial class PagoPatrocinador: Form
    {
        csConexion conexion;
        csDatos csDatos;
        string IdPatrocinador;
        csDGV csDGV;
        int IDTorneo;
        public PagoPatrocinador(int IDtorneo, string IDPatrocinador, string u, string c)
        {
            IDTorneo = IDtorneo;
            IdPatrocinador = IDPatrocinador;
            conexion = new csConexion(u, c);
            csDatos = new csDatos(u, c);
            InitializeComponent();
        }

        private void PagoPatrocinador_Load(object sender, EventArgs e)
        {
            DataTable torneo = conexion.ListDGV($"Select NombreTorneo, CostoInscripcion, FechaInicio from Torneo where IDTorneo = {IDTorneo}");
            lbNameTorneo.Text = torneo.Rows[0]["NombreTorneo"].ToString();
            DataTable Empresa = conexion.ListDGV($"select NombreEmpresa from Patrocinador where IDPatrocinador = '{IdPatrocinador}' ");
            lbNameTorneo.Text = Empresa.Rows[0]["NombreEmpresa"].ToString();

            DataTable Patrocinador_Torneo = conexion.ListDGV($"select * from Patrocinador_Torneo where IDTorneo = {IDTorneo} and IDPatrocinador = '{IdPatrocinador}'");
            lblNivel.Text = Patrocinador_Torneo.Rows[0]["TipoPatrocinio"].ToString();
            lblCosto.Text = Patrocinador_Torneo.Rows[0]["PrecioPatrocinio"].ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            decimal saldoIngresado;
            decimal costoTotal;

            bool saldoOk = decimal.TryParse(txtsaldo.Text, out saldoIngresado);
            bool costoOk = decimal.TryParse(lblCosto.Text, out costoTotal);

            if (!saldoOk || !costoOk)
            {
                MessageBox.Show("Verifica que ambos montos sean válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (saldoIngresado == costoTotal)
            {
                csDatos.PagoPatrocinador(IDTorneo, IdPatrocinador, "PAGADO");
                MessageBox.Show("pagado");
                Close();
            }
            else
            {
                MessageBox.Show("El saldo ingresado debe ser igual al costo total.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
