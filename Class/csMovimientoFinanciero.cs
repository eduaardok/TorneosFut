using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneosFut.Class;

namespace TorneosFut
{
    class csMovimientoFinanciero
    {
        csConexion conexion;
        public csMovimientoFinanciero(string u, string c)
        {
            conexion = new csConexion(u, c);
        }
        private int _idTorneo;
        private string _tipoMovimiento;
        private decimal _monto;
        private string _categoria;
        private DateTime _fechaPago;
        private string _descripcion;
        private decimal _dineroDisponible;
        public int IDTorneo
        {
            get => _idTorneo;
            set => _idTorneo = value;
        }
        public string TipoMovimiento
        {
            get => _tipoMovimiento;
            set => _tipoMovimiento = value;
        }
        public decimal Monto
        {
            get => _monto;
            set => _monto = value;
        }
        public string Categoria
        {
            get => _categoria;
            set => _categoria = value;
        }
        public DateTime FechaPago
        {
            get => _fechaPago;
            set => _fechaPago = value;
        }
        public string Descripcion
        {
            get => _descripcion;
            set => _descripcion = value;
        }
        public decimal DineroDisponible
        {
            get => _dineroDisponible;
            set => _dineroDisponible = value;
        }
        public bool AgregarMovimientoInscripcion(int iDTorneo, decimal monto, string descripcion)
        {
            DataTable torneo = conexion.ListDGV($"SELECT TOP 1 DineroDisponible FROM MovimientoFinanciero ORDER BY Fecha DESC;");
            DineroDisponible = decimal.Parse(torneo.Rows[0]["DineroDisponible"].ToString());
            decimal DineroActual = DineroDisponible + monto;
            IDTorneo = iDTorneo;
            Monto = monto;
            Descripcion = descripcion;
            MessageBox.Show(IDTorneo.ToString());
            MessageBox.Show(Monto.ToString("N2").Trim());
            MessageBox.Show(DateTime.Now.ToString("yyyy-MM-dd"));
            MessageBox.Show(Descripcion);
            MessageBox.Show(DineroActual.ToString("N2").Trim());
            string xmlMovimiento =
                "<MovimientosFinancieros>" +
                "    <MovimientoFinanciero>" +
                $"        <IDTorneo>{IDTorneo}</IDTorneo>" +
                $"        <TipoMovimiento>Ingreso</TipoMovimiento>" +
                $"        <Monto>{Monto.ToString("N2").Trim()}</Monto>" +
                $"        <Categoria>Inscripción</Categoria>" +
                $"        <Fecha>{DateTime.Now.ToString("yyyy-MM-dd")}</Fecha>" +
                $"        <Descripcion>{Descripcion}</Descripcion>" +
                $"        <DineroDisponible>{DineroActual.ToString("F2").Trim()}</DineroDisponible>" +
                "    </MovimientoFinanciero>" +
                "</MovimientosFinancieros>";

            string consultaSQL = $"DECLARE @cadenaa VARCHAR(MAX) = '{xmlMovimiento}'; EXEC spRegistraMovimientoFinanciero @cadenaa;";

            return conexion.Consulta(consultaSQL);
        }
    }
}
