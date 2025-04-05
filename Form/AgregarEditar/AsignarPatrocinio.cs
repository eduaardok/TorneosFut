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
    public partial class AsignarPatrocinio: Form
    {
        csConexion conexion;
        public AsignarPatrocinio(string u, string c)
        {
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
                int idTorneo = Convert.ToInt32(row["IDTorneo"]);
                string nombreTorneo = row["NombreTorneo"].ToString();
                cmbTorneos.Items.Add(nombreTorneo);
            }
            DataTable patro = conexion.ListDGV($"SELECT * FROM Patrocinador");
            cmbPatrocinadores.Items.Clear();
            foreach (DataRow row in patro.Rows)
            {
                string idPatro = row["IDPatrocinador"].ToString();
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

        private void cmbPatrocinadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreEmpresaSeleccionada = cmbPatrocinadores.SelectedItem.ToString();

            DataTable dt = conexion.ListDGV(
                $"SELECT * FROM Patrocinador WHERE NombreEmpresa = '{nombreEmpresaSeleccionada.Replace("'", "''")}'"
            );

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtNameEmpresa.Text = row["NombreEmpresa"].ToString();
                txtNameContacto.Text = row["NombreContacto"].ToString();
                txtTelefono.Text = row["Telefono"].ToString();
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
    }
}
