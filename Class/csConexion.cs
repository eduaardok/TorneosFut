using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows.Forms;

namespace TorneosFut
{
    internal class csConexion
    {
        private SqlConnection conec;
        private string _server = "26.102.193.210";
       // private string _server = ".";
        private string _database = "BDTorneosBeta";
        // private string _database = "BDTorneosFutbol";
        private string _usuario;
        private string _clave;
        public string Server
        {
            get => _server;
            set => _server = value;
        }
        public string Database
        {
            get => _database;
            set => _database = value;
        }
        public string Usuario
        {
            get => _usuario;
            set => _usuario = value;
        }
        public string Clave
        {
            get => _clave;
            set => _clave = value;
        }
        public SqlConnection Conexion
        {
            get => conec;
            set => conec = value;
        }
        private string CadenaConexion => $"Server={_server}; Database={_database}; User id={_usuario}; Password={_clave};";
        public csConexion()
        {
            _usuario = "UsuarioLectura";
            _clave = "usuario";
        }
        void Conectar()
        {
            string CadenaConexion = $"Server={_server}; Database={_database}; User id={_usuario}; Password={_clave};";
            conec = new SqlConnection(CadenaConexion);
        }
        public bool AbrirCon()
        {
            Conectar();
            try
            {
                conec.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }

        public DataTable ListDGV(string consul)
        {
            AbrirCon();
            DataTable data = new DataTable();
            SqlDataAdapter sqlData = new SqlDataAdapter(consul, conec);
            sqlData.Fill(data);
            CerrarCon();
            return data;
        }

        // Para guardar la imagen
        public bool EjecutarTransaccion(string consultaDatos, string consultaImagen, byte[] imagen, string nombreParametroID = "@IDEntidad")
        {
            conec.Open();
            SqlTransaction transaccion = conec.BeginTransaction();
            try
            {
                string consultaID = consultaDatos + "; SELECT SCOPE_IDENTITY();";
                SqlCommand comandoDatos = new SqlCommand(consultaID, conec, transaccion);
                int idEntidad = Convert.ToInt32(comandoDatos.ExecuteScalar());

                SqlCommand comandoImagen = new SqlCommand(consultaImagen, conec, transaccion);
                comandoImagen.Parameters.AddWithValue("@imagen", imagen);
                comandoImagen.Parameters.AddWithValue(nombreParametroID, idEntidad);
                comandoImagen.ExecuteNonQuery();

                transaccion.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                MessageBox.Show($"Error en la transacción: {ex.Message}");
                return false;
            }
            // Esta es la estructura que se usa para llamar la función, también guarda registros en general no solo la imagen, así que deben // hacer 2 consultas, una para la imagen y otra para guardar los demás datos, vean el código del frmAggEntrenador en el evento 
            // clic del botón para que vean como se usa, también ahí esta el código para que vean como se convierte la imagen a byte y todo eso
            // conec.EjecutarTransaccion(consultaDatos, consultaImagen, imgByte)
        }

        // Para editar la imagen
        public bool EditarImagen(int idEntidad, byte[] imagen, string tabla, string columnaImagen, string columnaID)
        {
            conec.Open();
            SqlTransaction transaccion = conec.BeginTransaction();
            try
            {
                string consultaImagen = $"update {tabla} set {columnaImagen} = @imagen where {columnaID} = @idEntidad";
                SqlCommand comandoImagen = new SqlCommand(consultaImagen, conec, transaccion);
                comandoImagen.Parameters.AddWithValue("@imagen", imagen);
                comandoImagen.Parameters.AddWithValue("@idEntidad", idEntidad);
                comandoImagen.ExecuteNonQuery();
                transaccion.Commit();
                conec.Close();
                return true;
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                MessageBox.Show($"Error en la transacción: {ex.Message}");
                conec.Close();
                return false;
            }
            // Esta función solamente edita lo que son las imágenes, no es como la anterior que también edita los registros, así que tengan en cuenta esto
            // aquí esta el ejemplo de como se usa la función el ID del entrenador yo lo obtengo directamente del DGV, no se como lo harán ustedes pero deben pasárselo ya sea como variable o si no de forma directa, lo de img es prácticamente lo mismo que antes solo que ahora se va a editar la info, le tienen que pasar aparte de esas 2 cosas, el nombre de la tabla, el nombre que tenga la columna en donde se guarda la imagen, y el nombre de la columna en la que se almacena el ID de lo que sea que vayan a guardar
            // al igual que antes pueden ir al frmEditarDT para que vean como lo uso yo
            // conec.EditarImagen(idEntrenador, imgByte, "Entrenador", "ImagenEntrenador", "IDEntrenador");
        }

        // Para poder obtener la imagen y mostrarla 
        public byte[] ObtenerImagen(string consulta, string columnaImagen)
        {
            byte[] imagen = null;
            try
            {
                AbrirCon();
                SqlCommand comando = new SqlCommand(consulta, conec);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    if (!reader.IsDBNull(reader.GetOrdinal(columnaImagen)))
                    {
                        imagen = (byte[])reader[columnaImagen];
                    }
                }
                reader.Close();
                CerrarCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la imagen: " + ex.Message);
            }
            return imagen;
            // Aquí como se ve solamente es de pasar la consulta y el nombre de la columna en la que se almacena la imagen así como antes, yo hago que se muestre cuando se selecciona algo en el DGV, así mismo vean el código que hay en frmEntrenadores para que vean como lo uso
            // conec.ObtenerImagen(consulta, "ImagenEntrenador")
        }
        public void RegistrarAuditoriaInicioSesion(string usuario, bool exito)
        {
            string estado = exito ? "Exitoso" : "Fallido";

            string query = "INSERT INTO Auditoria_IniciosDeSesion (usuario, estado) " +
                           $"VALUES ('{usuario}', '{estado}')";
            Consulta(query);
        }

