using PruebasTorneos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneosFut.Class;
namespace TorneosFut
{
    class csDatos
    {
        csConexion conexion;
        csUsuario csUsuario;
        csEntrenador csEntrenador;
        csImagenes csImagenes;
        public csDatos(string u, string c)
        {
            conexion = new csConexion(u, c);
            csUsuario = new csUsuario(u, c);
            csEntrenador = new csEntrenador(u, c);
            csImagenes = new csImagenes();
        }
        public int ObtenerIDUsuario(DataGridView dgv)
        {
            return csUsuario.IDUsuario(dgv);
        }


        //Insertar Temporal
        public bool InsertarEntrenador(string nombre, string apellido, string sexo, string imagen, string filename)
        {
            if (csEntrenador.AgregarEntrenador(nombre, apellido, sexo, imagen+ Path.GetExtension(filename)))
                csImagenes.guardarIMG(filename, imagen);
            else
                return false;
            return true;
                
        }
    }
}
