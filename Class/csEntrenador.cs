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
        public int IDEntrenador(DataGridView dgv)
        {
            int id = int.Parse(dgv.Rows[dgv.CurrentRow.Index].Cells[0].Value.ToString());
            return id;
        }
        public string Imagen(string i)
        {

            DataGridView dt = new DataGridView();
            dt.DataSource=    conexion.ListDGV($"Select ImagenEntrenador from Entrenador where IDEntrenador = '{i}'");
            string img = dt.Rows[0].Cells[0].Value.ToString(); 
            return img;
        }
        public DataTable ListaIdEntrenadores()
        {
            DataTable dt = conexion.ListDGV("Select IDEntrenador from Entrenador");
            return dt;
        }
        public bool AgregarEntrenador(string Id,string nombre, string apellido, string sexo,string fecha , string imagen)
        {
            if (conexion.Consulta($"insert into Entrenador (IDEntrenador, NombreEntrenador, ApellidoEntrenador, Sexo, FechaNacimiento, ImagenEntrenador)" +
                $" values ('{Id}','{nombre}','{apellido}', '{sexo}', '{fecha}', '{imagen}')"))
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
            string consul = "select IDEntrenador, NombreEntrenador, ApellidoEntrenador, Sexo from Entrenador";
            DataTable dt = conexion.ListDGV(consul);
            dgvEntrenador.DataSource = dt;
            /*foreach (DataGridViewColumn column in dgvEntrenador.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }*/
            MostrarImagen("10111", ptb);
        }
        void AdaptarDGV(DataGridView dgvEntrenador)
        {
            int filas = dgvEntrenador.RowCount;
            for (int i = 0; i < filas; i++)
            {
                dgvEntrenador.Rows[i].Height = dgvEntrenador.Height / filas;
            }
            dgvEntrenador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void MostrarImagen(string id,PictureBox ptb)
        {

            
                            csImagenes.CargarImagen("Imagen638776550043571267.png", ptb);

            //csImagenes.CargarImagen(Imagen(id), ptb);
        }
        public void filtro(string filtro, DataGridView dgvEntrenador)
        {
            if (string.IsNullOrWhiteSpace(filtro))
            {
                dgvEntrenador.DataSource = conexion.ListDGV(@"select IDEntrenador,NombreEntrenador, ApellidoEntrenador, Sexo from Entrenador");
                AdaptarDGV(dgvEntrenador);
            }
            else
            {
                string consulta = $@"select IDEntrenador, NombreEntrenador, ApellidoEntrenador, Sexo from Entrenador where IDEntrenador like '%{filtro}%' or 
                    NombreEntrenador like '%{filtro}%' or ApellidoEntrenador like '%{filtro}%'";

                DataTable dt = conexion.ListDGV(consulta);
                dgvEntrenador.DataSource = dt;
            }
        }
        public DataTable ListadeEntrenadoresfiltro(string filtro)
        {
            DataTable dt;
            dt = conexion.ListDGV($"select * FROM Entrenador where IDEntrenador like '%{filtro}%' " +
                $"or NombreEntrenador like '%{filtro}%' or ApellidoEntrenador like '%{filtro}%' or Sexo like '%%' or FechaNacimiento like '%{filtro}%'");
            return dt;
        }
        public DataTable ListadeEntrenadores()
        {
            DataTable dt = conexion.ListDGV("Select * from Entrenador");
            return dt;
        }
    }
}