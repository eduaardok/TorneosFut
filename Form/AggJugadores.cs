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
using TorneosFut.Class;
namespace pruebas
{
    public partial class AggJugadores : Form
    {
        OpenFileDialog img;
        csImagenes imagenes;
        csConexion conexion;
        Jugador ve;
        csJugador jugador;
        public AggJugadores(Jugador f, string u, string c)
        {
            img = new OpenFileDialog();
            imagenes = new csImagenes();
            conexion = new csConexion();
            conexion.Usuario = u;
            conexion.Clave = c;
            jugador = new csJugador(u, c);
            InitializeComponent();
            ve= f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
        }

        private void lblPosicion_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtaltura.Text != "" && txtapellido.Text != "" && cmbsexo.Text != "" && dtpNacimiento.Text != "" && CmbPosicion.Text != "" && TxtNacionalidad.Text != "" && txtpeso.Text != "" && txtaltura.Text != "" && cmbpierna.Text != "")
                {
                    if (!valinombres(Txtnombre) && !valinombres(txtapellido))
                    {
                        if (!validaaltu(txtaltura) && !validaaltu(txtpeso))
                        {
                            jugador.AgregarJugador(txtIDJugador,Txtnombre, txtapellido, cmbsexo, dtpNacimiento, CmbPosicion,TxtNacionalidad, txtpeso, txtaltura, cmbpierna);
                            txtaltura.Clear();
                            txtapellido.Clear();
                            txtpeso.Clear();
                            TxtNacionalidad.Clear();
                            Txtnombre.Clear();
                            cmbpierna.SelectedIndex = -1;
                            cmbsexo.SelectedIndex = -1;
                            CmbPosicion.SelectedIndex = -1;
                            MessageBox.Show("Jugador agregado con exito");
                            ve.dgvJugador.DataSource = jugador.mostrarJugador();
                        }
                        else MessageBox.Show("altura invalida");
                    }
                    else MessageBox.Show("Nombre invalido, solo se permite letras");
                }
                else MessageBox.Show("Llenar todos los campos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        bool validaaltu(TextBox txt)
        {
            foreach (char c in txt.Text)
            {
                if (!char.IsDigit(c) && c != '.')
                {
                    return true;
                }
            }
            return false;
        }

        bool valinombres(TextBox txt)
        {
            foreach (char c in txt.Text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return true;
                }
            }
            return false;
        }

        private void btngCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCargarimagen_Click(object sender, EventArgs e)
        {
            img.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;";
            img.Title = "Selecciona una imagen";

            if (img.ShowDialog() == DialogResult.OK)
            {
                ptbImagen.Image = Image.FromFile(img.FileName);
            }
        }
    }
}