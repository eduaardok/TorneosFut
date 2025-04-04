using pruebas;
using PruebasTorneos;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneosFut.Class;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace TorneosFut
{
    class csDatos
    {
        csConexion csConexion;
        csUsuario csUsuario;
        csEntrenador csEntrenador;
        csImagenes csImagenes;
        csEquipo csEquipo;
        csJugador csJugador;
        csTorneo csTorneo;
        csArbitro csArbitro;
        csIncripcionEquipo csIncripcion;
        csMovimientoFinanciero csMovimiento;
        csEstadio csEstadio;
        csPatrocinador csPatrocinador;
        csOrganizador csOrganizador;
        public csDatos(string u, string c)
        {
            csConexion = new csConexion(u, c);
            csUsuario = new csUsuario(u, c);
            csEntrenador = new csEntrenador(u, c);
            csImagenes = new csImagenes();
            csEquipo = new csEquipo(u, c);
            csJugador = new csJugador(u, c);
            csTorneo = new csTorneo(u, c);
            csArbitro = new csArbitro(u, c);
            csIncripcion = new csIncripcionEquipo(u, c);
            csMovimiento = new csMovimientoFinanciero(u, c);
            csEstadio = new csEstadio(u, c);
            csPatrocinador = new csPatrocinador(u, c);
            csOrganizador = new csOrganizador(u, c);
        }
        #region Login
        public bool Login(string usuario, string clave)
        {
            if (clave == ObtenerClaveUsuario(usuario))
                return true;
            return false;
        }
        public string ObtenerUsuarioDeCorreo(string correo)
        {
            return csUsuario.UsuarioDeCorreo(correo);
        }
        public string ObtenerClaveDeCorreo(string correo)
        {
            return csUsuario.ClaveoDeCorreo(correo);
        }
        #endregion

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
           return  csUsuario.UsuarioBDDeNombreUsuario(usuario);
        }
        public string ObtenerClaveBD(string usuario)
        {
            return csUsuario.ClaveBDDeNombreUsuario(usuario);
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

        #region Entrenador
        public string ObtenerIDEntrenadorDesdeDGV(DataGridView dgv)
        {
            return csEntrenador.IDEntrenadorSeleccionado(dgv);
        }
        public string ObtenerNombreEntrenadorPorID(string id)
        {
            return csEntrenador.NombreEntrenadorPorID(id);
        }
        public string ObtenerApellidoEntrenadorPorID(string id)
        {
            return csEntrenador.ApellidoEntrenadorPorID(id);
        }
        public string ObtenerSexoEntrenadorPorID(string id)
        {
            return csEntrenador.SexoEntrenadorPorID(id);
        }
        public string ObtenerFechaNacEntrenadorPorID(string id)
        {
            return csEntrenador.FechaNacEntrenadorPorID(id);
        }
       public string ObtenerImagenEntrenadorPorID(string id)
        {
            return csEntrenador.ImagenEntrenadorPorID(id);
        }
        #endregion

        #region Estadio
        public string ObtenerIDEstadioDesdeDGV(DataGridView dgv)
        {
            return csEstadio.IDEstadioSeleccionado(dgv);
        }

        public string ObtenerNombreEstadio(string id)
        {
            return csEstadio.NombreEstadioDeID(id);
        }
        public string ObtenerUbicacionEstadio(string id)
        {
            return csEstadio.UbicacionEstadioDeID(id);
        }
        #endregion
        #region Torneo
        public string ObtenerIDTorneoDesdeDGV(DataGridView dgv)
        {
            return csTorneo.IDTorneoSeleccionado(dgv);
        }
        public int ObtenerCantidadPartidosGenerados(string id)
        {
            return csTorneo.PartidosGenerados(id);
        }
        public List<string> ObtenerListaEquiposTorneo(string id)
        {
            return csTorneo.ListEquiposTorneo(id);
        }
        #endregion
        #region MostrarImagenes
        public void MostrarImagenEntrenador(string id, PictureBox ptb)
        {
            csEntrenador.MostrarImagen(id, ptb);
        }

        public void MostrarImagenEstadio(string id, PictureBox ptb)
        {
            csEstadio.MostrarImagen(id, ptb);
        }
        #endregion

        #region Insertar
        /* public bool CrearLoginBD(string u, string c)
         {
             return csUsuario.NuevoLogin(u, c);
         }*/
        public bool InsertarUsuario(string nombre, string nombreusuario, string clave, string correo, string nombreusuariobd, string clavebd)
        {
            if (csUsuario.AgregarUsuario(nombre, nombreusuario, clave, correo, nombreusuariobd, clavebd))
            {
                return true;
            }
            else
                return false;

        }
        
        public bool InsertarEntrenador(string nombre, string apellido, string sexo,DateTime fecha, string imagen, string filename)
        {
            if (csEntrenador.AgregarEntrenador(nombre, apellido, sexo, fecha, imagen + Path.GetExtension(filename)))
            {
                csImagenes.guardarIMG(filename, imagen);
                MessageBox.Show("Entrenador registrado correctamente");
                return true;
            }
            else
                return false;

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
        public bool InsertarJugador( TextBox Txtnombre, TextBox txtapellido, ComboBox cmbsexo, DateTimePicker dtpNacimiento,
                                      ComboBox CmbPosicion, TextBox TxtNacionalidad, TextBox txtpeso, TextBox txtaltura, ComboBox cmbpierna, string imagen, string filename)
        {

                if (csJugador.AgregarJugador(Txtnombre, txtapellido, cmbsexo, dtpNacimiento, CmbPosicion, TxtNacionalidad, txtpeso, txtaltura, cmbpierna, imagen + Path.GetExtension(filename)))
                {
                    csImagenes.guardarIMG(filename, imagen);
                    return true;
                }
                else
                    return false;
          
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
        public bool InsertarJugadorTitular(string IDJugador, int IDPartido)
        {
            if (!JugadorYaRegistrado(IDJugador, IDPartido)) // Verifica si ya está registrado
            {
                if (csJugador.AgregarTitulares(IDJugador, IDPartido)) // Llama al método que ejecuta el SP
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public void EjecutarConsulta(string query)
        {
            csConexion.Consulta(query);
        }
        public bool QuitarJugadorTitular(string IDJugador, int IDPartido)
        {
            if (JugadorYaEsTitular(IDJugador, IDPartido)) // Verifica si es titular en el partido
            {
                if (csJugador.QuitarTitulares(IDJugador, IDPartido)) // Llama al método que ejecuta el SP para quitar la titularidad
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                MessageBox.Show("El jugador no está registrado como titular en este partido.");
                return false;
            }
        }
        public bool JugadorYaEsTitular(string IDJugador, int IDPartido)
        {
            // Aquí llamamos a un método que consulta la base de datos si el jugador ya es titular
            DataTable dt = csConexion.ListDGV($"SELECT COUNT(1) FROM JugadorPartido WHERE IDJugador = '{IDJugador}' AND IDPartido = {IDPartido} AND esTitular = 1");

            return dt.Rows.Count > 0;
        }
        public List<string> ObtenerListaEquiposGrupoTorneo(string grupo)
        {
            return csTorneo.ListEquiposTorneoGrupo(grupo);
        }

        public bool JugadorYaRegistrado(string IDJugador, int IDPartido)
        {
            DataTable dt = csConexion.ListDGV($"SELECT 1 FROM JugadorPartido WHERE IDJugador = '{IDJugador}' AND IDPartido = {IDPartido}");
            return dt.Rows.Count > 0;
        }


        public bool InsertarTorneo(string Txtnombre, string formato, string ModoFutbol, string Organizador, string te, string fin, decimal costo)
        {
            if (csTorneo.AgregarTorneo(Txtnombre, formato, ModoFutbol, Organizador, te, fin, costo))
            {
                MessageBox.Show("Torneo registrado correctamente");
                return true;
            }
            else
                return false;
        }
        public bool InsertarEstadio(string id, string nombre, string ubicacion, string imagen, string filename)
        {
                if (csEstadio.AgregarEstadio(id, nombre, ubicacion, imagen + Path.GetExtension(filename)))
                {
                   csImagenes.guardarIMG(filename, imagen);
                  return true;
                }
                else
                    return false;
        }
        public int LimiteJugador(string idTorneo)
        {
            return csTorneo.LimitedeJugador(idTorneo);
        }
        public bool InsertarArbittro(string id, string nombre, string apellido, string correo)
        {
            return csArbitro.AgregarArbitro(id, nombre, apellido, correo);
        }
        #endregion

        #region Actualizar
        public bool ActualizarClaveUsuario(string clave, string id)
        {
            return csUsuario.NuevaClaveUsuario(clave, id);
        }
        /*public bool ActualizarClaveBD(string u, string c)
        {
            return csUsuario.NuevaClaveLogin(u, c);
        }*/
        public bool EditarUsuario(string id, string nombre, string nombreusuario, string clave, string correo, string nombreusuariobd, string clavebd)
        {
            return csUsuario.ActualizarUsuario(id, nombre, nombreusuario, clave, correo, nombreusuariobd , clavebd);
        }
        public bool EditarEntrenador(string id, string nombre, string apellido, string sexo, DateTime fechaN, string imagen,string filename)
        {
            csImagenes.guardarIMG(filename, imagen);
            return csEntrenador.ActualizarEntrenador(id, nombre, apellido, sexo, fechaN, imagen+Path.GetExtension(filename));
        }
        public bool EditarEstadio(string id, string nombre, string ubicacion, string imagen, string filename)
        {
            csImagenes.guardarIMG(filename, imagen);

            return csEstadio.ActualizarEstadio(id, nombre, ubicacion, imagen + Path.GetExtension(filename));
        }
        public bool EditarEquipo(string IdEquipo, string IdEstadio, string nombre, string genero, string Eqlocal, string Eqvisitante, string imagen, string presidente, string filename)
        {
            csImagenes.guardarIMG(filename, imagen);

            return csEquipo.ActualizarEquipo(IdEquipo, IdEstadio, nombre, genero, Eqlocal, Eqvisitante, imagen + Path.GetExtension(filename), presidente);
        }
        public bool EditarArbitro(string id, string nombre, string apellido, string correo)
        {
            return csArbitro.ActualizarArbitro(id, nombre, apellido, correo);
        }
        public bool AgregarArbitro(string id, string nombre, string apellido, string correo)
        {
            return csArbitro.AgregarArbitro(id, nombre, apellido, correo);
        }
        public bool EditarTorneo(string id, string Txtnombre, string formato, string ModoFutbol, string Organizador, string te, string fin, decimal costo)
        {
            if (csTorneo.ActualizarTorneo(id, Txtnombre, formato, ModoFutbol, Organizador, te, fin, costo))
            {
                MessageBox.Show("Torneo actualizado correctamente");
                return true;
            }
            else
                return false;
        }
        public bool EditarJugador( string idJugadorr,TextBox Txtnombre, TextBox txtapellido, ComboBox cmbsexo, DateTimePicker dtpNacimiento,
        ComboBox CmbPosicion, TextBox TxtNacionalidad, TextBox txtpeso, TextBox txtaltura, ComboBox cmbpierna, string imagen, string filename)
        {
            csImagenes.guardarIMG(filename, imagen);
            return csJugador.ActualizarJugador( idJugadorr,Txtnombre, txtapellido, cmbsexo, dtpNacimiento, CmbPosicion, TxtNacionalidad, txtpeso, txtaltura, cmbpierna,imagen + Path.GetExtension(filename));
        }
        public bool EditarPatrocinador(string ID,string NombrePatrocinador, string Descripcion)
        {
            return csPatrocinador.EditarPatrocinador(ID,NombrePatrocinador,Descripcion);
        }
        public bool AgregarPatrocinador(string ID, string NombrePatrocinador, string Descripcion)
        {
            return csPatrocinador.AgregarPatrocinador(ID,NombrePatrocinador,Descripcion);
        }
        #endregion
        public bool AgreegarOrganizador(string NombreEmpresa, string Telefono, string Correo)
        {
            return csOrganizador.AgregarOrganizador(NombreEmpresa,Telefono,Correo);
        }
        public bool EditarOrganizador(string ID, string NombreEmpresa, string Telefono, string Correo)
        {
            return csOrganizador.EditarOrganizador(ID,NombreEmpresa,Telefono,Correo);
        }

        #region Métodos para Alineaciones

        public DataTable ObtenerTitularesPorPartido(int idPartido, string idEquipo)
        {
            return csJugador.ObtenerTitularesPorPartido(idPartido, idEquipo);
        }

        public DataTable ObtenerModoFutbolPorPartido(int idPartido)
        {
            return csTorneo.ObtenerModoFutbolPorPartido(idPartido);
        }

        public DataTable ObtenerEquiposDelPartido(int idPartido)
        {
            return csTorneo.ObtenerEquiposDelPartido(idPartido);
        }

        #endregion
        #region Validaciones (hay que moverlas)

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

        //INSCRIPCIONES
        public bool InsertarIncripcion(int IDTorneo, List<string> listaEquipos, decimal montoAPagar, string fecha)
        {
            return csIncripcion.AgregarInscripcion(IDTorneo, listaEquipos, montoAPagar, fecha);
        }
        public bool QuitarIncripcion(string IDEquipo)
        {
            return csIncripcion.EliminarInscripcion(IDEquipo);
        }
        public bool ModificarIncripcion(string idInscripcion, decimal abono, decimal saldo, decimal montoAPagar, string estado)
        {
            return csIncripcion.EditarInscripcion(idInscripcion, abono, saldo, montoAPagar, estado);
        }
        public bool InsertarMovimientoInscripcion(int IDTorneo, decimal abonoMo, string Descripciopn, string iDInscripcion, decimal monto, decimal saldo, string estado)
        {
            if (ModificarIncripcion(iDInscripcion, abonoMo, saldo, monto, estado))
                return csMovimiento.AgregarMovimientoInscripcion(IDTorneo, abonoMo, Descripciopn);
            return false;
        }
        //GENERAR TORNEO
       /* public bool GenerarPartidos(string torneo)
        {
            return csTorneo.GenerarTorneo(torneo);
        }*/
        public string NombrePatrocinador(string ID)
        {
            return csEstadio.NombrePatrocinador(ID);
        }
        public string DescripcionPatrocinador(String ID)
        {
            return csEstadio.DescripcionPatrocinador(ID);
        }
        public string NombreArbitro(string id)
        {
            return csArbitro.nombrearbitro(id);
        }
        public string apellidoArbitro(string id)
        {
            return csArbitro.apellidoarbitro(id);
        }
        public string CorreoArbitro(string id)
        {
            return csArbitro.correo(id);
        }
        public string CorreoOrganizador(string id)
        {
            return csOrganizador.CorreoOrganizador(id);
        }
        public string NombreOrganizador(string id)
        {
            return csOrganizador.NombreOrganizador(id);
        }
        public string TelefonoOrganizador(string id)
        {
            return csOrganizador.TelefonoOrganizador(id);
        }


    }
}
