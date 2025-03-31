using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Policy;
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
        public DataTable ListaArbitros()
        {
            DataTable dt = csConexion.ListDGV("Select * from Arbitro");
            return dt;
        }
        public DataTable ListaDeArbitrosFiltro(string filtro)
        {
            DataTable dt; 
            dt = csConexion.ListDGV($"select * from Arbitro where IDArbitro like '%{filtro}%' or NombreArbitro like '%{filtro}%' or ApellidoArbitro like '%{filtro}%'");
            return dt;
        }
        public string GenerarNuevoIDArbitro()
        {
            string nuevoID = "ARB01";
            string consulta = "SELECT MAX(IDArbitro) FROM Arbitro WHERE IDArbitro LIKE 'ARB%'";

            DataTable dt = csConexion.ListDGV(consulta);

            if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
            {
                string ultimoID = dt.Rows[0][0].ToString(); 

                if (int.TryParse(ultimoID.Substring(3), out int numero))
                {
                    nuevoID = "ARB" + (numero + 1).ToString("D2"); 
                }
            }

            return nuevoID;
        }

        #region Insertar
        public bool AgregarArbitro(string id, string nombre, string apellido, string correo)
        {
            IDArbitro = GenerarNuevoIDArbitro();
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
        public string nombrearbitro(string id )
        {
            DataTable dt = csConexion.ListDGV($"select NombreArbitro from Arbitro where IDArbitro='{id}'");
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            else return "";
        }
        public string apellidoarbitro(string id)
        {
            DataTable dt = csConexion.ListDGV($"select ApellidoArbitro from Arbitro where IDArbitro='{id}'");
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            else return "";
        }
        public string correo(string id)
        {

            DataTable dt = csConexion.ListDGV($"select Correo from Arbitro where IDArbitro='{id}'");
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            else return "";
        }
    }
}
