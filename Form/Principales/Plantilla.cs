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
        private List<Guna2PictureBox> _controlesJugadores = new List<Guna2PictureBox>();
        private const int TAMANO_JUGADOR = 70;

        public Plantilla(string idPartido, string usuario, string clave)
        {
            InitializeComponent();
            _datos = new csDatos(usuario, clave);
            
            MostrarAlineacionEnCancha(int.Parse(idPartido));
        }
        
        private void MostrarAlineacionEnCancha(int idPartido)
        {
            LimpiarCancha();

            var (modo, equipoLocal, equipoVisitante) = ObtenerDatosPartido(idPartido);
            if (modo == null) return;

            var titularesLocal = _datos.ObtenerTitularesPorPartido(idPartido, equipoLocal);
            var titularesVisitante = _datos.ObtenerTitularesPorPartido(idPartido, equipoVisitante);

            MostrarEquipoEnCancha(titularesLocal, true, modo);
            MostrarEquipoEnCancha(titularesVisitante, false, modo);
        }

        private (string modo, string local, string visitante) ObtenerDatosPartido(int idPartido)
        {
            DataTable dtEquipos = _datos.ObtenerEquiposDelPartido(idPartido);
            DataTable dtModo = _datos.ObtenerModoFutbolPorPartido(idPartido);

            if (dtEquipos.Rows.Count == 0 || dtModo.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron datos del partido");
                return (null, null, null);
            }

            return (
                dtModo.Rows[0]["NombreModo"].ToString(),
                dtEquipos.Rows[0]["EquipoLocal"].ToString(),
                dtEquipos.Rows[0]["EquipoVisitante"].ToString()
            );
        }

        private void MostrarEquipoEnCancha(DataTable jugadores, bool esLocal, string modo)
        {
            var posiciones = ObtenerPosicionesParaModo(modo, esLocal);
            int index = 0;

            foreach (DataRow jugador in jugadores.Rows)
            {
                string posicion = jugador["Posicion"].ToString().ToUpper();
                string clave = $"{posicion}_{index}";

                if (posiciones.ContainsKey(clave))
                {
                    CrearJugadorGuna2(
                        jugador["IDJugador"].ToString(),
                        jugador["NombreCompleto"].ToString(),
                        posicion,
                        jugador["Dorsal"].ToString(),
                        posiciones[clave],
                        esLocal
                    );
                    index++;
                }
            }
        }

        private void CrearJugadorGuna2(string idJugador, string nombreCompleto, string posicion, string dorsal, Point ubicacion, bool esLocal)
        {
            // Crear PictureBox de Guna2
            var picJugador = new Guna2PictureBox
            {
                Size = new Size(TAMANO_JUGADOR, TAMANO_JUGADOR),
                Location = new Point(ubicacion.X - TAMANO_JUGADOR / 2, ubicacion.Y - TAMANO_JUGADOR / 2),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderRadius = TAMANO_JUGADOR / 2,
                Cursor = Cursors.Hand,
                Tag = idJugador
            };

          

            // Configurar sombra
            picJugador.ShadowDecoration.BorderRadius = TAMANO_JUGADOR / 2;
            picJugador.ShadowDecoration.Depth = 10;
            picJugador.ShadowDecoration.Enabled = true;
            picJugador.ShadowDecoration.Color = Color.FromArgb(100, 0, 0, 0);

            // Usar tu método para cargar la imagen



            // Si no hay imagen, mostrar dorsal
            if (picJugador.Image == null)
            {
                picJugador.Image = CrearImagenDorsal(dorsal, esLocal ? Color.Blue : Color.Red);
            }

            // Configurar tooltip
            var toolTip = new Guna2HtmlToolTip();
            toolTip.SetToolTip(picJugador, $"<b>{nombreCompleto}</b><br>Posición: {posicion}<br>Dorsal: {dorsal}");
            toolTip.BackColor = Color.White;
            toolTip.ForeColor = Color.Black;

            // Label para el dorsal (opcional)
            var lblDorsal = new Label
            {
                Text = dorsal,
                ForeColor = Color.White,
                BackColor = Color.Black,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(ubicacion.X - 10, ubicacion.Y + TAMANO_JUGADOR / 2 + 5),
                AutoSize = false,
                Size = new Size(30, 20),
                TextAlign = ContentAlignment.MiddleCenter
            };

            pnlCancha.Controls.Add(picJugador);
            pnlCancha.Controls.Add(lblDorsal);
            _controlesJugadores.Add(picJugador);

            // Evento para mostrar detalles
            picJugador.Click += (sender, e) => MostrarDetallesJugador(idJugador);
        }

        private Bitmap CrearImagenDorsal(string dorsal, Color color)
        {
            var bmp = new Bitmap(TAMANO_JUGADOR, TAMANO_JUGADOR);
            using (var g = Graphics.FromImage(bmp))
            {
                // Fondo circular
                g.FillEllipse(new SolidBrush(color), 0, 0, TAMANO_JUGADOR, TAMANO_JUGADOR);

                // Texto del dorsal
                using (var font = new Font("Arial", 16, FontStyle.Bold))
                using (var brush = new SolidBrush(Color.White))
                {
                    var format = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    g.DrawString(dorsal, font, brush,
                        new RectangleF(0, 0, TAMANO_JUGADOR, TAMANO_JUGADOR),
                        format);
                }
            }
            return bmp;
        }

        private Dictionary<string, Point> ObtenerPosicionesParaModo(string modo, bool esLocal)
        {
            var posiciones = new Dictionary<string, Point>();
            int centroX = esLocal ? pnlCancha.Width / 3 : pnlCancha.Width * 2 / 3;
            int centroY = pnlCancha.Height / 2;

            switch (modo.ToUpper())
            {
                case "5V5":
                case "FUTSAL":
                case "BEACH":
                    posiciones.Add("PORTERO_0", new Point(centroX, centroY));
                    posiciones.Add("DEFENSA_0", new Point(centroX + 100, centroY - 80));
                    posiciones.Add("DEFENSA_1", new Point(centroX + 100, centroY + 80));
                    posiciones.Add("DELANTERO_0", new Point(centroX + 200, centroY - 80));
                    posiciones.Add("DELANTERO_1", new Point(centroX + 200, centroY + 80));
                    break;

                case "11V11":
                    posiciones.Add("PORTERO_0", new Point(centroX, centroY));
                    posiciones.Add("DEFENSA_0", new Point(centroX + 80, centroY - 120));
                    posiciones.Add("DEFENSA_1", new Point(centroX + 80, centroY - 60));
                    posiciones.Add("DEFENSA_2", new Point(centroX + 80, centroY));
                    posiciones.Add("DEFENSA_3", new Point(centroX + 80, centroY + 60));
                    posiciones.Add("MEDIO_0", new Point(centroX + 160, centroY - 100));
                    posiciones.Add("MEDIO_1", new Point(centroX + 160, centroY - 30));
                    posiciones.Add("MEDIO_2", new Point(centroX + 160, centroY + 30));
                    posiciones.Add("MEDIO_3", new Point(centroX + 160, centroY + 100));
                    posiciones.Add("DELANTERO_0", new Point(centroX + 240, centroY - 70));
                    posiciones.Add("DELANTERO_1", new Point(centroX + 240, centroY));
                    posiciones.Add("DELANTERO_2", new Point(centroX + 240, centroY + 70));
                    break;
            }

            if (!esLocal)
            {
                var newPositions = new Dictionary<string, Point>();
                foreach (var pos in posiciones)
                {
                    newPositions.Add(pos.Key, new Point(pnlCancha.Width - pos.Value.X, pos.Value.Y));
                }
                return newPositions;
            }

            return posiciones;
        }

        private void MostrarDetallesJugador(string idJugador)
        {
            // Implementa la lógica para mostrar detalles del jugador
            MessageBox.Show($"Detalles del jugador {idJugador}");
        }

        private void LimpiarCancha()
        {
            foreach (var control in _controlesJugadores)
            {
                pnlCancha.Controls.Remove(control);
            }
            _controlesJugadores.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}