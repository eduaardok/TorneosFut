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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;


namespace TorneosFut
{
    class csUsuario
    {
        private string _idUsuario;
        private string _nombres;
        private string _nombreUsuario;
        private string _claveUsuario;
        private string _correo;
        private string _nombreUsuarioBD;
        private string _claveBD;
        static csConexion csConexion;
        public csUsuario(string u, string c)
        {
            csConexion = new csConexion(u, c);
        }
        public string IDUsuario
        {
            get => _idUsuario;
            set => _idUsuario = value;
        }
        public string Nombres
        {
            get => _nombres;
            set => _nombres = value;
        }
        public string NombreUsuario
        {
            get => _nombreUsuario;
            set => _nombreUsuario = value;
        }
        public string ClaveUsuario
        {
            get => _claveUsuario;
            set => _claveUsuario = value;
        }
        public string Correo
        {
            get => _correo;
            set => _correo = value;
        }
        public string NombreUsuarioBD
        {
            get => _nombreUsuarioBD;
            set => _nombreUsuarioBD = value;
        }
        public string ClaveBD
        {
            get => _claveBD;
            set => _claveBD = value;
        }
        #region Login
        public string UsuarioBDDeNombreUsuario(string u)
        {
            DataTable dt = csConexion.ListDGV($"select NombreUsuarioBD from Usuario where NombreUsuario='{u}'");
               return $"{dt.Rows[0][0].ToString()}";
        }
        public string ClaveBDDeNombreUsuario(string u)
        {
            DataTable dt = csConexion.ListDGV($"select ClaveBD from Usuario where NombreUsuario='{u}'");
                return $"{dt.Rows[0][0].ToString()}";
        }
        #endregion

        #region Usuario base de datos
        /*public bool NuevoLogin(string user, string pass)
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

        }*/
       /* public bool NuevaClaveLogin(string user, string pass)
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

        }*/
        #endregion

        #region DevolverCampo
        public string IDUsuarioSeleccionado(DataGridView dgv)
        {
            return dgv.Rows[dgv.CurrentRow.Index].Cells[0].Value.ToString();
        }
        public int IDUsuarioDeNombreUsuario(string nombreusuario)
        {
            DataTable dt = csConexion.ListDGV($"select IDUsuario from Usuario where NombreUsuario='{nombreusuario}'");
            return int.Parse(dt.Rows[0][0].ToString());
        }
        public string ClaveUsuarioDeNombreUsuario(string nombreusuario)
        {
            DataTable dt = csConexion.ListDGV($"select ClaveUsuario from Usuario where NombreUsuario='{nombreusuario}'");
            if (dt.Rows.Count > 0)
                return dt.Rows[0][0].ToString();
            else
                return " ";
        }
        public string NombreDeID(string id)
        {
            DataTable dt = csConexion.ListDGV($"select Nombres from Usuario where IDUsuario={id}");
            return dt.Rows[0][0].ToString();
        }
        public string UsuarioDeID(string id)
        {
            DataTable dt = csConexion.ListDGV($"select NombreUsuario from Usuario where IDUsuario={id}");
            return dt.Rows[0][0].ToString();
        }
        public string ClaveDeID(string id)
        {
            DataTable dt = csConexion.ListDGV($"select ClaveUsuario from Usuario where IDUsuario={id}");
            return dt.Rows[0][0].ToString();
        }
        public string CorreoDeID(string id)
        {
            DataTable dt = csConexion.ListDGV($"select Correo from Usuario where IDUsuario={id}");
            return dt.Rows[0][0].ToString();
        }
        public string UsuarioBDDeID(string id)
        {
            DataTable dt = csConexion.ListDGV($"select NombreUsuarioBD from Usuario where IDUsuario={id}");
            return dt.Rows[0][0].ToString();
        }
        public string ClaveBDDeID(string id)
        {
            DataTable dt = csConexion.ListDGV($"select ClaveBD from Usuario where IDUsuario={id}");
            return dt.Rows[0][0].ToString();
        }

        #endregion

