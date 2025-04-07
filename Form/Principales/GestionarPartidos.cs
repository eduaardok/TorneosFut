using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneosFut;
using TorneosFut.Class;

namespace pruebas
{
    public partial class btnTablaPos : Form
    {
        csConexion conexion;
        Goles gol;
        Plantilla plan;
        string IDPartido;
        csDGV csDGV;
        csDatos csDatos;
        string IdTorneo;
        AgregarTitulares agregarTitulares;
        

        public btnTablaPos(string IDtorneo,string u, string c)
        {
            conexion = new csConexion(u, c);
            csDatos = new csDatos(u, c);
            IdTorneo = IDtorneo;
            csDGV = new csDGV(u,c, IdTorneo, IDPartido);
            InitializeComponent();
        }

        private void txtBuscador_KeyUp(object sender, KeyEventArgs e)
        {
            /*string filtro = txtBuscarPartido.Text.Trim().ToString();
            if (string.IsNullOrWhiteSpace(filtro))
            {
                dgvPartido.DataSource = conexion.ListDGV("select * from Partido");
            }
            else
            {
                string consulta = $"select * from Partido where " +
                    $"EquipoLocal like '%{filtro}%' or EquipoVisitante like '%{filtro}%' or Jornada like '%{filtro}%'";

                DataTable dt = conexion.ListDGV(consulta);
                dgvPartido.DataSource = dt;
            }*/
        }
        public static void AbrirFormEnPanel(Panel panel, Form formHijo)
        {
            if (panel.Controls.Count > 0)
                panel.Controls.Clear(); // Limpia cualquier contenido previo

            formHijo.TopLevel = false;  // Indica que no es un formulario independiente
            formHijo.Dock = DockStyle.Fill; // Ajusta al tamaño del panel
            panel.Controls.Add(formHijo); // Agrega el formulario al panel
            panel.Tag = formHijo; // Asocia el formulario con el panel
            formHijo.BringToFront(); // Lo trae al frente
            formHijo.Show(); // Muestra el formulario dentro del panel
        }
        private void dgvJugador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void verjugadores_Load(object sender, EventArgs e)
        {

            c.Tag = "NoCambiar";
            panel1.Tag = "NoCambiar";
            panel3.Tag = "NoCambiar";
            panel4.Tag = "NoCambiar";
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            csDGV.MostrarPartidos(dgvPartido, IdTorneo);
            csDGV.AdaptarDGV(dgvPartido);
            //dgvPartido.Columns["IDPartido"].Visible = false;
           // dgvPartido.Columns["IDTorneo"].Visible = false;
            dgvPartido.ColumnHeaderMouseClick += dgvPartido_ColumnHeaderMouseClick;
            foreach (DataGridViewColumn column in dgvPartido.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        void ActualizarTabla()
        {
            if (txtBuscarPartido.Text == "Buscar por nombre de Equipo")
                txtBuscarPartido.Text = "";
            csDGV.MostrarPartidosFiltro(dgvPartido,txtBuscarPartido.Text, IdTorneo);
            csDGV.AdaptarDGV(dgvPartido, pnlDgvPartido);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void btnGol_Click(object sender, EventArgs e)
        {
            //csDGV = null;
            //csDGV = new csDGV(conexion.Usuario, conexion.Clave, IdTorneo, IDPartido);
            if (dgvPartido.CurrentRow != null && dgvPartido.CurrentRow.Index >= 0)
            {
                if (dgvPartido.Rows[dgvPartido.CurrentRow.Index].Cells["EstadoPartido"].Value.ToString() == "FINALIZADO")
                {
                    MessageBox.Show("El partido ya finalizó");
                }
                else
                {
                    gol = new Goles(conexion.Usuario, conexion.Clave, IDPartido);
                    gol.ShowDialog();
                }
            }
            ActualizarTabla();
        }

        private void dgvPartido_SelectionChanged(object sender, EventArgs e)
        {
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Verifica si el botón izquierdo del mouse está presionado
            {
                // Mueve el formulario a la nueva posición
                this.Location = new Point(
                    this.Location.X + e.X - (c.Width / 2),
                    this.Location.Y + e.Y - (c.Height / 2));
            }
        }

        private int ObtenerCantidadGrupos(string idTorneo)
        {
            DataTable dt = conexion.ListDGV($"SELECT F.CantidadGrupos FROM Formato F INNER JOIN Torneo T ON F.IDFormato = T.IDFormato WHERE T.IDTorneo = {idTorneo}");
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["CantidadGrupos"]);
            }
            return 1; // Valor por defecto si no se encuentra el formato
        }

        private void btnGenerarPartidos_Click(object sender, EventArgs e)
        {
            DataGridView dgvPartidos = new DataGridView();
            dgvPartidos.Columns.Add("Jornada", "Jornada");
            dgvPartidos.Columns.Add("EquipoLocal", "EquipoLocal");
            dgvPartidos.Columns.Add("EquipoVisitante", "EquipoVisitante");
            dgvPartidos.Columns.Add("Grupo", "Grupo");
            int cantidadgrupos = ObtenerCantidadGrupos(IdTorneo);
            if (csDatos.ObtenerCantidadPartidosGenerados(IdTorneo) == 0)
            {
                conexion.Consulta($"exec GenerarGrupos {IdTorneo}");
                DataTable dt = conexion.ListDGV($"select IDGrupo from Grupo where IDTorneo = {IdTorneo}");
                // List<string> equipos = csDatos.ObtenerListaEquiposTorneo(IdTorneo);
                for (int i = 0; i < cantidadgrupos; i++)
                {
                    string idgrupo = dt.Rows[i][0].ToString();
                    List<string> grupoEquipo = csDatos.ObtenerListaEquiposGrupoTorneo(idgrupo);
                    GenerarFixture(grupoEquipo, i + 1);
                }




                if (EsIdaVuelta(IdTorneo) == 1) // función que devuelve 1 o 0
                {
                    GenerarPartidosVuelta(IdTorneo);
                }

                // GenerarFixture(equipos);
                /* for (int i = 0; i < dgvPartidos.Rows.Count - 1; i++)
                 {
                     if (!conexion.Consulta($"insert into Partido (IDTorneo, IDEstadio, Jornada, EquipoLocal, EquipoVisitante, EstadoPartido) " +
                          $"values ({IdTorneo},1, {dgvPartidos.Rows[i].Cells["Jornada"].Value}, '{dgvPartidos.Rows[i].Cells["EquipoLocal"].Value}'," +
                          $"'{dgvPartidos.Rows[i].Cells["EquipoVisitante"].Value}', 'PROGRAMADO')"))
                         return;
                 }*/
                MessageBox.Show("Partidos generados correctamente");
                if (conexion.Consulta($"exec spAsignarFechasPartidos {IdTorneo}"))
                {
                    MessageBox.Show("Fechas asignadas correctamente");
                }
                else
                {
                    MessageBox.Show("Error al asignar fechas");
                }
                conexion.Consulta($"exec spAsignarEstadioPartidos {IdTorneo}");

                ActualizarTabla();
            }

        }


        void GenerarFixture(List<string> equipos, int grupo)
        {
            DataGridView dgvPartidos = new DataGridView();
            dgvPartidos.Columns.Add("Jornada", "Jornada");
            dgvPartidos.Columns.Add("EquipoLocal", "EquipoLocal");
            dgvPartidos.Columns.Add("EquipoVisitante", "EquipoVisitante");

            int numJornadas = equipos.Count - 1;
            int partido = 0;

            // Crear un patrón para alternar local y visitante
            List<bool> alternarLocalidad = new List<bool>();

            // Generamos el patrón de local/visitante para todas las jornadas
            for (int i = 0; i < numJornadas; i++)
            {
                // Alternamos el rol entre Local y Visitante
                for (int j = 0; j < equipos.Count / 2; j++)
                {
                    alternarLocalidad.Add(j % 2 == 0); // Los partidos alternan entre local (true) y visitante (false)
                }
            }

            // Crear partidos jornada por jornada
            for (int jornada = 1; jornada <= numJornadas; jornada++)
            {
                // Generar partidos (simplificado)
                for (int i = 0; i < equipos.Count / 2; i++)
                {
                    dgvPartidos.Rows.Add();
                    string equipoLocal, equipoVisitante;

                    // Dependiendo de si es Local o Visitante en la jornada, asignamos los equipos
                    if (alternarLocalidad[partido])
                    {
                        equipoLocal = equipos[i];
                        equipoVisitante = equipos[equipos.Count - 1 - i];
                    }
                    else
                    {
                        equipoLocal = equipos[equipos.Count - 1 - i];
                        equipoVisitante = equipos[i];
                    }

                    // Asignar valores a las celdas del DataGridView
                    dgvPartidos.Rows[partido].Cells["Jornada"].Value = jornada.ToString();
                    dgvPartidos.Rows[partido].Cells["EquipoLocal"].Value = equipoLocal;
                    dgvPartidos.Rows[partido].Cells["EquipoVisitante"].Value = equipoVisitante;

                    partido++;
                }
                // Rotar equipos para la siguiente jornada después de haber generado los partidos
                equipos = RotarEquipos(equipos);
            }
            for (int i = 0; i < dgvPartidos.Rows.Count - 1; i++)
            {
                if (!conexion.Consulta($"insert into Partido (IDTorneo, IDEstadio, Jornada, EquipoLocal, EquipoVisitante, EstadoPartido, Grupo) " +
                     $"values ({IdTorneo},1, {dgvPartidos.Rows[i].Cells["Jornada"].Value}, '{dgvPartidos.Rows[i].Cells["EquipoLocal"].Value}'," +
                     $"'{dgvPartidos.Rows[i].Cells["EquipoVisitante"].Value}', 'PROGRAMADO', {grupo})"))
                    return;

            }
            // MessageBox.Show("Partidos generados correctamente");
        }


        List<string> RotarEquipos(List<string> equipos)
        {
            if (equipos.Count < 2)
                return equipos; // Sin rotación si hay menos de 2 equipos
                                // Fijar el primer equipo y rotar el resto
            string equipoFijo = equipos[0]; // Fijar el primer equipo
            List<string> resto = equipos.GetRange(1, equipos.Count - 1); // Tomar los demás
            string ultimo = resto[resto.Count - 1]; // Guardar el último
            resto.RemoveAt(resto.Count - 1); // Quitar el último
            resto.Insert(0, ultimo); // Insertarlo al inicio

            List<string> resultado = new List<string> { equipoFijo }; // Iniciar con el fijo
            resultado.AddRange(resto); // Agregar los rotados
            return resultado;
        }


        void GenerarPartidosVuelta(string idTorneo)
        {
            // Obtener el número total de jornadas de ida
            DataTable dtMaxJornada = conexion.ListDGV($"SELECT MAX(Jornada) AS MaxJornada FROM Partido WHERE IDTorneo = {idTorneo}");
            int jornadasIda = dtMaxJornada.Rows[0]["MaxJornada"] != DBNull.Value ? Convert.ToInt32(dtMaxJornada.Rows[0]["MaxJornada"]) : 0;

            // Obtener todos los partidos de ida
            DataTable partidosIda = conexion.ListDGV($"SELECT Jornada, EquipoLocal, EquipoVisitante, Grupo FROM Partido WHERE IDTorneo = {idTorneo} ORDER BY Jornada");

            foreach (DataRow row in partidosIda.Rows)
            {
                int jornadaOriginal = Convert.ToInt32(row["Jornada"]);
                int jornadaVuelta = jornadaOriginal + jornadasIda; // Jornada de vuelta

                string equipoLocal = row["EquipoVisitante"].ToString(); // Invertido
                string equipoVisitante = row["EquipoLocal"].ToString();
                string grupo = row["Grupo"].ToString();

                // Insertar partido de vuelta
                conexion.Consulta($" INSERT INTO Partido (IDTorneo, IDEstadio, Jornada, EquipoLocal, EquipoVisitante, EstadoPartido, Grupo)"+
                 $" VALUES ({idTorneo}, 1, {jornadaVuelta}, '{equipoLocal}', '{equipoVisitante}', 'PROGRAMADO', {grupo})");
            }
        }


        int EsIdaVuelta(string idT)
        {
            DataTable dt = conexion.ListDGV($"select F.IdaVueltaGrupos from Torneo T inner join Formato F on T.IDFormato = F.IDFormato where T.IDTorneo =  {idT}");
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["IdaVueltaGrupos"]);
            }
            return 0;
        }

