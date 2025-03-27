using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorneosFut.Class
{
    class csTorneo
    {
        csConexion csConexion;
        public csTorneo(string u, string c)
        {
            csConexion = new csConexion(u, c);
        }
        public string IDTorneoSeleccionado(DataGridView dgv)
        {
            return dgv.Rows[dgv.CurrentRow.Index].Cells["IDTorneo"].Value.ToString();
        }
        public string GenerarNuevoIDTorneo()
        {
            string query = "SELECT ISNULL(MAX(IDTorneo), 0) + 1 FROM Torneo";
            DataTable dt = csConexion.ListDGV(query);
            return dt.Rows[0][0].ToString();
        }
        #region ValidarInscripciones
        public bool TotalEquiposInscritos(string torneo)
        {
            int participantes;
            DataTable dt = csConexion.ListDGV($"select F.CantidadEquipos from Formato F inner join Torneo T on F.IDFormato = T.IDFormato where T.IDTorneo ={torneo}");
            participantes = int.Parse(dt.Rows[0][0].ToString());
            int inscritos;
            DataTable dt1 = csConexion.ListDGV($"select count(*) from Torneo T inner join InscripcionEquipo I on T.IDTorneo = I.IDTorneo where T.IDTorneo = {torneo}");
            inscritos = int.Parse(dt1.Rows[0][0].ToString());
            if (participantes == inscritos)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Cantidad de equipos inscritos inferior a cantidad de equipos participantes (requeridos)");
                return false;
            }
        }
        public bool TotalEquiposPagados(string torneo)
        {
            int participantes;
            DataTable dt = csConexion.ListDGV($"select F.CantidadEquipos from Formato F inner join Torneo T on F.IDFormato = T.IDFormato where T.IDTorneo ={torneo}");
            participantes = int.Parse(dt.Rows[0][0].ToString());
            int pagados;
            DataTable dt1 = csConexion.ListDGV($"select count(*) from Torneo T inner join InscripcionEquipo I on T.IDTorneo = I.IDTorneo where T.IDTorneo = {torneo} and  I.Estado = 'Pagado'");
            pagados = int.Parse(dt1.Rows[0][0].ToString());
            if (participantes == pagados)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Todos los equipos deben pagar completamente su inscripción para iniciar el torneo");
                return false;
            }
        }
        #endregion

        #region Generar Torneo
        public bool GenerarTorneo(string torneo)
        {
            DataTable dt = csConexion.ListDGV($"select count(*) from Torneo T inner join Partido P on T.IDTorneo = P.IDTorneo where T.IDTorneo ={torneo}");
            if (int.Parse(dt.Rows[0][0].ToString()) < 0)
            {
                return csConexion.Consulta("EJECUTAR PARA CREAR TORNEO"); //falta
            }
            else
                return true;
        }
        #endregion
        public DataTable ListadeTorneo()
        {
            DataTable dt = csConexion.ListDGV("Select * from Torneo");
            return dt;
        }
        public DataTable ListaIDTorneo()
        {
            DataTable dt = csConexion.ListDGV("Select IDTorneo from Torneo");
            return dt;
        }
        public DataTable ListadeTorneofiltro(string filtro)
        {
            DataTable dt;
            dt = csConexion.ListDGV($"select * from Torneo where NombreTorneo like '%{filtro}%'");


            return dt;
        }
        public bool AgregarTorneo(string Txtnombre, string formato, string ModoFutbol, string Organizador, string te, string fin, decimal costo)
        {
            if (csConexion.Consulta($"insert into Torneo (IDTorneo, NombreTorneo, IDModoFutbol, IDOrganizador, FechaInicio, FechaFin, Usuario, Estado, CostoInscripcion, IDFormato)" +
                $" values ({GenerarNuevoIDTorneo()}, '{Txtnombre}', {ModoFutbol}, '{Organizador}','{te}','{fin}', system_user, 'PENDIENTE', {costo}, {formato})"))
                return true;
            else
                return false;

        }
        public bool ActualizarTorneo(string id, string Txtnombre, string formato, string ModoFutbol, string Organizador, string te, string fin, decimal costo)
        {
            if (csConexion.Consulta($"update Torneo set NombreTorneo = '{Txtnombre}', IDFormato={formato}, IDModoFutbol = {ModoFutbol}, IDOrganizador= '{Organizador}'," +
                $" FechaInicio ='{te}', FechaFin = '{fin}', CostoInscripcion = {costo} where IDTorneo = {id}"))
                return true;
            else
                return false;

        }
        public DataTable LlenarOrganizadores()
        {
            DataTable dt = csConexion.ListDGV("Select * from Organizador");
            return dt;
        }
        public DataTable LlenarFormato()
        {
            DataTable dt = csConexion.ListDGV("Select * from Formato");
            return dt;
        }
        public DataTable LlenarFormatoID(string name)
        {
            DataTable dt = csConexion.ListDGV($"Select * from Formato where NombreFormato = '{name}'");
            return dt;
        }
        public DataTable LlenarModo()
        {
            DataTable dt = csConexion.ListDGV("Select * from ModoFutbol");
            return dt;
        }
        public DataTable LlenarModoID(string name)
        {
            DataTable dt = csConexion.ListDGV($"Select * from ModoFutbol where NombreModo = '{name}'");
            return dt;
        }
    }
}

