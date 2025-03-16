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


        private string _database = "BDTorneosBetaV2";
        // private string _database = "BDTorneosFutbol";
        //private string _server = ".";
        //private string _database = "BDTorneosBetaCopia";

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
        public csConexion(string us, string cl)
        {
            _usuario = us;
            _clave = cl;
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

        public void RegistrarAuditoriaInicioSesion()
        {
            string query = "EXEC InsertarAuditoriaInicioSesion";
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
                $"  USE BDTorneosBetaV2; IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = '{user}') " +
                $"   BEGIN CREATE USER {user} FOR LOGIN {user};ALTER ROLE db_owner ADD MEMBER {user}; END";
            SqlCommand crearL = new SqlCommand(consul, conec);
            try
            {
                crearL.ExecuteNonQuery();
                CerrarCon();
                Database = "BDTorneosBetaV2";
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CerrarCon();
                Database = "BDTorneosBetaV2";
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
                Database = "BDTorneosBetaV2";
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                CerrarCon();
                Database = "BDTorneosBetaV2";
                return false;
            }
           
        }
    }
}