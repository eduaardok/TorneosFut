using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;


namespace TorneosFut
{
    class csUsuario
    {
        csConexion conexion;
        public csUsuario(string u, string c)
        {
            conexion = new csConexion(u, c);
        }
        //LOGIN
        public string UsuarioBD(string u)
        {
            DataTable dt = conexion.ListDGV($"select NombreUsuarioBD from Usuario where NombreUsuario='{u}'");
            return $"{dt.Rows[0][0].ToString()}";
        }
        public string ClaveBD(string u)
        {
            DataTable dt = conexion.ListDGV($"select ClaveBD from Usuario where NombreUsuario='{u}'");
            return $"{dt.Rows[0][0].ToString()}";
        }
        //USUARIO BD
        public bool NuevoLogin(string user, string pass)
        {
            conexion.Database = "master";
            string consul = $"IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = '{user}') BEGIN " +
                $"CREATE LOGIN {user} WITH PASSWORD = '{pass}'; END" +
                $"  USE BDTorneosBetaV2; IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = '{user}') " +
                $"   BEGIN CREATE USER {user} FOR LOGIN {user};ALTER ROLE db_owner ADD MEMBER {user}; END";
            if(conexion.Consulta(consul))
            {
                conexion.Database = "BDTorneosBetaV2";
                return true;
            }
            else
            {
                conexion.Database = "BDTorneosBetaV2";
                return false;
            }

        }
        public bool NuevaClaveLogin(string user, string pass)
        {
            conexion.Database = "master";
            string consul = $"ALTER LOGIN {user} WITH PASSWORD = '{pass}';";
            if (conexion.Consulta(consul))
            {
                conexion.Database = "BDTorneosBetaV2";
                return true;
            }
            else
            {
                conexion.Database = "BDTorneosBetaV2";
                return false;
            }

        }

        //USUARIO
        public int IDUsuarioSeleccionado(DataGridView dgv)
        {
            return int.Parse(dgv.Rows[dgv.CurrentRow.Index].Cells[0].Value.ToString());
        }
        public int IDUsuarioDeNombreUsuario(string nombreusuario)
        {
            DataTable dt = conexion.ListDGV($"select IDUsuario from Usuario where NombreUsuario='{nombreusuario}'");
            return int.Parse(dt.Rows[0][0].ToString());
        }
        public string ClaveUsuarioDeNombreUsuario(string nombreusuario)
        {
            DataTable dt = conexion.ListDGV($"select ClaveUsuario from Usuario where NombreUsuario='{nombreusuario}'");
            return dt.Rows[0][0].ToString();
        }
        public bool NuevaClaveUsuario(string clave, string id)
        {
            return conexion.Consulta($"update Usuario set ClaveUsuario='{clave}' where IDUsuario={id}");
        }
        public DataTable ListaDeUsuarios()
        {
           DataTable dt = conexion.ListDGV("Select * from Usuario");
           return dt;
        }
        public DataTable ListaDeUsuariosFiltro(bool m, string filtro)
        {
            DataTable dt;
            if (m)
               dt = conexion.ListDGV($"Select * from Usuario where IDUsuario like '%{filtro}%' or Nombres like '%{filtro}%'" +
                                        $" or NombreUsuario like '%{filtro}%' or NombreUsuarioBD like '%{filtro}%'");
            else
                dt = conexion.ListDGV($"Select IDUsuario, Nombres, NombreUsuario, Correo, NombreUsuarioBD from Usuario where IDUsuario like '%{filtro}%' or Nombres like '%{filtro}%'" +
                                    $" or NombreUsuario like '%{filtro}%' or NombreUsuarioBD like '%{filtro}%'");

            return dt;
        }

        public bool AgregarUsuario(string id, string nombre, string nombreusuario, string clave, string correo, string nombreusuariobd, string clavebd)
        {
            return conexion.Consulta($"insert into Usuario (IDUsuario, Nombres, NombreUsuario, ClaveUsuario, Correo, NombreUsuarioBD, ClaveBD) " +
                $"values ({id},'{nombre}','{nombreusuario}', '{clave}', '{correo}', '{nombreusuariobd}', '{clavebd}')");
        }
        public bool ActualizarUsuario(string id, string nombre, string nombreusuario, string clave, string correo, string nombreusuariobd, string clavebd)
        {
            return conexion.Consulta($"update Usuario set Nombres='{nombre}', NombreUsuario= '{nombreusuario}',ClaveUsuario='{clave}', " +
                    $" Correo= '{correo}', NombreUsuarioBD= '{nombreusuariobd}',ClaveBD='{clavebd}' where IDUsuario={id} ");
        }
    }
}
