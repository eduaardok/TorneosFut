using pruebas;
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
        //csConexion csConexion;
        csUsuario csUsuario;
        csEntrenador csEntrenador;
        csImagenes csImagenes;
        csEquipo csEquipo;
        csJugador csJugador;
        csTorneo csTorneo;
        public csDatos(string u, string c)
        {
            //csConexion = new csConexion(u, c);
            csUsuario = new csUsuario(u, c);
            csEntrenador = new csEntrenador(u, c);
            csImagenes = new csImagenes();
            csEquipo = new csEquipo(u, c);
            csJugador = new csJugador(u, c);
            csTorneo = new csTorneo(u, c);
        }

        #region Usuario
        public string ObtenerIDUsuarioDesdeDGV(DataGridView dgv)
        {
            return csUsuario.IDUsuarioSeleccionado(dgv);
        }
        public int ObtenerIDUsuario(string nombreusuario)
        {
            return csUsuario.IDUsuarioDeNombreUsuario(nombreusuario);
        }
        public string ObtenerClaveUsuario(string usuario)
        {
            return csUsuario.ClaveUsuarioDeNombreUsuario(usuario);
        }
       
        public string ObtenerUsuarioBD(string usuario)
        {
           return  csUsuario.UsuarioBD(usuario);
        }
        public string ObtenerClaveBD(string usuario)
        {
            return csUsuario.ClaveBD(usuario);
        }
        #region DatosDeID
        public string ObtenerNombrePorID(string id)
        {
            return csUsuario.NombreDeID(id);
        }
        public string ObtenerUsuarioPorID(string id)
        {
            return csUsuario.UsuarioDeID(id);
        }
        public string ObtenerClavePorID(string id)
        {
            return csUsuario.ClaveDeID(id);

        }
        public string ObtenerCorreoPorID(string id)
        {
            return csUsuario.CorreoDeID(id);
        }
        public string ObtenerUsuarioBDPorID(string id)
        {
            return csUsuario.UsuarioBDDeID(id);
        }
        public string ObtenerClaveBDPorID(string id)
        {
            return csUsuario.ClaveBDDeID(id);
        }
        #endregion

        #endregion

        #region Insertar
        public bool CrearLoginBD(string u, string c)
        {
            return csUsuario.NuevoLogin(u, c);
        }
        public bool InsertarUsuario(string nombre, string nombreusuario, string clave, string correo, string nombreusuariobd, string clavebd)
        {
            if (validarUsuario())
            {
                if (csUsuario.AgregarUsuario(csUsuario.IDUsuarioNuevo(), nombre, nombreusuario, clave, correo, nombreusuariobd, clavebd))
                {
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
        public bool InsertarJugadorEquipo(string IDJugador, string IDEquipo, int Dorsal)
        {
            if (!DorsalJugadorRepetido(IDEquipo,Dorsal.ToString()))
            {
                if (csJugador.AgregarJugadorEquipo(IDJugador, IDEquipo, Dorsal))
                {
                    MessageBox.Show("Jugador registrado correctamente en el equipo");
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
        public bool InsertarTorneo(int idTorneo, string Txtnombre, string formato, string ModoFutbol, int IdUsuario, string Organizador, string te)
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
        #endregion
        
        #region Actualizar
        public bool ActualizarClaveUsuario(string clave, string id)
        {
            return csUsuario.NuevaClaveUsuario(clave, id);
        }
        public bool ActualizarClaveBD(string u, string c)
        {
            return csUsuario.NuevaClaveLogin(u, c);
        }
        public bool ActualizarUsuario(string id, string nombre, string nombreusuario, string clave, string correo, string nombreusuariobd, string clavebd)
        {
            return csUsuario.ActualizarUsuario(id, nombre, nombreusuario, clave, correo, nombreusuariobd , clavebd);
        }
        #endregion
        
        #region Validaciones (hay que moverlas)
        public bool validarUsuario()
        {
            return false;

        }
        public bool JugadorSinEquipo(string IdJugador, string IdEquipo)
        {
            if (csJugador.DejarJugadorSinEquipo(IdJugador, IdEquipo))
            {
                MessageBox.Show("Jugador apartado del equipo");
                return true;
            }
            else
                return false;
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
        public bool DorsalJugadorRepetido(string id, string dorsal)
        {
            DataTable dt = csJugador.ListaDorsalesJugadores(id);
            string[] dorsales = new string[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dorsales[i] = dt.Rows[i][0].ToString();
            }
            for (int i = 0; i < dorsales.Length; i++)
            {
                if (dorsales[i] == id)
                {
                    MessageBox.Show($"Ya un jugador registrado con ese dorsal");
                    return true;
                }
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
    #endregion
    }
}
