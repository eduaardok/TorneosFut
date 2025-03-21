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

namespace TorneosFut
{
    public partial class InscripcionEquipo : Form
    {
        csConexion conexion;
        csDatos csDatos;
        string IDPartido;
        csDGV csDGV;
        string IdTorneo;
        bool Incripcion;
        decimal costo;
        decimal abono;
        decimal saldo;
        public InscripcionEquipo(string IDtorneo, string u, string c, bool x)
        {
            conexion = new csConexion(u, c);
            csDatos = new csDatos(u, c);
            IdTorneo = IDtorneo;
            csDGV = new csDGV(u, c, IdTorneo, IDPartido);
            Incripcion = x;
            InitializeComponent();
        }

        private void btngCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InscripcionEquipo_Load(object sender, EventArgs e)
        {
            DataTable equipos = conexion.ListDGV($"select NombreEquipo from Equipo");
            foreach (DataRow row in equipos.Rows)
            {
                string nombreEquipo = row["NombreEquipo"].ToString();
                cmbEquipos.Items.Add(nombreEquipo);
            }
            cmbEquipos.DropDownStyle = ComboBoxStyle.DropDown;
            cmbEquipos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbEquipos.AutoCompleteSource = AutoCompleteSource.ListItems;

            DataTable torneo = conexion.ListDGV($"Select NombreTorneo, CostoInscripcion from Torneo where IDTorneo = {IdTorneo}");
            string Nametorneo = torneo.Rows[0]["NombreTorneo"].ToString();
            txtCosto.Text = torneo.Rows[0]["CostoInscripcion"].ToString();
            lbNameTorneo.Text = Nametorneo;
            costo = decimal.Parse(txtCosto.Text);
        }
        private void lbBorde_Paint(object sender, PaintEventArgs e)
        {
            lbBorde.BackColor = Color.Transparent;
            using (Pen pen = new Pen(ColorTranslator.FromHtml("#FB038C"), 3))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, lbBorde.Width - 1, lbBorde.Height - 1);
            }
        }
        private void txtAbono_TextChanged_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAbono.Text, out abono))
            {
                saldo = costo - abono;
                txtSaldo.Text = saldo.ToString();
            }
            else
            {
                txtSaldo.Text = "0.00";
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataTable equipos = conexion.ListDGV($"select IDEquipo from Equipo where NombreEquipo = '{cmbEquipos.SelectedItem}'");
            string idequipo = equipos.Rows[0]["IDEquipo"].ToString();

            if (decimal.TryParse(txtAbono.Text, out abono))
            {
                if (Incripcion)
                {
                    if (csDatos.InsertarIncripcion(int.Parse(IdTorneo), idequipo, abono, saldo, costo, dtpFecha.Value, "Pendiente"))
                    {
                        MessageBox.Show("Se inscribió el equipo correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al inscribir el equipo");
                    }
                }
                else
                {
                    // En proceso
                }
            }
            else
            {
                MessageBox.Show("Por favor ingresa un abono válido.");
            }
        }
    }
}