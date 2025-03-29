using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using TorneosFut.Class;

namespace TorneosFut
{
    public partial class Plantilla : Form
    {
        private csDatos _datos;
        private csDGV csDGV;
        private List<Guna2CirclePictureBox> _controlesJugadores = new List<Guna2CirclePictureBox>();
        private const int TAMANO_JUGADOR = 50; // Reducimos el tamaño
        private int _limit;
        private int _idPartido;
        private string _equipoLocal;
        private string _equipoVisitante;

        public Plantilla(string idPartido, string idTorneo, string usuario, string clave)
        {
            InitializeComponent();

            // Configuración inicial
            this.Text = "Alineación del Partido";
            this.BackColor = Color.FromArgb(240, 240, 240);

            _datos = new csDatos(usuario, clave);
            csDGV = new csDGV(usuario, clave);
            _limit = _datos.LimiteJugador(idTorneo);
            _idPartido = int.Parse(idPartido);

            var equipos = ObtenerEquipos(_idPartido);
            _equipoLocal = equipos.local;
            _equipoVisitante = equipos.visitante;

            CargarAlineacion();
        }

        private void CargarAlineacion()
        {
            try
            {
                LimpiarCancha();

                DataTable jugadoresLocal = ObtenerJugadoresTitulares(_idPartido, _equipoLocal);
                DataTable jugadoresVisitante = ObtenerJugadoresTitulares(_idPartido, _equipoVisitante);

                MostrarEquipoEnCancha(jugadoresLocal, true);
                MostrarEquipoEnCancha(jugadoresVisitante, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar alineación: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ObtenerJugadoresTitulares(int idPartido, string idEquipo)
        {
            string query = $@"SELECT j.IDJugador, 
                            j.NombreJugador + ' ' + j.ApellidoJugador AS NombreCompleto,
                            je.Dorsal, j.Posicion
                            FROM JugadorPartido jp
                            JOIN Jugador j ON jp.IDJugador = j.IDJugador
                            JOIN Jugador_Equipo je ON j.IDJugador = je.IDJugador AND je.IDEquipo = '{idEquipo}'
                            WHERE jp.IDPartido = {idPartido} AND jp.EsTitular = 1
                            ORDER BY j.Posicion, je.Dorsal";

            return csDGV.EjecutarConsulta(query);
        }

        private (string local, string visitante) ObtenerEquipos(int idPartido)
        {
            DataTable dt = _datos.ObtenerEquiposDelPartido(idPartido);
            if (dt.Rows.Count == 0)
                throw new Exception("No se encontró información del partido");

            return (dt.Rows[0]["EquipoLocal"].ToString(),
                   dt.Rows[0]["EquipoVisitante"].ToString());
        }

        private void MostrarEquipoEnCancha(DataTable jugadores, bool esLocal)
        {
            if (jugadores.Rows.Count == 0) return;

            string formacion = ObtenerFormacion(jugadores.Rows.Count);
            Point[] posiciones = CalcularPosiciones(formacion, esLocal, jugadores.Rows.Count);

            for (int i = 0; i < jugadores.Rows.Count && i < posiciones.Length; i++)
            {
                DataRow jugador = jugadores.Rows[i];
                CrearJugadorGuna2(
                    jugador["IDJugador"].ToString(),
                    jugador["NombreCompleto"].ToString(),
                    jugador["Dorsal"].ToString(),
                    posiciones[i],
                    esLocal
                );
            }
        }

        private string ObtenerFormacion(int cantidadJugadores)
        {
            switch (cantidadJugadores)
            {
                case 5: return "2-2-1";
                case 6: return "2-3-1";
                case 7: return "3-3-1";
                case 8: return "3-4-1";
                case 9: return "3-4-2";
                case 10: return "4-4-2";
                case 11: return "4-4-2";
                default: return "1-1-1";
            }
        }

        private Point[] CalcularPosiciones(string formacion, bool esLocal, int totalJugadores)
        {
            List<Point> posiciones = new List<Point>();
            int anchoCancha = 865; // Tamaño del formulario
            int altoCancha = 941; // Tamaño del formulario
            // Reducir márgenes al mínimo para maximizar el espacio
            int margenHorizontal = 20; // Márgenes más pequeños para aprovechar el espacio
            int margenVertical = 50;   // Márgenes verticales más pequeños
            int ajusteLocalY = 10; // Ajuste de posición en Y para los jugadores locales
            int ajusteVisitanteY = -10; // Ajuste de posición en Y para los visitantes
            // Reducir espacio vertical y horizontal entre jugadores
            int espacioVertical = (altoCancha - 2 * margenVertical) / 4; // Reducir aún más el espacio entre filas
            int espacioHorizontal = (anchoCancha - 2 * margenHorizontal) / 5; // Reducir espacio horizontal por jugador
            // Portero (ubicación centrada en Y)
            int yPortero = esLocal ? margenVertical + ajusteLocalY : altoCancha - margenVertical + ajusteVisitanteY;
            posiciones.Add(new Point(anchoCancha / 2, yPortero));
            // Distribución por formación
            string[] lineas = formacion.Split('-');
            int filaActual = 1;
            foreach (string linea in lineas)
            {
                int cantidad = int.Parse(linea);
                int ajusteY = esLocal ? ajusteLocalY : ajusteVisitanteY;
                int y = (esLocal ? margenVertical + (filaActual * espacioVertical) : altoCancha - margenVertical - (filaActual * espacioVertical)) + ajusteY;
                // Ajustamos el espacio entre jugadores al reducir aún más el divisor
                int espacioX = (anchoCancha - 2 * margenHorizontal) / (cantidad + 1); // Ajustamos para no dejar tanto espacio
                for (int i = 0; i < cantidad; i++)
                {
                    int x = margenHorizontal + (i + 1) * espacioX;
                    posiciones.Add(new Point(x, y));
                }
                filaActual++;
            }
            return posiciones.ToArray();
        }
        private void CrearJugadorGuna2(string idJugador, string nombre, string dorsal, Point ubicacion, bool esLocal)
        {
            var picJugador = new Guna2CirclePictureBox
            {
                Size = new Size(TAMANO_JUGADOR, TAMANO_JUGADOR),
                Location = new Point(ubicacion.X - TAMANO_JUGADOR / 2, ubicacion.Y - TAMANO_JUGADOR / 2),
                SizeMode = PictureBoxSizeMode.Zoom, // Mejor uso de espacio sin distorsión
                Cursor = Cursors.Hand,
                Tag = new { ID = idJugador, Nombre = nombre, Dorsal = dorsal },
                FillColor = esLocal ? Color.Blue : Color.Red,
                BackColor = Color.Transparent, // Evitar superposiciones de color
                Anchor = AnchorStyles.None
            };
            // Dibujar dorsal
            using (var bmp = new Bitmap(TAMANO_JUGADOR, TAMANO_JUGADOR))
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(picJugador.FillColor); // Fondo del color del equipo

                using (var font = new Font("Arial", 12, FontStyle.Bold))
                using (var brush = new SolidBrush(Color.White))
                {
                    var format = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    g.DrawString(dorsal, font, brush, new RectangleF(0, 0, TAMANO_JUGADOR, TAMANO_JUGADOR), format);
                }
                picJugador.Image = (Bitmap)bmp.Clone();
            }

            // Tooltip
            var toolTip = new Guna2HtmlToolTip
            {
                BackColor = Color.White,
                ForeColor = Color.Black
            };
            toolTip.SetToolTip(picJugador, $"<b>{nombre}</b><br>Dorsal: {dorsal}");

            pnlCancha.Controls.Add(picJugador);
            _controlesJugadores.Add(picJugador);

            picJugador.Click += (sender, e) => MostrarDetallesJugador(picJugador.Tag);
        }

        private void MostrarDetallesJugador(object tag)
        {
            dynamic info = tag;
            MessageBox.Show($"Nombre: {info.Nombre}\nDorsal: {info.Dorsal}",
                          $"Jugador #{info.ID}",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }

        private void LimpiarCancha()
        {
            foreach (var control in _controlesJugadores)
            {
                if (control != null && !control.IsDisposed)
                {
                    pnlCancha.Controls.Remove(control);
                    control.Dispose();
                }
            }
            _controlesJugadores.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            RedibujarCancha();
        }

        private void RedibujarCancha()
        {
            if (_idPartido > 0 && _limit > 0)
                CargarAlineacion();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Configurar panel de cancha
            const int margin = 20;
            pnlCancha.Size = new Size(
                this.ClientSize.Width - (margin * 2),
                this.ClientSize.Height - (margin * 2) - btnCerrar.Height - 10);
            pnlCancha.Location = new Point(margin, margin);

            // Configurar botón de cerrar
            btnCerrar.Location = new Point(
                this.ClientSize.Width - btnCerrar.Width - margin,
                this.ClientSize.Height - btnCerrar.Height - margin);
        }

    }
}