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
        private string _database = "BDTorneosFutbol";
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
        public bool EjecutarTransaccion(string consultaDatos, string consultaImagen, byte[] imagen)
        {
            conec.Open();
            SqlTransaction transaccion = conec.BeginTransaction();

            try
            {
                string consultaID = consultaDatos + "; SELECT SCOPE_IDENTITY();";
                SqlCommand comandoDatos = new SqlCommand(consultaID, conec, transaccion);
                int idEntrenador = Convert.ToInt32(comandoDatos.ExecuteScalar());
                SqlCommand comandoImagen = new SqlCommand(consultaImagen, conec, transaccion);
                comandoImagen.Parameters.AddWithValue("@imagen", imagen);
                comandoImagen.Parameters.AddWithValue("@IDEntrenador", idEntrenador);
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
        }

        public bool InsertarImagen(byte[] imagen)
        {
            try
            {
                AbrirCon();
                string consulIMG = "insert into Entrenador (ImagenEntrenador) values (@imagen)";
                SqlCommand comando = new SqlCommand(consulIMG, conec);
                comando.Parameters.AddWithValue("@imagen", imagen);
                comando.ExecuteNonQuery();
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

        public bool EditarEntrenador(int idEntrenador, string nombre, string apellido, byte[] imagen)
        {
            conec.Open();
            SqlTransaction transaccion = conec.BeginTransaction();

            try
            {
                string consultaDatos = "update Entrenador set Nombres = @nombre, Apellidos = @apellido " +
                                        "where IDEntrenador = @idEntrenador";

                SqlCommand comandoDatos = new SqlCommand(consultaDatos, conec, transaccion);
                comandoDatos.Parameters.AddWithValue("@nombre", nombre);
                comandoDatos.Parameters.AddWithValue("@apellido", apellido);
                comandoDatos.Parameters.AddWithValue("@idEntrenador", idEntrenador);
                comandoDatos.ExecuteNonQuery();

                string consultaImagen = "UPDATE Entrenador SET ImagenEntrenador = @imagen WHERE IDEntrenador = @idEntrenador";
                SqlCommand comandoImagen = new SqlCommand(consultaImagen, conec, transaccion);
                comandoImagen.Parameters.AddWithValue("@imagen", imagen);
                comandoImagen.Parameters.AddWithValue("@idEntrenador", idEntrenador);
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
        }

        public byte[] ObtenerImagen(string consulta)
        {
            byte[] imagen = null;

            try
            {
                AbrirCon();
                SqlCommand comando = new SqlCommand(consulta, conec);
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    if (!reader.IsDBNull(reader.GetOrdinal("ImagenEntrenador")))
                    {
                        imagen = (byte[])reader["ImagenEntrenador"];
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
        }
        public bool Login(string usuario, string contraseña)
        {
            string consulta = $"select ClaveApp from Administrador where UsuarioApp='{usuario}'";
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
            DataTable dt = ListDGV($"select UsuarioBD from Administrador where UsuarioApp='{u}'");
            return $"{dt.Rows[0][0].ToString()}";
        }
        public string RetornaClave(string u)
        {
            DataTable dt = ListDGV($"select ClaveBD from Administrador where UsuarioApp='{u}'");
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
