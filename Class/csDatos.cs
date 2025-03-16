using PruebasTorneos;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
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
        csJugador csJugador;
        csTorneo csTorneo;
        public csDatos(string u, string c)
        {
            conexion = new csConexion(u, c);
            csUsuario = new csUsuario(u, c);
            csEntrenador = new csEntrenador(u, c);
            csImagenes = new csImagenes();
            csEquipo = new csEquipo(u, c);
            csJugador = new csJugador(u, c);
            csTorneo = new csTorneo(u, c);
        }

        public int ObtenerIDUsuario(DataGridView dgv)
        {
            return csUsuario.IDUsuario(dgv);
        }
        public bool InsertarEntrenador(string Id,string nombre, string apellido, string sexo,string fecha, string imagen, string filename)
        {
            if(validarIDEntrenador(Id))
            {
                if (csEntrenador.AgregarEntrenador(Id, nombre, apellido, sexo, fecha, imagen + Path.GetExtension(filename)))
                {
                    csImagenes.guardarIMG(filename, imagen);
                    MessageBox.Show("Entrenador registrado correctamente");
                    return true;
                }
                else
                    return false;
            }
            else
            {
                return false;
            }
           
        }
        public bool InsertarEquipo(string IdEquipo, string IdEstadio, string nombre, string genero, string Eqlocal, string Eqvisitante, string imagen, string presidente, string filename)
        {
            if (validarIDEquipo(IdEquipo))
            {
                if (csEquipo.AgregarEquipo(IdEquipo, IdEstadio, nombre, genero, Eqlocal, Eqvisitante, imagen + Path.GetExtension(filename), presidente))
                {
                    csImagenes.guardarIMG(filename, imagen);
                    MessageBox.Show("Equipo registrado correctamente");
                    return true;
                }
                else
                    return false;
            }
            else
            {
                return true;
            }
        }
        public bool InsertarJugador(string idJugador, TextBox Txtnombre, TextBox txtapellido, ComboBox cmbsexo, DateTimePicker dtpNacimiento,
                                      ComboBox CmbPosicion, TextBox TxtNacionalidad, TextBox txtpeso, TextBox txtaltura, ComboBox cmbpierna, string imagen, string filename)
        {
            if (validarIDJugador(idJugador))
            {
                if (csJugador.AgregarJugador(idJugador, Txtnombre, txtapellido, cmbsexo, dtpNacimiento, CmbPosicion, TxtNacionalidad, txtpeso, txtaltura, cmbpierna, imagen + Path.GetExtension(filename)))
                {
                    csImagenes.guardarIMG(filename, imagen);
                    MessageBox.Show("Jugador registrado correctamente");
                    return true;
                }
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
        int GenerarIDRandom()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            return rnd.Next(0, 100);
        }
        public bool InsertarTorneo(int idTorneo, TextBox Txtnombre, ComboBox formato, ComboBox ModoFutbol, int IdUsuario, ComboBox Organizador, DateTimePicker te)
        {
            if (validarIDTorneo(idTorneo.ToString()))
            {
                if (csTorneo.AgregarTorneo(idTorneo, Txtnombre, formato, ModoFutbol, IdUsuario, Organizador, te))
                {
                    MessageBox.Show("Torneo registrado correctamente");
                    return true;
                }
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
        public bool IDEquipoRepetido(string id)
        {
            DataTable dt = csEquipo.ListadeEquipos();

            string[] IDS = new string[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                IDS[i] = dt.Rows[i][0].ToString();
            }
            for (int i = 0; i < IDS.Length; i++)
            {
                if (IDS[i] == id)
                {
                    MessageBox.Show("El ID ya existe");
                    return true;
                }
                MessageBox.Show(IDS[i].ToString());
            }
            return false;
        }
        public bool IDJugadorRepetido(string id)
        {
            DataTable dt = csJugador.ListaidJugadores();

            string[] IDS = new string[dt.Rows.Count];

            for (int i = 0; i < dt.Rows. Count; i++)
            {
                IDS[i]= dt.Rows[i][0].ToString();
            }
            for (int i = 0; i < IDS.Length;i++)
            {

                if (IDS[i] == id)
                {
                    MessageBox.Show("Número de cédula ya existente");
                    return true;
                }
            }
            return false;
        }
        public bool IDEntrenadorRepetido(string id)
        {
            DataTable dt = csEntrenador.ListaIdEntrenadores();

            string[] IDS = new string[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                IDS[i] = dt.Rows[i][0].ToString();
            }
            for (int i = 0; i < IDS.Length; i++)
            {

                if (IDS[i] == id)
                {
                    MessageBox.Show("Número de cédula ya existente");
                    return true;
                }
            }
            return false;
        }
        public bool IDTorneoRepetido(string id)
        {
            DataTable dt = csTorneo.ListaIDTorneo();

            string[] IDS = new string[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                IDS[i] = dt.Rows[i][0].ToString();
            }
            for (int i = 0; i < IDS.Length; i++)
            {

                if (IDS[i] == id)
                {
                    MessageBox.Show($"Ya existe un torneo registrado con el ID: {id}");
                    return true;
                }
            }
            return false;
        }
        public bool validarIDTorneo(string id)
        {
            if (validarSoloNumeros(id) && !(IDTorneoRepetido(id)))
            {
                return true;
            }
            return false;
        }
        public bool validarIDEntrenador(string ID)
        {
            if (validarSoloNumeros(ID) && validarlongitud(ID, 10) && !(IDEntrenadorRepetido(ID)))
            {
                return true;
            }
            return false;
        }
        public bool validarIDEquipo(string ID)
        {

            if (validarLongitudEquipo(ID) && !(IDEquipoRepetido(ID)))
            {
                return true;
            }
            return false;
        }
        bool validarLongitudEquipo(string id)
        {
            id=id.Trim();
            if(id.Length<3||id.Length>4)
            {
                MessageBox.Show("El ID debe tener de 3 a 4 caracteres");
                return false;
            }
            return true;
        }

        public bool validarIDJugador(string ID)
        {

            if (validarSoloNumeros(ID) && validarlongitud(ID,10)&& !(IDJugadorRepetido(ID)))
            {
                return true;
            }
            return false;
        }
        public bool validarSoloNumeros(string ID) 
        {
            string numero = "1234567890";
            for(int i = 0; i<ID.Length;i++)
            {
                if (!numero.Contains(ID[i]))
                {
                    MessageBox.Show("Ingrese solo caracteres numéricos");
                    return false;
                }
            }
            return true;
        }

        public bool validarlongitud(string ID,int n)
        {
            if (ID.Length == n)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Ingrese un número de cédula válido");
                return false;
            }
        }
    }
}
