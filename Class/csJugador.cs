using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TorneosFut.Class
{
    class csJugador
    {
        csConexion conexion;
        public csJugador(string u, string c)
        {
            conexion = new csConexion();
            conexion.Usuario = u;
            conexion.Clave = c;
        }

        public DataTable mostrarJugador()
        {
            return conexion.ListDGV("select Nombres,Apellidos,Sexo,FechaNacimiento,Posicion,EquipoActual,Goles,Disponibilidad, PartidosJugados,Nacionalidad,Peso,Altura,PiernaHabil from Jugador");
        }
        public string filtro(string filtro)
        {
            return $"select Nombres,Apellidos,Sexo,FechaNacimiento,Posicion,EquipoActual,Goles,Disponibilidad, PartidosJugados,Nacionalidad,Peso,Altura,PiernaHabil from Jugador where IDJugador like '%{filtro}%' or " +
                    $"Nombres like '%{filtro}%' or Apellidos like '%{filtro}%' or EquipoActual like '%{filtro}%'";

        }
        public void editarjugador(TextBox Txtnombre, TextBox txtapellido, ComboBox CmbPosicion,ComboBox Cmbequipo, TextBox txtpeso, TextBox txtaltura, int ID)
        {
            conexion.Consulta($"UPDATE Jugador set Nombres='{Txtnombre.Text}', Apellidos='{txtapellido.Text}'" +
                            $",Posicion='{CmbPosicion.Text}', EquipoActual={int.Parse(Cmbequipo.SelectedValue.ToString())}, Peso={decimal.Parse(txtpeso.Text)}, Altura= {decimal.Parse(txtaltura.Text)}  where IDJugador={ID}");
        }

        public void agregarJugador(TextBox Txtnombre, TextBox txtapellido, ComboBox cmbsexo, DateTimePicker dtpNacimiento, ComboBox CmbPosicion, ComboBox Cmbequipo,TextBox TxtNacionalidad, TextBox txtpeso, TextBox txtaltura, ComboBox cmbpierna)
        {
            conexion.Consulta("INSERT INTO Jugador (Nombres, Apellidos, Sexo, FechaNacimiento, Posicion, EquipoActual, Goles, Asistencias," +
                            " Disponibilidad, PartidosJugados, Nacionalidad, Peso, Altura, PiernaHabil, ImagenJugador) " +
                                     $"VALUES ('{Txtnombre.Text}', '{txtapellido.Text}', '{cmbsexo.Text}', '{dtpNacimiento.Value}', '{CmbPosicion.Text}', {int.Parse(Cmbequipo.SelectedValue.ToString())}, {0}, {0}, {1}, {0}, " +
                                 $"'{TxtNacionalidad.Text}', {decimal.Parse(txtpeso.Text)}, {decimal.Parse(txtaltura.Text)}, '{cmbpierna.Text}', 'imangens')");
        }

    }
}
