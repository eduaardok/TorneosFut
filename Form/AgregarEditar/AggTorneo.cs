using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneosFut.Class;
namespace TorneosFut
{
    public partial class AggTorneo : Form
    {
        csTorneo csTorneo;
        csConexion conexion;
        static string id;
        static bool agg = true;
        string form;
        string tipo;
        csDatos csDatos;
        csDGV csDGV;
        public AggTorneo(bool a, string i, string u, string c)
        {
            csTorneo = new csTorneo(u, c);
            conexion = new csConexion(u, c);
            agg = a;
            id = i;
            csDatos = new csDatos(u, c);
            csDGV = new csDGV(u, c);
            InitializeComponent();
        }
        void Editar()
        {
            if (!agg)
            {
                lblEncabezado.Text = "EDICIÓN DE TORNEO";
                cmbFormato.Enabled = false;
                cmbModoFutbol.Enabled = false;
                btnCrear.Text = "EDITAR";

                DataTable torneo = conexion.ListDGV($"select F.NombreFormato, M.NombreModo from ModoFutbol M\r\ninner join \r\n(select t.IDTorneo, T.IDModoFutbol, F.NombreFormato from Formato F\r\ninner join\r\n(select IDTorneo, IDModoFutbol, IDFormato from Torneo) T on T.IDFormato = F.IDFormato)F on F.IDModoFutbol = M.IDModoFutbol\r\nwhere F.IDTorneo = {id}");
                form = torneo.Rows[0]["NombreFormato"].ToString();
                cmbFormato.DataSource = csTorneo.LlenarFormatoID(form);
                cmbFormato.ValueMember = "IDFormato";
                cmbFormato.DisplayMember = "NombreFormato";
                tipo = torneo.Rows[0]["NombreModo"].ToString();
                cmbModoFutbol.DataSource = csTorneo.LlenarModoID(tipo);
                cmbModoFutbol.ValueMember = "IDModoFutbol";
                cmbModoFutbol.DisplayMember = "NombreModo";
            }
        }
        private void AggTorneo_Load(object sender, EventArgs e)
        {
            panel2.Tag = "NoCambiar";
            panel1.Tag = "NoCambiar";
            panel3.Tag = "NoCambiar";
            panel4.Tag = "NoCambiar";
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            Editar();
            csDGV.llenarcmbOrganizador(cmbOrganizador);
            cmbOrganizador.SelectedIndex = -1;
            csDGV.llenarcmbFormato(cmbFormato);
            cmbFormato.SelectedIndex= -1;
            csDGV.llenarcmbModo(cmbModoFutbol);
            cmbModoFutbol.SelectedIndex = -1;

            Editar();
        }

        private void btngSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btngEnviar_Click(object sender, EventArgs e)
        {
            if (CamposVacios())
            {
                try
                {
                    if (!agg)
                    {
                        csDatos.EditarTorneo(id, txtNombre.Text, cmbFormato.SelectedValue.ToString(), cmbModoFutbol.SelectedValue.ToString(), cmbOrganizador.SelectedValue.ToString(), dtpInicio.Value.ToString(), dtpFin.Value.ToString(), decimal.Parse(txtCosto.Text));
                    }
                    else
                    {
                        csDatos.InsertarTorneo(txtNombre.Text, cmbFormato.SelectedValue.ToString(), cmbModoFutbol.SelectedValue.ToString(), cmbOrganizador.SelectedValue.ToString(), dtpInicio.Value.ToString(), dtpFin.Value.ToString(), decimal.Parse(txtCosto.Text));
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Datos invalidos");
                }
            }
        }
        bool CamposVacios()
        {
            if (txtNombre.Text == "" || txtCosto.Text == "" || cmbFormato.Text == "" || cmbModoFutbol.Text == "" || cmbOrganizador.Text == "" || dtpFin.Text == "" || dtpInicio.Text == "")
            {
                MessageBox.Show("Faltan datos por llenar");
                return false;
            }
            else return true;  
        }
    }
}
