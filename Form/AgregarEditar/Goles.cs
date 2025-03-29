using Guna.UI2.AnimatorNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneosFut;
using TorneosFut.Class;

namespace pruebas
{
    public partial class Goles: Form
    {
        //int IDPartido;
        //int IDJugador;
        csConexion conexion ;
        GestionarPartidos f;
        static string Id;
        csDGV csDGV;
        csPartido csPartido; 
        private DataGridView dgvSeleccionado;

        public Goles(string u, string c, string ID)
        {
            conexion = new csConexion(u, c);
            Id = ID;
            csDGV= new csDGV(u,c);
            InitializeComponent(); 

        }
        private void editarjugador_Load(object sender, EventArgs e)
        {
            dgvjugadoresLocales.DataSource = conexion.ListDGV($"select J.IDJugador, JE.IDEquipo  from Jugador_Equipo JE inner join " +
                $"Jugador J on JE.IDJugador = J.IDJugador inner join Partido P on P.EquipoLocal = JE.IDEquipo" +
                $" where JE.IDEquipo = P.EquipoLocal and JE.FechaSalida is null and P.IDPartido = {Id}");
            dgvjugadoresVisitantes.DataSource = conexion.ListDGV($"select J.IDJugador, JE.IDEquipo  from Jugador_Equipo JE inner join " +
                $"Jugador J on JE.IDJugador = J.IDJugador inner join Partido P on P.EquipoVisitante = JE.IDEquipo" +
                $" where JE.IDEquipo = P.EquipoVisitante and JE.FechaSalida is null and P.IDPartido = {Id}");

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {

            //if (txtaltura.Text != "" && txtapellido.Text != "" && CmbPosicion.Text != "" && Cmbequipo.Text != "" && txtpeso.Text != "" && txtaltura.Text != "")
            //{
            //    if (!valinombres(Txtnombre) && !valinombres(txtapellido))
            //    {
            //        if (!validaaltu(txtaltura) && !validaaltu(txtpeso))
            //        {
            //            conexion.Consulta($"UPDATE Jugador set Nombres='{Txtnombre.Text}', Apellidos='{txtapellido.Text}'" +
            //                $",Posicion='{CmbPosicion.Text}', EquipoActual={int.Parse(Cmbequipo.SelectedValue.ToString())}, Peso={decimal.Parse(txtpeso.Text)}, Altura= {decimal.Parse(txtaltura.Text)}  where IDJugador={ID}");
            //            txtaltura.Clear();
            //            txtapellido.Clear();
            //            txtpeso.Clear();
            //            Txtnombre.Clear();
            //            Cmbequipo.SelectedIndex = -1;
            //            CmbPosicion.SelectedIndex = -1;
            //            MessageBox.Show("Jugador editado con exito");
            //            f.dgvJugador.DataSource = conexion.ListDGV("Select* from Jugador");
            //            Close();
            //        }
            //        else MessageBox.Show("altura invalida");
            //    }
            //    else MessageBox.Show("Nombre invalido, solo se permite letras");
            //}
        }
        bool validaaltu(TextBox txt)
        {
            for (int i = 1; i < txt.Text.Length; i++)
            {
                for (int j = 46; j < 58; j++)
                {
                    if (txt.Text[i] != j)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        bool valinombres(TextBox txt)
        {
            for (int i = 1; i < txt.Text.Length; i++)
            {
                for (int j = 97; j < 123; j++)
                {
                    if (txt.Text[i] != j)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void CmbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
          
           
        }

        private void btngCancelar_Click(object sender, EventArgs e)
        {
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvjugadoresLocales_SelectionChanged(object sender, EventArgs e)
        {
            dgvSeleccionado = dgvjugadoresLocales;

        }

        private void dgvjugadoresVisitantes_SelectionChanged(object sender, EventArgs e)
        {
            dgvSeleccionado = dgvjugadoresVisitantes;

        }

        private void btngGol_Click(object sender, EventArgs e)
        {
            if (dgvSeleccionado != null && dgvSeleccionado.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvSeleccionado.SelectedRows[0];

                // Ejemplo: Agregar jugador y equipo a la tabla de abajo
                string idJugador = filaSeleccionada.Cells["IDJugador"].Value.ToString();
                string idEquipo = filaSeleccionada.Cells["IDEquipo"].Value.ToString();

                // Aquí decides en qué tabla agregarlo (puedes tener un dgvEventos)
                dgvgoles.Rows.Add(idJugador, idEquipo, (Convert.ToInt32(numEquipos.Value)).ToString());
            }
        }

        private void btnQuitarAsistencia_Click(object sender, EventArgs e)
        {
            EliminarFilaSeleccionada(dgvasistencia);
        }

        private void btnQuitarGol_Click(object sender, EventArgs e)
        {
            EliminarFilaSeleccionada(dgvgoles);
        }

        private void btngAsistencia_Click(object sender, EventArgs e)
        {
            if (dgvSeleccionado != null && dgvSeleccionado.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvSeleccionado.SelectedRows[0];

                // Ejemplo: Agregar jugador y equipo a la tabla de abajo
                string idJugador = filaSeleccionada.Cells["IDJugador"].Value.ToString();
                string idEquipo = filaSeleccionada.Cells["IDEquipo"].Value.ToString();

                // Aquí decides en qué tabla agregarlo (puedes tener un dgvEventos)
                dgvasistencia.Rows.Add(idJugador, idEquipo, (Convert.ToInt32(numEquipos.Value)).ToString());
            }
        }
        private void EliminarFilaSeleccionada(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0) // Verifica si hay una fila seleccionada
            {
                int rowIndex = dgv.SelectedRows[0].Index;

                if (!dgv.Rows[rowIndex].IsNewRow) // Evita eliminar una fila nueva vacía
                {
                    dgv.Rows.RemoveAt(rowIndex);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            using (conexion.Conexion)
            {
                try
                {
                    conexion.Conexion.Open();

                    SqlTransaction transaccion = conexion.Conexion.BeginTransaction();

                    try
                    {
                        // Guardar Goles
                        foreach (DataGridViewRow row in dgvgoles.Rows)
                        {
                            if (row.Cells["IDJugador"].Value != null) // Verifica que la fila tenga datos
                            {
                                using (SqlCommand cmd = new SqlCommand("spInsertarGol", conexion.Conexion, transaccion))
                                {
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@IDPartido", int.Parse(Id));
                                    cmd.Parameters.AddWithValue("@IDJugador", (row.Cells["IDJugador"].Value));
                                    cmd.Parameters.AddWithValue("@IDEquipo",(row.Cells["IDEquipo"].Value));
                                    cmd.Parameters.AddWithValue("@Minuto", Convert.ToInt32(row.Cells["Minuto"].Value));

                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        // Guardar Asistencias
                        foreach (DataGridViewRow row in dgvasistencia.Rows)
                        {
                            if (row.Cells["IDJugador"].Value != null) // Verifica que la fila tenga datos
                            {
                                using (SqlCommand cmd = new SqlCommand("spInsertarAsistencia", conexion.Conexion, transaccion))
                                {
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@IDPartido", int.Parse(Id));
                                    cmd.Parameters.AddWithValue("@IDJugador", (row.Cells["IDJugador"].Value));
                                    cmd.Parameters.AddWithValue("@IDEquipo", (row.Cells["IDEquipo"].Value));
                                    cmd.Parameters.AddWithValue("@Minuto", Convert.ToInt32(row.Cells["Minuto"].Value));

                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        // Si todo salió bien, se confirma la transacción
                        transaccion.Commit();
                        MessageBox.Show("Datos guardados correctamente.");
                        conexion.Conexion.Close();
                        Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error de SQL Server: " + ex.Message);
                        conexion.Conexion.Close();
                    }
                    catch (Exception ex)
                    {
                        transaccion.Rollback();
                        MessageBox.Show("Error al guardar datos: " + ex.Message);
                        conexion.Conexion.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión: " + ex.Message);
                    conexion.Conexion.Close();
                }
            }
        }
        public bool InsertarGol(int idPartido, int idJugador, int idEquipo, int minuto)
        {
            using (conexion.Conexion)
            {
                try
                {
                    conexion.Conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("spInsertarGol", conexion.Conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IDPartido", idPartido);
                        cmd.Parameters.AddWithValue("@IDJugador", idJugador);
                        cmd.Parameters.AddWithValue("@IDEquipo", idEquipo);
                        cmd.Parameters.AddWithValue("@Minuto", minuto);

                        int resultado = (int)cmd.ExecuteScalar(); // Ejecuta y obtiene el código de retorno
                        conexion.Conexion.Close();
                        return resultado == 0; // Retorna true si no hubo error
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error de SQL Server: " + ex.Message);
                    conexion.Conexion.Close();
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar gol: " + ex.Message);
                    conexion.Conexion.Close();
                    return false;
                }
            }
        }
        public bool InsertarAsistencia(int idPartido, int idJugador, int idEquipo, int minuto)
        {
            using (conexion.Conexion)
            {
                try
                {
                    conexion.Conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("spInsertarAsistencia", conexion.Conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IDPartido", idPartido);
                        cmd.Parameters.AddWithValue("@IDJugador", idJugador);
                        cmd.Parameters.AddWithValue("@IDEquipo", idEquipo);
                        cmd.Parameters.AddWithValue("@Minuto", minuto);

                        int resultado = (int)cmd.ExecuteScalar(); // Ejecuta y obtiene el código de retorno

                        return resultado == 0; // Retorna true si no hubo error
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error de SQL Server: " + ex.Message);
                    conexion.Conexion.Close();
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar asistencia: " + ex.Message);
                    conexion.Conexion.Close();
                    return false;
                }
            }
        }

    }
}