        #region ListasParaValidaciones
        public DataTable ListaNombres()
        {
            return csConexion.ListDGV("select Nombres from Usuario");
        }
        public DataTable ListaUsuarios()
        {
            return csConexion.ListDGV("select NombreUsuario from Usuario");
        }
        public DataTable ListaUsuariosBD()
        {
            return csConexion.ListDGV("select NombreUsuarioBD from Usuario");
        }
        public DataTable ListaCorreos()
        {
            return csConexion.ListDGV("select Correo from Usuario");
        }
        #endregion

        #region Listas
        public DataTable ListaDeUsuarios()
        {
           DataTable dt = csConexion.ListDGV("Select IDUsuario, Nombres, NombreUsuario, Correo, NombreUsuarioBD from Usuario");
           return dt;
        }
        public DataTable ListaDeUsuariosFiltro(bool m, string filtro)
        {
            DataTable dt;
            if (m)
               dt = csConexion.ListDGV($"Select * from Usuario where IDUsuario like '%{filtro}%' or Nombres like '%{filtro}%'" +
                                        $" or NombreUsuario like '%{filtro}%' or NombreUsuarioBD like '%{filtro}%'");
            else
                dt = csConexion.ListDGV($"Select IDUsuario, Nombres, NombreUsuario, Correo, NombreUsuarioBD from Usuario where IDUsuario like '%{filtro}%' or Nombres like '%{filtro}%'" +
                                    $" or NombreUsuario like '%{filtro}%' or NombreUsuarioBD like '%{filtro}%'");

            return dt;
        }
        #endregion

        #region Inserts
        public bool AgregarUsuario(string nombre, string nombreusuario, string clave, string correo, string nombreusuariobd, string clavebd)
        {
            Nombres = nombre;
            NombreUsuario = nombreusuario;
            ClaveUsuario = clave;
            Correo = correo;
            NombreUsuarioBD = nombreusuariobd;
            ClaveBD = clavebd;
            string xmlUsuario =
                "<Usuarios>" +
                "    <Usuario>" +
                $"        <Nombres>{nombre}</Nombres>" +
                $"        <NombreUsuario>{nombreusuario}</NombreUsuario>" +
                $"        <ClaveUsuario>{clave}</ClaveUsuario>" +
                $"        <Correo>{correo}</Correo>" +
                $"        <NombreUsuarioBD>{nombreusuariobd}</NombreUsuarioBD>" +
                $"        <ClaveBD>{clavebd}</ClaveBD>" +
                "    </Usuario>" +
                "</Usuarios>";
            string consultaSQL = $"DECLARE @Datos XML = '{xmlUsuario}'; EXEC spRegistrarUsuario @Datos;";

            return csConexion.Consulta(consultaSQL);
        }
        #endregion

        #region Updates
        public bool ActualizarUsuario(string id, string nombre, string nombreusuario, string clave, string correo, string nombreusuariobd, string clavebd)
        {
            IDUsuario = id;
            Nombres = nombre;
            NombreUsuario = nombreusuario;
            ClaveUsuario = clave;
            Correo = correo;
            NombreUsuarioBD = nombreusuariobd;
            ClaveBD = clavebd;
            string xmlUsuario =
            "<Usuarios>" +
            "    <Usuario>" +
            $"        <IDUsuario>{IDUsuario}</IDUsuario>" +
            $"        <Nombres>{Nombres}</Nombres>" +
            $"        <NombreUsuario>{NombreUsuario}</NombreUsuario>" +
            $"        <ClaveUsuario>{ClaveUsuario}</ClaveUsuario>" +
            $"        <Correo>{Correo}</Correo>" +
            $"        <NombreUsuarioBD>{NombreUsuarioBD}</NombreUsuarioBD>" +
            $"        <ClaveBD>{ClaveBD}</ClaveBD>" +
            "    </Usuario>" +
            "</Usuarios>";
            string consultaSQL = $"DECLARE @Datos XML = '{xmlUsuario}'; EXEC spEditarUsuario @Datos;";
            return csConexion.Consulta(consultaSQL);
        }
        public bool NuevaClaveUsuario(string clave, string id)
        {
            return csConexion.Consulta($"update Usuario set ClaveUsuario='{clave}' where IDUsuario={id}");
        }
        #endregion
    }
}
