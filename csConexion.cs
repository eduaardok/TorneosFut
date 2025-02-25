using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows.Forms;

namespace TorneosFut
{
    internal class csConexion
    {
        SqlConnection conec;
        static string cadenaconec = $"Server=26.102.193.210; Database=BDTorneosFutbol; User id= FutXpert; Password= Torneos";
        public csConexion()
        {
            conec = new SqlConnection(cadenaconec);
        }
        public bool AbrirCon()
        {
            try
            {
                conec.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }

        public DataTable ListDGV(string consul)
        {
            AbrirCon();
            DataTable data = new DataTable();
            SqlDataAdapter sqlData = new SqlDataAdapter(consul, conec);
            sqlData.Fill(data);
            CerrarCon();
            return data;
        }

        public bool Login(string usuario, string contraseña)
        {
            string consulta = $"select Clave from Administrador where Usuario='{usuario}'";
            DataTable dt = ListDGV(consulta);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (contraseña == dt.Rows[i][0].ToString())
                {
                    return true;
                }
            }
            return false;
        }

        public bool Consulta(string consul)
        {
            AbrirCon();
            SqlCommand consulta = new SqlCommand(consul, conec);
            try
            {
                consulta.ExecuteNonQuery();
                CerrarCon();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CerrarCon();
                return false;
            }
        }

        public bool CerrarCon()
        {
            conec.Close();
            return true;
        }
    }
}
