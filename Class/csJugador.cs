using pruebas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
                                   + "Posicion,Nacionalidad,Peso,Altura,PiernaHabil,ImagenJugador from Jugador");
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
            DataTable dt = csConexion.ListDGV("select j.IDJugador, NombreJugador, ApellidoJugador from Jugador j left join Jugador_Equipo e on j.IDJugador = e.IDJugador where e.IDEquipo is null or e.FechaSalida is not null");
            return dt;
        }
        public DataTable ListadeJugadoresFiltro(string filtro)
        {
            DataTable dt;
            dt = csConexion.ListDGV($"select IDJugador,NombreJugador,ApellidoJugador,Sexo,FechaNacimiento, Posicion,Nacionalidad,Peso,Altura,PiernaHabil,ImagenJugador from Jugador where IDJugador like '%{filtro}%' " +
                    $"or NombreJugador like '%{filtro}%' or ApellidoJugador like '%{filtro}%' or Posicion like '%{filtro}%'");
            return dt;
        }

        public void MostrarImagen(string id, PictureBox ptb)
        {
            DataTable datat = csConexion.ListDGV($"Select ImagenJugador from Jugador where IDJugador = '{id}'");

            if (datat != null && datat.Rows.Count > 0)
            {
                string nombreIMG = datat.Rows[0]["ImagenJugador"].ToString();
                csImagenes.CargarImagen(nombreIMG, ptb);
            }
        }
        #region Insertar
        public bool AgregarJugador( TextBox Txtnombre, TextBox txtapellido, ComboBox cmbsexo, DateTimePicker dtpNacimiento,
                                      ComboBox CmbPosicion, TextBox TxtNacionalidad, TextBox txtpeso, TextBox txtaltura, ComboBox cmbpierna, string imagen)
        {
            NombreJugador = Txtnombre.Text;
            ApellidoJugador = txtapellido.Text;
            Sexo = cmbsexo.Text;
            FechaNacimiento = dtpNacimiento.Value.ToString("yyyy-MM-dd");
            Posicion = CmbPosicion.Text;
            Nacionalidad = TxtNacionalidad.Text;
            Peso = txtpeso.Text;
            Altura = txtaltura.Text;
            PiernaHabil = cmbpierna.Text;
            IDJugador = IDGeneradoIDJugador(NombreJugador,ApellidoJugador);
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
        public string IDGeneradoIDJugador(string nombre, string apellido)
        {
            nombre = nombre.ToUpper();
            apellido = apellido.ToUpper();
            string id = "";
            Random rnd = new Random();
            bool repetir = false;
            do
            {
                char primeraLetraNombre = nombre[0];
                char primeraLetraApellido = apellido[0];
                char letraAleatoriaNombre = nombre[rnd.Next(1, nombre.Length)];
                char letraAleatoriaApellido = apellido[rnd.Next(1, apellido.Length)];
                char numeroRandom = rnd.Next(0, 10).ToString()[0];
                id = $"{primeraLetraNombre}{primeraLetraApellido}{letraAleatoriaNombre}{letraAleatoriaApellido}{numeroRandom}";
                // Verificar si el ID ya existe en la base de datos
                DataTable dt = csConexion.ListDGV($"SELECT 1 FROM Jugador WHERE IDJugador= '{id}'");
                repetir = (dt.Rows.Count > 0);
            } while (repetir); // Si ya existe, se repite el proceso
            return id;
        }
        #endregion
        #region Actualizar

        #endregion 
        public bool ActualizarJugador(string idJugador,TextBox Txtnombre, TextBox txtapellido, ComboBox cmbsexo, DateTimePicker dtpNacimiento,
        ComboBox CmbPosicion, TextBox TxtNacionalidad, TextBox txtpeso, TextBox txtaltura, ComboBox cmbpierna, string imagen)
        {
            NombreJugador = Txtnombre.Text;
            ApellidoJugador = txtapellido.Text;
            Sexo = cmbsexo.Text;
            FechaNacimiento = dtpNacimiento.Value.ToString("yyyy-MM-dd");
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
            if (csConexion.Consulta($"DECLARE @cadenaa VARCHAR(MAX) = '{xmlJugador}'; EXEC spEditarJugador @cadenaa;"))
                return true;
            else
                return false;
        }
        public bool AgregarJugadorEquipo(string IDJugador, string IDEquipo, int Dorsal)
        {
            try
            {

                csConexion.Consulta($"update Jugador_Equipo set FechaSalida = null where IDJugador = '{IDJugador}' and FechaSalida is not null ");
                if (csConexion.Consulta($"exec spRegistraJugadorEquipo '{IDJugador}', '{IDEquipo}', {Dorsal}"))
                    return true;
                else return false;
            }
            catch(SqlException ex)
            {
                if (ex.Message.Contains("El dorsal"))
                {
                    MessageBox.Show(ex.Message); 
                }
                return false;
            }
        }
        public bool DejarJugadorSinEquipo(string IDJugador, string IDEquipo)
        {
            if (csConexion.Consulta($"exec spQuitarJugadorEquipo '{IDJugador}', '{IDEquipo}'"))
                return true;
            else
                return false;
        }
        public DataTable ObtenerTitularesPorPartido(int idPartido, string idEquipo)
        {
            string query = $@" select j.IDJugador, j.NombreJugador + ' ' + j.ApellidoJugador as NombreCompleto, j.Posicion, je.Dorsal, j.ImagenJugador as ImagenUrl
                            from JugadorPartido jp join Jugador j on jp.IDJugador = j.IDJugador join Jugador_Equipo je on j.IDJugador = je.IDJugador and je.IDEquipo = '{idEquipo}'
                             where jp.IDPartido = {idPartido} and jp.EsTitular = 1 order by case  when j.Posicion like '%PORTERO%' then 1 when j.Posicion like '%DEFENSA%' then 2
                             when j.Posicion like '%MEDIO%' then 3 when j.Posicion like '%DELANTERO%' then 4 else 5 end,  je.Dorsal";
            DataTable dt = csConexion.ListDGV(query);
            return dt;
        }
        public bool AgregarTitulares(string IDJugador, int IDPartido)
        {
            try
            {
                if (csConexion.Consulta($"exec spRegistraTitulares '{IDJugador}', {IDPartido}"))
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error al registrar jugador: {ex.Message}");
                return false;
            }
        }
        public bool QuitarTitulares(string IDJugador, int IDPartido)
        {
            try
            {
                // Ejecuta el procedimiento almacenado para quitar al jugador de los titulares
                if (csConexion.Consulta($"exec spQuitarTitular '{IDJugador}', {IDPartido}"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                // Maneja los errores y muestra un mensaje en caso de excepciones
                MessageBox.Show($"Error al quitar jugador de titulares: {ex.Message}");
                return false;
            }
        }

    }
}