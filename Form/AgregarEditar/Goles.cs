using Guna.UI2.AnimatorNS;
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
    public partial class Goles: Form
    {
        //int IDPartido;
        //int IDJugador;
        csConexion conexion ;
        GestionarPartidos f;
        static string Id;
        csDGV csDGV;
        csPartido csPartido;
        public Goles(string u, string c, string ID)
        {
            conexion = new csConexion(u, c);
            Id = ID;
            csDGV= new csDGV(u,c);
            InitializeComponent(); 

        }
        private void editarjugador_Load(object sender, EventArgs e)
        {
            csDGV.MostrarEquiposCMB(CmbEquipo, Id);
            
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {

            //if (txtaltura.Text != "" && txtapellido.Text != "" && CmbPosicion.Text != "" && Cmbequipo.Text != "" && txtpeso.Text != "" && txtaltura.Text != "")
            //{
            //    if (!valinombres(Txtnombre) && !valinombres(txtapellido))
            //    {
            //        if (!validaaltu(txtaltura) && !validaaltu(txtpeso))
            //        {
            //            conexion.Consulta($"UPDATE Jugador set Nombres='{Txtnombre.Text}', Apellidos='{txtapellido.Text}'" +
            //                $",Posicion='{CmbPosicion.Text}', EquipoActual={int.Parse(Cmbequipo.SelectedValue.ToString())}, Peso={decimal.Parse(txtpeso.Text)}, Altura= {decimal.Parse(txtaltura.Text)}  where IDJugador={ID}");
            //            txtaltura.Clear();
            //            txtapellido.Clear();
            //            txtpeso.Clear();
            //            Txtnombre.Clear();
            //            Cmbequipo.SelectedIndex = -1;
            //            CmbPosicion.SelectedIndex = -1;
            //            MessageBox.Show("Jugador editado con exito");
            //            f.dgvJugador.DataSource = conexion.ListDGV("Select* from Jugador");
            //            Close();
            //        }
            //        else MessageBox.Show("altura invalida");
            //    }
            //    else MessageBox.Show("Nombre invalido, solo se permite letras");
            //}
        }
        bool validaaltu(TextBox txt)
        {
            for (int i = 1; i < txt.Text.Length; i++)
            {
                for (int j = 46; j < 58; j++)
                {
                    if (txt.Text[i] != j)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        bool valinombres(TextBox txt)
        {
            for (int i = 1; i < txt.Text.Length; i++)
            {
                for (int j = 97; j < 123; j++)
                {
                    if (txt.Text[i] != j)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void CmbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
          
           csPartido= new csPartido(conexion.Usuario,conexion.Clave,CmbEquipo.Text);
            CMBJugador.DataSource = csPartido.ListaDeJugadoresEquipo(CmbEquipo.Text);
            CMBJugador.ValueMember = "IDJugador";
            CMBJugador.DisplayMember = "NombreJugador";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btngCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            bool local;
            DataTable dt = conexion.ListDGV($"select count(*) from Partido where EquipoLocal = '{CmbEquipo.Text}' and IDPartido = {Id}");
            if (dt.Rows[0][0].ToString() == "1")
                local = true;
            else
                local = false;
           // MessageBox.Show(dt.Rows[0][0].ToString() + CmbEquipo.SelectedValue);
            if (local)
            {
                dt = conexion.ListDGV($"select count(*) from Gol G inner join Partido P on G.IDPartido=P.IDPartido where P.IDPartido = {Id} and P.EquipoLocal = '{CmbEquipo.Text}'");
                int golesact = int.Parse(dt.Rows[0][0].ToString());
                conexion.Consulta($"update Partido set GolesLocal = {golesact+1} where IDPartido = {Id}; "+
                    $"insert into Gol (IDPartido, IDJugador, Minuto) values ({Id}, '{CMBJugador.SelectedValue}', {txtMinuto.Text})");
            }
            else
            {
                dt = conexion.ListDGV($"select count(*) from Gol G inner join Partido P on G.IDPartido=P.IDPartido where P.IDPartido = {Id} and P.EquipoVisitante = '{CmbEquipo.Text}'");
                int golesact = int.Parse(dt.Rows[0][0].ToString());
                conexion.Consulta($"update Partido set GolesVisitante = {golesact + 1} where IDPartido = {Id}; " +
                    $"insert into Gol (IDPartido, IDJugador, Minuto) values ({Id}, '{CMBJugador.SelectedValue}', {txtMinuto.Text})"); 
            }
            Close();
        }
    }
}
