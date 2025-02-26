using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneosFut;

namespace pruebas
{
    public partial class Jugador: Form
    {
        csConexion conexion = new csConexion();
        verjugadores verJu;
        AgregarJugadores agregaJu;
        public Jugador()
        {

            InitializeComponent();
            verJu = new verjugadores();
            agregaJu = new AgregarJugadores(verJu);


        }
        public static void AbrirFormEnPanel(Panel panel, Form formHijo)
        {
            if (panel.Controls.Count > 0)
                panel.Controls.Clear(); // Limpia cualquier contenido previo

            formHijo.TopLevel = false;  // Indica que no es un formulario independiente
            formHijo.Dock = DockStyle.Fill; // Ajusta al tamaño del panel
            panel.Controls.Add(formHijo); // Agrega el formulario al panel
            panel.Tag = formHijo; // Asocia el formulario con el panel
            formHijo.BringToFront(); // Lo trae al frente
            formHijo.Show(); // Muestra el formulario dentro del panel
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void VerJugadores_Load(object sender, EventArgs e)
        {
            AbrirFormEnPanel(panel2, verJu);
        }

        private void gnjugadores_Click(object sender, EventArgs e)
        {
            gnAgregarJu.Checked = false;
            gnjugadores.Checked = true;
            AbrirFormEnPanel(panel2, verJu);
        }

        private void gnAgregarJu_Click(object sender, EventArgs e)
        {
            gnAgregarJu.Checked = true;
            gnjugadores.Checked = false;
            AbrirFormEnPanel(panel2, agregaJu);

        }
    }
}
