using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using TorneosFut.Class;

namespace TorneosFut
{
    public partial class Plantilla : Form
    {
        // Diccionario con todas las formaciones posibles
        private Dictionary<int, List<string>> formacionesPorJugadores = new Dictionary<int, List<string>>()
{
    {5, new List<string>{"3-1", "2-2", "1-2-1", "1-3"}},
    {6, new List<string>{"3-2", "2-3", "1-3-1", "4-1"}},
    {7, new List<string>{"3-3", "2-3-1", "2-2-2", "4-2"}},
    {8, new List<string>{"3-4", "2-4-1", "3-3-1", "4-3"}},
    {9, new List<string>{"3-4-1", "3-3-2", "4-3-1", "4-4", "2-4-2"}},
    {10, new List<string>{"4-4-1", "4-3-2", "3-4-2", "4-2-3", "3-5-1", "5-3-1"}},
    {11, new List<string>{"4-4-2", "4-3-3", "3-5-2", "4-2-3-1", "3-4-3", "5-4-1"}}
};



        csEquipo eq;
        private csDatos _datos;
        private csDGV csDGV;
        private List<Guna2CirclePictureBox> _controlesJugadores = new List<Guna2CirclePictureBox>();
        private const int TAMANO_JUGADOR = 50;
        private int _limit;
        private int _idPartido;
        private string _equipoLocal;
        private string _equipoVisitante;
        private DataTable jugadoresLocal;
        private DataTable jugadoresVisitante;

        public Plantilla(string idPartido, string idTorneo, string usuario, string clave)
        {
            InitializeComponent();
            this.Text = "Alineación del Partido";
            this.BackColor = Color.FromArgb(240, 240, 240);
            eq = new csEquipo(usuario,clave);
            _datos = new csDatos(usuario, clave);
            csDGV = new csDGV(usuario, clave);
            _limit = _datos.LimiteJugador(idTorneo);
            _idPartido = int.Parse(idPartido);

            var equipos = ObtenerEquipos(_idPartido);
            _equipoLocal = equipos.local;
            _equipoVisitante = equipos.visitante;
            InicializarControlesFormacion();
            CargarAlineacion();
        }

        private void InicializarControlesFormacion()
        {
            cmbFormacionLocal.SelectedIndexChanged -= CmbFormacion_SelectedIndexChanged;
            cmbFormacionVisitante.SelectedIndexChanged -= CmbFormacion_SelectedIndexChanged;

            cmbFormacionLocal.SelectedIndexChanged += CmbFormacion_SelectedIndexChanged;
            cmbFormacionVisitante.SelectedIndexChanged += CmbFormacion_SelectedIndexChanged;
        }

