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
            conexion = new csConexion(u, c);
        }

        public DataTable mostrarJugador()
        {
            return conexion.ListDGV(@"select IDJugador,NombreJugador,ApellidoJugador,Sexo,fechaNacimiento,
                                    Posicion,Nacionalidad,Peso,Altura,PiernaHabil from Jugador");
        }
        public string filtro(string filtro)
        {
            return $@"select IDJugador,NombreJugador,ApellidoJugador,Sexo,fechaNacimiento,
                                    Posicion,Nacionalidad,Peso,Altura,PiernaHabil from Jugador where IDJugador like '%{filtro}%' or 
                    Nombres like '%{filtro}%' or Apellidos like '%{filtro}%' or EquipoActual like '%{filtro}%'";
        }
        public void editarjugador(TextBox Txtnombre, TextBox txtapellido, ComboBox CmbPosicion, TextBox txtpeso, TextBox txtaltura, int ID)
        {
            conexion.Consulta($@"UPDATE Jugador set NombreJugador='{Txtnombre.Text}', ApellidoJugador='{txtapellido.Text}'
                            ,Posicion='{CmbPosicion.Text}', 
                            Peso={decimal.Parse(txtpeso.Text)}, Altura= {decimal.Parse(txtaltura.Text)}  where IDJugador={ID}");
        }
        public void agregarJugador(TextBox Txtnombre, TextBox txtapellido, ComboBox cmbsexo, DateTimePicker dtpNacimiento, ComboBox CmbPosicion, TextBox TxtNacionalidad, TextBox txtpeso, TextBox txtaltura, ComboBox cmbpierna)
        {
            conexion.Consulta($@"INSERT INTO Jugador (IDJugador, NombreJugador,ApellidoJugador,Sexo,fechaNacimiento,
                                    Posicion,Nacionalidad,Peso,Altura,PiernaHabil)  
                            VALUES ('1250598925', '{Txtnombre.Text}', '{txtapellido.Text}', '{cmbsexo.Text}', '{dtpNacimiento.Value}', 
                            '{CmbPosicion.Text}','{TxtNacionalidad.Text}', {decimal.Parse(txtpeso.Text)}, {decimal.Parse(txtaltura.Text)}, 
                            '{cmbpierna.Text}')");
        }
        public DataTable ListadeJugadores()
        {
            DataTable dt = conexion.ListDGV("Select * from Jugador");
            return dt;
        }
        public DataTable ListadeJugadoresfiltro(string filtro)
        {
            DataTable dt;
            dt = conexion.ListDGV($"select * from Jugador where IDJugador like '%{filtro}%' " +
                    $"or Nombres like '%{filtro}%' or Apellidos like '%{filtro}%' or EquipoActual like '%{filtro}%'");
            return dt;
        }
    }
}
