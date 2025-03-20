using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneosFut
{
    class csArbitro
    {
        csConexion csConexion;
        public csArbitro(string u, string c)
        {
            csConexion = new csConexion(u, c);
        }
        private string _idArbitro;
        private string _nombreArbitro;
        private string _apellidoArbitro;
        private string _correo;

        public string IDArbitro
        {
            get => _idArbitro;
            set => _idArbitro = value;
        }

        public string NombreArbitro
        {
            get => _nombreArbitro;
            set => _nombreArbitro = value;
        }

        public string ApellidoArbitro
        {
            get => _apellidoArbitro;
            set => _apellidoArbitro = value;
        }

        public string Correo
        {
            get => _correo;
            set => _correo = value;
        }
        #region Insertar
        public bool AgregarArbitro(string id, string nombre, string apellido, string correo)
        {
            IDArbitro = id;
            NombreArbitro = nombre;
            ApellidoArbitro = apellido;
            Correo = correo;

            string xmlArbitro =
                "<Arbitros>" +
                "    <Arbitro>" +
                $"        <IDArbitro>{IDArbitro}</IDArbitro>" +
                $"        <NombreArbitro>{NombreArbitro}</NombreArbitro>" +
                $"        <ApellidoArbitro>{ApellidoArbitro}</ApellidoArbitro>" +
                $"        <Correo>{Correo}</Correo>" +
                "    </Arbitro>" +
                "</Arbitros>";

            string consultaSQL = $"DECLARE @Datos XML = '{xmlArbitro}'; EXEC spRegistrarArbitro @Datos;";

            return csConexion.Consulta(consultaSQL);
        }
        #endregion
        #region Actualizar
        public bool ActualizarArbitro(string id, string nombre, string apellido, string correo)
        {
            IDArbitro = id;
            NombreArbitro = nombre;
            ApellidoArbitro = apellido;
            Correo = correo;

            string xmlArbitro =
                "<Arbitros>" +
                "    <Arbitro>" +
                $"        <IDArbitro>{IDArbitro}</IDArbitro>" +
                $"        <NombreArbitro>{NombreArbitro}</NombreArbitro>" +
                $"        <ApellidoArbitro>{ApellidoArbitro}</ApellidoArbitro>" +
                $"        <Correo>{Correo}</Correo>" +
                "    </Arbitro>" +
                "</Arbitros>";

            string consultaSQL = $"DECLARE @Datos XML = '{xmlArbitro}'; EXEC spEditarArbitro @Datos;";

            return csConexion.Consulta(consultaSQL);
        }

        #endregion
    }
}
