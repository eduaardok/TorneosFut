using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneosFut.Class;

namespace TorneosFut
{
    class csPatrocinador
    {

        csConexion csConexion;
        public csPatrocinador(string u, string c)
        {
            csConexion = new csConexion(u, c);
        }
        private string _idPatrocinador;
        private string _nombreEmpresa;
        private string _nombreContacto;

        public string IDPatrocinador
        {
            get => _idPatrocinador;
            set => _idPatrocinador = value;
        }

        public string NombreEmpresa
        {
            get => _nombreEmpresa;
            set => _nombreEmpresa = value;
        }

        public string Contacto
        {
            get => _nombreContacto;
            set => _nombreContacto = value;
        }
        public string GenerarNuevoIDPatrocinador()
        {
            string nuevoID = "PAT1"; // Valor inicial
            string consulta = "SELECT MAX(IDPatrocinador) FROM Patrocinador WHERE IDPatrocinador LIKE 'PAT%'";
            DataTable dt = csConexion.ListDGV(consulta);
            string resultado = dt.Rows[0][0].ToString();
            try
            {
                if (!string.IsNullOrEmpty(resultado) && resultado != DBNull.Value.ToString())
                {
                    string ultimoID = resultado; 
                    if (int.TryParse(ultimoID.Substring(3), out int numero))
                    {
                        nuevoID = "PAT" + (numero + 1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar ID: " + ex.Message);
            }

            return nuevoID;
        }


        #region Listas
        public DataTable ListaDePatrocinadoresFiltro(string filtro)
        {
            DataTable dt;
            dt = csConexion.ListDGV($"select * from Patrocinador where IDPatrocinador like '%{filtro}%' or NombreEmpresa like '%{filtro}%'");
            return dt;
        }
        public DataTable ListaDePatrocinadores()
        {
            DataTable dt = csConexion.ListDGV("select * from Patrocinador");
            return dt;
        }
        #endregion


        #region Insertar
        public bool AgregarPatrocinador(string id, string nombre, string contacto, string telefono)
        {
            IDPatrocinador = GenerarNuevoIDPatrocinador();
            NombreEmpresa = nombre;
            Contacto = contacto;
            string xmlPatrocinador =
                "<Patrocinadores>" +
                "    <Patrocinador>" +
                $"        <IDPatrocinador>{IDPatrocinador}</IDPatrocinador>" +
                $"        <NombreEmpresa>{NombreEmpresa}</NombreEmpresa>" +
                $"        <NombreContacto>{Contacto}</NombreContacto>" +
                $"        <Telefono>{telefono}</Telefono>" +
                "    </Patrocinador>" +
                "</Patrocinadores>";
            string consultaSQL = $"DECLARE  @cadenaa varchar(MAX)= '{xmlPatrocinador}'; EXEC spRegistrarPatrocinador @cadenaa;";
            return csConexion.Consulta(consultaSQL);
        }

        #endregion
        #region Actualizar
        public bool EditarPatrocinador(string id, string nombre, string contacto, string telefono)
        {
            IDPatrocinador = id;
            NombreEmpresa = nombre;
            Contacto = contacto;
            string xmlPatrocinador =
                "<Patrocinadores>" +
                "    <Patrocinador>" +
                $"        <IDPatrocinador>{IDPatrocinador}</IDPatrocinador>" +
                $"        <NombreEmpresa>{NombreEmpresa}</NombreEmpresa>" +
                $"        <NombreContacto>{Contacto}</NombreContacto>" +
                $"        <Telefono>{telefono}</Telefono>" +
                "    </Patrocinador>" +
                "</Patrocinadores>";
            string consultaSQL = $"DECLARE  @cadenaa varchar(MAX)= '{xmlPatrocinador}'; EXEC spEditarPatrocinador @cadenaa;";
            return csConexion.Consulta(consultaSQL);
        }
        public bool AsignarPatrocinador(string idPatrocinaddor, int IDTorneo, string tipoPatrocinio, decimal precioPatrocinio, string estado)
        {
            string xmlPatrocinio =
                "<PatrocinadorTorneos>" +
                "    <PatrocinadorTorneo>" +
                $"        <IDPatrocinador>{idPatrocinaddor}</IDPatrocinador>" +
                $"        <IDTorneo>{IDTorneo}</IDTorneo>" +
                $"        <TipoPatrocinio>{tipoPatrocinio}</TipoPatrocinio>" +
                $"        <PrecioPatrocinio>{precioPatrocinio.ToString("F2").Trim()}</PrecioPatrocinio>" +
                $"        <Estado>{estado}</Estado>" +
                "    </PatrocinadorTorneo>" +
                "</PatrocinadorTorneos>";

            string consultaSQL = $"DECLARE @cadenaa VARCHAR(MAX) = '{xmlPatrocinio}'; EXEC spRegistraPatrocinadorTorneo @cadenaa;";

            return csConexion.Consulta(consultaSQL);
        }

        #endregion
    }
}
