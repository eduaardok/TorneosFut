
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

        public bool AgregarInscripcion(int IdTorneo, string IdEquipo, decimal abono, decimal saldo, decimal montoAPagar, DateTime fechaLimite, string estado)
        {
            IDInscripcion = GenerarIDInscripcion(IdTorneo, IdEquipo);
            IDTorneo = IdTorneo.ToString().Trim();
            IDEquipo = IdEquipo.ToString().Trim();
            Abono = abono;
            Saldo = saldo;
            MontoAPagar = montoAPagar;
            FechaLimite = fechaLimite.ToString("yyyy-MM-dd").Trim();
            Estado = estado.ToString().Trim();

            string xmlInscripcion =
                "<InscripcionEquipos>" +
                "    <InscripcionEquipo>" +
                $"        <IDInscripcion>{IDInscripcion}</IDInscripcion>" +
                $"        <IDTorneo>{IDTorneo}</IDTorneo>" +
                $"        <IDEquipo>{IDEquipo}</IDEquipo>" +
                $"        <Abono>{Abono.ToString("N2").Trim()}</Abono>" +
                $"        <Saldo>{Saldo.ToString("N2").Trim()}</Saldo>" +
                $"        <MontoAPagar>{MontoAPagar.ToString("N2").Trim()}</MontoAPagar>" +
                $"        <FechaLimite>{FechaLimite}</FechaLimite>" +
                $"        <Estado>{Estado}</Estado>" +
                "    </InscripcionEquipo>" +
                "</InscripcionEquipos>";
            return conexion.Consulta($"DECLARE @cadenaa VARCHAR(MAX) = '{xmlInscripcion}'; EXEC spRegistraInscripcionEquipo @cadenaa;");
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
