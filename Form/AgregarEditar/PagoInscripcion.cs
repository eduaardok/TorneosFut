using pruebas;
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
    public partial class PagoInscripcion : Form
    {
        csConexion conexion;
        csDatos csDatos;
        string IDPartido;
        csDGV csDGV;
        string IdTorneo;
        decimal costo;
        decimal abono;
        decimal saldo;
        string IdEquipo;
        public PagoInscripcion(string IDtorneo, string IDEquipo, string u, string c)
        {
            conexion = new csConexion(u, c);
            csDatos = new csDatos(u, c);
            IdTorneo = IDtorneo;
            IdEquipo = IDEquipo;
            csDGV = new csDGV(u, c, IdTorneo, IDPartido);
            InitializeComponent();
        }
        private void PagoInscripcion_Load(object sender, EventArgs e)
        {
            DataTable torneoo = conexion.ListDGV($"select IDInscripcion, Estado, Saldo, MontoAPagar from InscripcionEquipo where IDTorneo = {IdTorneo} and IDEquipo = '{IdEquipo}'");
            lblCosto.Text = Convert.ToDecimal(torneoo.Rows[0]["Saldo"].ToString()).ToString("F2");


            DataTable equipos = conexion.ListDGV($"select NombreEquipo from Equipo where IDEquipo = '{IdEquipo}'");
            string nameEquipo = equipos.Rows[0]["NombreEquipo"].ToString();
            lblEquipo.Text = nameEquipo;

            DataTable torneo = conexion.ListDGV($"Select NombreTorneo, CostoInscripcion, FechaInicio from Torneo where IDTorneo = {IdTorneo}");
            string Nametorneo = torneo.Rows[0]["NombreTorneo"].ToString();
            //lblCosto.Text = Convert.ToDecimal(torneo.Rows[0]["CostoInscripcion"].ToString()).ToString("F2");
            lblSaldo.Text = lblCosto.Text;
            lblFechaLimite.Text = Convert.ToDateTime(torneo.Rows[0]["FechaInicio"]).ToString("yyyy-MM-dd");
            lbNameTorneo.Text = Nametorneo;
            costo = decimal.Parse(lblCosto.Text);

        }

        private void btngCancelar_Click(object sender, EventArgs e)
        {
            lblEquipo.Text = "";
            Close();
        }

        private void txtAbono_TextChanged_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAbono.Text, out abono))
            {
                saldo = costo - abono;
                lblSaldo.Text = saldo.ToString();
            }
            else
            {
                lblSaldo.Text = lblCosto.Text;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataTable torneo = conexion.ListDGV($"select IDInscripcion, Estado, Saldo, MontoAPagar from InscripcionEquipo where IDTorneo = {IdTorneo} and IDEquipo = '{IdEquipo}'");
            string idInscripcion = torneo.Rows[0]["IDInscripcion"].ToString();
            string estadoo = torneo.Rows[0]["Estado"].ToString();
            decimal saldoo = decimal.Parse(torneo.Rows[0]["Saldo"].ToString());
            decimal montoo = decimal.Parse(torneo.Rows[0]["MontoAPagar"].ToString());
            
            if (decimal.TryParse(txtAbono.Text, out abono))
            {
                if (csDatos.InsertarMovimientoInscripcion(int.Parse(IdTorneo), abono, txtDescripcion.Text, idInscripcion, montoo, saldoo, estadoo))
                {
                    MessageBox.Show("Se abono correctamente");
                }
                else
                {
                    MessageBox.Show("Error al abonar");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingresa un abono válido.");
            }
        }
    }
}