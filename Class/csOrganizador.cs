using System;
using System.Collections.Generic;
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

        #region Insertar
        public bool AgregarOrganizador(string id, string nombreEmpresa, string telefono, string correo)
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
    }
}
