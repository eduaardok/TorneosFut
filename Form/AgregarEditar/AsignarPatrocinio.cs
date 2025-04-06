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
    public partial class AsignarPatrocinio : Form
    {
        csDatos datos;
        csConexion conexion;
        string idPatrocinaddor;
        int IDTorneo;
        public AsignarPatrocinio(string u, string c)
        {
            datos = new csDatos(u, c);
            conexion = new csConexion(u, c);
            InitializeComponent();
        }

        private void btngSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AsignarPatrocinio_Load(object sender, EventArgs e)
        {
            DataTable torneooo = conexion.ListDGV($"SELECT * FROM Torneo");
            cmbTorneos.Items.Clear();
            foreach (DataRow row in torneooo.Rows)
            {
                string nombreTorneo = row["NombreTorneo"].ToString();
                cmbTorneos.Items.Add(nombreTorneo);
            }
            DataTable patro = conexion.ListDGV($"SELECT * FROM Patrocinador");
            cmbPatrocinadores.Items.Clear();
            foreach (DataRow row in patro.Rows)
            {
                string nombreEmpresa = row["NombreEmpresa"].ToString();
                cmbPatrocinadores.Items.Add(nombreEmpresa);
            }
            cmbPatrocinadores.SelectedIndexChanged += cmbPatrocinadores_SelectedIndexChanged;

            panelBronce.FillColor = Color.White; // Fondo blanco
            panelBronce.CustomBorderColor = Color.White; // Tu color rosa
            panelBronce.CustomBorderThickness = new Padding(2); // Grosor del borde
            panelPlata.FillColor = Color.White; // Fondo blanco
            panelPlata.CustomBorderColor = Color.White;
            panelPlata.CustomBorderThickness = new Padding(2); // Grosor del borde
            panelOro.FillColor = Color.White; // Fondo blanco
            panelOro.CustomBorderColor = Color.White; // Tu color rosa
            panelOro.CustomBorderThickness = new Padding(2); // Grosor del borde

                                  
        }
       
        private void cmbTorneos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            decimal costoInscripcion = 0;
            string nombreTorneo = cmbTorneos.SelectedItem.ToString();
            DataTable dt = conexion.ListDGV(
                $"SELECT * FROM Torneo WHERE NombreTorneo = '{nombreTorneo.Replace("'", "''")}'"
            );
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                IDTorneo = Convert.ToInt32(row["IDTorneo"].ToString());
                costoInscripcion = Convert.ToDecimal(row["CostoInscripcion"].ToString());
            }
            CostosPatrocinio(costoInscripcion);
        }
        private void CostosPatrocinio(decimal x)
        {
            if ((x > 0) && (x <= 50))
            {
                lblCostoBronce.Text = "10.00";
                lblCostoPlata.Text = "20.00";
                lblCostoOro.Text = "30.00";
            }
            else if(x < 100)
            {
                lblCostoBronce.Text = "15.00";
                lblCostoPlata.Text = "30.00";
                lblCostoOro.Text = "50.00";
            }
            else
            {
                lblCostoBronce.Text = "25.00";
                lblCostoPlata.Text = "50.00";
                lblCostoOro.Text = "75.00";
            }
        }

        private void cmbPatrocinadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreEmpresa = cmbPatrocinadores.SelectedItem.ToString();

            DataTable dt = conexion.ListDGV(
                $"SELECT * FROM Patrocinador WHERE NombreEmpresa = '{nombreEmpresa.Replace("'", "''")}'"
            );

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtNameEmpresa.Text = row["NombreEmpresa"].ToString();
                txtNameContacto.Text = row["NombreContacto"].ToString();
                txtTelefono.Text = row["Telefono"].ToString();
                idPatrocinaddor = row["IDPatrocinador"].ToString();
            }
        }

        private void btnBronce_CheckedChanged(object sender, EventArgs e)
        {
            if (btnBronce.Checked)
            {
                btnPlata.Checked = false;
                btnOro.Checked = false;
            }
            panelBronce.CustomBorderColor = Color.FromArgb(251, 3, 140);
            panelPlata.CustomBorderColor = Color.White;
            panelOro.CustomBorderColor = Color.White;
        }

        private void btnPlata_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPlata.Checked)
            {
                btnBronce.Checked = false;
                btnOro.Checked = false;
            }
            panelPlata.CustomBorderColor = Color.FromArgb(251, 3, 140);
            panelBronce.CustomBorderColor = Color.White;
            panelOro.CustomBorderColor = Color.White;
        }

        private void btnOro_CheckedChanged(object sender, EventArgs e)
        {
            if (btnOro.Checked)
            {
                btnBronce.Checked = false;
                btnPlata.Checked = false;
            }
            panelOro.CustomBorderColor = Color.FromArgb(251, 3, 140);
            panelPlata.CustomBorderColor = Color.White;
            panelBronce.CustomBorderColor = Color.White;
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            string tipoPatrocinio = "";
            decimal precioPatrocinio = 0;

            if (btnBronce.Checked)
            {
                tipoPatrocinio = "Bronce";
                precioPatrocinio = Convert.ToDecimal(lblCostoBronce.Text.Trim().ToString());
                MessageBox.Show(precioPatrocinio.ToString());
            }
            else if (btnPlata.Checked)
            {
                tipoPatrocinio = "Plata";
                precioPatrocinio = Convert.ToDecimal(lblCostoPlata.Text.Trim().ToString());
                MessageBox.Show(precioPatrocinio.ToString());
            }
            else if (btnOro.Checked)
            {
                tipoPatrocinio = "Oro";
                precioPatrocinio = Convert.ToDecimal(lblCostoOro.Text.Trim().ToString());
                MessageBox.Show(precioPatrocinio.ToString());
            }
            else
            {
                MessageBox.Show("Debes seleccionar un nivel de patrocinio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (datos.AsignarPatrocinio(idPatrocinaddor, IDTorneo, tipoPatrocinio, precioPatrocinio, "PENDIENTE"))
            {
                MessageBox.Show("¡Patrocinador asignado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error al asignar el patrocinador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
