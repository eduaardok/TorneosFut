using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private string _nombrePatrocinador;
        private string _descripcion;

        public string IDPatrocinador
        {
            get => _idPatrocinador;
            set => _idPatrocinador = value;
        }

        public string NombrePatrocinador
        {
            get => _nombrePatrocinador;
            set => _nombrePatrocinador = value;
        }

        public string Descripcion
        {
            get => _descripcion;
            set => _descripcion = value;
        }
        #region Listas
        public DataTable ListaDePatrocinadoresFiltro(string filtro)
        {
            DataTable dt;
            dt = csConexion.ListDGV($"select * from Patrocinador where IDPatrocinador like '%{filtro}%' or NombrePatrocinador like '%{filtro}%'");
            return dt;
        }
        public DataTable ListaDePatrocinadores()
        {
            DataTable dt = csConexion.ListDGV("select * from Patrocinador");
            return dt;
        }
        #endregion


        #region Insertar
        public bool AgregarPatrocinador(string id, string nombre, string descripcion)
        {
            IDPatrocinador = id;
            NombrePatrocinador = nombre;
            Descripcion = descripcion;
            string xmlPatrocinador =
                "<Patrocinadores>" +
                "    <Patrocinador>" +
                $"        <IDPatrocinador>{IDPatrocinador}</IDPatrocinador>" +
                $"        <NombrePatrocinador>{NombrePatrocinador}</NombrePatrocinador>" +
                $"        <Descripcion>{Descripcion}</Descripcion>" +
                "    </Patrocinador>" +
                "</Patrocinadores>";
            string consultaSQL = $"DECLARE  @cadenaa varchar(MAX)= '{xmlPatrocinador}'; EXEC spRegistrarPatrocinador @cadenaa;";
            return csConexion.Consulta(consultaSQL);
        }

        #endregion
        #region Actualizar
        public bool EditarPatrocinador(string id, string nombre, string descripcion)
        {
            IDPatrocinador = id;
            NombrePatrocinador = nombre;
            Descripcion = descripcion;
            string xmlPatrocinador =
                "<Patrocinadores>" +
                "    <Patrocinador>" +
                $"        <IDPatrocinador>{IDPatrocinador}</IDPatrocinador>" +
                $"        <NombrePatrocinador>{NombrePatrocinador}</NombrePatrocinador>" +
                $"        <Descripcion>{Descripcion}</Descripcion>" +
                "    </Patrocinador>" +
                "</Patrocinadores>";
            string consultaSQL = $"DECLARE  @cadenaa varchar(MAX)= '{xmlPatrocinador}'; EXEC spEditarPatrocinador @cadenaa;";
            return csConexion.Consulta(consultaSQL);
        }
        #endregion
    }
}
