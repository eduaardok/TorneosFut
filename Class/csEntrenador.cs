﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneosFut;
using TorneosFut.Class;
namespace PruebasTorneos
{
    internal class csEntrenador
    {
        csConexion conexion;
        public csEntrenador(string u, string c)
        {
            conexion = new csConexion();
            conexion.Usuario = u;
            conexion.Clave = c;
        }
        public void Cargar(DataGridView dgvEntrenador)
        {
            string consul = "select IDEntrenador, Nombres, Apellidos, Sexo, coalesce(cast(EquipoActual as varchar), 'SinEquipo') as EquipoActual, PartidosGanados, PartidosPerdidos, PartidosEmpatados, (PartidosGanados+PartidosPerdidos+PartidosEmpatados) as TotalPartidos from Entrenador";
            DataTable dt = conexion.ListDGV(consul);
            dgvEntrenador.DataSource = dt;
            foreach (DataGridViewColumn column in dgvEntrenador.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
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
        public void filtro(string filtro, DataGridView dgvEntrenador)
        {
            if (string.IsNullOrWhiteSpace(filtro))
            {
                dgvEntrenador.DataSource = conexion.ListDGV("select IDEntrenador, Nombres, Apellidos, Sexo, coalesce(cast(EquipoActual as varchar), 'SinEquipo') as EquipoActual, " +
                    "PartidosGanados, PartidosPerdidos, PartidosEmpatados, (PartidosGanados+PartidosPerdidos+PartidosEmpatados) as TotalPartidos from Entrenador");
                AdaptarDGV(dgvEntrenador);
            }
            else
            {
                string consulta = $"select IDEntrenador, Nombres, Apellidos, Sexo, coalesce(cast(EquipoActual as varchar), 'SinEquipo') as EquipoActual, " +
                    $"PartidosGanados, PartidosPerdidos, PartidosEmpatados, (PartidosGanados+PartidosPerdidos+PartidosEmpatados) as TotalPartidos from Entrenador where IDEntrenador like '%{filtro}%' or " +
                    $"Nombres like '%{filtro}%' or Apellidos like '%{filtro}%' or EquipoActual like '%{filtro}%'";

                DataTable dt = conexion.ListDGV(consulta);
                dgvEntrenador.DataSource = dt;
            }
        }
    }
}