        private void CmbFormacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFormacionLocal.Focused)
            {
                bool guardado = eq.GuardarFormacion(_idPartido, _equipoLocal, cmbFormacionLocal.SelectedItem.ToString());
                if (guardado)
                {
                    ActualizarAlineaciones(true);
                }
            }
        }
        private void CargarAlineacion()
        {
            try
            {
                LimpiarCancha();
                jugadoresLocal = ObtenerJugadoresTitulares(_idPartido, _equipoLocal);
                jugadoresVisitante = ObtenerJugadoresTitulares(_idPartido, _equipoVisitante);
                if (jugadoresLocal == null || jugadoresLocal.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron jugadores titulares para el equipo local");
                    return;
                }

                if (jugadoresVisitante == null || jugadoresVisitante.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron jugadores titulares para el equipo visitante");
                    return;
                }
                try
                {
                    MostrarEquipoEnCancha(jugadoresLocal, true);
                }
                catch (Exception exLocal)
                {
                    MessageBox.Show($"Error mostrando equipo local: {exLocal.Message}");
                }

                try
                {
                    MostrarEquipoEnCancha(jugadoresVisitante, false);
                }
                catch (Exception exVisitante)
                {
                    MessageBox.Show($"Error mostrando equipo visitante: {exVisitante.Message}");
                }
            }
            catch (Exception exGeneral)
            {
                MessageBox.Show($"Error cargando alineación: {exGeneral.Message}",
                                "Error crítico",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
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
        private bool _actualizando = false; // Variable de control
        private void ActualizarAlineaciones(bool esLocal)
        {
            if (_actualizando) return;
            _actualizando = true;

            try
            {
                EliminarJugadoresEquipo(esLocal);
                DataTable jugadores = esLocal ? jugadoresLocal : jugadoresVisitante;
                if (jugadores == null || jugadores.Rows.Count == 0) return;
                ComboBox cmb = esLocal ? cmbFormacionLocal : cmbFormacionVisitante;
                string formacion = cmb.SelectedItem?.ToString() ?? "4-4-2";
                Point[] posiciones = CalcularPosicionesMejorado(formacion, esLocal, jugadores.Rows.Count);

                for (int i = 0; i < Math.Min(jugadores.Rows.Count, posiciones.Length); i++)
                {
                    CrearJugadorConPosicion(jugadores.Rows[i], posiciones[i], esLocal);
                }
            }
            finally
            {
                _actualizando = false;
            }
        }
        private void MostrarEquipoEnCancha(DataTable jugadores, bool esLocal)
        {
            if (pnlCancha == null || jugadores == null) return;

            try
            {
                // 1. Obtener ComboBox correspondiente
                ComboBox cmbFormacion = esLocal ? cmbFormacionLocal : cmbFormacionVisitante;

                // 2. Actualizar opciones de formación (con verificación)
                if (cmbFormacion != null)
                {
                    cmbFormacion.BeginUpdate();
                    try
                    {
                        ActualizarOpcionesFormacion(cmbFormacion, _limit);
                    }
                    finally
                    {
                        cmbFormacion.EndUpdate();
                    }
                }

                // 3. Calcular posiciones
                string formacion = cmbFormacion?.SelectedItem?.ToString() ?? "4-4-2";
                Point[] posiciones = CalcularPosicionesMejorado(formacion, esLocal, jugadores.Rows.Count);

                // 4. Crear jugadores (con verificación de posición)
                for (int i = 0; i < Math.Min(jugadores.Rows.Count, posiciones.Length); i++)
                {
                    DataRow jugador = jugadores.Rows[i];
                    Point posicion = posiciones[i];

                    // Verificar posición válida
                    if (posicion.X < 0 || posicion.Y < 0 ||
                        posicion.X > pnlCancha.Width || posicion.Y > pnlCancha.Height)
                    {
                        posicion = new Point(pnlCancha.Width / 2, pnlCancha.Height / 2);
                    }

                    CrearJugadorGuna2(
                        jugador["IDJugador"].ToString(),
                        jugador["NombreCompleto"].ToString(),
                        jugador["Dorsal"].ToString(),
                        posicion,
                        esLocal
                    );
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error en MostrarEquipoEnCancha: {ex.Message}");
                throw;
            }
        }
        private bool ValidarFormacion(string formacion, int cantidadJugadoresCampo)
        {
            string[] lineas = formacion.Split('-');
            int total = 0;

            foreach (string linea in lineas)
            {
                total += int.Parse(linea);
            }

            return total == cantidadJugadoresCampo;
        }
        private void EliminarJugadoresEquipo(bool esLocal)
        {
            var controlesAEliminar = new List<Guna2CirclePictureBox>();

            foreach (var control in _controlesJugadores)
            {
                try
                {
                    if (control?.Tag == null) continue;

                    dynamic tag = control.Tag;
                    if (tag.EsLocal == esLocal)
                    {
                        controlesAEliminar.Add(control);
                    }
                }
                catch
                {
                    // Si hay error, igualmente eliminar el control
                    controlesAEliminar.Add(control);
                }
            }

            foreach (var control in controlesAEliminar)
            {
                try
                {
                    pnlCancha.Controls.Remove(control);
                    control.Dispose();
                    _controlesJugadores.Remove(control);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error eliminando jugador: {ex.Message}");
                }
            }

            // Limpieza adicional
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void ConfigurarEventosCombobox()
        {
            // Limpiar eventos previos
            cmbFormacionLocal.SelectedIndexChanged -= CmbFormacion_SelectedIndexChanged;
            cmbFormacionVisitante.SelectedIndexChanged -= CmbFormacion_SelectedIndexChanged;

            // Asignar nuevos eventos
            cmbFormacionLocal.SelectedIndexChanged += CmbFormacion_SelectedIndexChanged;
            cmbFormacionVisitante.SelectedIndexChanged += CmbFormacion_SelectedIndexChanged;
        }
        private void ActualizarOpcionesFormacion(ComboBox cmb, int cantidadJugadores)
        {
            if (cmb == null) return;

            // Guardar selección actual antes de actualizar
            string seleccionPrevia = cmb.SelectedItem?.ToString();

            try
            {
                cmb.BeginUpdate();
                cmb.Items.Clear();

                int jugadoresAjustados = Math.Max(5, Math.Min(11, cantidadJugadores));

                if (formacionesPorJugadores.TryGetValue(jugadoresAjustados, out List<string> formaciones))
                {
                    formaciones = formaciones.OrderBy(f => f.Count(c => c == '-')).ToList();

                    foreach (string formacion in formaciones)
                    {
                        cmb.Items.Add(formacion);
                    }

                    // Restaurar selección previa si existe en las nuevas opciones
                    if (!string.IsNullOrEmpty(seleccionPrevia) && cmb.Items.Contains(seleccionPrevia))
                    {
                        cmb.SelectedItem = seleccionPrevia;
                    }
                    else
                    {
                        // Lógica de selección por defecto solo si no hay selección previa
                        if (cmb.Items.Count > 0)
                        {
                            string defaultFormation;
                            switch (jugadoresAjustados)
                            {
                                case 5: defaultFormation = "2-2-1"; break;
                                case 6: defaultFormation = "3-2-1"; break;
                                case 7: defaultFormation = "3-3-1"; break;
                                case 8: defaultFormation = "3-4-1"; break;
                                case 9: defaultFormation = "3-4-2"; break;
                                case 10:
                                case 11: defaultFormation = "4-4-2"; break;
                                default: defaultFormation = formaciones.First(); break;
                            }
                            int index = cmb.Items.IndexOf(defaultFormation);
                            cmb.SelectedIndex = index >= 0 ? index : 0;
                        }
                    }
                }
                else
                {
                    string formacionDefault = cantidadJugadores <= 5 ? "2-2-1" : "4-4-2";
                    cmb.Items.Add(formacionDefault);
                    cmb.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al actualizar opciones: {ex.Message}");
                cmb.Items.Add("4-4-2");
                cmb.SelectedIndex = 0;
            }
            finally
            {
                cmb.EndUpdate();
            }
        }
        private void CrearJugadorConPosicion(DataRow jugador, Point posicion, bool esLocal)
        {
            if (jugador == null || pnlCancha == null) return;

            try
            {
                string id = jugador["IDJugador"]?.ToString() ?? "0";
                string nombre = jugador["NombreCompleto"]?.ToString() ?? "Jugador";
                string dorsal = jugador["Dorsal"]?.ToString() ?? "0";
                var picJugador = new Guna2CirclePictureBox
                {
                    Size = new Size(TAMANO_JUGADOR, TAMANO_JUGADOR),
                    Location = new Point(
                        Math.Max(0, Math.Min(pnlCancha.Width - TAMANO_JUGADOR, posicion.X - TAMANO_JUGADOR / 2)),
                        Math.Max(0, Math.Min(pnlCancha.Height - TAMANO_JUGADOR, posicion.Y - TAMANO_JUGADOR / 2))),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    FillColor = esLocal ? Color.Blue : Color.Red,
                    BackColor = Color.Transparent,

                    Tag = new
                    {
                        ID = id,
                        Nombre = nombre,
                        Dorsal = dorsal,
                        EsLocal = esLocal
                    },
                    Cursor = Cursors.Hand
                };
                var bmp = new Bitmap(TAMANO_JUGADOR, TAMANO_JUGADOR);
                using (var g = Graphics.FromImage(bmp))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.Clear(picJugador.FillColor);
                    using (var font = new Font("Arial", 12, FontStyle.Bold))
                    {
                        var format = new StringFormat
                        {
                            Alignment = StringAlignment.Center,
                            LineAlignment = StringAlignment.Center
                        };
                        g.DrawString(dorsal, font, Brushes.Black,
                                    new RectangleF(1, 1, TAMANO_JUGADOR, TAMANO_JUGADOR), format);
                        g.DrawString(dorsal, font, Brushes.White,
                                    new RectangleF(0, 0, TAMANO_JUGADOR, TAMANO_JUGADOR), format);
                    }
                }
                picJugador.Image = bmp;
                var toolTip = new Guna2HtmlToolTip
                {
                    BackColor = Color.White,
                    ForeColor = Color.Black,
                    BorderColor = Color.Gray,
                    AutoPopDelay = 5000, // 5 segundos visible
                    InitialDelay = 300,   // 300ms para aparecer
                    ReshowDelay = 100     // 100ms para reaparecer
                };

                toolTip.SetToolTip(picJugador,
                    $"<b>{nombre}</b><br>" +
                    $"Dorsal: {dorsal}");


                // Evento de clic
                picJugador.Click += (s, e) => MostrarDetallesJugador(picJugador.Tag);

                // Agregar al panel y a la lista de controles
                pnlCancha.Controls.Add(picJugador);
                _controlesJugadores.Add(picJugador);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al crear jugador: {ex.Message}");
                // Opcional: Mostrar algún indicador de error
            }
        }
        private Point[] CalcularPosicionesMejorado(string formacion, bool esLocal, int totalJugadores)
        {
            List<Point> posiciones = new List<Point>();
            int anchoCancha = pnlCancha.Width;
            int altoCancha = pnlCancha.Height;

            // Margenes ajustables según el tamaño de la cancha
            int margenHorizontal = (int)(anchoCancha * 0.1); // 10% del ancho
            int margenVertical = (int)(altoCancha * 0.1);    // 10% del alto
            int espacioEntreFilas = (int)(altoCancha * 0.15); // 15% del alto

            // Posición del portero (centrado en su área)
            int yPortero = esLocal ? margenVertical : altoCancha - margenVertical;
            posiciones.Add(new Point(anchoCancha / 2, yPortero));

            if (totalJugadores <= 1) return posiciones.ToArray();

            // Procesar la formación (ej: "3-4-2")
            string[] lineas = formacion.Split('-');
            int filaActual = 1;

            foreach (string linea in lineas)
            {
                int jugadoresEnFila = int.Parse(linea);
                int yBase = esLocal ?
                    margenVertical + (filaActual * espacioEntreFilas) :
                    altoCancha - margenVertical - (filaActual * espacioEntreFilas);

                // Distribución horizontal con espaciado proporcional
                int espacioX = (anchoCancha - (2 * margenHorizontal)) / (jugadoresEnFila + 1);

                for (int i = 0; i < jugadoresEnFila; i++)
                {
                    // Posición base + variación aleatoria controlada
                    int x = margenHorizontal + ((i + 1) * espacioX);
                    int y = yBase;

                    // Pequeña variación aleatoria (opcional)
                    if (jugadoresEnFila > 1) // Solo si hay más de 1 jugador en la fila
                    {
                        Random rnd = new Random(Guid.NewGuid().GetHashCode());
                        x += rnd.Next(-(espacioX / 4), espacioX / 4);
                        y += rnd.Next(-(espacioEntreFilas / 6), espacioEntreFilas / 6);
                    }

                    // Asegurar que no salgan de los márgenes
                    x = Math.Max(margenHorizontal, Math.Min(anchoCancha - margenHorizontal, x));
                    y = Math.Max(margenVertical, Math.Min(altoCancha - margenVertical, y));

                    posiciones.Add(new Point(x, y));
                }

                filaActual++;
            }

            return posiciones.ToArray();
        }
        private void ActualizarAlineacioness(bool esLocal)
        {
            var jugadoresAEliminar = ObtenerJugadoresPorEquipo(esLocal);

            foreach (var jugador in jugadoresAEliminar)
            {
                try
                {
                    pnlCancha.Controls.Remove(jugador);
                    jugador.Dispose();
                    _controlesJugadores.Remove(jugador);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error al eliminar jugador: {ex.Message}");
                }
            }

            // Volver a cargar el equipo con la nueva formación
            DataTable jugadores = esLocal ? jugadoresLocal : jugadoresVisitante;
            if (jugadores != null)
            {
                MostrarEquipoEnCancha(jugadores, esLocal);
            }
        }
        private List<Guna2CirclePictureBox> ObtenerJugadoresPorEquipo(bool esLocal)
        {
            var jugadores = new List<Guna2CirclePictureBox>();

            foreach (var control in _controlesJugadores)
            {
                try
                {
                    if (control?.Tag == null) continue;

                    dynamic tag = control.Tag;
                    bool? esLocalControl = tag.EsLocal;

                    if (esLocalControl.HasValue && esLocalControl.Value == esLocal)
                    {
                        jugadores.Add(control);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error al verificar jugador: {ex.Message}");
                    continue;
                }
            }

            return jugadores;
        }
        private void CrearJugadorGuna2(string idJugador, string nombre, string dorsal, Point ubicacion, bool esLocal)
        {
            var picJugador = new Guna2CirclePictureBox
            {
                Size = new Size(TAMANO_JUGADOR, TAMANO_JUGADOR),
                Location = new Point(ubicacion.X - TAMANO_JUGADOR / 2, ubicacion.Y - TAMANO_JUGADOR / 2),
                SizeMode = PictureBoxSizeMode.Zoom,
                FillColor = esLocal ? Color.Blue : Color.Red,
                BackColor = Color.Transparent,
                Tag = new { ID = idJugador, Nombre = nombre, Dorsal = dorsal, EsLocal = esLocal },
                Cursor = Cursors.Hand
            };
            var bmp = new Bitmap(TAMANO_JUGADOR, TAMANO_JUGADOR);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(picJugador.FillColor);
                // Sombra
                using (var font = new Font("Arial", 12, FontStyle.Bold))
                using (var brush = new SolidBrush(Color.Black))
                {
                    StringFormat format = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    g.DrawString(dorsal, font, brush, new RectangleF(1, 1, TAMANO_JUGADOR, TAMANO_JUGADOR), format);
                }

                // Texto
                using (var font = new Font("Arial", 12, FontStyle.Bold))
                using (var brush = new SolidBrush(Color.White))
                {
                    StringFormat format = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    g.DrawString(dorsal, font, brush, new RectangleF(0, 0, TAMANO_JUGADOR, TAMANO_JUGADOR), format);
                }
            }
            picJugador.Image = bmp;
            // Tooltip
            var toolTip = new Guna2HtmlToolTip();
            toolTip.BackColor = Color.White;
            toolTip.ForeColor = Color.Black;
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
            if (pnlCancha == null) return;

            try
            {
                pnlCancha.SuspendLayout();

                foreach (var control in _controlesJugadores.ToList()) // Usar ToList para copia
                {
                    try
                    {
                        if (control != null)
                        {
                            pnlCancha.Controls.Remove(control);
                            control.Dispose();
                        }
                    }
                    catch { /* Ignorar errores de disposición */ }
                }

                _controlesJugadores.Clear();
            }
            finally
            {
                pnlCancha.ResumeLayout();
                GC.Collect(); // Solo en casos necesarios
            }
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
        private void CargarFormacionesGuardadas()
        {
            string formacionLocal = eq.CargarFormacion(_idPartido, _equipoLocal);
            string formacionVisitante = eq.CargarFormacion(_idPartido, _equipoVisitante);

            // Aplicar las formaciones a los ComboBox
            if (cmbFormacionLocal.Items.Contains(formacionLocal))
                cmbFormacionLocal.SelectedItem = formacionLocal;

            if (cmbFormacionVisitante.Items.Contains(formacionVisitante))
                cmbFormacionVisitante.SelectedItem = formacionVisitante;
        }
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        private void Plantilla_Load(object sender, EventArgs e)
        {
            CargarAlineacion();
            CargarFormacionesGuardadas();
        }
    }
}

















