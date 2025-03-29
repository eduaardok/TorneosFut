
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneosFut.Class
{
    class csIncripcionEquipo
    {
        csConexion conexion;
        private string _idInscripcion;
        private string _idTorneo;
        private string _idEquipo;
        private decimal _abono;
        private decimal _saldo;
        private decimal _montoAPagar;
        private string _fechaLimite;
        private string _estado;

        public csIncripcionEquipo(string usuario, string clave)
        {
            conexion = new csConexion(usuario, clave);
        }

        public string IDInscripcion
        {
            get => _idInscripcion;
            set => _idInscripcion = value;
        }

        public string IDTorneo
        {
            get => _idTorneo;
            set => _idTorneo = value;
        }

        public string IDEquipo
        {
            get => _idEquipo;
            set => _idEquipo = value;
        }

        public decimal Abono
        {
            get => _abono;
            set => _abono = value;
        }

        public decimal Saldo
        {
            get => _saldo;
            set => _saldo = value;
        }

        public decimal MontoAPagar
        {
            get => _montoAPagar;
            set => _montoAPagar = value;
        }

        public string FechaLimite
        {
            get => _fechaLimite;
            set => _fechaLimite = value;
        }

        public string Estado
        {
            get => _estado;
            set => _estado = value;
        }
        public DataTable ListadeEquiposInc(string IDTorneo)
        {
            DataTable dt = conexion.ListDGV("select I.IDEquipo, E.NombreEquipo, I.Estado from (select * from InscripcionEquipo) I " +
                                            $"INNER JOIN (select IDEquipo, NombreEquipo from Equipo) E ON I.IDEquipo = E.IDEquipo where I.IDTorneo = {IDTorneo}");
            return dt;
        }
        public bool AgregarInscripcion(int IdTorneo, List<string> listaEquipos, decimal montoAPagar, string fecha)
        {
            string xmlInscripciones = "<InscripcionEquipos>";

            foreach (string IDEquipo in listaEquipos)
            {
                string IDInscripcion = GenerarIDInscripcion(IdTorneo, IDEquipo);
                string Estado = "PENDIENTE";
                decimal Abono = 0;
                decimal Saldo = montoAPagar;

                xmlInscripciones +=
                    $"    <InscripcionEquipo>" +
                    $"        <IDInscripcion>{IDInscripcion}</IDInscripcion>" +
                    $"        <IDTorneo>{IdTorneo}</IDTorneo>" +
                    $"        <IDEquipo>{IDEquipo}</IDEquipo>" +
                    $"        <Abono>{Abono.ToString("N2").Trim()}</Abono>" +
                    $"        <Saldo>{Saldo.ToString("N2").Trim()}</Saldo>" +
                    $"        <MontoAPagar>{montoAPagar.ToString("N2").Trim()}</MontoAPagar>" +
                    $"        <FechaLimite>{fecha}</FechaLimite>" +
                    $"        <Estado>{Estado}</Estado>" +
                    "    </InscripcionEquipo>";
            }

            xmlInscripciones += "</InscripcionEquipos>";

            return conexion.Consulta($"declare @cadenaa VARCHAR(MAX) = '{xmlInscripciones}'; exec spRegistraInscripcionEquipo @cadenaa;");
        }
        public bool EliminarInscripcion(string IdEquipo)
        {
            IDEquipo = IdEquipo;
            return conexion.Consulta($"DELETE FROM InscripcionEquipo WHERE IDEquipo = '{IDEquipo}';");
        }
        public bool EditarInscripcion(string idInscripcion, decimal abono, decimal saldo, decimal montoAPagar, string estado)
        {
            string consultaSQL = $@"
            EXEC spEditarInscripcionEquipo
                @IDInscripcion = '{idInscripcion}',
                @Abono = {abono},
                @Saldo = {saldo},
                @MontoAPagar = {montoAPagar},
                @Estado = '{estado}'";
            return conexion.Consulta(consultaSQL);
        }
        public string GenerarIDInscripcion(int idTorneo, string idEquipo)
        {
            string idInscripcion;
            bool repetir;
            do
            {
                idInscripcion = $"{idTorneo}-{idEquipo}";

                DataTable dt = conexion.ListDGV($"select 1 from InscripcionEquipo where IDInscripcion = '{idInscripcion}'");
                repetir = (dt.Rows.Count > 0);

            } while (repetir);

            return idInscripcion;
        }
    }
}
