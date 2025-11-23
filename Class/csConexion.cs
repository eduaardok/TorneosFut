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
        csDatos csDatos;
        private SqlConnection conec;
        //Server VPN
        /*private string _server = ".\SQLEXPRESS";
        private string _database = "BDTorneosBetaV2";*/
        //Server Local
        private string _server = $@"26.197.0.134";
        private string _database = "BDTorneos";

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
        public csConexion()
        {
            _usuario = "administrador";
            _clave = "Admin2025";
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
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir conexión: " + ex.Message);
                return false;
            }
        }

        public DataTable ListDGV(string consul)
        {
            DataTable data = new DataTable();
            AbrirCon();

            if (conec == null || conec.State != ConnectionState.Open)
            {
                MessageBox.Show("No se pudo abrir la conexión a la base de datos.");
                return data;
            }

            try
            {
                using (SqlDataAdapter sqlData = new SqlDataAdapter(consul, conec))
                {
                    sqlData.Fill(data);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de SQL Server: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                CerrarCon();
            }

            return data;
        }
        public void RegistrarAuditoriaInicioSesion()
        {
            string query = "EXEC spRegistrarInicioDeSesion";
            Consulta(query);
        }
        public void RegistrarAuditoriaCierreSesion()
        {
            string query = "EXEC spRegistrarCierreDeSesion";
            Consulta(query);
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
            catch (SqlException ex)
            {
                MessageBox.Show("Error de SQL Server: " + ex.Message);
                CerrarCon();
                return false;
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
            if (conec != null && conec.State == ConnectionState.Open)
            {
                conec.Close();
            }
            return true;
        }
    }
}