using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorneosFut.Class
{
    class csEstadio
    {
        csConexion csConexion;
        csImagenes csImagenes;
        public csEstadio(string u, string c)
        {
            csImagenes = new csImagenes();
            csConexion = new csConexion(u, c);
        }
        private string _idEstadio;
        private string _nombreEstadio;
        private string _ubicacion;
        private string _imagenEstadio;

        public string IDEstadio
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
            dt = csConexion.ListDGV($"select IDEstadio, NombreEstadio, Ubicacion from Estadio where IDEstadio like '%{filtro}%' or NombreEstadio like '%{filtro}%'");
            return dt;
        }
        public DataTable ListaDeEstadios()
        {
            DataTable dt = csConexion.ListDGV("select IDEstadio, NombreEstadio, Ubicacion from Estadio");
            return dt;
        }

        #endregion
        #region ObtenerDatos
        public void Cargar(DataGridView dgvEntrenador, PictureBox ptb)
        {
            string consul = "select IDEstadio, NombreEstadio, Ubicacion from Estadio";
            DataTable dt = csConexion.ListDGV(consul);
            dgvEntrenador.DataSource = dt;
            MostrarImagen(dt.Rows[0]["IDEstadio"].ToString(), ptb);
        }
        
        public void MostrarImagen(string id, PictureBox ptb)
        {
            DataTable datat = csConexion.ListDGV($"select ImagenEstadio from Estadio where IDEstadio = {id}");

            if (datat != null && datat.Rows.Count > 0)
            {
                string nombreIMG = datat.Rows[0]["ImagenEstadio"].ToString();
                csImagenes.CargarImagen(nombreIMG, ptb);
            }
        }
        public string IDEstadioSeleccionado(DataGridView dgv)
        {
            return dgv.Rows[dgv.CurrentRow.Index].Cells["IDEstadio"].Value.ToString();
        }
        public string NombreEstadioDeID(string id)
        {
            DataTable dt = csConexion.ListDGV($"select NombreEstadio from Estadio where IDEstadio={id}");
            return dt.Rows[0][0].ToString();
        }
        public string UbicacionEstadioDeID(string id)
        {
            DataTable dt = csConexion.ListDGV($"select Ubicacion from Estadio where IDEstadio={id}");
            return dt.Rows[0][0].ToString();
        }
        #endregion
        #region Insertar
        public bool AgregarEstadio(string id, string nombre, string ubicacion, string imagen)
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
        public bool ActualizarEstadio(string id, string nombre, string ubicacion, string imagen)
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