        public bool Login(string usuario, string contraseña)
        {
            string consulta = $"select ClaveUsuario from Usuario where NombreUsuario='{usuario}'";
            DataTable dt = ListDGV(consulta);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (contraseña == dt.Rows[i][0].ToString())
                {
                    return true;
                }
            }
            return false;
        }
        public string RetornaUser(string u)
        {
            DataTable dt = ListDGV($"select NombreUsuarioBD from Usuario where NombreUsuario='{u}'");
            return $"{dt.Rows[0][0].ToString()}";
        }
        public string RetornaClave(string u)
        {
            DataTable dt = ListDGV($"select ClaveBD from Usuario where NombreUsuario='{u}'");
            return $"{dt.Rows[0][0].ToString()}";
        }
        public bool Consulta(string consul)
        {
            AbrirCon();
            SqlCommand consulta = new SqlCommand(consul, conec);
            try
            {
                consulta.ExecuteNonQuery();
                CerrarCon();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CerrarCon();
                return false;
            }
        }
        public bool CerrarCon()
        {
            conec.Close();
            return true;
        }
        public bool CrearLoginBD(string user, string pass)
        {
            Database = "master";
            AbrirCon();
            string consul = $"IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = '{user}') BEGIN " +
                $"CREATE LOGIN {user} WITH PASSWORD = '{pass}'; END" +
                $"  USE BDTorneosFutbol; IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = '{user}') " +
                $"   BEGIN CREATE USER {user} FOR LOGIN {user};ALTER ROLE db_owner ADD MEMBER {user}; END";
            SqlCommand crearL = new SqlCommand(consul, conec);
            try
            {
                crearL.ExecuteNonQuery();
                CerrarCon();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CerrarCon();
                return false;
            }
        }
        public bool ActualizarLoginBD(string user, string pass)
        {
            Database = "master";
            AbrirCon();
            string consul = $"ALTER LOGIN {user} WITH PASSWORD = '{pass}';";
            SqlCommand actualizarL = new SqlCommand(consul, conec);
            try
            {
                actualizarL.ExecuteNonQuery();
                CerrarCon();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CerrarCon();
                return false;
            }
        }
    }
}