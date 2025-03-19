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
    public partial class InscripcionEquipo: Form
    {
        csConexion conexion;
        string IDPartido;
        csDGV csDGV;
        string IdTorneo;
        public InscripcionEquipo(string IDtorneo, string u, string c)
        {
            conexion = new csConexion(u, c);
            IdTorneo = IDtorneo;
            csDGV = new csDGV(u, c, IdTorneo, IDPartido);
            InitializeComponent();
        }

        private void btngCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InscripcionEquipo_Load(object sender, EventArgs e)
        {
            DataTable torneo = conexion.ListDGV($"Select NombreTorneo from Torneo where IDTorneo = {IdTorneo}");
            string Nametorneo = torneo.Rows[0]["NombreTorneo"].ToString();
            lbNameTorneo.Text = Nametorneo;

            DataTable equipos = conexion.ListDGV($"select NombreEquipo from Equipo");
            foreach (DataRow row in equipos.Rows)
            {
                string nombreEquipo = row["NombreEquipo"].ToString();
                cmbEquipos.Items.Add(nombreEquipo);
            }
            cmbEquipos.DropDownStyle = ComboBoxStyle.DropDown;
            cmbEquipos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbEquipos.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void lbBorde_Paint(object sender, PaintEventArgs e)
        {
            lbBorde.BackColor = Color.Transparent;
            using (Pen pen = new Pen(ColorTranslator.FromHtml("#FB038C"), 3))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, lbBorde.Width - 1, lbBorde.Height - 1);
            }
        }
    }
}
