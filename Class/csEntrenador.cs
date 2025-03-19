using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneosFut;
using TorneosFut.Class;
namespace PruebasTorneos
{
    internal class csEntrenador
    {
        csConexion conexion;
        csImagenes csImagenes;
        public csEntrenador(string u, string c)
        {
            conexion = new csConexion(u,c);
            csImagenes = new csImagenes();
        }
        
        public string IDGeneradoEntrenador(string nombre, string apellido)
        {
            nombre = nombre.ToUpper();
            apellido = apellido.ToUpper();
            string id = "";
            Random rnd = new Random();
            bool repetir = false;
            do
            {
                char primeraLetraNombre = nombre[0];
                char primeraLetraApellido = apellido[0];
                char letraAleatoriaNombre = nombre[rnd.Next(1, nombre.Length)];
                char letraAleatoriaApellido = apellido[rnd.Next(1, apellido.Length)];
                char numeroRandom = rnd.Next(0, 10).ToString()[0];
                id = $"{primeraLetraNombre}{primeraLetraApellido}{letraAleatoriaNombre}{letraAleatoriaApellido}{numeroRandom}";
                // Verificar si el ID ya existe en la base de datos
                DataTable dt = conexion.ListDGV($"SELECT 1 FROM Entrenador WHERE IDEntrenador = '{id}'");
                repetir = (dt.Rows.Count > 0);
            } while (repetir); // Si ya existe, se repite el proceso
            return id;
        }
        #region Devolver Campo
        public string IDEntrenadorSeleccionado(DataGridView dgv)
        {
            return dgv.Rows[dgv.CurrentRow.Index].Cells["IDEntrenador"].Value.ToString();
        }
        public string NombreEntrenadorPorID(string id)
        {
            DataTable dt = conexion.ListDGV($"select NombreEntrenador from Entrenador where IDEntrenador='{id}'");
            return dt.Rows[0][0].ToString();
        }
        public string ApellidoEntrenadorPorID(string id)
        {
            DataTable dt = conexion.ListDGV($"select ApellidoEntrenador from Entrenador where IDEntrenador='{id}'");
            return dt.Rows[0][0].ToString();
        }
        public string SexoEntrenadorPorID(string id)
        {
            DataTable dt = conexion.ListDGV($"select Sexo from Entrenador where IDEntrenador='{id}'");
            return dt.Rows[0][0].ToString();
        }
        public string FechaNacEntrenadorPorID(string id)
        {
            DataTable dt = conexion.ListDGV($"select FechaNacimiento from Entrenador where IDEntrenador='{id}'");
            return dt.Rows[0][0].ToString();
        }
        public string ImagenEntrenador(string i)
        {

            DataGridView dt = new DataGridView();
            dt.DataSource=    conexion.ListDGV($"Select ImagenEntrenador from Entrenador where IDEntrenador = '{i}'");
            string img = dt.Rows[0].Cells[0].Value.ToString(); 
            return img;
        }     
        #endregion

        public DataTable ListaIdEntrenadores()
        {
            DataTable dt = conexion.ListDGV("Select IDEntrenador from Entrenador");
            return dt;
        }
        public bool AgregarEntrenador(string nombre, string apellido, string sexo,string fecha , string imagen)
        {
            if (conexion.Consulta($"insert into Entrenador (IDEntrenador, NombreEntrenador, ApellidoEntrenador, Sexo, FechaNacimiento, ImagenEntrenador)" +
                $" values ('{IDGeneradoEntrenador(nombre,apellido)}','{nombre}','{apellido}', '{sexo}', '{fecha}', '{imagen}')"))
                return true;
            else
                return false;
        }
        public DataTable ListaidEntrenador()
        {
            DataTable dt = conexion.ListDGV("Select IDEntrenador from Entrenador");
            return dt;
        }
        public void Cargar(DataGridView dgvEntrenador, PictureBox ptb)
        {
            string consul = "select IDEntrenador, NombreEntrenador, ApellidoEntrenador, Sexo, FechaNacimiento from Entrenador";
            DataTable dt = conexion.ListDGV(consul);
            dgvEntrenador.DataSource = dt;
            MostrarImagen("10111", ptb);
        }
        
        public void MostrarImagen(string id,PictureBox ptb)
        {
            DataTable datat = conexion.ListDGV($"Select ImagenEntrenador from Entrenador where IDEntrenador = '{id}'");

            if (datat != null && datat.Rows.Count > 0)
            {
                string nombreIMG = datat.Rows[0]["ImagenEntrenador"].ToString();
                csImagenes.CargarImagen(nombreIMG, ptb);
            }
        }
        public DataTable ListadeEntrenadoresFiltro(string filtro)
        {
            DataTable dt;
            dt = conexion.ListDGV($"select IDEntrenador, NombreEntrenador, ApellidoEntrenador, Sexo, FechaNacimiento FROM Entrenador where IDEntrenador like '%{filtro}%' " +
                $"or NombreEntrenador like '%{filtro}%' or ApellidoEntrenador like '%{filtro}%' or FechaNacimiento like '%{filtro}%'");
            return dt;
        }
        public DataTable ListadeEntrenadores()
        {
            DataTable dt = conexion.ListDGV("Select * from Entrenador");
            return dt;
        }
    }
}