using pruebas;
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
        csConexion csConexion;
        csImagenes csImagenes;
        private string _idJugador;
        private string _nombreJugador;
        private string _apellidoJugador;
        private string _sexo;
        private string _fechaNacimiento;
        private string _posicion;
        private string _nacionalidad;
        private string _peso;
        private string _altura;
        private string _piernaHabil;
        private string _imagenJugador;
        string ID;
        public csJugador(string u, string c)
        {
            csConexion = new csConexion(u,c);
            csImagenes = new csImagenes();
            
        }

        public string IDJugador
        {
            get => _idJugador;
            set => _idJugador = value;
        }
        public string NombreJugador
        {
            get => _nombreJugador;
            set => _nombreJugador = value;
        }
        public string ApellidoJugador
        {
            get => _apellidoJugador;
            set => _apellidoJugador = value;
        }
        public string Sexo
        {
            get => _sexo;
            set => _sexo = value;
        }
        public string FechaNacimiento
        {
            get => _fechaNacimiento;
            set => _fechaNacimiento = value;
        }
        public string Posicion
        {
            get => _posicion;
            set => _posicion = value;
        }
        public string Nacionalidad
        {
            get => _nacionalidad;
            set => _nacionalidad = value;
        }
        public string Peso
        {
            get => _peso;
            set => _peso = value;
        }
        public string Altura
        {
            get => _altura;
            set => _altura = value;
        }
        public string PiernaHabil
        {
            get => _piernaHabil;
            set => _piernaHabil = value;
        }

        public string ImagenJugador
        {
            get => _imagenJugador;
            set => _imagenJugador = value;
        }
        public string Imagen(string i)
        {

            DataGridView dt = new DataGridView();
            dt.DataSource = csConexion.ListDGV($"Select ImagenJugador from Jugador where IDJugador = '{ID}'");
            string img = dt.Rows[0].Cells[0].Value.ToString();
            return img;
        }
        public DataTable mostrarJugador()
        {
            return csConexion.ListDGV("select IDJugador,NombreJugador,ApellidoJugador,Sexo,FechaNacimiento,"
                                   + "Posicion,Nacionalidad,Peso,Altura,PiernaHabil from Jugador");
        }
        public DataTable ListaidJugadores()
        {
            DataTable dt = csConexion.ListDGV("Select IDJugador from Jugador");
            return dt;
        }
        public DataTable ListaDorsalesJugadores(string idEquipo)
        {
            DataTable dt = csConexion.ListDGV($"Select Dorsal from Jugador_Equipo where IDEquipo = '{idEquipo}'");
            return dt;
        }
        public DataTable ListadeJugadores()
        {
            DataTable dt = csConexion.ListDGV("Select * from Jugador");
            return dt;
        }
        public DataTable ListadeJugadoresSinEquipo()
        {
            DataTable dt = csConexion.ListDGV("select j.IDJugador,NombreJugador,ApellidoJugador from Jugador j  left join Jugador_Equipo e " +
                "on j.IDJugador=e.IDJugador where e.IDEquipo is null or e.FechaSalida is not null");
            return dt;
        }
        public DataTable ListadeJugadoresFiltro(string filtro)
        {
            DataTable dt;
            dt = csConexion.ListDGV($"select IDJugador,NombreJugador,ApellidoJugador,Sexo,FechaNacimiento, Posicion,Nacionalidad,Peso,Altura,PiernaHabil from Jugador where IDJugador like '%{filtro}%' " +
                    $"or NombreJugador like '%{filtro}%' or ApellidoJugador like '%{filtro}%' or Posicion like '%{filtro}%'");
            return dt;
        }
        public bool AgregarJugador(string idJugador, TextBox Txtnombre, TextBox txtapellido, ComboBox cmbsexo, DateTimePicker dtpNacimiento,
                                      ComboBox CmbPosicion, TextBox TxtNacionalidad, TextBox txtpeso, TextBox txtaltura, ComboBox cmbpierna, string imagen)
        {
            NombreJugador = Txtnombre.Text;
            ApellidoJugador = txtapellido.Text;
            Sexo = cmbsexo.Text;
            FechaNacimiento = dtpNacimiento.Value.ToString();
            MessageBox.Show(FechaNacimiento);
            Posicion = CmbPosicion.Text;
            Nacionalidad = TxtNacionalidad.Text;
            Peso = txtpeso.Text;
            Altura = txtaltura.Text;
            PiernaHabil = cmbpierna.Text;
            IDJugador = idJugador;
            ImagenJugador = imagen;
            string xmlJugador =
                "<Jugadores>" +
                "    <Jugador>" +
                $"        <IDJugador>{IDJugador}</IDJugador>" +
                $"        <NombreJugador>{NombreJugador}</NombreJugador>" +
                $"        <ApellidoJugador>{ApellidoJugador}</ApellidoJugador>" +
                $"        <Sexo>{Sexo}</Sexo>" +
                $"        <FechaNacimiento>{FechaNacimiento}</FechaNacimiento>" +
                $"        <Posicion>{Posicion}</Posicion>" +
                $"        <Nacionalidad>{Nacionalidad}</Nacionalidad>" +
                $"        <Peso>{Peso}</Peso>" +
                $"        <Altura>{Altura}</Altura>" +
                $"        <PiernaHabil>{PiernaHabil}</PiernaHabil>" +
                $"        <ImagenJugador>{ImagenJugador}</ImagenJugador>" +
                "    </Jugador>" +
                "</Jugadores>";
            if (csConexion.Consulta($"DECLARE @cadenaa VARCHAR(MAX) = '{xmlJugador}'; EXEC spRegistraJugador @cadenaa;"))
                return true;
            else
                return false;
        }
        public bool AgregarJugadorEquipo(string IDJugador, string IDEquipo, int Dorsal)
        {
            if (csConexion.Consulta($"insert into Jugador_Equipo (IDJugador, IDEquipo, FechaEntrada, Dorsal)" +
                $" values ('{IDJugador}', '{IDEquipo}', GETDATE(), {Dorsal})"))
                return true;
            else
                return false;
        }
        public bool DejarJugadorSinEquipo(string IDJugador, string IDEquipo)
        {
            if (csConexion.Consulta($"update Jugador_Equipo set FechaSalida= getdate() where IDJugador='{IDJugador}' and IDEquipo='{IDEquipo}'"))
                return true;
            else
                return false;
        }
    }
}