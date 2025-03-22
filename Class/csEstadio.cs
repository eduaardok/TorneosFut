using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneosFut.Class
{
    class csEstadio
    {
        csConexion csConexion;

        public csEstadio(string u, string c)
        {
            csConexion = new csConexion(u, c);
        }
        private int _idEstadio;
        private string _nombreEstadio;
        private string _ubicacion;
        private string _imagenEstadio;

        public int IDEstadio
        {
            get => _idEstadio;
            set => _idEstadio = value;
        }

        public string NombreEstadio
        {
            get => _nombreEstadio;
            set => _nombreEstadio = value;
        }

        public string Ubicacion
        {
            get => _ubicacion;
            set => _ubicacion = value;
        }

        public string ImagenEstadio
        {
            get => _imagenEstadio;
            set => _imagenEstadio = value;
        }
        #region Listas
        public DataTable ListaDeEstadiosFiltro(string filtro)
        {
            DataTable dt;
            dt = csConexion.ListDGV($"select IDEstadio, NombreEstadio from Estadio where IDEstadio like '%{filtro}%' or NombreEstadio like '%{filtro}%'");
            return dt;
        }
        public DataTable ListaDeEstadios()
        {
            DataTable dt = csConexion.ListDGV("select IDEstadio, NombreEstadio from Estadio");
            return dt;
        }

        #endregion

        #region Insertar
        public bool AgregarEstadio(int id, string nombre, string ubicacion, string imagen)
        {
            IDEstadio = id;
            NombreEstadio = nombre;
            Ubicacion = ubicacion;
            ImagenEstadio = imagen;

            string xmlEstadio =
                "<Estadios>" +
                "    <Estadio>" +
                $"        <IDEstadio>{IDEstadio}</IDEstadio>" +
                $"        <NombreEstadio>{NombreEstadio}</NombreEstadio>" +
                $"        <Ubicacion>{Ubicacion}</Ubicacion>" +
                $"        <ImagenEstadio>{ImagenEstadio}</ImagenEstadio>" +
                "    </Estadio>" +
                "</Estadios>";

            string consultaSQL = $"DECLARE @Datos VARCHAR(MAX) = '{xmlEstadio}'; EXEC spRegistrarEstadio @Datos;";

            return csConexion.Consulta(consultaSQL);
        }
        #endregion
        #region Actualizar
        public bool ActualizarEstadio(int id, string nombre, string ubicacion, string imagen)
        {
            IDEstadio = id;
            NombreEstadio = nombre;
            Ubicacion = ubicacion;
            ImagenEstadio = imagen;
            string xmlEstadio =
                "<Estadios>" +
                "    <Estadio>" +
                $"        <IDEstadio>{IDEstadio}</IDEstadio>" +
                $"        <NombreEstadio>{NombreEstadio}</NombreEstadio>" +
                $"        <Ubicacion>{Ubicacion}</Ubicacion>" +
                $"        <ImagenEstadio>{ImagenEstadio}</ImagenEstadio>" +
                "    </Estadio>" +
                "</Estadios>";

            string consultaSQL = $"DECLARE @Datos VARCHAR(MAX) = '{xmlEstadio}'; EXEC spEditarEstadio @Datos;";

            return csConexion.Consulta(consultaSQL);
        }

        #endregion
    }
}