        private void txtBuscarPartido_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarPartido.Text == "Buscar por nombre de Equipo")
                txtBuscarPartido.Text = "";
            ActualizarTabla();
        }

        private void txtBuscarPartido_Click(object sender, EventArgs e)
        {
            if (txtBuscarPartido.Text == "Buscar por nombre de Equipo")
                txtBuscarPartido.Text = "";
        }

        private void btnEstadoPartido_Click(object sender, EventArgs e)
        {
            if(dgvPartido.Rows.Count>0)
            {
                // Confirmación antes de ejecutar el procedimiento
                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de que desea finalizar este partido? No podrá volver a editarlo.",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        // Ejecutar el procedimiento almacenado
                        conexion.Consulta($"EXEC spFinalizarPartido @IDPartido = {IDPartido}");

                        // Mostrar mensaje de éxito
                        MessageBox.Show(
                            "El partido ha sido finalizado correctamente.",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores
                        MessageBox.Show(
                            "Error al finalizar el partido: " + ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
            ActualizarTabla();
        }

        private void dgvPartido_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvPartido.CurrentRow != null && dgvPartido.CurrentRow.Index >= 0)
            {
                IDPartido = dgvPartido.Rows[dgvPartido.CurrentRow.Index].Cells["IDPartido"].Value.ToString();
               // MessageBox.Show(IDPartido);
            }
        }

        private void dgvPartido_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (dgvPartido.CurrentRow != null && dgvPartido.CurrentRow.Index >= 0)
            {
                plan = new Plantilla(IDPartido, IdTorneo,conexion.Usuario, conexion.Clave);
                plan.ShowDialog();
            }
            ActualizarTabla();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (dgvPartido.CurrentRow != null && dgvPartido.CurrentRow.Index >= 0)
            {
                string estadoPartido = dgvPartido.CurrentRow.Cells["EstadoPartido"].Value?.ToString() ?? "";
                if (estadoPartido.ToUpper() == "FINALIZADO")
                {
                    MessageBox.Show("No se pueden modificar los titulares de un partido finalizado",
                                  "Partido Finalizado",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                }
                else
                {
                    agregarTitulares = new AgregarTitulares(IDPartido, IdTorneo, conexion.Usuario, conexion.Clave);
                    agregarTitulares.ShowDialog();
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAmonestaciones_Click(object sender, EventArgs e)
        {

        }

        private void btnAsignarFechas_Click(object sender, EventArgs e)
        {
            if (conexion.Consulta($"exec spAsignarFechasPartidos {IdTorneo}"))
            {
                MessageBox.Show("Fechas asignadas correctamente");
            }
            else
            {
                MessageBox.Show("Error al asignar fechas");
            }
            ActualizarTabla();
        }

        private void btnTabla_Click(object sender, EventArgs e)
        {
            TablaDePosiciones tbl = new TablaDePosiciones(conexion.Usuario, conexion.Clave, IdTorneo);
            tbl.ShowDialog();
        }

        private void btnPosiciones_Click(object sender, EventArgs e)
        {
            frmTablaP tabla = new frmTablaP(IdTorneo);
            tabla.Show(); 
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            DataTable dt = conexion.ListDGV($"SELECT EquipoLocal FROM Partido WHERE IDPartido = {IDPartido}");
            frmCalendarioEE calendario = new frmCalendarioEE(IdTorneo, dt.Rows[0]["EquipoLocal"].ToString());
            calendario.ShowDialog();
        }
    }
}