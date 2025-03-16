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
        csEquipo csEquipo;
        public csDatos(string u, string c)
        {
            conexion = new csConexion(u, c);
            csUsuario = new csUsuario(u, c);
            csEntrenador = new csEntrenador(u, c);
            csImagenes = new csImagenes();
            csEquipo = new csEquipo(u, c);
        }
        public int ObtenerIDUsuario(DataGridView dgv)
        {
            return csUsuario.IDUsuario(dgv);
        }


        //Insertar Temporal
        public bool InsertarEntrenador(string Id,string nombre, string apellido, string sexo,string fecha, string imagen, string filename)
        {
            if (csEntrenador.AgregarEntrenador(Id,nombre, apellido, sexo,fecha, imagen+ Path.GetExtension(filename)))
                csImagenes.guardarIMG(filename, imagen);
            else
                return false;
            return true;
                
        }
        public bool InsertarEquipo(string IdEquipo,string IdEstadio, string nombre, string genero, string Eqlocal, string Eqvisitante, string imagen, string presidente,string filename)
        {
            if (csEquipo.AgregarEquipo(IdEquipo,IdEstadio, nombre, genero, Eqlocal, Eqvisitante, imagen + Path.GetExtension(filename), presidente))
                csImagenes.guardarIMG(filename, imagen);
            else
                return false;
            return true;

        }
    }
}
