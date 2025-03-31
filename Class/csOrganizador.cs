using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneosFut
{
    class csOrganizador
    {
        csConexion csConexion;
        public csOrganizador(string u, string c)
        {
            csConexion = new csConexion(u, c);
        }
        private string _idOrganizador;
        private string _nombreEmpresa;
        private string _telefono;
        private string _correo;

        public string IDOrganizador
        {
            get => _idOrganizador;
            set => _idOrganizador = value;
        }

        public string NombreEmpresa
        {
            get => _nombreEmpresa;
            set => _nombreEmpresa = value;
        }

        public string Telefono
        {
            get => _telefono;
            set => _telefono = value;
        }

        public string Correo
        {
            get => _correo;
            set => _correo = value;
        }
        public DataTable Listaorganizadores()
        {
            DataTable dt = csConexion.ListDGV("Select * from Organizador");
            return dt;
        }
        public string GenerarNuevoIDOrganizador()
        {
            string nuevoID = "ORG1"; // Valor inicial
            string consulta = "SELECT MAX(IDOrganizador) FROM Organizador WHERE IDOrganizador LIKE 'ORG%'";

            DataTable dt = csConexion.ListDGV(consulta);

            if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
            {
                string ultimoID = dt.Rows[0][0].ToString(); // Último ID obtenido (ej. "ORG5")

                // Extraer número y generar el siguiente
                if (int.TryParse(ultimoID.Substring(3), out int numero))
                {
                    nuevoID = "ORG" + (numero + 1); // Formato "ORGX"
                }
            }

            return nuevoID;
        }

        #region Insertar
        public bool AgregarOrganizador(string nombreEmpresa, string telefono, string correo)
        {
            IDOrganizador = GenerarNuevoIDOrganizador();
            NombreEmpresa = nombreEmpresa;
            Telefono = telefono;
            Correo = correo;
            string xmlOrganizador =
                "<Organizadores>" +
                "    <Organizador>" +
                $"        <IDOrganizador>{IDOrganizador}</IDOrganizador>" +
                $"        <NombreEmpresa>{NombreEmpresa}</NombreEmpresa>" +
                $"        <Telefono>{telefono}</Telefono>" +
                $"        <Correo>{correo}</Correo>" +
                "    </Organizador>" +
                "</Organizadores>";
            string consultaSQL = $"DECLARE  @cadenaa varchar(MAX)= '{xmlOrganizador}'; EXEC spRegistrarOrganizador @cadenaa;";
            return csConexion.Consulta(consultaSQL);
        }
        #endregion
        #region Actualizar
        public bool EditarOrganizador(string id, string nombreEmpresa, string telefono, string correo)
        {
            IDOrganizador = id;
            NombreEmpresa = nombreEmpresa;
            Telefono = telefono;
            Correo = correo;
            string xmlOrganizador =
                "<Organizadores>" +
                "    <Organizador>" +
                $"        <IDOrganizador>{IDOrganizador}</IDOrganizador>" +
                $"        <NombreEmpresa>{NombreEmpresa}</NombreEmpresa>" +
                $"        <Telefono>{Telefono}</Telefono>" +
                $"        <Correo>{Correo}</Correo>" +
                "    </Organizador>" +
                "</Organizadores>";

            string consultaSQL = $"DECLARE  @cadenaa varchar(MAX)= '{xmlOrganizador}'; EXEC spEditarOrganizador @cadenaa;";
            return csConexion.Consulta(consultaSQL);
        }
        #endregion
        public string NombreOrganizador(string ID)
        {
            DataTable dt = csConexion.ListDGV($"select NombreEmpresa from Organizador where IDOrganizador='{ID}'");
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            else return "";
        }
        public string TelefonoOrganizador(string ID)
        {
            DataTable dt = csConexion.ListDGV($"select Telefono from Organizador where IDOrganizador='{ID}'");
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            else return "";
        }
        public string CorreoOrganizador(string ID)
        {
            DataTable dt = csConexion.ListDGV($"select Correo from Organizador where IDOrganizador='{ID}'");
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            else return "";
        }
    }
}
