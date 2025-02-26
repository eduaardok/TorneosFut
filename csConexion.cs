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
        SqlConnection conec;
        //static string cadenaconec = $"Server=DESKTOP-CIGAE77; Database=BDTorneosFutbol; User id= FutXpert; Password= Torneos";
        static string cadenaconec = $"Server=26.102.193.210; Database=BDTorneosFutbol; User id= FutXpert; Password= Torneos";
        static string cadenamaster = $"Server=26.102.193.210; Database=master; User id= FutXpert; Password= Torneos";
        SqlConnection master;
        public csConexion()
        {
            conec = new SqlConnection(cadenaconec);
            master = new SqlConnection(cadenamaster);
        }
        public bool AbrirCon(SqlConnection c)
        {
            try
            {
                c.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }
        public bool AbrirCon()
        {
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

        public bool Login(string usuario, string contraseña)
        {
            string consulta = $"select Clave from Administrador where Usuario='{usuario}'";
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
        public bool CerrarCon(SqlConnection c)
        {
            c.Close();
            return true;
        }
        public bool CerrarCon()
        {
            conec.Close();
            return true;
        }
        public bool CrearLoginBD(string user, string pass)
        {
            AbrirCon(master);
            string consul = $"IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = '{user}') BEGIN " +
                $"CREATE LOGIN {user} WITH PASSWORD = '{pass}'; END" +
                $"  USE BDTorneosFutbol; IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = '{user}') " +
                $"   BEGIN CREATE USER {user} FOR LOGIN {user};ALTER ROLE db_owner ADD MEMBER {user}; END";
            SqlCommand crearL = new SqlCommand(consul, master);
            try
            {
                crearL.ExecuteNonQuery();
                CerrarCon(master);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CerrarCon(master);
                return false;
            }
        }
        public bool ActualizarLoginBD(string user, string pass)
        {
            AbrirCon(master);
            string consul = $"ALTER LOGIN {user} WITH PASSWORD = '{pass}';";
            SqlCommand actualizarL = new SqlCommand(consul, master);
            try
            {
                actualizarL.ExecuteNonQuery();
                CerrarCon(master);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CerrarCon(master);
                return false;
            }
        }
    }
}
