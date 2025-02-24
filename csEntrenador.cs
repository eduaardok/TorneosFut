using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneosFut;

namespace PruebasTorneos
{
    internal class csEntrenador
    {
        csConexion conec= new csConexion();
        public void Cargar(DataGridView dgvEntrenador)
        {
            string consul = "select IDEntrenador, Nombres, Apellidos, coalesce(cast(EquipoActual as varchar), 'SinEquipo') as EquipoActual, PartidosGanados, PartidosPerdidos, PartidosEmpatados, (PartidosGanados+PartidosPerdidos+PartidosEmpatados) as TotalPartidos from Entrenador";
            DataTable dt = conec.ListDGV(consul);
            dgvEntrenador.DataSource = dt;
            AdaptarDGV(dgvEntrenador);
        }

        void AdaptarDGV(DataGridView dgvEntrenador)
        {
            int filas = dgvEntrenador.RowCount;
            for (int i = 0; i < filas; i++)
            {
                dgvEntrenador.Rows[i].Height = dgvEntrenador.Height / filas;
            }
            dgvEntrenador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}