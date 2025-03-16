using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorneosFut.Class
{
    class csEquipo
    {
        csConexion conexion;
        private string _idEquipo;
        private string _idEstadio;
        private string _nombreEquipo;
        private string _genero;
        private string _equipacionLocal;
        private string _equipacionVisitante;
        private string _imagenEscudo;
        private string _presidente;
        public csEquipo(string u, string c)
        {
            conexion = new csConexion(u,c);
        }
        public string IDEquipo
        {
            get => _idEquipo;
            set => _idEquipo = value;
        }
        public string IDEstadio
        {
            get => _idEstadio;
            set => _idEstadio = value;
        }
        public string NombreEquipo
        {
            get => _nombreEquipo;
            set => _nombreEquipo = value;
        }
        public string Genero
        {
            get => _genero;
            set => _genero = value;
        }
        public string EquipacionLocal
        {
            get => _equipacionLocal;
            set => _equipacionLocal = value;
        }
        public string EquipacionVisitante
        {
            get => _equipacionVisitante;
            set => _equipacionVisitante = value;
        }
        public string ImagenEscudo
        {
            get => _imagenEscudo;
            set => _imagenEscudo = value;
        }
        public string Presidente
        {
            get => _presidente;
            set => _presidente = value;
        }
        public DataTable ListaIDEquipo()
        {
            DataTable dt = conexion.ListDGV("select IDEquipo from Equipo");
            return dt;
        }

        public DataTable ListadeEquipos()
        {
            DataTable dt = conexion.ListDGV("select IDEquipo,IDEstadio,NombreEquipo,Presidente,Genero,EquipacionLocal,EquipacionVisitante from Equipo");
            return dt;
        }
        public DataTable ListadeEquiposfiltro(string filtro)
        {
            DataTable dt;
            dt = conexion.ListDGV($"select * from Equipo where IDEquipo like '%{filtro}%' " +
                                 $"or NombreEquipo like '%{filtro}%'");
            return dt;
        }
        public string Imagen(string i)
        {

            DataGridView dt = new DataGridView();
            dt.DataSource = conexion.ListDGV($"Select ImagenEntrenador from Entrenador where IDEntrenador = '{i}'");
            string img = dt.Rows[0].Cells[0].Value.ToString();
            return img;
        }
        public bool AgregarEquipo(string idEquipo, string idEstadio, string nombre, string genero, string equipacionLocal, string equipacionVisitante, string imagen, string presidente)
        {
            IDEquipo = idEquipo.Trim();
            IDEstadio = idEstadio.Trim();
            NombreEquipo = nombre.Trim();
            Genero = genero.Trim();
            EquipacionLocal = equipacionLocal.Trim();
            EquipacionVisitante = equipacionVisitante.Trim();
            ImagenEscudo = imagen.Trim();
            Presidente = presidente.Trim();

            string xmlEquipo =
                "<Equipos>" +
                "    <Equipo>" +
                $"        <IDEquipo>{IDEquipo}</IDEquipo>" +
                $"        <IDEstadio>{IDEstadio}</IDEstadio>" +
                $"        <NombreEquipo>{NombreEquipo}</NombreEquipo>" +
                $"        <Genero>{Genero}</Genero>" +
                $"        <EquipacionLocal>{EquipacionLocal}</EquipacionLocal>" +
                $"        <EquipacionVisitante>{EquipacionVisitante}</EquipacionVisitante>" +
                $"        <ImagenEscudo>{ImagenEscudo}</ImagenEscudo>" +
                $"        <Presidente>{Presidente}</Presidente>" +
                "    </Equipo>" +
                "</Equipos>";
            if (conexion.Consulta($"declare @cadenaa varchar(MAX) = '{xmlEquipo}'; exec spRegistraEquipo @cadenaa;"))
                return true;
            else
                return false;
        }
    }
}
